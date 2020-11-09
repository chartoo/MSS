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
            DO.Login.name = null;
            DO.Login.role = null;
            DO.Login.password = null;
            DO.Login.phone = null;
            DO.Login.id = 0;
            DO.Login login = new DB.User().Authenticate(password);
            if (login.Name!=null && login.Role != null)
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
