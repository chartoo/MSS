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
    public partial class AddCategory : Form
    {
        public int ID = 0;
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (txtName.Text != "")
            {
                DO.Category category = new DO.Category();
                category.Name = txtName.Text;
                if (new DB.Category().STORE(category))
                    this.Close();
                else
                    MessageBox.Show("Could not save data! \n Please Try Again or Contact Support team", "Store Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                lbErrorName.Visible = true;
           
        }
        private void UPDATE()
        {
            if (txtName.Text != "")
            {
                DO.Category category = new DO.Category();
                category.Name = txtName.Text;
                if (new DB.Category().UPDATE(ID,category))
                    this.Close();
                else
                    MessageBox.Show("Could not update data! \n Please Try Again (or) Contact Support team", "Store Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbErrorName.Visible = true;
            }
        }
        private void AddCategory_Load(object sender, EventArgs e)
        {
            if(ID!=0)
            {
                btnSave.Text = "Change";
                btnDelete.Visible = true;
                txtName.Text = new DB.Category().SHOW(ID).Name;  
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ID!=0)
            {
                if(new DB.Category().DESTROY(ID))
                {
                    this.Close();
                }
            }
        }
    }
}
