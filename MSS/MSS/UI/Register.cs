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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (Store())
                {
                    this.Hide();
                    new AddValidCode().Show();
                }
            }
            else MessageBox.Show("Please enter the red star values.", "Fill All!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }
        private Boolean Store()
        {
            Random rnd = new Random();
            int myId = rnd.Next(000000, 999999);
            if (new DO.Configuraion().CheckForInternetConnection())
            {
                DO.Configuraion config = new DO.Configuraion()
                {
                    Name = txtName.Text,
                    Person = txtPerson.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    MyId ="MSS-"+ myId
                };
                if (new DB.Configuration().STORE(config))
                {
                    return true;
                }
                return false;
            }
            else
                MessageBox.Show("Please Connect to the internet.", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private Boolean Validate()
        {
            if (txtName.Text == "") return false;
            if (txtPerson.Text == "") return false;
            if (txtPhone.Text == "") return false;
            if (txtEmail.Text == "") return false;
            else return true;

        }

        private void cbIKnow_CheckedChanged(object sender, EventArgs e)
        {
            btnRegister.Enabled = cbIKnow.Checked == true ? true : false;
        }
    }
}
