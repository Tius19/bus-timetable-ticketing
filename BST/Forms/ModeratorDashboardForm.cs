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
                bool isAdmin = false;
                bool isModerator = false;

                if (row.Cells["IsAdmin"].Value != null)
                    isAdmin = Convert.ToBoolean(row.Cells["IsAdmin"].Value);

                if (row.Cells["IsModerator"].Value != null)
                    isModerator = Convert.ToBoolean(row.Cells["IsModerator"].Value);

                if (isModerator)
                {
                    row.Cells["Action"].Value = "Cannot Modify";
                    row.Cells["Action"].ReadOnly = true;
                }
                else if (isAdmin)
                {
                    row.Cells["Action"].Value = "Demote to User";
                    row.Cells["Action"].ReadOnly = false;
                }
                else
                {
                    row.Cells["Action"].Value = "Make Admin";
                    row.Cells["Action"].ReadOnly = false;
                }
            }
        }

        // Handle Make Admin / Demote button click
        private void dgvUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvUsers.Columns[e.ColumnIndex].Name == "Action")
            {
                int userId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserID"].Value);

                bool isAdmin = dgvUsers.Rows[e.RowIndex].Cells["IsAdmin"].Value != null &&
                               Convert.ToBoolean(dgvUsers.Rows[e.RowIndex].Cells["IsAdmin"].Value);

                bool isModerator = dgvUsers.Rows[e.RowIndex].Cells["IsModerator"].Value != null &&
                                   Convert.ToBoolean(dgvUsers.Rows[e.RowIndex].Cells["IsModerator"].Value);

                if (isModerator)
                {
                    MessageBox.Show("Moderator account cannot be modified.");
                    return;
                }

                if (isAdmin)
                {
                    // Demote admin to regular user
                    userService.DemoteAdmin(userId);
                    MessageBox.Show("User demoted to Regular User.");
                }
                else
                {
                    // Promote user to admin
                    userService.MakeAdmin(userId);
                    MessageBox.Show("User promoted to Admin.");
                }

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
                bool isAdmin = false;
                bool isModerator = false;

                if (row.Cells["IsAdmin"].Value != null)
                    isAdmin = Convert.ToBoolean(row.Cells["IsAdmin"].Value);

                if (row.Cells["IsModerator"].Value != null)
                    isModerator = Convert.ToBoolean(row.Cells["IsModerator"].Value);

                if (isModerator)
                {
                    row.Cells["Action"].Value = "Cannot Modify";
                    row.Cells["Action"].ReadOnly = true;
                }
                else if (isAdmin)
                {
                    row.Cells["Action"].Value = "Demote to User";
                    row.Cells["Action"].ReadOnly = false;
                }
                else
                {
                    row.Cells["Action"].Value = "Make Admin";
                    row.Cells["Action"].ReadOnly = false;
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

        // NEW: Logout button click handler
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.CurrentUser = null;

            Login login = new Login();
            login.Show();

            this.Close();
        }
    }
}