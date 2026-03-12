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

            decimal pricePerSeat = 1500;
            decimal totalPrice = seatCount * pricePerSeat;

            int userId = Session.CurrentUser.UserID;

            PaymentForm payment = new PaymentForm(tripId, userId, totalPrice, seatCount);
            payment.ShowDialog();

            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }
    }
}