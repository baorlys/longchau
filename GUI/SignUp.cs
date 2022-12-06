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
    public partial class SignUp : Form
    {
        User user = new User();
        UserBLL userBLL = new UserBLL();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            user.email = txbEmail.Text;
            user.name = txbName.Text;
            user.phone = txbPhone.Text;
            user.password = txbPassword.Text;
            string confirmPass = txbConfirm.Text;
            MessageHandler etUser = userBLL.checkSignUp(user,confirmPass);
            if (!etUser.getStatus())
            {
                MessageBox.Show(etUser.getMessage());
                return;
            }
            MessageBox.Show("Thành công");
        }
    }
}
