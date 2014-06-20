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
        private Costumer costumer = new Costumer();
        private ContainerType containerType = new ContainerType();
        private int additionalWeight = 0;
        public containerForm()
        {
            InitializeComponent();
            FillCompanyList();
            FillTypeList();
        }

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

        private void FillTypeList()
        {
            cbType.Items.Clear();
            containerTypes = ContainerType.GetAll();
            foreach (ContainerType CT in containerTypes)
            {
                cbType.Items.Add(CT.name);
                //listBCompany.Items.Add(c.companyName);
            }
        }

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

            containerType = containerTypes[cbType.SelectedIndex];

            if(containerType.id == 0)
            {
                error += "Geen type geselecteerd \n"; 
            }
            
            try
            {
                additionalWeight = Convert.ToInt16(NUPWeight.Value);
            }
            catch(Exception ex)
            {
                error += "Geen correct gewicht nummer \n";
            }

            if (additionalWeight < 1)
            {
                error += "Gewicht mag niet nul zijn \n";
            }

            

            //DEBUG
            //if (error != string.Empty)
            if (error == string.Empty)
            {

                bool succes = container.Add(costumer, containerType, additionalWeight);

                if (succes)
                {
                    lbError.Text = string.Empty;
                    NUPWeight.Value = 0;
                    cbType.SelectedIndex = -1;
                }
                else
                {
                    error += "Er is iets fout gegaan bij het wegschijven";
                    lbError.Text = error;
                }

            }
            else
            {
                lbError.Text = error;
            }


            


        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb = (TextBox)sender;
            tb.Text = "";
        }

        private void btSelectCompany_Click(object sender, EventArgs e)
        {
            costumer = costumers[listBCompany.SelectedIndex];
            lblCompanySelected.Text = costumer.companyName;

            btDeleteContainers.Visible = Visible;
        }

        private void btAddCompany_Click(object sender, EventArgs e)
        {
            lblErrorCompany.Text = string.Empty;
            int kvk = 0;
            bool error = false;
            Costumer costumer = new Costumer();

            if (tbCompanyName.Text == string.Empty)
                error = true;

            if (tbContactPerson.Text == string.Empty)
                error = true;

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



            if(error != true)
            {
                costumer = costumers[cbMotherCompany.SelectedIndex];
                bool succes = costumer.Add(costumer, tbCompanyName.Text, tbContactPerson.Text, kvk);

                if (!succes)
                    lblErrorCompany.Text = "Er is iets fout gegaan bij het wegschrijven";
                else
                    FillCompanyList();
            }
            else
            {
                lblErrorCompany.Text = "Controleer de gegevens";
            }


        }

        private void btDeleteContainers_Click(object sender, EventArgs e)
        {
            deleteContainerForm dcf = new deleteContainerForm(costumer);
            dcf.Show();
        }
    }
}
