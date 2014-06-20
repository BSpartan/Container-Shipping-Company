using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerShippingCompany
{
    public partial class mappingForm : Form
    {
        List<Destination> destinations = new List<Destination>();
        List<Freighter> freighters = new List<Freighter>();
        List<Container> availableContainers = new List<Container>();
        List<Container> placedContainers = new List<Container>();
        List<Container> proirity = new List<Container>();

        Freighter freighter;
        Destination destination;
        public mappingForm()
        {
            InitializeComponent();
            WriteLegenda();
            FillComboBoxes();
        }

        private void WriteLegenda()
        {
            rtbLegenda.Text = "\n\n _ = lege positie \n C = normale container\n V = waardevolle container \n E = actief gekoelde container";
        }

        private void FillComboBoxes()
        {
            cbDestination.Items.Clear();
            cbTypeShip.Items.Clear();
            freighters = Freighter.GetAll();
            destinations = Destination.GetAll();
            foreach (Freighter f in freighters)
            {
                cbTypeShip.Items.Add(f.shipType);
                //listBCompany.Items.Add(c.companyName);
            }

            foreach (Destination d in destinations)
            {
                cbDestination.Items.Add(d.name);
                //listBCompany.Items.Add(c.companyName);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(cbTypeShip.SelectedIndex == -1 ||  cbDestination.SelectedIndex == -1)
            {
                return;
            }

            Container container = new Container();

            freighter = freighters[cbTypeShip.SelectedIndex];
            destination = destinations[cbDestination.SelectedIndex];
            availableContainers.Clear();
            placedContainers.Clear();
            availableContainers = container.GetNonShippedContainerList();

            int totalSpots = freighter.maxHeight * freighter.containerRows * freighter.containersEachRow;
            int availablePowerSupply = freighter.powerSupply;

            availableContainers = availableContainers.OrderByDescending(o => o.containerType.chilled).ThenBy(o => o.containerType.chilled).ThenBy(o => o.weight).ToList();

            int countX = 1;
            int countY = 1;
            int countZ = 1;
            int y;
            int x;
            int z;
            bool excists;

            foreach(Container con in availableContainers)
            {
                countZ = 1;

                while(true)
                {
                    if (placedContainers.Count == totalSpots)
                            break;

                    if (con.containerType.valuable == 1 && countX == freighter.containerRows)
                    {
                        countX = 2;
                        if (countY == freighter.containersEachRow)
                        {
                            countZ++;
                            countY = 0;
                        }
                        countY++;
                    }

                    if (con.containerType.valuable == 0 && con.containerType.valuable == 0 && proirity.Count > 0)
                    {
                        y = countY;
                        x = countX;
                        z = countZ;
                    }
                    else
                    {
                        y = countY;
                        x = countX;
                        z = countZ;
                    }

                    excists = CheckIfPositionIsValid(x, y, z);

                    if (!excists)
                    {
                        con.positionX = x;
                        con.positionY = y;
                        con.positionZ = z;
                        placedContainers.Add(con);

                        if (con.containerType.chilled == 1)
                        availablePowerSupply--;

                        break;
                    }
                    else
                    {
                        if (con.containerType.chilled == 1 && countX == freighter.containerRows)
                        {
                            countX = 0;
                            countZ++;
                        }
                        else if (countX == freighter.containerRows)
                        {
                            
                            if (countY == freighter.containersEachRow)
                            {
                                countZ++;
                                countY = 0;
                            }
                            countX = 0;
                            countY++;
                        }
                        countX++;
                    }
                }
            }

            FillTextBox();
        }

        private void FillTextBox()
        {
            string text = "\n\n";
            for(int z = 1; z <= freighter.maxHeight; z++)
            {
                text += "Laag " + z + ":\n";

                for (int x = 1; x <= freighter.containerRows; x++)
                {
                    for (int y = 1; y <= freighter.containersEachRow; y++)
                    {
                        ContainerType containertype = new ContainerType();
                        containertype = CheckIfPositionTypeIsFilled(x,y,z);

                        if(containertype != null)
                        {
                            if (containertype.chilled == 0 && containertype.valuable == 0)
                                text += "C ";
                            else
                                text += (containertype.valuable == 1 ? "V " : "E ");
                        }
                        else
                            text += "_ ";
                    }

                    text += "\n";
                }

                text += "\n";

            }

            rtbMapping.Text = text;
        }

        private bool CheckIfPositionIsValid(int x, int y, int z)
        {
            int weight = 0;

            foreach (Container contain in placedContainers)
            {
                if (contain.positionX == x && contain.positionY == y && contain.positionZ == z)
                {
                    return true;
                }
            }

            for (int i = 1; i <= z; i++)
            {
                foreach (Container contain in placedContainers)
                {
                    if (contain.positionX == x && contain.positionY == y && contain.positionZ == i)
                    {
                        weight += (contain.weight + 4000);
                    }
                }
            }

            if (weight < 120000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private ContainerType CheckIfPositionTypeIsFilled(int x, int y, int z)
        {
            foreach (Container con in placedContainers)
            {
                if (con.positionX == x && con.positionY == y && con.positionZ == z)
                {
                    return con.containerType;
                }
            }

            return null;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            // Set the help text description for the FolderBrowserDialog. 
            folderBrowserDialog1.Description = "Selecteer waar u het bestand wilt opslaan.";

            // Do not allow the user to create new files via the FolderBrowserDialog. 
            folderBrowserDialog1.ShowNewFolderButton = false;

            // Default to the My Documents folder. 
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set a variable to the My Documents path. 
                string mydocpath = folderBrowserDialog1.SelectedPath;
                StringBuilder sb = new StringBuilder();

                placedContainers = placedContainers.OrderBy(o => o.costumer.companyName).ToList();

                sb.AppendLine(freighter.shipType);
                sb.AppendLine();
                sb.AppendLine(destination.name + " " + destination.land);
                sb.AppendLine();

                foreach(Container container in placedContainers)
                {
                    sb.AppendLine(string.Format("{0}: ID:{1}  -  X:{2}  Y:{3}  Z:{4}", container.costumer.companyName, container.id, container.positionX, container.positionY, container.positionZ));
                }
                

                // Write the stream contents to a new file named "vrachtschip-export.txt".
                using (StreamWriter outfile = new StreamWriter(mydocpath + @"\vrachtschip-export.txt"))
                {
                    outfile.Write(sb.ToString());
                }
            }
        }

        private void btnMarkContainers_Click(object sender, EventArgs e)
        {
            foreach(Container container in placedContainers)
            {
                container.ChangeStatusToShipped(container.id);
            }
        }
    }
}
