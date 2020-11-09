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
    public partial class Cashbook : Form
    {
        int reason = 0, cashType = 0;
        public Cashbook()
        {
            InitializeComponent();
        }
        public Panel CashbookPanel()
        {
            //dgvCashbookRecord.Rows.Add("1", "2020-4-24","ရောင်းချချင်းအတွက် ","121333","ဖုန်းအသစ် ","3000000","0","Detail");
            //double totalIncome = dgvCashbookRecord.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells["income"].Value));
            //double totalExpense = dgvCashbookRecord.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells["exp"].Value));
            //txtTotalIncome.Text = totalIncome.ToString();
            //txtTotalExpense.Text = totalExpense.ToString();
            SHOW_ALL();
            return panelCashbook;
        }

        private void SHOW_ALL()
        {
            double totalIncome = 0,totalExpense=0;
            List<DO.Cashbook> cashbooks = new DB.Cashbook().ALL();
            dgvCashbookRecord.Rows.Clear();
            foreach (var cashbook in cashbooks)
            {
                int row = dgvCashbookRecord.Rows.Add();
                dgvCashbookRecord.Rows[row].Cells["no"].Value = row + 1;
                dgvCashbookRecord.Rows[row].Cells["id"].Value = cashbook.Id;
                dgvCashbookRecord.Rows[row].Cells["date"].Value = cashbook.Date.ToString("yyyy-MM-dd");
                dgvCashbookRecord.Rows[row].Cells["cash_reason"].Value =( cashbook.Reason == 1 ? "ရောင်းချခြင်းအတွက် − " : cashbook.Reason == 2 ? "ဝန်ဆောင်မှုပြုခြင်းအတွက် - " : "တခြားကိစ္စအတွက် - " )+( cashbook.CashType==0?"ဝင်ငွေ":"ထွက်ငွေ");
                dgvCashbookRecord.Rows[row].Cells["voucher"].Value =cashbook.Voucher;
                dgvCashbookRecord.Rows[row].Cells["description"].Value =cashbook.Description;
                dgvCashbookRecord.Rows[row].Cells["income"].Value = cashbook.CashType==0?cashbook.Total :0;
                dgvCashbookRecord.Rows[row].Cells["exp"].Value = cashbook.CashType == 0 ? 0 : cashbook.Total;
                dgvCashbookRecord.Rows[row].Cells["actions"].Value = "More";
                totalIncome += cashbook.CashType == 0 ? cashbook.Total : 0;
                totalExpense += cashbook.CashType == 1 ? cashbook.Total : 0;
            }
            txtTotalIncome.Text = totalIncome.ToString();
            txtTotalExpense.Text = totalExpense.ToString();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
             if(new DB.Cashbook().STORE(Store()))
            {
                ClearInput();
                SHOW_ALL();
            }
        }

        private void dgvCashbookRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var row = dgvCashbookRecord.Rows[e.RowIndex];
                int id = Convert.ToInt16(row.Cells["id"].Value);
                new CashbookEdit(id).ShowDialog();
                SHOW_ALL();
            }
        }

        private void Cashbook_Load(object sender, EventArgs e)
        {

        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void rbtnSale_CheckedChanged(object sender, EventArgs e)
        {
            reason=rbtnSale.Checked ? 1 : reason;
        }

        private void rbtnService_CheckedChanged(object sender, EventArgs e)
        {
            reason = rbtnService.Checked ? 2 : reason;
        }

        private void rbtnOther_CheckedChanged(object sender, EventArgs e)
        {
            reason = rbtnOther.Checked ? 0 : reason;
        }

        private void rbtnIncome_CheckedChanged(object sender, EventArgs e)
        {
            cashType = rbtnIncome.Checked ? 0 : cashType;
        }

        private void rbtnExpense_CheckedChanged(object sender, EventArgs e)
        {
            cashType = rbtnExpense.Checked ? 1 : cashType;
        }

        private DO.Cashbook Store()
        {
           
            DO.Cashbook cashbook = new DO.Cashbook();
            cashbook.Reason = reason;
            cashbook.CashType = cashType;
            cashbook.Casher = txtCasher.Text;
            cashbook.Voucher = txtVoucher.Text;
            cashbook.Description = txtDescription.Text;
            cashbook.Total =Convert.ToDouble( txtTotal.Text);
            cashbook.Date = dtpDueDate.Value;
            return cashbook;
        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            Boolean all = rbtnFilterAll.Checked ? true : false;
            Boolean income = rbtnFilterIncome.Checked ? true : false;
            Boolean expense = rbtnFilterExpense.Checked ? true : false;
            double totalIncome = 0, totalExpense = 0;
            try
            {
                List<DO.Cashbook> cashbooks = new DB.Cashbook().FILTER_SEARCH(dtpFilterFrom.Value, dtpFilterTo.Value, all, income, expense);
                dgvCashbookRecord.Rows.Clear();
                foreach (var cashbook in cashbooks)
                {
                    int row = dgvCashbookRecord.Rows.Add();
                    dgvCashbookRecord.Rows[row].Cells["no"].Value = row + 1;
                    dgvCashbookRecord.Rows[row].Cells["id"].Value = cashbook.Id;
                    dgvCashbookRecord.Rows[row].Cells["date"].Value = cashbook.Date.ToString("yyyy-MM-dd");
                    dgvCashbookRecord.Rows[row].Cells["cash_reason"].Value = (cashbook.Reason == 1 ? "ရောင်းချခြင်းအတွက် − " : cashbook.Reason == 2 ? "ဝန်ဆောင်မှုပြုခြင်းအတွက် - " : "တခြားကိစ္စအတွက် - ") + (cashbook.CashType == 0 ? "ဝင်ငွေ" : "ထွက်ငွေ");
                    dgvCashbookRecord.Rows[row].Cells["voucher"].Value = cashbook.Voucher;
                    dgvCashbookRecord.Rows[row].Cells["description"].Value = cashbook.Description;
                    dgvCashbookRecord.Rows[row].Cells["income"].Value = cashbook.CashType == 0 ? cashbook.Total : 0;
                    dgvCashbookRecord.Rows[row].Cells["exp"].Value = cashbook.CashType == 0 ? 0 : cashbook.Total;
                    dgvCashbookRecord.Rows[row].Cells["actions"].Value = "More";
                    totalIncome += cashbook.CashType == 0 ? cashbook.Total : 0;
                    totalExpense += cashbook.CashType == 1 ? cashbook.Total : 0;
                }
                txtTotalIncome.Text = totalIncome.ToString();
                txtTotalExpense.Text = totalExpense.ToString();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Please connect to support team.", "System Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void ClearInput()
        {
            txtCasher.Text="";
            txtVoucher.Text="";
            txtDescription.Text="";
            txtTotal.Text="";
            dtpDueDate.Value = DateTime.Now;
        }
    }
}
