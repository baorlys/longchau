using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;


namespace GUI
{
    public partial class SignIn : Form
    {
        User user = new User();
        UserBLL userBLL = new UserBLL();
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            user.email = txbEmail.Text;
            user.password = txbPassword.Text;
            string userInfo = userBLL.checkLogin(user);
            switch (userInfo)
            {
                case "required email":
                    MessageBox.Show("Vui lòng nhập email");
                    return;
                case "required password":
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                    return;
                case "invalid email/pass":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
            }
            MessageBox.Show(userInfo);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
