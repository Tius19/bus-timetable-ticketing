using BST.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check empty fields
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // Confirm password check
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Password rules
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must contain:\n- 1 Capital letter\n- 1 Number\n- 1 Symbol");
                return;
            }

            AuthenticationService auth = new AuthenticationService();

            bool success = auth.Register(username, email, password);

            if (success)
            {
                MessageBox.Show("Account created successfully! Please log in.");

                Login login = new Login();
                login.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Email may already exist.");
            }
        }


        private bool IsValidPassword(string password)
        {
            bool hasUpper = password.Any(char.IsUpper);
            bool hasNumber = password.Any(char.IsDigit);
            bool hasSymbol = password.Any(ch => !char.IsLetterOrDigit(ch));

            return hasUpper && hasNumber && hasSymbol;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowHidepass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void btnShowHideConfirmpass_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
        }
    }
}
