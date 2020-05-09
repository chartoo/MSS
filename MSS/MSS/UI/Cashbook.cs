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
        public Cashbook()
        {
            InitializeComponent();
        }
        public Panel CashbookPanel()
        {
            dgvCashbookRecord.Rows.Add("1", "2020-4-24","ရောင်းချချင်းအတွက် ","121333","ဖုန်းအသစ် ","3000000","0","Detail");
            double totalIncome = dgvCashbookRecord.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells["income"].Value));
            double totalExpense = dgvCashbookRecord.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells["exp"].Value));
            txtTotalIncome.Text = totalIncome.ToString();
            txtTotalExpense.Text = totalExpense.ToString();
            return panelCashbook;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rbtnType = panelType.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            MessageBox.Show("Now Clicked is : "+rbtnType.Name);
        }

        private void dgvCashbookRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("လုပ်‌ဆောင်နေဆဲ ");
            }
        }

        private void Cashbook_Load(object sender, EventArgs e)
        {

        }
    }
}
