using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccss
{
    public class SQLConnectionData
    {
        public static SqlConnection Connect()
        {
            string connection = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=UserLogin;Persist Security Info=True;User ID=sa;Password=000000hieu;Encrypt=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }

    }
    public class DA_Login
    {
        public static string CheckLogin(TaiKhoan tk)
        {
            string user = null;
            using (SqlConnection conn = SQLConnectionData.Connect())
            {
                conn.Open();
                string query = "SELECT UserName FROM LoginInform WHERE UserName = @UserName AND UserPassword = @UserPassword";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", tk.UserName);
                    cmd.Parameters.AddWithValue("@UserPassword", tk.UserPassword);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                user = reader.GetString(0); // Đọc tên người dùng
                            }
                        }
                        else
                        {
                            user = "Tài khoản hoặc mật khẩu không chính xác";
                        }
                    }
                }
            }
            return user;
        }
    }
}
