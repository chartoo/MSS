using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS.UI
{
    public partial class Service : Form
    {
        int cleared = 0, remainType = 0;
        public Service()
        {
            InitializeComponent();
        }
        public Panel ServicePanel()
        {
            SHOW_ALL();
            GetCashers();
            GetCustomers();
            GetCategories();
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

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                STORE();
            }
        }
        private void GetCashers()
        {
            cmbCasher.DataSource = null;
            cmbCasher.Text = "select casher";
            var dict = new Dictionary<int, string>();
            foreach (var user in new DB.User().ALL())
            {
                dict.Add(user.Id, user.Name);
            }
            cmbCasher.DataSource = new BindingSource(dict, null);
            cmbCasher.DisplayMember = "Value";
            cmbCasher.ValueMember = "Key";
        }
        private void GetCustomers()
        {
            cmbCustomer.DataSource = null;
            cmbCustomer.Text = "select customer";
            var dict = new Dictionary<int, string>();
            foreach (var customer in new DB.Customer().ALL())
            {
                dict.Add(customer.Id, customer.Name);
            }
            cmbCustomer.DataSource = new BindingSource(dict, null);
            cmbCustomer.DisplayMember = "Value";
            cmbCustomer.ValueMember = "Key";
        }
        private void GetCategories()
        {
            cmbCategory.DataSource = null;
            cmbCategory.Text = "select category";
            var dict = new Dictionary<int, string>();
            foreach (var category in new DB.Category().ALL())
            {
                dict.Add(category.Id, category.Name);
            }
            cmbCategory.DataSource = new BindingSource(dict, null);
            cmbCategory.DisplayMember = "Value";
            cmbCategory.ValueMember = "Key";
        }
        private Boolean Validation()
        {
            var isAnyEmpty = ScanForControls<ComboBox>(this)
                            .Where(x => x.SelectedIndex < 0)
                            .Any();

            if (isAnyEmpty)
            {
                MessageBox.Show("please fill all * fields");
                return false;
            }
            else if (Convert.ToDouble(txtPayment.Text) <= 0)
            {
                MessageBox.Show("please fill Payment");
                return false;
            }
            else
                return true;
        }
        public IEnumerable<T> ScanForControls<T>(Control parent) where T : Control
        {
            if (parent is T)
                yield return (T)parent;

            foreach (Control child in parent.Controls)
            {
                foreach (var child2 in ScanForControls<T>(child))
                    yield return (T)child2;
            }
        }
        private void SHOW_ALL()
        {
            double total = 0;
            List<DO.Service> services = new DB.Service().ALL();
            dgvService.Rows.Clear();
            foreach (var service in services)
            {
                int row = dgvService.Rows.Add();
                dgvService.Rows[row].Height = 35;
                dgvService.Rows[row].Cells["no"].Value = row + 1;
                dgvService.Rows[row].Cells["id"].Value = service.Id;
                dgvService.Rows[row].Cells["return_date"].Value = service.ReturnDate.ToString("yyyy-MM-dd");
                dgvService.Rows[row].Cells["customer"].Value = new DB.Customer().SHOW(service.CustomerId).Name;
                dgvService.Rows[row].Cells["item"].Value = new DB.Category().SHOW(service.CategoryId).Name + "-" + service.Model;
                dgvService.Rows[row].Cells["imei"].Value = service.Imei;
                dgvService.Rows[row].Cells["remark"].Value = service.Remark;
                dgvService.Rows[row].Cells["total"].Value = service.Total;
                dgvService.Rows[row].Cells["status"].Value = service.Cleared == 0 ? "မရှင်းသေး" : service.Cleared == 1 ? "ရှင်းပြီး" : "စရန်ပေးပြီး";
                dgvService.Rows[row].Cells["actions"].Value = "More";
                total += service.Total;
                dgvService.Text = (row + 1).ToString();
            }
            txtServiceTotal.Text = total.ToString();
        }
        private void STORE()
        {
            DO.Service service = new DO.Service();
            //@user_id,@customer_id,@category_id,@model,@imei,@return_date,@total,@payment,@remain,@remain_type,@remark,@description
            service.UserId = (int)cmbCasher.SelectedValue;
            service.CustomerId = (int)cmbCustomer.SelectedValue;
            service.CategoryId = (int)cmbCategory.SelectedValue;
            service.Model = txtPhoneModel.Text;
            service.Imei = txtIMEI.Text;
            service.ReturnDate = dtpReturn.Value;
            service.Total = Convert.ToDouble(txtTotal.Text);
            service.Payment = Convert.ToDouble(txtPayment.Text);
            service.Remain = Convert.ToDouble(txtRemain.Text);
            service.Cleared = cleared;
            service.RemainType = remainType;
            service.Remark = txtRemark.Text;
            service.Description = txtDescription.Text;
            if (new DB.Service().STORE(service))
            {
                SetDefault();
            }
            else MessageBox.Show("Something wrong! \n Please try againg (or) Contact support team", "Storing Erroor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rdbClear_CheckedChanged(object sender, EventArgs e)
        {
            cleared = 1;
            remainType = 3;
        }

        private void rdbNotClear_CheckedChanged(object sender, EventArgs e)
        {
            cleared = 0;
        }
        private void rdbPreAmount_CheckedChanged(object sender, EventArgs e)
        {
            
            cleared = 0;
            remainType = 1;
        }
        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            double total = 0;
            double payment = 0;
            try
            {
                 total = Convert.ToDouble(txtTotal.Text);
                 payment = Convert.ToDouble(txtPayment.Text);
            }
            catch(Exception exp)
            {
                 total = 0;
                 payment = 0;
            }
           
            if (total < payment)
            {
                remainType = 1;
                lbRecPay.Text = "ပေးရန် ကျန်ငွေ :";
                txtRemain.Text = (payment - total).ToString();
            }
            else if (total == payment)
            {
                remainType = 3;
                cleared = 0;
                txtRemain.Text = (total - payment).ToString();
            }
            else
            {
                remainType = 0;
                lbRecPay.Text = "ရရန် ကျန်ငွေ :";
                txtRemain.Text = (total - payment).ToString();
            }
        }
        private void SetDefault()
        {
            SHOW_ALL();
            GetCashers();
            GetCustomers();
            GetCategories();
            txtIMEI.Text = "";
            txtPhoneModel.Text = "";
            txtPayment.Text = "0";
            txtTotal.Text = "0";
            txtRemain.Text = "0";
            txtDescription.Text = "";
            txtRemark.Text = "";

        }
        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var row = dgvService.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];

            if (cell is DataGridViewButtonCell)
            {
                ServiceEdit serviceEdit = new ServiceEdit(Convert.ToInt16(row.Cells["id"].Value));
                serviceEdit.ShowDialog();
                SHOW_ALL();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            int all = rdbFilterAll.Checked ? 1 : 0;
            int cleared = rdbFilterCleared.Checked ? 1 : 0;
            int notCleared = rdbFilterNotCleared.Checked ? 1 : 0;
            if (dtpFilterFrom.Value <= dtpFilterTo.Value)
            {
                double total = 0;
                List<DO.Service> services = new DB.Service().SEARCH(dtpFilterFrom.Value, dtpFilterTo.Value, all, cleared, notCleared);
                dgvService.Rows.Clear();
                foreach (var service in services)
                {
                    int row = dgvService.Rows.Add();
                    dgvService.Rows[row].Height = 35;
                    dgvService.Rows[row].Cells["no"].Value = row + 1;
                    dgvService.Rows[row].Cells["id"].Value = service.Id;
                    dgvService.Rows[row].Cells["return_date"].Value = service.ReturnDate.ToString("yyyy-MM-dd");
                    dgvService.Rows[row].Cells["customer"].Value = new DB.Customer().SHOW(service.CustomerId).Name;
                    dgvService.Rows[row].Cells["item"].Value = new DB.Category().SHOW(service.CategoryId).Name + "-" + service.Model;
                    dgvService.Rows[row].Cells["imei"].Value = service.Imei;
                    dgvService.Rows[row].Cells["remark"].Value = service.Remark;
                    dgvService.Rows[row].Cells["total"].Value = service.Total;
                    dgvService.Rows[row].Cells["status"].Value = service.Cleared == 0 ? "မရှင်းသေး" : service.Cleared == 1 ? "ရှင်းပြီး" : "စရန်ပေးပြီး";
                    dgvService.Rows[row].Cells["actions"].Value = "More";
                    total += service.Total;
                    dgvService.Text = (row + 1).ToString();
                }
                txtServiceTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please select correct Date Interval");
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Text = 0.ToString();
            txtPayment.Text = 0.ToString();
            txtIMEI.Text = "";
            txtPhoneModel.Text = "";
            txtRemain.Text = "0";
            txtRemark.Text = "";
        }

        private void dgvService_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            var row = dgvService.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];
            if (cell is DataGridViewButtonCell)
                dataGridView.Cursor = Cursors.Hand;
            else
                dataGridView.Cursor = Cursors.Default;
        }
    }
}
