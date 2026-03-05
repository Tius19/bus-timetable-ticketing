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
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            AuthenticationService authService = new AuthenticationService();

            //User user = authService.Login(email, password);

            //if (user != null)
            //{
            //    MessageBox.Show("Login Successful!");

            //    if (user.IsAdmin)
            //    {
            //        AdminDashboardForm admin = new AdminDashboardForm();
            //        admin.Show();
            //    }
            //    else
            //    {
            //        UserDashboardForm userDashboard = new UserDashboardForm();
            //        userDashboard.Show();
            //    }

            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Email or Password");
            //}
        }
    }
}
