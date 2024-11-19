using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccss
{
    public class AccessLogin : DA_Login
    {
        public string checkLoginAL(TaiKhoan tk)
        {
            string info = CheckLogin(tk);
            return info;
        }
    }
}
