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
    public class AuthenticationService
    {
        private DatabaseService db = new DatabaseService();

        public bool Register(string email, string password)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "INSERT INTO Users (Email, Password, IsAdmin) VALUES (@Email,@Password,0)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public User Login(string email, string password)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Users WHERE Email=@Email AND Password=@Password";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new User
                {
                    UserID = (int)reader["UserID"],
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString(),
                    IsAdmin = (bool)reader["IsAdmin"]
                };
            }

            return null;
        }
    }
}
