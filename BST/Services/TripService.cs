using BST.Data;
using BST.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST.Services
{
    public class TripService
    {
        private DatabaseService db = new DatabaseService();

        public List<Trip> GetAllTrips()
        {
            List<Trip> trips = new List<Trip>();

            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"
            SELECT 
                t.TripID,
                t.BusID,
                b.BusNumber,
                t.FromLocation,
                t.ToLocation,
                t.Departure,
                t.Arrival,
                t.Status,
                b.SeatsAvailable,
                t.Price
            FROM Trip t
            JOIN Bus b ON t.BusID = b.BusID
            WHERE t.Status='Active'";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                trips.Add(new Trip
                {
                    TripID = (int)reader["TripID"],
                    BusID = (int)reader["BusID"],
                    BusNumber = reader["BusNumber"].ToString(),
                    FromLocation = reader["FromLocation"].ToString(),
                    ToLocation = reader["ToLocation"].ToString(),
                    Departure = (DateTime)reader["Departure"],
                    Arrival = (DateTime)reader["Arrival"],
                    Status = reader["Status"].ToString(),
                    SeatsAvailable = (int)reader["SeatsAvailable"],
                    Price = reader["Price"] == DBNull.Value ? 0 : (decimal)reader["Price"]
                });
            }

            return trips;
        }

        public void AddTrip(Trip trip)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Trip
    (BusID,FromLocation,ToLocation,Departure,Arrival,Price,Status)
    VALUES (@BusID,@From,@To,@Departure,@Arrival,@Price,'Active')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@BusID", trip.BusID);
            cmd.Parameters.AddWithValue("@From", trip.FromLocation);
            cmd.Parameters.AddWithValue("@To", trip.ToLocation);
            cmd.Parameters.AddWithValue("@Departure", trip.Departure);
            cmd.Parameters.AddWithValue("@Arrival", trip.Arrival);
            cmd.Parameters.AddWithValue("@Price", trip.Price);

            cmd.ExecuteNonQuery();
        }

        public void CancelTrip(int tripId)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                // 1️⃣ Get BusID for this trip
                string busQuery = "SELECT BusID FROM Trip WHERE TripID=@TripID";
                SqlCommand busCmd = new SqlCommand(busQuery, conn, transaction);
                busCmd.Parameters.AddWithValue("@TripID", tripId);

                int busId = (int)busCmd.ExecuteScalar();

                // 2️⃣ Get seats booked for this trip
                string seatQuery = "SELECT ISNULL(SUM(SeatCount),0) FROM Ticket WHERE TripID=@TripID";
                SqlCommand seatCmd = new SqlCommand(seatQuery, conn, transaction);
                seatCmd.Parameters.AddWithValue("@TripID", tripId);

                int seatsBooked = (int)seatCmd.ExecuteScalar();

                // 3️⃣ Restore seats
                string restoreSeats = @"
        UPDATE Bus 
        SET SeatsAvailable = SeatsAvailable + @Seats
        WHERE BusID=@BusID";

                SqlCommand restoreCmd = new SqlCommand(restoreSeats, conn, transaction);
                restoreCmd.Parameters.AddWithValue("@Seats", seatsBooked);
                restoreCmd.Parameters.AddWithValue("@BusID", busId);
                restoreCmd.ExecuteNonQuery();

                // 4️⃣ Cancel tickets
                string cancelTickets = @"
        UPDATE Ticket 
        SET Status='Cancelled'
        WHERE TripID=@TripID";

                SqlCommand ticketCmd = new SqlCommand(cancelTickets, conn, transaction);
                ticketCmd.Parameters.AddWithValue("@TripID", tripId);
                ticketCmd.ExecuteNonQuery();

                // 5️⃣ Refund payments
                string refundPayments = @"
        UPDATE Payment
        SET Status='Refunded'
        WHERE TripID=@TripID";

                SqlCommand paymentCmd = new SqlCommand(refundPayments, conn, transaction);
                paymentCmd.Parameters.AddWithValue("@TripID", tripId);
                paymentCmd.ExecuteNonQuery();

                // 6️⃣ Cancel trip
                string cancelTrip = @"
        UPDATE Trip
        SET Status='Cancelled'
        WHERE TripID=@TripID";

                SqlCommand tripCmd = new SqlCommand(cancelTrip, conn, transaction);
                tripCmd.Parameters.AddWithValue("@TripID", tripId);
                tripCmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public DataTable GetTripsWithBookings()
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"
            SELECT 
                t.TripID,
                t.FromLocation + ' -> ' + t.ToLocation AS Route,
                t.Departure,
                t.Status,
                ISNULL(COUNT(ticket.TicketID),0) AS Bookings
            FROM Trip t
            LEFT JOIN Ticket ticket ON t.TripID = ticket.TripID
            GROUP BY 
                t.TripID,
                t.FromLocation,
                t.ToLocation,
                t.Departure,
                t.Status";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public void DeleteTrip(int tripId)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "DELETE FROM Trip WHERE TripID=@TripID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TripID", tripId);

            cmd.ExecuteNonQuery();
        }
    }
}
