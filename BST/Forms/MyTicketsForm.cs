using BST.Models;
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
    public partial class MyTicketsForm : Form
    {
        TicketService ticketService = new TicketService();

        public MyTicketsForm()
        {
            InitializeComponent();
        }

        private void MyTicketsForm_Load(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void LoadTickets()
        {
            int userId = Session.CurrentUser.UserID;

            List<Ticket> tickets = ticketService.GetUserTickets(userId);
            dgvTickets.AutoGenerateColumns = false;
            dgvTickets.DataSource = tickets;
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
