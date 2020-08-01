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
    public partial class CashbookEdit : Form
    {
        DO.Cashbook cashbook;
        public CashbookEdit()
        {
            InitializeComponent();
        }
        public CashbookEdit(int id)
        {
            InitializeComponent();
            cashbook = new DB.Cashbook().SHOW(id);
            Console.WriteLine(cashbook);
            if(cashbook!=null)
            {
                txtCasher.Text = cashbook.Casher;
                txtVoucher.Text = cashbook.Voucher;
                txtDescription.Text = cashbook.Description;
                txtTotal.Text = cashbook.Total.ToString();
                dtpDueDate.Value = cashbook.Date;
                lbReason.Text = cashbook.Reason == 1 ? "ရောင်းချခြင်းအတွက်" : cashbook.Reason == 2 ? "ဝန်ဆောင်မှုပြုခြင်းအတွက်" : "အခြားသောကိစ္စအတွက်";
                lbCashType.Text = cashbook.CashType == 0 ? "ဝင်ငွေ" : "ထွက်ငွေ";
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Are you sure want to delete this data?","Delete?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                if(new DB.Cashbook().DESTROY(cashbook.Id))
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Deleting Error! \n If you don't understand, contact support team");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DO.Cashbook cashbook = new DO.Cashbook();
            cashbook.Id = this.cashbook.Id;
            cashbook.Casher = txtCasher.Text;
            cashbook.Voucher = txtVoucher.Text;
            cashbook.Total = Convert.ToDouble( txtTotal.Text);
            cashbook.Description = txtDescription.Text;
            cashbook.Date = dtpDueDate.Value;
            if(new DB.Cashbook().UPDATE(cashbook))
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Updating Error! \n If you don't understand, contact support team");
            }
        }
    }
}
