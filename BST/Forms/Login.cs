using BST.Services;
using BST.Models;
using BST.Forms;
namespace BST
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthenticationService authService = new AuthenticationService();

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            AuthenticationService auth = new AuthenticationService();

            User user = auth.Login(email, password);

            if (user != null)
            {
                MessageBox.Show("Login successful");

                // ⭐ SAVE USER SESSION
                Session.CurrentUser = user;

                if (user.IsModerator)
                {
                    ModeratorDashboardForm mod = new ModeratorDashboardForm();
                    mod.Show();
                    this.Hide();
                }
                else if (user.IsAdmin)
                {
                    AdminDashboardForm admin = new AdminDashboardForm();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    UserDashboardForm userDash = new UserDashboardForm();
                    userDash.Show();
                    this.Hide();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

        }
    }
}
