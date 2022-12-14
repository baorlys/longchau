using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ResetPass : Form
    {
        private string email;
        public ResetPass()
        {
            InitializeComponent();
        }

        public ResetPass(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void txbChangePassword_Click(object sender, EventArgs e)
        {
            string newPass = txbNewPass.Texts;
            string confirmPass = txbConfirmPass.Texts;
            if (newPass == "" || confirmPass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu không khớp");
            }


        }
    }
}
