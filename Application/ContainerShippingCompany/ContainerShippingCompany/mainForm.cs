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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //Show form
        private void btnNewContainers_Click(object sender, EventArgs e)
        {
            containerForm cf = new containerForm();
            cf.Show();
        }

        //Show form
        private void btnNewMapping_Click(object sender, EventArgs e)
        {
            mappingForm mf = new mappingForm();
            mf.Show();
        }
    }
}
