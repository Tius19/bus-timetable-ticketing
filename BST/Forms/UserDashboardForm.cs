using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// NEW
using BST.Services;
using BST.Models;

namespace BST.Forms
{
    public partial class UserDashboardForm : Form
    {
        // NEW: Trip service
        TripService tripService = new TripService();
        TicketService ticketService = new TicketService();

        public UserDashboardForm()
        {
            InitializeComponent();
        }

        // NEW: Load trips when form opens
        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            LoadTrips();
            LoadLocations();
            lblWelcome.Text = "Welcome, " + Session.CurrentUser.Username;
        }

        // NEW: Method to load trips into grid
        private void LoadTrips()
        {
            List<Trip> trips = tripService.GetAllTrips();

            dgvTrips.AutoGenerateColumns = false; // IMPORTANT FIX
            dgvTrips.DataSource = trips;
        }

        // Load user's booked trips
        private void LoadMyTrips()
        {
            var userTickets = ticketService.GetUserTickets(Session.CurrentUser.UserID);
            var myTrips = new List<Trip>();

            foreach (var ticket in userTickets)
            {
                var trip = tripService.GetAllTrips().FirstOrDefault(t => t.TripID == ticket.TripID);
                if (trip != null && trip.Status != "Cancelled")
                {
                    myTrips.Add(trip);
                }
            }

            dgvTrips.AutoGenerateColumns = false;
            dgvTrips.DataSource = myTrips;

            if (myTrips.Count == 0)
            {
                MessageBox.Show("You have no booked trips.");
            }
        }

        // Load user's past trips
        private void LoadPastTrips()
        {
            var userTickets = ticketService.GetUserTickets(Session.CurrentUser.UserID);
            var pastTrips = new List<Trip>();

            foreach (var ticket in userTickets)
            {
                var trip = tripService.GetAllTrips().FirstOrDefault(t => t.TripID == ticket.TripID);
                if (trip != null && trip.Departure < DateTime.Now && trip.Status != "Cancelled")
                {
                    pastTrips.Add(trip);
                }
            }

            dgvTrips.AutoGenerateColumns = false;
            dgvTrips.DataSource = pastTrips;

            if (pastTrips.Count == 0)
            {
                MessageBox.Show("You have no past trips.");
            }
        }

        // Load user's cancelled trips
        private void LoadCancelledTrips()
        {
            var userTickets = ticketService.GetUserTickets(Session.CurrentUser.UserID);
            var cancelledTrips = new List<Trip>();

            foreach (var ticket in userTickets)
            {
                var trip = tripService.GetAllTrips().FirstOrDefault(t => t.TripID == ticket.TripID);
                if (trip != null && trip.Status == "Cancelled")
                {
                    cancelledTrips.Add(trip);
                }
            }

            dgvTrips.AutoGenerateColumns = false;
            dgvTrips.DataSource = cancelledTrips;

            if (cancelledTrips.Count == 0)
            {
                MessageBox.Show("You have no cancelled trips.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numPassengers_ValueChanged(object sender, EventArgs e)
        {

        }

        // BOOK button logic
        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTrips.Columns[e.ColumnIndex].Name == "colBook")
            {
                int seatsLeft = Convert.ToInt32(dgvTrips.Rows[e.RowIndex].Cells["SeatsLeft"].Value);

                if (seatsLeft <= 0)
                {
                    MessageBox.Show("This bus is fully booked.");
                    return;
                }
                int tripId = Convert.ToInt32(dgvTrips.Rows[e.RowIndex].Cells["TripID"].Value);

                BookingForm booking = new BookingForm(tripId);
                booking.Show();
            }
        }

        private void btnMyTickets_Click(object sender, EventArgs e)
        {
            MyTicketsForm tickets = new MyTicketsForm();
            tickets.Show();
        }

        private void LoadLocations()
        {
            var trips = tripService.GetAllTrips();

            cmbFrom.Items.Clear();
            cmbTo.Items.Clear();

            var fromLocations = trips.Select(t => t.FromLocation).Distinct().ToList();
            var toLocations = trips.Select(t => t.ToLocation).Distinct().ToList();

            cmbFrom.Items.AddRange(fromLocations.ToArray());
            cmbTo.Items.AddRange(toLocations.ToArray());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var trips = tripService.GetAllTrips();

            // From filter
            if (cmbFrom.SelectedItem != null)
            {
                string from = cmbFrom.SelectedItem.ToString();
                trips = trips.Where(t => t.FromLocation == from).ToList();
            }

            // To filter
            if (cmbTo.SelectedItem != null)
            {
                string to = cmbTo.SelectedItem.ToString();
                trips = trips.Where(t => t.ToLocation == to).ToList();
            }

            // Date filter
            DateTime selectedDate = dtTripDate.Value.Date;
            trips = trips.Where(t => t.Departure.Date == selectedDate).ToList();

            // Passenger filter (NEW)
            int passengers = (int)numPassengers.Value;

            if (passengers > 0)
            {
                trips = trips.Where(t => t.SeatsAvailable >= passengers).ToList();
            }
            dgvTrips.DataSource = trips;

            if (trips.Count == 0)
            {
                MessageBox.Show("No trips available for selected filters.");
            }
        }

        private void btnViewTrips_Click(object sender, EventArgs e)
        {
            LoadMyTrips();
        }

        private void btnBookTrip_Click(object sender, EventArgs e)
        {
            LoadTrips();
        }

        private void btnPastTrips_Click(object sender, EventArgs e)
        {
            LoadPastTrips();
        }

        private void btnCancelledTrips_Click(object sender, EventArgs e)
        {
            LoadCancelledTrips();
        }

        // NEW: Logout button click handler
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.CurrentUser = null;

            Login login = new Login();
            login.Show();

            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}