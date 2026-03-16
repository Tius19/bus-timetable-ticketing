namespace BST.Forms
{
    partial class RegisterForm
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
            label1 = new Label();
            lblEmail = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            txtUsername = new TextBox();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            label4 = new Label();
            btnShowHidepass = new Button();
            btnShowHideConfirmpass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(101, 35);
            label1.Name = "label1";
            label1.Size = new Size(237, 30);
            label1.TabIndex = 1;
            label1.Text = "CATAN BUS REGISTER";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(54, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 200);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(179, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(179, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(119, 296);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(254, 296);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(179, 116);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 9;
            txtUsername.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 119);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "UserName";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(179, 236);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(200, 23);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 239);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 10;
            label4.Text = "Confirm Password";
            // 
            // btnShowHidepass
            // 
            btnShowHidepass.Location = new Point(392, 197);
            btnShowHidepass.Name = "btnShowHidepass";
            btnShowHidepass.Size = new Size(30, 23);
            btnShowHidepass.TabIndex = 12;
            btnShowHidepass.Text = "👁️";
            btnShowHidepass.UseVisualStyleBackColor = true;
            btnShowHidepass.Click += btnShowHidepass_Click;
            // 
            // btnShowHideConfirmpass
            // 
            btnShowHideConfirmpass.Location = new Point(392, 239);
            btnShowHideConfirmpass.Name = "btnShowHideConfirmpass";
            btnShowHideConfirmpass.Size = new Size(30, 23);
            btnShowHideConfirmpass.TabIndex = 13;
            btnShowHideConfirmpass.Text = "👁️";
            btnShowHideConfirmpass.UseVisualStyleBackColor = true;
            btnShowHideConfirmpass.Click += btnShowHideConfirmpass_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 407);
            Controls.Add(btnShowHideConfirmpass);
            Controls.Add(btnShowHidepass);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(lblEmail);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblEmail;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnBack;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtConfirmPassword;
        private Label label4;
        private Button btnShowHidepass;
        private Button btnShowHideConfirmpass;
    }
}