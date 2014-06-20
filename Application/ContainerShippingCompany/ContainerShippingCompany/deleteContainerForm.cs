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
    public partial class deleteContainerForm : Form
    {
        Costumer costumer = new Costumer();
        Container container = new Container();
        List<Container> containers = new List<Container>();

        public deleteContainerForm()
        {
            InitializeComponent();
        }

        //Constr
        public deleteContainerForm(Costumer costumer)
        {
            InitializeComponent();
            this.costumer = costumer;
            BindDataGrid();
            
        }

        //Bind data to datagridview
        private void BindDataGrid()
        {
            containers = container.GetNonShippedContainerList(costumer);
            var bindinglist = new BindingList<Container>(containers);
            var source = new BindingSource(bindinglist, null);
            dgvContainers.DataSource = source;
        }

        private void btDeleteSelected_Click(object sender, EventArgs e)
        {
            container = containers[dgvContainers.CurrentCell.RowIndex];
            container.Delete(container.id);
            BindDataGrid();
        }
    }
}
