using BST.Data;
using BST.Models;
using Microsoft.Data.SqlClient;
using System;

namespace BST.Services
{
    public class AuthenticationService
    {
        private DatabaseService db = new DatabaseService();

        // REGISTER USER
        public bool Register(string username, string email, string password)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"INSERT INTO Users 
                            (Username, Email, Password, IsAdmin, IsModerator) 
                            VALUES (@Username, @Email, @Password, 0, 0)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Username", username);
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

        // LOGIN USER
        public User Login(string email, string password)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"SELECT * FROM Users 
                     WHERE Email = @Email AND Password = @Password";

            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                User user = new User
                {
                    UserID = Convert.ToInt32(reader["UserID"]),
                    Username = reader["Username"]?.ToString(),
                    Email = reader["Email"]?.ToString(),
                    Password = reader["Password"]?.ToString(),
                    IsAdmin = reader["IsAdmin"] != DBNull.Value && Convert.ToBoolean(reader["IsAdmin"]),
                    IsModerator = reader["IsModerator"] != DBNull.Value && Convert.ToBoolean(reader["IsModerator"])
                };

                return user;
            }

            return null;
        }
    }
}