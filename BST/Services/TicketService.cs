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
    public class TicketService
    {
        private DatabaseService db = new DatabaseService();

        public bool BookTicket(int userId, int tripId, int seatCount, decimal price)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            // 1️⃣ Get BusID for this trip
            string busQuery = "SELECT BusID FROM Trip WHERE TripID=@TripID";
            SqlCommand busCmd = new SqlCommand(busQuery, conn);
            busCmd.Parameters.AddWithValue("@TripID", tripId);

            int busId = (int)busCmd.ExecuteScalar();

            // 2️⃣ Check available seats
            string seatQuery = "SELECT SeatsAvailable FROM Bus WHERE BusID=@BusID";
            SqlCommand seatCmd = new SqlCommand(seatQuery, conn);
            seatCmd.Parameters.AddWithValue("@BusID", busId);

            int seatsAvailable = (int)seatCmd.ExecuteScalar();

            if (seatCount > seatsAvailable)
            {
                MessageBox.Show("Not enough seats available.");
                return false;
            }

            // 3️⃣ Insert ticket
            string ticketQuery = @"INSERT INTO Ticket (UserID,TripID,SeatCount,Price,Status)
                           VALUES (@UserID,@TripID,@Seats,@Price,'Active')";

            SqlCommand ticketCmd = new SqlCommand(ticketQuery, conn);

            ticketCmd.Parameters.AddWithValue("@UserID", userId);
            ticketCmd.Parameters.AddWithValue("@TripID", tripId);
            ticketCmd.Parameters.AddWithValue("@Seats", seatCount);
            ticketCmd.Parameters.AddWithValue("@Price", price);

            ticketCmd.ExecuteNonQuery();

            // 4️⃣ Reduce available seats
            string updateSeats = @"UPDATE Bus 
                           SET SeatsAvailable = SeatsAvailable - @Seats
                           WHERE BusID=@BusID";

            SqlCommand updateCmd = new SqlCommand(updateSeats, conn);

            updateCmd.Parameters.AddWithValue("@Seats", seatCount);
            updateCmd.Parameters.AddWithValue("@BusID", busId);

            updateCmd.ExecuteNonQuery();

            return true;
        }

        public List<Ticket> GetUserTickets(int userId)
        {
            List<Ticket> tickets = new List<Ticket>();

            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Ticket WHERE UserID=@UserID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", userId);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tickets.Add(new Ticket
                {
                    TicketID = (int)reader["TicketID"],
                    UserID = (int)reader["UserID"],
                    TripID = (int)reader["TripID"],
                    SeatCount = (int)reader["SeatCount"],
                    Price = (decimal)reader["Price"],
                    Status = reader["Status"].ToString()
                });
            }

            return tickets;
        }

        public DataTable GetAllTickets()
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"
            SELECT 
                t.TicketID,
                u.Email AS [User],
                tr.FromLocation + ' -> ' + tr.ToLocation AS Route,
                tr.Departure,
                t.SeatCount AS Seats,
                t.Price,
                t.Status
            FROM Ticket t
            JOIN Users u ON t.UserID = u.UserID
            JOIN Trip tr ON t.TripID = tr.TripID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
