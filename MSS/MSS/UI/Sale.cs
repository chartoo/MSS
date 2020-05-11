using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS.UI
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
            
        }
        public Panel SalePanel()
        {
            return panelSale;
        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            new AddCustomer().ShowDialog();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            new AddCategory().ShowDialog();
        }
    }
}
