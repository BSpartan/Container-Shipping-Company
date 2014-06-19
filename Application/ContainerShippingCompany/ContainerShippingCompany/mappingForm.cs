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
    public partial class mappingForm : Form
    {
        public mappingForm()
        {
            InitializeComponent();
            WriteLegenda();
        }

        private void WriteLegenda()
        {
            rtbLegenda.Text = "\n\n _ = lege positie \n C = normale container\n V = waardevolle container \n E = actief gekoelde container";
        }
    }
}
