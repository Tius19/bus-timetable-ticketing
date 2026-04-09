namespace BST.Forms
{
    partial class ModeratorDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            btnLogout = new Button();
            button1 = new Button();
            txtSearchUser = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            lblTitle = new Label();
            dgvUsers = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            IsAdmin = new DataGridViewTextBoxColumn();
            IsModerator = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 64, 0);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Controls.Add(button1);
            panelHeader.Controls.Add(txtSearchUser);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(btnSearch);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(799, 173);
            panelHeader.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(673, 115);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 31);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(541, 115);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 5;
            button1.Text = "View All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(113, 117);
            txtSearchUser.Margin = new Padding(3, 4, 3, 4);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(242, 27);
            txtSearchUser.TabIndex = 3;
            txtSearchUser.KeyDown += txtSearchUser_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 120);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 4;
            label1.Text = "Search User";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(374, 115);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(163, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CatanBus - Moderator Dashboard";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = Color.Beige;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { UserID, UserName, Email, IsAdmin, IsModerator, Action });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 173);
            dgvUsers.Margin = new Padding(3, 4, 3, 4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(799, 428);
            dgvUsers.TabIndex = 3;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick_1;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "UserID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Width = 125;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "Username";
            UserName.HeaderText = "UserName";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // IsAdmin
            // 
            IsAdmin.DataPropertyName = "IsAdmin";
            IsAdmin.HeaderText = "IsAdmin";
            IsAdmin.MinimumWidth = 6;
            IsAdmin.Name = "IsAdmin";
            IsAdmin.ReadOnly = true;
            IsAdmin.Width = 125;
            // 
            // IsModerator
            // 
            IsModerator.DataPropertyName = "IsModerator";
            IsModerator.HeaderText = "IsModerator";
            IsModerator.MinimumWidth = 6;
            IsModerator.Name = "IsModerator";
            IsModerator.ReadOnly = true;
            IsModerator.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Width = 125;
            // 
            // ModeratorDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 601);
            Controls.Add(dgvUsers);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModeratorDashboardForm";
            Text = "ModeratorDashboardForm";
            Load += ModeratorDashboardForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button btnLogout;
        private Button btnSearch;
        private Label lblTitle;
        private TextBox txtSearchUser;
        private Label label1;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn IsAdmin;
        private DataGridViewTextBoxColumn IsModerator;
        private DataGridViewButtonColumn Action;
        private Button button1;
    }
}