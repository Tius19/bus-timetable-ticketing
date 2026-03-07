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

        public UserDashboardForm()
        {
            InitializeComponent();
        }

        // NEW: Load trips when form opens
        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            LoadTrips();
        }

        // NEW: Method to load trips into grid
        private void LoadTrips()
        {
            List<Trip> trips = tripService.GetAllTrips();

            dgvTrips.AutoGenerateColumns = false; // IMPORTANT FIX
            dgvTrips.DataSource = trips;
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
            if (dgvTrips.Columns[e.ColumnIndex].Name == "colBook" && e.RowIndex >= 0)
            {
                int tripId = Convert.ToInt32(dgvTrips.Rows[e.RowIndex].Cells["colTripID"].Value);

                BookingForm booking = new BookingForm(tripId);
                booking.Show();
            }
        }
    }
}