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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }
        public Panel UserPanel()
        {
            SHOW_ALL();
            return panelUserList;
        }
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var row = dgvUser.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];

            if (cell is DataGridViewButtonCell)
            {
                AddUser addUser = new AddUser();
                addUser.ID = Convert.ToInt16(row.Cells["id"].Value);
                addUser.ShowDialog();
                SHOW_ALL();
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }
        private void SHOW_ALL()
        {
            List<DO.User> users = new DB.User().ALL();
            dgvUser.Rows.Clear();
            foreach (var user in users)
            {
                int row = dgvUser.Rows.Add();
                dgvUser.Rows[row].Cells["no"].Value = row + 1;
                dgvUser.Rows[row].Cells["id"].Value = user.Id;
                dgvUser.Rows[row].Cells["name"].Value = user.Name;
                dgvUser.Rows[row].Cells["gender"].Value = user.Gender==1?"Male":"Female";
                dgvUser.Rows[row].Cells["role"].Value = user.Role;
                dgvUser.Rows[row].Cells["phone"].Value = user.Phone;
                dgvUser.Rows[row].Cells["created_at"].Value = user.Created_at;
                dgvUser.Rows[row].Cells["actions"].Value = "Detail";
            }
        }
       

    }
}
