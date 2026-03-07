using BST.Services;
using System;
using System.Windows.Forms;

namespace BST.Forms
{
    public partial class BookingForm : Form
    {
        private int tripId;
        TicketService ticketService = new TicketService();

        public BookingForm(int tripId)
        {
            InitializeComponent();
            this.tripId = tripId;
        }
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            int seatCount = (int)numSeats.Value;

            decimal pricePerSeat = 1500; // simple fixed price
            decimal totalPrice = seatCount * pricePerSeat;

            int userId = 1; // temporary (later we pass logged in user)

            ticketService.BookTicket(userId, tripId, seatCount, totalPrice);

            MessageBox.Show("Ticket booked successfully!");

            this.Close();
        }
    }
}