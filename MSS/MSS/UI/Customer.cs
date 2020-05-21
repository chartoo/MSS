using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace MSS.UI
{
    public partial class Customer : Form
    {
        DO.Customer CustomerDO = new DO.Customer();
        DB.Customer CustomerDB = new DB.Customer();

        public Customer()
        {
            InitializeComponent();
        }

        public Panel CustomerPanel()
        {
            ShowAllCustomer();
            return panelCustomer;
        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            new AddCustomer().ShowDialog();
            ShowAllCustomer();
        }
        private void ShowAllCustomer()
        {
            List<DO.Customer> customers =new DB.Customer().ALL();
            dgvCustomer.Rows.Clear();
            foreach (var customer in customers)
            {
                int row = dgvCustomer.Rows.Add();
                dgvCustomer.Rows[row].Cells["no"].Value = row + 1;
                dgvCustomer.Rows[row].Cells["id"].Value = customer.Id;
                dgvCustomer.Rows[row].Cells["name"].Value = customer.Name;
                dgvCustomer.Rows[row].Cells["gender"].Value = customer.Gender == 1 ? "Male" : customer.Gender == 2 ? "Female" : "Other";
                dgvCustomer.Rows[row].Cells["phone"].Value = customer.Phone1;
                dgvCustomer.Rows[row].Cells["address"].Value = customer.Address;
                dgvCustomer.Rows[row].Cells["created_at"].Value = customer.Created_at.ToString("yyyy-MM-dd hh:mm:ss tt");
                dgvCustomer.Rows[row].Cells["actions"].Value = "Detail";
                lbRowCount.Text = (row+1).ToString();
            }
        }
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var row = dgvCustomer.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];

            if (cell is DataGridViewButtonCell)
            {
                AddCustomer addCustomer=new AddCustomer();
                addCustomer.ID = Convert.ToInt16(row.Cells["id"].Value);
                addCustomer.ShowDialog();
                ShowAllCustomer();
            }
            
        }
        private void FILTER(string name,string phone)
        {
            List<DO.Customer> customers = new DB.Customer().FILTER_SEARCH(name,phone);
            dgvCustomer.Rows.Clear();
            foreach (var customer in customers)
            {
                int row = dgvCustomer.Rows.Add();
                dgvCustomer.Rows[row].Cells["no"].Value = row + 1;
                dgvCustomer.Rows[row].Cells["id"].Value = customer.Id;
                dgvCustomer.Rows[row].Cells["name"].Value = customer.Name;
                dgvCustomer.Rows[row].Cells["gender"].Value = customer.Gender == 1 ? "Male" : customer.Gender == 2 ? "Female" : "Other";
                dgvCustomer.Rows[row].Cells["phone"].Value = customer.Phone1;
                dgvCustomer.Rows[row].Cells["address"].Value = customer.Address;
                dgvCustomer.Rows[row].Cells["created_at"].Value = customer.Created_at.ToString("yyyy-MM-dd hh:mm:ss tt");
                dgvCustomer.Rows[row].Cells["actions"].Value = "Detail";
                lbRowCount.Text = (row + 1).ToString();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            FILTER(txtSearchName.Text, txtSearchPhone.Text);
        }

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
            FILTER(txtSearchName.Text, txtSearchPhone.Text);
        }

        private void dgvCustomer_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            var row = dgvCustomer.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];
            if (cell is DataGridViewButtonCell)
                dataGridView.Cursor = Cursors.Hand;
            else
                dataGridView.Cursor = Cursors.Default;
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
