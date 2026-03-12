using BST.Data;
using BST.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace BST.Services
{
    public class BusService
    {
        private DatabaseService db = new DatabaseService();

        // Add new bus
        public void AddBus(string busNumber, int seatsCapacity)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Bus (BusNumber, SeatsCapacity, SeatsAvailable)
                             VALUES (@BusNumber,@SeatsCapacity,@SeatsCapacity)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@BusNumber", busNumber);
            cmd.Parameters.AddWithValue("@SeatsCapacity", seatsCapacity);

            cmd.ExecuteNonQuery();
        }

        // Get all buses
        public List<Bus> GetAllBuses()
        {
            List<Bus> buses = new List<Bus>();

            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Bus";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                buses.Add(new Bus
                {
                    BusID = (int)reader["BusID"],
                    BusNumber = reader["BusNumber"].ToString(),
                    SeatsCapacity = (int)reader["SeatsCapacity"],
                    SeatsAvailable = (int)reader["SeatsAvailable"]
                });
            }

            return buses;
        }
    }
}