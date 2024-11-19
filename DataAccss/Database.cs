using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccss
{
    public class Database
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=VNUF_StudentManagement;User ID=sa;Password=000000hieu;Encrypt=True;TrustServerCertificate=True";

        public SqlConnection Connection;

        public Database()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}
