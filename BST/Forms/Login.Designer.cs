namespace BST
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            btnShowHide = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 45);
            label1.Name = "label1";
            label1.Size = new Size(275, 36);
            label1.TabIndex = 0;
            label1.Text = "CATAN BUS LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 148);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "txtEmail";
            txtEmail.Location = new Point(192, 144);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaximumSize = new Size(228, 27);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.AccessibleName = "txtPassword";
            txtPassword.Location = new Point(192, 212);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.MaximumSize = new Size(228, 27);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 212);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.AccessibleName = "btnLogin";
            btnLogin.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(168, 304);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // btnRegister
            // 
            btnRegister.AccessibleName = "btnRegister";
            btnRegister.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(306, 304);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(114, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnShowHide
            // 
            btnShowHide.Location = new Point(427, 212);
            btnShowHide.Margin = new Padding(3, 4, 3, 4);
            btnShowHide.Name = "btnShowHide";
            btnShowHide.Size = new Size(34, 29);
            btnShowHide.TabIndex = 7;
            btnShowHide.Text = "👁️";
            btnShowHide.UseVisualStyleBackColor = true;
            btnShowHide.Click += btnShowHide_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(533, 484);
            Controls.Add(btnShowHide);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnShowHide;
    }
}
