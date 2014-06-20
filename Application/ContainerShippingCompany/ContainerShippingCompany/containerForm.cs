using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerShippingCompany
{
    public partial class containerForm : Form
    {
        private List<Costumer> costumers = new List<Costumer>();
        private List<ContainerType> containerTypes = new List<ContainerType>();
        private List<Destination> destinations = new List<Destination>();
        private Costumer costumer = new Costumer();
        private ContainerType containerType = new ContainerType();
        private Destination destination = new Destination();
        private int additionalWeight = 0;


        public containerForm()
        {
            InitializeComponent();
            FillCompanyList();
            FillTypeList();
        }

        //Fill the company list with values
        private void FillCompanyList()
        {
            listBCompany.Items.Clear();
            cbMotherCompany.Items.Clear();
            costumers = Costumer.GetAll();
            foreach (Costumer c in costumers)
            {
                listBCompany.Items.Add(c.companyName);
                cbMotherCompany.Items.Add(c.companyName);
            }
        }

        //Fill the comboboxes with values
        private void FillTypeList()
        {
            cbType.Items.Clear();
            cbDestination.Items.Clear();

            destinations = Destination.GetAll();
            foreach (Destination DN in destinations)
            {
                cbDestination.Items.Add(DN.name);
            }

            containerTypes = ContainerType.GetAll();
            foreach (ContainerType CT in containerTypes)
            {
                cbType.Items.Add(CT.name);
            }
        }

        //Add container to the database
        private void btAddContainer_Click(object sender, EventArgs e)
        {
            Container container = new Container();
            ContainerType containerType = new ContainerType();
            string error = string.Empty;
            lbError.Text = string.Empty;

            //Check if all fields have input
            if(costumer.id == 0)
            {
                error += "Geen bedrijf geselecteerd \n";
            }

            //Check if a type or destination is selected
            containerType = containerTypes[cbType.SelectedIndex];
            destination = destinations[cbDestination.SelectedIndex];

            if(containerType.id == 0)
            {
                error += "Geen type geselecteerd \n"; 
            }

            if (destination.id == 0)
            {
                error += "Geen bestemming geselecteerd \n";
            }
            
            //check if weight is a number
            try
            {
                additionalWeight = Convert.ToInt16(NUPWeight.Value);
            }
            catch(Exception ex)
            {
                error += "Geen correct gewicht nummer \n";
            }

            //check if weight is not 0
            if (additionalWeight < 1)
            {
                error += "Gewicht mag niet nul zijn \n";
            }

            

            //DEBUG
            //if (error != string.Empty)

            //If there are no errors add the container to the database
            if (error == string.Empty)
            {
                //In case of database failure check result
                bool succes = container.Add(costumer, containerType, destination, additionalWeight);

                //if succes empty form
                if (succes)
                {
                    lbError.Text = string.Empty;
                    NUPWeight.Value = 0;
                    cbType.SelectedIndex = -1;
                    cbDestination.SelectedIndex = -1;
                }
                else
                {
                    //Show errors
                    error += "Er is iets fout gegaan bij het wegschijven";
                    lbError.Text = error;
                }

            }
            else
            {
                //Show errors
                lbError.Text = error;
            }


            


        }

        //On textbox focus remove current value
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb = (TextBox)sender;
            tb.Text = "";
        }

        //When a company is selected add the company to the object and show values
        private void btSelectCompany_Click(object sender, EventArgs e)
        {
            costumer = costumers[listBCompany.SelectedIndex];
            lblCompanySelected.Text = costumer.companyName;

            btDeleteContainers.Visible = Visible;
        }

        //Add a new company to the database
        private void btAddCompany_Click(object sender, EventArgs e)
        {
            //Error checking
            lblErrorCompany.Text = string.Empty;
            int kvk = 0;
            bool error = false;
            Costumer costumer = new Costumer();

            //Check if input fields are empty
            if (tbCompanyName.Text == string.Empty)
                error = true;

            if (tbContactPerson.Text == string.Empty)
                error = true;

            //Check if empty if not check if its a number, continue if it is
            if (tbCompanyKvk.Text == string.Empty)
            {
                error = true;
            }
            else
            {
                try
                {
                    kvk = Convert.ToInt32(tbCompanyKvk.Text);
                }
                catch (Exception ex)
                {
                    error = true;
                }
            }

            if (cbMotherCompany.SelectedIndex == -1)
            {
                error = true;
            }


            //If there are no error add to database
            if(error != true)
            {
                //Check result in case of database failure
                costumer = costumers[cbMotherCompany.SelectedIndex];
                bool succes = costumer.Add(costumer, tbCompanyName.Text, tbContactPerson.Text, kvk);

                //if succes refresh company list
                if (!succes)
                    lblErrorCompany.Text = "Er is iets fout gegaan bij het wegschrijven";
                else
                    FillCompanyList();
            }
            else
            {
                //show error
                lblErrorCompany.Text = "Controleer de gegevens";
            }


        }

        //Open delete container form with correct costumer
        private void btDeleteContainers_Click(object sender, EventArgs e)
        {
            deleteContainerForm dcf = new deleteContainerForm(costumer);
            dcf.Show();
        }
    }
}
