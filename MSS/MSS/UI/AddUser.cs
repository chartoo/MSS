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
    public partial class AddUser : Form
    {
        public int ID = 0, gender = 1;
        public AddUser()
        {
            InitializeComponent();
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 2;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                btnSave.Text = "Change";
                btnDelete.Visible = true;
                SHOW();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                lbErrorName.Visible = true;
            }
            if (cbRole.Text.ToLower() == "select role" && cbRole.Text.ToLower() == "")
            {
                lbErrorRole.Visible = true;
            }
            if (txtPassword.Text != txtConformPassword.Text || txtPassword.Text.Length < 4)
            {
                lbErrorPassword.Visible = true;
            }
            else
            {
                DO.User user = new DO.User();
                user.Name = txtName.Text;
                user.Phone = txtPhone.Text;
                user.Role = cbRole.Text;
                user.Password = txtPassword.Text;
                user.Gender = gender;
                if (ID != 0)
                    UPDATE(user);
                else
                    STROE(user);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure want to remove this user? \n Name : " + txtName.Text, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (new DB.User().DESTROY(ID))
                    this.Close();
                else
                    MessageBox.Show("This User can not delete . \n If you wish to delete, Firstly delete related records.", "Couldn't Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void STROE(DO.User user)
        {
            if (new DB.User().STORE(user))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please try again (or) Contact support team!", "User Storing Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SHOW()
        {
            DO.User user = new DB.User().SHOW(ID);
            txtName.Text = user.Name;
            txtPhone.Text = user.Phone;
            txtPassword.Text = user.Password;
            txtConformPassword.Text = user.Password;
            cbRole.Text = user.Role;
            rdbMale.Checked = user.Gender == 1 ? true : false;
            rdbFemale.Checked = user.Gender == 2 ? true : false;
        }
        private void UPDATE(DO.User user)
        {
            if (new DB.User().UPDATE(ID,user))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please try again (or) Contact support team!", "User updateing Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
