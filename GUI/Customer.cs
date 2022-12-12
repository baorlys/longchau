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

namespace GUI
{
    public partial class Customer : Form
    {
        private User userLogin;

        public User UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; }
        }
        public Customer(User userLogin)
        {
            InitializeComponent();
            this.userLogin = userLogin;
            label1.Text = "Hello " + userLogin.Name;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
