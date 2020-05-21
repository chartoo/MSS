using MSS.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS
{
    public partial class Main : Form
    {
        Cashbook cashbook = new Cashbook();
        public Main()
        {
            InitializeComponent();
            AddChartValue();
        }

        private void btnCashbook_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(cashbook.CashbookPanel());
        }

        private void btnDashbook_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelMainDashbook);
        }
        private void AddChartValue()
        {
            int[] yValuesOfSale = { 10, 25, 100, 34, 25, 224, 53, 22, 80, 241, 94, 100 };
            int[] yValuesOfService = { 40, 250, 120, 34, 25, 324, 530, 22, 804, 241, 942, 143 };
            string[] xValues = { "Jan", "Feb", "March", "Apr", "May", "Jan", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
            chartIncome.Series[0].Points.DataBindXY(xValues, yValuesOfSale);
            chartIncome.Series[1].Points.DataBindXY(xValues, yValuesOfService);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Sale().SalePanel());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Service().ServicePanel());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Category().CategoryPanel());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Customer().CustomerPanel());
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new ProfitLost().ProfitLostPanel());
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnRecPay_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new ReceivablePayable().ReceivablePayablePanel());
        }

        private void btnSaleShort_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Sale().SalePanel());
        }

        private void btnServiceShort_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Service().ServicePanel());
        }

        private void btnCustomerShort_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Customer().CustomerPanel());
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new UserList().UserPanel());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show( "Are you sure wish to Logout ? ", "Question?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                new Login().Show();
                this.Hide();
            }
        }
    }
}
