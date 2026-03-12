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
    public class UserService
    {
        private DatabaseService db = new DatabaseService();

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Users";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    UserID = (int)reader["UserID"],
                    Username = reader["Username"].ToString(),
                    Email = reader["Email"].ToString(),
                    IsAdmin = (bool)reader["IsAdmin"],
                    IsModerator = (bool)reader["IsModerator"]
                });
            }

            return users;
        }

        public void MakeAdmin(int userId)
        {
            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "UPDATE Users SET IsAdmin = 1 WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", userId);

            cmd.ExecuteNonQuery();
        }

        public List<User> SearchUsers(string keyword)
        {
            List<User> users = new List<User>();

            using SqlConnection conn = db.GetConnection();
            conn.Open();

            string query = @"
    SELECT UserID, Username, Email, IsAdmin, IsModerator
    FROM Users
    WHERE Username LIKE @Keyword OR Email LIKE @Keyword";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    UserID = (int)reader["UserID"],
                    Username = reader["Username"].ToString(),
                    Email = reader["Email"].ToString(),
                    IsAdmin = (bool)reader["IsAdmin"],
                    IsModerator = (bool)reader["IsModerator"]
                });
            }

            return users;
        }

    }
}
