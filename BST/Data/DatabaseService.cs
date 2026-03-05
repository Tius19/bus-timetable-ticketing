using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST.Data
{
    public class DatabaseService
    {
        private string connectionString =
            "Server=DESKTOP-47GUR0C\\SQLEXPRESS;Database=CatanBusDB;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
