using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public class DatabaseManager
    {
        private string connectionString = "Data Source=LAPTOP-A393U748\\SQLAWSAFAHMED;Initial Catalog=InventoryDB;User ID=sa;Password=Aa@12738;";

        public SqlConnection OpenConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
