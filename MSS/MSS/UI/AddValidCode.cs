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
    public partial class AddValidCode : Form
    {
        public AddValidCode()
        {
            InitializeComponent();
            GetData();
        }
        private void GetData()
        {
            DO.Configuraion config = new DB.Configuration().GET();
            lbName.Text = config.Name;
            lbPerson.Text = config.Person;
            txtID.Text = config.MyId;
        }
        private void linkViaEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!new DO.Configuraion().CheckForInternetConnection())
                MessageBox.Show("Please Connect to the internet", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Process.Start("mailto:support.mss@gmail.com?subject=Request+Private+code");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!new DO.Configuraion().CheckForInternetConnection())
                MessageBox.Show("Please Connect to the internet.", "Connection Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void linkResendCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!new DO.Configuraion().CheckForInternetConnection())
                MessageBox.Show("Please Connect to the internet.", "Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
