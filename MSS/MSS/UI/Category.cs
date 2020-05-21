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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        public Panel CategoryPanel()
        {
            SHOW_ALL();
            return panelCategory;
        }
        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            new AddCategory().ShowDialog();
            SHOW_ALL();
        }
        private void SHOW_ALL()
        {
            List<DO.Category> categories = new DB.Category().ALL();
            dgvCategory.Rows.Clear();
            foreach (var category in categories)
            {
                int row = dgvCategory.Rows.Add();
                dgvCategory.Rows[row].Cells["no"].Value = row + 1;
                dgvCategory.Rows[row].Cells["id"].Value = category.Id;
                dgvCategory.Rows[row].Cells["name"].Value = category.Name;
                dgvCategory.Rows[row].Cells["created_at"].Value = category.Created_at.ToString("yyyy-MM-dd hh:mm:ss tt");
                dgvCategory.Rows[row].Cells["actions"].Value = "Detail";
                lbShowCount.Text = (row + 1).ToString();
            }
        }

        private void dgvCategory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            var row = dgvCategory.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];
            if (cell is DataGridViewButtonCell)
                dataGridView.Cursor = Cursors.Hand;
            else
                dataGridView.Cursor = Cursors.Default;
        }
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var row = dgvCategory.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];

            if (cell is DataGridViewButtonCell)
            {
                AddCategory addCategory = new AddCategory();
                addCategory.ID = Convert.ToInt16(row.Cells["id"].Value);
                addCategory.ShowDialog();
                SHOW_ALL();
            }

        }

        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            List<DO.Category> categories = new DB.Category().FILTER_SEARCH(txtSearchCategory.Text);
            dgvCategory.Rows.Clear();
            foreach (var category in categories)
            {
                int row = dgvCategory.Rows.Add();
                dgvCategory.Rows[row].Cells["no"].Value = row + 1;
                dgvCategory.Rows[row].Cells["id"].Value = category.Id;
                dgvCategory.Rows[row].Cells["name"].Value = category.Name;
                dgvCategory.Rows[row].Cells["created_at"].Value = category.Created_at.ToString("yyyy-MM-dd hh:mm:ss tt");
                dgvCategory.Rows[row].Cells["actions"].Value = "Detail";
                lbShowCount.Text = (row + 1).ToString();
            }
        }
    }
}
