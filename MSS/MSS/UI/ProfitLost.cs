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
    public partial class ProfitLost : Form
    {
        public ProfitLost()
        {
            InitializeComponent();
        }

        public Panel ProfitLostPanel()
        {
            return panelProfitLost;
        }
        private void ProfitLost_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        private void getYear()
        {
            cbYear.DataSource = null;
            cbYear.Text = "select customer";
            var dict = new Dictionary<int, string>();
            foreach (var customer in new DB.Customer().ALL())
            {
                dict.Add(customer.Id, customer.Name);
            }
            cbYear.DataSource = new BindingSource(dict, null);
            cbYear.DisplayMember = "Value";
            cbYear.ValueMember = "Key";
        }
    }
}
