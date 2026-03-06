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

                if (user.IsAdmin)
                {
                    AdminDashboardForm admin = new AdminDashboardForm();
                    admin.Show();
                }
                else
                {
                    UserDashboardForm userDash = new UserDashboardForm();
                    userDash.Show();
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
    }
}
