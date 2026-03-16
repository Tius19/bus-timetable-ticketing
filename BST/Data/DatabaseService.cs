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
            "Server=DESKTOP-V8ICCLN\\SQLEXPRESS;Database=CatanBusDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
