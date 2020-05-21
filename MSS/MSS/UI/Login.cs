using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSS.DB;
namespace MSS.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            if(password=="12345")
            {
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password! Please try again");
                txtPassword.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          new ConnectionManager().GetAllUsers();
        }
    }
}
