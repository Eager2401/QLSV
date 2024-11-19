using DataAccss;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class BLLLogin
    {
        AccessLogin tkAcc = new AccessLogin();
        public string CheckLoginBLL(TaiKhoan tk)
        {
            if (string.IsNullOrEmpty(tk.UserName))
            {
                return "Tài khoản trống";
            }
            if (string.IsNullOrEmpty(tk.UserPassword))
            {
                return "Mật khẩu rỗng";
            }
            string info = tkAcc.checkLoginAL(tk);
            return info;

        }
    }
}
