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
    public partial class SaleEdit : Form
    {
        public int saleID = 0;
        int cleared = 0, remainType = 0;
        DO.Sale sale = new DO.Sale();
        public SaleEdit(int ID)
        {
            saleID = ID;
            InitializeComponent();
            SHOW(ID);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SHOW(int ID)
        {
             sale = new DB.Sale().SHOW(ID);
            if (sale!=null)
            {
                txtPhoneModel.Text = sale.Model;
                cbMass.Checked = sale.Mass == 1 ? true : false;
                cbItem.Checked = sale.Item == 1 ? true : false;
                txtIMEI.Text = sale.Imei;
                dtpSaleDate.Value = sale.SaleDate;
                txtDescription.Text = sale.Description;
                txtTotal.Text = sale.Total.ToString();
                txtPayment.Text = sale.Payment.ToString();
                txtReceivablePayable.Text = sale.Remain.ToString();
                rdbCleared.Checked = sale.Cleared == 1 ? true : false;
                rdbNotCleared.Checked = sale.Cleared == 0 ? true : false;
                GetCategories(sale.CategoryId);
                GetCustomerInfo(sale.CustomerId);
                GetCasherInfo(sale.UserId);
            }
        }
       
        private void GetCategories(int currnetID)
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
            cmbCategory.SelectedValue= currnetID;
        }

        private void GetCustomerInfo(int currentID)
        {
            DO.Customer customer = new DB.Customer().SHOW(currentID);
            if (customer != null)
            {
                lbCustomerName.Text = customer.Name;
                lbCustomerPhoneAddress.Text = customer.Phone1 + "(" + customer.Address + ")";
            }
        }
        private void GetCasherInfo(int currentID)
        {
            DO.User user = new DB.User().SHOW(currentID);
            if (user != null)
            {
                lbCasher.Text = user.Name;
            }
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            new AddCategory().ShowDialog();
            GetCategories(sale.CategoryId);
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ID = Convert.ToInt16(sale.CustomerId);
            addCustomer.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(new DB.Sale().UPDATE(getUpdateData()))
            {
                MessageBox.Show("Updated your changes data ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txtTotal.Text);
            double payment = Convert.ToDouble(txtPayment.Text);
            if (total < payment)
            {
                remainType = 1;
                lbRecPay.Text = "ပေးရန် ကျန်ငွေ ကို  :";
                txtReceivablePayable.Text = (payment - total).ToString();
            }
            else
            {
                remainType = 0;
                lbRecPay.Text = "ရရန် ကျန်ငွေ ကို  :";
                txtReceivablePayable.Text = (total - payment).ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (new DB.Sale().DESTROY(sale.Id))
            {
                MessageBox.Show("Deleted Data");
                this.Close();
            }
        }

        private DO.Sale getUpdateData()
        {
            DO.Sale updateSale = new DO.Sale();
            updateSale.Id = sale.Id;
            updateSale.UserId = sale.UserId;
            updateSale.CustomerId = sale.CustomerId;
            updateSale.CategoryId = (int)cmbCategory.SelectedValue;
            updateSale.Model = txtPhoneModel.Text;
            updateSale.Imei = txtIMEI.Text;
            updateSale.Mass= cbMass.Checked == true ? 1 : 0;
            updateSale.Item = cbItem.Checked == true ? 1 : 0;
            updateSale.SaleDate = dtpSaleDate.Value;
            updateSale.Total = Convert.ToDouble(txtTotal.Text);
            updateSale.Payment = Convert.ToDouble(txtPayment.Text);
            updateSale.Remain = Convert.ToDouble(txtReceivablePayable.Text);
            updateSale.Description = txtDescription.Text;
            sale.RemainType = remainType;
            sale.Cleared = rdbCleared.Checked == true ? 1 : 0;
            
            return updateSale;
        }
    }
}
