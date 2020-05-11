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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        public Panel ServicePanel()
        {
            return panelService;
        }
        private void Service_Load(object sender, EventArgs e)
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
