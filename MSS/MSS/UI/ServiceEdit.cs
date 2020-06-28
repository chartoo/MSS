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
    public partial class ServiceEdit : Form
    {
        int cleared=0, remainType = 0;
        DO.Service service=new DO.Service();
        public ServiceEdit()
        {
            InitializeComponent();
        }
        public ServiceEdit(int id)
        {
            InitializeComponent();
            SHOW(id);
        }
        private void SHOW(int id)
        {
            service = new DB.Service().SHOW(id);
            if (service != null)
            {
                txtPhoneModel.Text = service.Model;
                txtIMEI.Text = service.Imei;
                dtpReturnDate.Value = service.ReturnDate;
                txtDescription.Text = service.Description;
                txtRemark.Text = service.Remark;
                txtTotal.Text = service.Total.ToString();
                txtPayment.Text = service.Payment.ToString();
                txtReceivablePayable.Text = service.Remain.ToString();
                rdbPreAmount.Checked = service.Cleared == 2 ? true : false;
                rdbCleared.Checked = service.Cleared == 1 ? true : false;
                rdbNotCleared.Checked = service.Cleared == 0 ? true : false;
                
                GetCategories(service.CategoryId);
                GetCustomerInfo(service.CustomerId);
                GetCasherInfo(service.UserId);
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
            cmbCategory.SelectedValue = currnetID;
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

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            AddCustomer customer = new AddCustomer();
            customer.ID = service.CustomerId;
            customer.ShowDialog();

        }

        private void GetCasherInfo(int currentID)
        {
            DO.User user = new DB.User().SHOW(currentID);
            if (user != null)
            {
                lbCasher.Text = user.Name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (getUpdateData()!=null && new DB.Service().UPDATE(getUpdateData()))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Retry to update data!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void rdbPreAmount_CheckedChanged(object sender, EventArgs e)
        {
           cleared = 2;
        }

        private void rdbCleared_CheckedChanged(object sender, EventArgs e)
        {
           cleared = 1;
        }

        private void rdbNotCleared_CheckedChanged(object sender, EventArgs e)
        {
            cleared = 0;
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            AddCategory category = new AddCategory();
            category.ShowDialog();
            GetCategories(service.CategoryId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Are you sure want to delete this data for "+lbCustomerName.Text+" (Total Price : "+service.Total+") ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                if (new DB.Service().DESTROY(service.Id))
                    this.Close();
            }
        }

        private DO.Service getUpdateData()
        {
            try
            {
                DO.Service updateService = new DO.Service();
                updateService.Id = service.Id;
                updateService.UserId = service.UserId;
                updateService.CustomerId = service.CustomerId;
                updateService.CategoryId = (int)cmbCategory.SelectedValue;
                updateService.Model = txtPhoneModel.Text;
                updateService.Imei = txtIMEI.Text;
                updateService.ReturnDate = dtpReturnDate.Value;
                updateService.Remark = txtRemark.Text;
                updateService.Total = Convert.ToDouble(txtTotal.Text);
                updateService.Payment = Convert.ToDouble(txtPayment.Text);
                updateService.Remain = Convert.ToDouble(txtReceivablePayable.Text);
                updateService.Description = txtDescription.Text;
                updateService.RemainType = remainType;
                updateService.Cleared = cleared;

                return updateService;
            }
            catch(Exception e)
            {
                MessageBox.Show("PLease Fill of all Data");
                return null;
            }
            
        }
    }
}
