using BussinessLogic;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FormLogin : Form
    {
        TaiKhoan tk = new TaiKhoan();
        BLLLogin tkBLL = new BLLLogin();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tk.UserName = txtMK.Text.Trim();
            tk.UserPassword = txtMK.Text.Trim();

            string getUser = tkBLL.CheckLoginBLL(tk);

            switch (getUser)
            {
                case "Tài khoản trống":
                    MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Mật khẩu rỗng":
                    MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "Tài khoản hoặc mật khâu không chính xác":
                    MessageBox.Show("Tài khoản hoặc mật khâu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            MessageBox.Show("Đăng nhập thành công");
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
