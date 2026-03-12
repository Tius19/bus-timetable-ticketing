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
            panelHeader = new Panel();
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
            button1 = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(button1);
            panelHeader.Controls.Add(txtSearchUser);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(btnSearch);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(644, 130);
            panelHeader.TabIndex = 2;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(174, 83);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(212, 23);
            txtSearchUser.TabIndex = 3;
            txtSearchUser.KeyDown += txtSearchUser_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 90);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Search User";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(411, 82);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(143, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(362, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CatanBus - Moderator Dashboard";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { UserID, UserName, Email, IsAdmin, IsModerator, Action });
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 130);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(644, 321);
            dgvUsers.TabIndex = 3;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick_1;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "UserID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "Username";
            UserName.HeaderText = "UserName";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // IsAdmin
            // 
            IsAdmin.DataPropertyName = "IsAdmin";
            IsAdmin.HeaderText = "IsAdmin";
            IsAdmin.Name = "IsAdmin";
            IsAdmin.ReadOnly = true;
            // 
            // IsModerator
            // 
            IsModerator.DataPropertyName = "IsModerator";
            IsModerator.HeaderText = "IsModerator";
            IsModerator.Name = "IsModerator";
            IsModerator.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Text = "Make Admin";
            Action.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            button1.Location = new Point(525, 82);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 5;
            button1.Text = "View All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ModeratorDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 451);
            Controls.Add(dgvUsers);
            Controls.Add(panelHeader);
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