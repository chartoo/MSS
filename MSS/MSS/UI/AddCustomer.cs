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
    public partial class AddCustomer : Form
    {
      public  int gender = 0, special = 0,ID=0;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 2;
        }

        private void rdbOther_CheckedChanged(object sender, EventArgs e)
        {
            gender = 0;
        }

        private void chbSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSpecial.Checked)
                special = 0;
            else
                special = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ID == 0)
                STORE();
            else
                UPDATE();
        }
        private void STORE()
        {
            if (txtName.Text == "")
                lbErrorCustomerName.Visible = true;
            if (txtPhone1.Text == "")
                lbErrorPhone1.Visible = true;
            if (txtName.Text != "" && txtPhone1.Text != "")
            {
                DO.Customer customer = new DO.Customer();
                customer.Name = txtName.Text;
                customer.Gender = gender;
                customer.Special = special;
                customer.Phone1 = txtPhone1.Text;
                customer.Phone2 = txtPhone2.Text;
                customer.Address = txtAddress.Text;
                customer.Description = txtDescription.Text;
                Boolean success = new DB.Customer().STORE(customer);
                if (success)
                    this.Close();
                else
                {
                    MessageBox.Show("Storing Error! \n Please Try Again");
                }
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SHOW();
                btnSave.Text = "Save Change";
                btnDelete.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to remove this customer? \n Name : "+txtName.Text, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (new DB.Customer().DESTROY(ID))
                    this.Close();
                else
                    MessageBox.Show("This Customer has many sales and services records. \n If you wish to delete, Firstly delete related records.", "Couldn't Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UPDATE()
        {
            if (txtName.Text == "")
                lbErrorCustomerName.Visible = true;
            if (txtPhone1.Text == "")
                lbErrorPhone1.Visible = true;
            if (txtName.Text != "" && txtPhone1.Text != "")
            {
                DO.Customer customer = new DO.Customer();
                customer.Name = txtName.Text;
                customer.Gender = gender;
                customer.Special = special;
                customer.Phone1 = txtPhone1.Text;
                customer.Phone2 = txtPhone2.Text;
                customer.Address = txtAddress.Text;
                customer.Description = txtDescription.Text;
                Boolean success = new DB.Customer().UPDATE(ID,customer);
                if (success)
                    this.Close();
                else
                {
                    MessageBox.Show(" Please Try Again \n or \n Contact to Support Team","Customer Updating Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
       private void SHOW()
        {
            DO.Customer customer = new DB.Customer().SHOW(ID);
            txtName.Text = customer.Name;
            txtPhone1.Text = customer.Phone1;
            txtPhone2.Text = customer.Phone2;
            txtAddress.Text = customer.Address;
            txtDescription.Text = customer.Description;
            chbSpecial.Checked = customer.Special == 1 ? true :false ;
            rdbMale.Checked = customer.Gender == 1 ? true : false;
            rdbFemale.Checked = customer.Gender == 2 ? true : false;
            rdbOther.Checked = customer.Gender == 0 ? true : false;
        }
    }
}
