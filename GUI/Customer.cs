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
    }
}
