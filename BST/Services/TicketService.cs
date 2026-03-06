using BST.Data;
using BST.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST.Services
{
    public class TicketService
    {
        private DatabaseService db = new DatabaseService();

        public void BookTicket(int userId, int tripId, int seatCount, decimal price)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Ticket
            (UserID,TripID,SeatCount,Price,Status)
            VALUES (@UserID,@TripID,@SeatCount,@Price,'Active')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@TripID", tripId);
            cmd.Parameters.AddWithValue("@SeatCount", seatCount);
            cmd.Parameters.AddWithValue("@Price", price);

            cmd.ExecuteNonQuery();
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
    }
}
