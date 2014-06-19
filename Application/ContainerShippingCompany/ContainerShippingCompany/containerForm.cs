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
        private Costumer costumer = new Costumer();
        private int selectedCompanyId = 0;
        private int additionalWeight = 0;
        public containerForm()
        {
            InitializeComponent();
            FillCompanyList();
        }

        private void FillCompanyList()
        {
            costumers = costumer.GetAllCostumers();
            foreach (Costumer c in costumers)
            {
                listBCompany.Items.Add(c.companyName);
            }
        }

        private void btAddContainer_Click(object sender, EventArgs e)
        {
            //Check if all fields have input
            if(selectedCompanyId < 1)
            {
                //show error
            }
            
            try
            {
                additionalWeight = Convert.ToInt16(NUPWeight.Value);
            }
            catch(Exception ex)
            {
                //show error
            }

            if (additionalWeight < 1)
            {
                // show error
            }

            Database db = new Database();
            db.OpenConnection();
            db.ExecuteCommand();
            db.CloseConnection();
            
            


        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb = (TextBox)sender;
            tb.Text = "";
        }
    }
}
