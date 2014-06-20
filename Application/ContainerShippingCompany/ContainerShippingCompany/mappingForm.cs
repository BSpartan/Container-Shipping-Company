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
        List<Container> toDelete = new List<Container>();
        List<Container> prioritys = new List<Container>();

        Freighter freighter;
        Destination destination;

        public mappingForm()
        {
            InitializeComponent();
            WriteLegenda();
            FillComboBoxes();
        }

        //Write default value to the rich text box
        private void WriteLegenda()
        {
            rtbLegenda.Text = "\n\n _ = lege positie \n C = normale container\n V = waardevolle container \n E = actief gekoelde container";
        }

        //Fill combo boxes with database data
        private void FillComboBoxes()
        {
            cbDestination.Items.Clear();
            cbTypeShip.Items.Clear();
            freighters = Freighter.GetAll();
            destinations = Destination.GetAll();
            foreach (Freighter f in freighters)
            {
                cbTypeShip.Items.Add(f.shipType);
            }

            foreach (Destination d in destinations)
            {
                cbDestination.Items.Add(d.name);
            }
        }

        //Generate the correct mapping
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Check if ship and destination is selected otherwise stop 
            if(cbTypeShip.SelectedIndex == -1 ||  cbDestination.SelectedIndex == -1)
            {
                return;
            }

            Container container = new Container();

            //Get select freighter and destination from combobox
            freighter = freighters[cbTypeShip.SelectedIndex];
            destination = destinations[cbDestination.SelectedIndex];

            //Clear incase of multiple runs
            availableContainers.Clear();
            placedContainers.Clear();

            //Get all available containers
            availableContainers = container.GetNonShippedContainerList();

            //Get the max amount of spots on a ship
            int totalSpots = freighter.maxHeight * freighter.containerRows * freighter.containersEachRow;

            //Get the max amount of power supply on a ship
            int availablePowerSupply = freighter.powerSupply;

            //Sort the containers so the chilled containers are first
            availableContainers = availableContainers.OrderByDescending(o => o.containerType.chilled).ThenBy(o => o.containerType.chilled).ThenBy(o => o.weight).ToList();

            //Remember count value
            int countX = 1;
            int countY = 1;
            int countZ = 1;
            int y;
            int x;
            int z;
            bool excists;

            //For every container in available containers
            foreach(Container con in availableContainers)
            {
                countZ = 1;

                //Continue to check 
                while(true)
                {
                    //If all spots have been filled close 
                    if (placedContainers.Count == totalSpots)
                            break;

                    //If a container is valuable make sure it can never be placed on the sides
                    if (con.containerType.valuable == 1 && countX == freighter.containerRows)
                    {
                        countX = 2;
                        if (countY == freighter.containersEachRow)
                        {
                            countZ++;
                            countY = 0;
                        }
                        countY++;

                        Container priority = new Container();
                        priority.positionX = countX;
                        priority.positionY = countY;
                        priority.positionZ = countZ + 1;
                        prioritys.Add(priority);
                    }

                    //If there is a priority position fill that one first otherwise normal position
                    if (con.containerType.valuable == 0 && con.containerType.valuable == 0 && prioritys.Count > 0)
                    {
                        y = prioritys[0].positionY;
                        x = prioritys[0].positionX;
                        z = prioritys[0].positionZ;

                        prioritys.RemoveAt(0);
                    }
                    else
                    {
                        y = countY;
                        x = countX;
                        z = countZ;
                    }

                    //Check if the given container position is valid
                    excists = CheckIfPositionIsValid(x, y, z);

                    //if its valid add the container to to the placed list
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
                        //if container is chilled make sure its always on the front row
                        if (con.containerType.chilled == 1 && countX == freighter.containerRows)
                        {
                            countX = 0;
                            countZ++;
                        }
                        //if the X is at its end, reset and add Y
                        else if (countX == freighter.containerRows)
                        {
                            //if the Y is at its end, reset and add Z
                            if (countY == freighter.containersEachRow)
                            {
                                //if the Z is at its end, break the loop
                                if (countZ == freighter.maxHeight)
                                {
                                    break;
                                }
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

            //Check all the valuables if the have a container on top of them
            foreach (Container cont in placedContainers)
            {
                bool hasTopContainer = false;

                if (cont.containerType.valuable == 1)
                {
                    foreach (Container contain in placedContainers)
                    {
                        if (contain.positionX == cont.positionX && contain.positionY == cont.positionY && contain.positionZ == (cont.positionZ + 1))
                        {
                            hasTopContainer = true;
                        }
                    }

                    if(!hasTopContainer)
                    {
                        //Add to delete later so the function doesn't break
                        toDelete.Add(cont);
                    }
                }
            }

            //Delete found containers
            foreach (Container cont in toDelete)
            {
                placedContainers.Remove(cont);
            }

            FillTextBox();
            btnExport.Enabled = true;
            btnMarkContainers.Enabled = true;
        }

        //Fill textbox with the found vontainer spots
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

        //Check if an position is valid 
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

        //Get type from valid container location
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

        //Export containers to given textfile
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

        //Mark al found containers in the database to be transported
        private void btnMarkContainers_Click(object sender, EventArgs e)
        {
            foreach(Container container in placedContainers)
            {
                container.ChangeStatusToShipped(container.id);
            }
        }
    }
}
