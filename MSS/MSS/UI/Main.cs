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
            lbUserName.Text = DO.Login.name;
            lbUserRole.Text = DO.Login.role;
            if (DO.Login.role == "Admin")
            {
                btnUser.Visible = true;
            }
            else btnUser.Visible = false;
            AddChartValue();
            TotalAmount();
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
            int[] yValuesOfSale = { 30, 25, 100, 34, 25, 224, 53, 22, 80, 241, 94, 100 };
            int[] yValuesOfService = { 140, 250, 120, 34, 25, 324, 530, 22, 804, 241, 942, 143 };
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
            currentTimer.Enabled = true;
            currentTimer.Interval = 1000;
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
                this.Hide();
                new Login().Show();
            }
        }
        private void TotalAmount()
        {
            lbCashbookIncome.Text = new DB.Dashboard().CashbookIncome().ToString();
            lbCashbookExpense.Text = new DB.Dashboard().CashbookExpense().ToString();
            lbSaleIncome.Text = new DB.Dashboard().SaleIncome().ToString();
            lbServiceIncome.Text = new DB.Dashboard().ServiceIncome().ToString();
        }

        private void currentTimer_Tick(object sender, EventArgs e)
        {
            lbcurrentDateLong.Text= DateTime.Now.ToString("dddd,MMMM dd-MM-yyyy");
            lbCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
