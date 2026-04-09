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
    public partial class AdminDashboardForm : Form
    {
        TripService tripService = new TripService();
        BusService busService = new BusService();
        public AdminDashboardForm()
        {
            InitializeComponent();
        }
        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadBuses();
            LoadTrips();

            // Add this line so the arrival date starts as Today
            dtArrivalDate.Value = DateTime.Now;
        }
        private void LoadTrips()
        {
            dgvSchedules.AutoGenerateColumns = false;
            dgvSchedules.DataSource = tripService.GetTripsWithBookings();
        }
        private void LoadBuses()
        {
            var buses = busService.GetAllBuses();

            cmbBus.DataSource = buses;
            cmbBus.DisplayMember = "BusNumber";
            cmbBus.ValueMember = "BusID";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            //  Check if the textboxes exist and have values
            if (string.IsNullOrWhiteSpace(txtFrom.Text) ||
                string.IsNullOrWhiteSpace(txtTo.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                cmbBus.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields and select a bus");
                return;
            }

            //  Validate Price
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Enter a valid price");
                return;
            }

            // GET DEPARTURE: Combine Date Picker + Departure Time Picker
            DateTime departure = dtDate.Value.Date.Add(dtDeparture.Value.TimeOfDay);

            // GET ARRIVAL: Combine NEW Arrival Date Picker + Arrival Time Picker

            DateTime arrival = dtArrivalDate.Value.Date.Add(dtArrival.Value.TimeOfDay);

            // 5. Logic Check; Arrival cannot be before Departure
            if (arrival <= departure)
            {
                MessageBox.Show("Error: The bus cannot arrive before it departs! Check your Arrival Date.");
                return;
            }

            // 6. Create Trip object
            Trip trip = new Trip
            {
                BusID = (int)cmbBus.SelectedValue,
                FromLocation = txtFrom.Text,
                ToLocation = txtTo.Text,
                Departure = departure,
                Arrival = arrival,
                Price = price
            };


            tripService.AddTrip(trip);
            MessageBox.Show("Schedule added successfully");
            LoadTrips();
        }

        private void dgvSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int tripId = Convert.ToInt32(dgvSchedules.Rows[e.RowIndex].Cells["TripID"].Value);

            if (dgvSchedules.Columns[e.ColumnIndex].Name == "CancelTrip")
            {

                string status = dgvSchedules.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (status == "Cancelled")
                {
                    MessageBox.Show("Trip already cancelled");
                    return;
                }
                tripService.CancelTrip(tripId);

                MessageBox.Show("Trip cancelled. All tickets refunded.");

                LoadTrips();
            }

            if (dgvSchedules.Columns[e.ColumnIndex].Name == "Delete")
            {
                int bookings = Convert.ToInt32(dgvSchedules.Rows[e.RowIndex].Cells["Bookings"].Value);

                if (bookings > 0)
                {
                    MessageBox.Show("Cannot delete trip with existing bookings");
                    return;
                }

                tripService.DeleteTrip(tripId);

                MessageBox.Show("Trip deleted");

                LoadTrips();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.CurrentUser = null;

            Login login = new Login();
            login.Show();

            this.Close();
        }

        private void btnManageSchedules_Click(object sender, EventArgs e)
        {
            LoadTrips();
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            ViewBookingsForm form = new ViewBookingsForm();
            form.ShowDialog();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            AddBusForm form = new AddBusForm();
            form.ShowDialog();

            LoadBuses();
        }

        private void cmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
