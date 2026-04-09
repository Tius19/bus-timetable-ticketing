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
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 45);
            label1.Name = "label1";
            label1.Size = new Size(320, 36);
            label1.TabIndex = 1;
            label1.Text = "CATAN BUS REGISTER";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(62, 202);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 254);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(205, 199);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(205, 250);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(136, 375);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(86, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(290, 375);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(205, 147);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(228, 27);
            txtUsername.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 151);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 8;
            label3.Text = "UserName";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(205, 299);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(228, 27);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 303);
            label4.Name = "label4";
            label4.Size = new Size(124, 19);
            label4.TabIndex = 10;
            label4.Text = "Confirm Password";
            // 
            // btnShowHidepass
            // 
            btnShowHidepass.Location = new Point(448, 250);
            btnShowHidepass.Margin = new Padding(3, 4, 3, 4);
            btnShowHidepass.Name = "btnShowHidepass";
            btnShowHidepass.Size = new Size(34, 29);
            btnShowHidepass.TabIndex = 12;
            btnShowHidepass.Text = "👁️";
            btnShowHidepass.UseVisualStyleBackColor = true;
            btnShowHidepass.Click += btnShowHidepass_Click;
            // 
            // btnShowHideConfirmpass
            // 
            btnShowHideConfirmpass.Location = new Point(448, 303);
            btnShowHideConfirmpass.Margin = new Padding(3, 4, 3, 4);
            btnShowHideConfirmpass.Name = "btnShowHideConfirmpass";
            btnShowHideConfirmpass.Size = new Size(34, 29);
            btnShowHideConfirmpass.TabIndex = 13;
            btnShowHideConfirmpass.Text = "👁️";
            btnShowHideConfirmpass.UseVisualStyleBackColor = true;
            btnShowHideConfirmpass.Click += btnShowHideConfirmpass_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(563, 516);
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
            Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
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