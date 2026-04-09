using BST.Services;
using BST.Models;
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
    public partial class BookingForm : Form
    {
        private int tripId;
        private decimal tripPrice;
        TicketService ticketService = new TicketService();
        TripService tripService = new TripService();

        public BookingForm(int tripId)
        {
            InitializeComponent();
            this.tripId = tripId;
        }
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            int seatCount = (int)numSeats.Value;
            decimal totalPrice = seatCount * tripPrice;

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
            // Get the actual trip price from the database
            var trip = tripService.GetAllTrips().FirstOrDefault(t => t.TripID == tripId);
            if (trip != null)
            {
                tripPrice = trip.Price;
            }
            else
            {
                MessageBox.Show("Trip not found.");
                this.Close();
            }
        }
    }
}