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
        private int selectedCompanyId = 0;
        private int additionalWeight = 0;
        public containerForm()
        {
            InitializeComponent();
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
    }
}
