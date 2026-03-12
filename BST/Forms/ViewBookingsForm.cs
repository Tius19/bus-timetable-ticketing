using BST.Services;
using System;
using System.Windows.Forms;

namespace BST.Forms
{
    public partial class ViewBookingsForm : Form
    {
        TicketService ticketService = new TicketService();

        public ViewBookingsForm()
        {
            InitializeComponent();
        }

        private void ViewBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.DataSource = ticketService.GetAllTickets();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}