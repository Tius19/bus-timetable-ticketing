using BST.Services;
using System;
using System.Windows.Forms;

namespace BST.Forms
{
    public partial class ModeratorDashboardForm : Form
    {
        // Create UserService object
        UserService userService = new UserService();

        public ModeratorDashboardForm()
        {
            InitializeComponent();
        }

        private void ModeratorDashboardForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // Load all users into grid
        private void LoadUsers()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = userService.GetAllUsers();

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.Cells["IsAdmin"].Value != null &&
                    Convert.ToBoolean(row.Cells["IsAdmin"].Value))
                {
                    row.Cells["Action"].Value = "Already Admin";
                    row.Cells["Action"].ReadOnly = true;
                }
            }
        }

        // Handle Make Admin button click

        private void dgvUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvUsers.Columns[e.ColumnIndex].Name == "Action")
            {
                int userId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserID"].Value);

                bool isAdmin = Convert.ToBoolean(dgvUsers.Rows[e.RowIndex].Cells["IsAdmin"].Value);

                if (isAdmin)
                {
                    MessageBox.Show("This user is already an Admin.");
                    return;
                }
                bool isModerator = Convert.ToBoolean(dgvUsers.Rows[e.RowIndex].Cells["IsModerator"].Value);

                if (isModerator)
                {
                    MessageBox.Show("Moderator account cannot be modified.");
                    return;
                }

                userService.MakeAdmin(userId);

                MessageBox.Show("User promoted to Admin.");

                LoadUsers();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchUser.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadUsers();
                return;
            }

            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = userService.SearchUsers(keyword);

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.Cells["IsAdmin"].Value != null &&
                    Convert.ToBoolean(row.Cells["IsAdmin"].Value))
                {
                    row.Cells["Action"].Value = "Already Admin";
                    row.Cells["Action"].ReadOnly = true;
                }
            }
        }

        private void txtSearchUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}