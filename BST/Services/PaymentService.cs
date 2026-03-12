using BST.Data;
using Microsoft.Data.SqlClient;

namespace BST.Services
{
    public class PaymentService
    {
        private DatabaseService db = new DatabaseService();

        public void ProcessPayment(int userId, int tripId, decimal amount)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Payment (UserID,TripID,Amount,Status)
                             VALUES (@UserID,@TripID,@Amount,'Paid')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@TripID", tripId);
            cmd.Parameters.AddWithValue("@Amount", amount);

            cmd.ExecuteNonQuery();
        }
    }
}