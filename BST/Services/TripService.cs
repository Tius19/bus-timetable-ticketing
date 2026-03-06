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
    public class TripService
    {
        private DatabaseService db = new DatabaseService();

        public List<Trip> GetAllTrips()
        {
            List<Trip> trips = new List<Trip>();

            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Trip WHERE Status='Active'";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                trips.Add(new Trip
                {
                    TripID = (int)reader["TripID"],
                    BusID = (int)reader["BusID"],
                    FromLocation = reader["FromLocation"].ToString(),
                    ToLocation = reader["ToLocation"].ToString(),
                    Departure = (System.DateTime)reader["Departure"],
                    Arrival = (System.DateTime)reader["Arrival"],
                    Status = reader["Status"].ToString()
                });
            }

            return trips;
        }

        public void AddTrip(Trip trip)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Trip 
            (BusID,FromLocation,ToLocation,Departure,Arrival,Status)
            VALUES (@BusID,@From,@To,@Departure,@Arrival,'Active')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@BusID", trip.BusID);
            cmd.Parameters.AddWithValue("@From", trip.FromLocation);
            cmd.Parameters.AddWithValue("@To", trip.ToLocation);
            cmd.Parameters.AddWithValue("@Departure", trip.Departure);
            cmd.Parameters.AddWithValue("@Arrival", trip.Arrival);

            cmd.ExecuteNonQuery();
        }

        public void CancelTrip(int tripId)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "UPDATE Trip SET Status='Cancelled' WHERE TripID=@TripID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TripID", tripId);

            cmd.ExecuteNonQuery();
        }
    }
}
