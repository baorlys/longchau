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
using DAL;
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
            user.Email = txbEmail.Texts;
            user.Name = txbName.Texts;
            user.Phone = txbPhone.Texts;
            user.Password = txbPassword.Texts;
            string confirmPass = txbConfirm.Texts;
            MessageHandler etUser = userBLL.checkSignUp(user, confirmPass);
            if (etUser.getStatus() == false)
            {
                MessageBox.Show(etUser.getMessage());
                return;
            }
            User userLogin = UserDAL.Instance.getUserByEmail(txbEmail.Texts);
            Customer customer = new Customer(userLogin);
            customer.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
