using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class CreateTrans : Form
    {
        public CreateTrans()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            int i = 1;
            int totalPrice = 0;
            CultureInfo ci = new CultureInfo("vi-VN");
            foreach (KeyValuePair<string, int> item in Cart.Instance.ListItem)
            {
                Medicine med = MedicineDAL.Instance.loadMedicineByMdcId(item.Key);
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.SubItems.Add(med.MdcId);
                lvItem.SubItems.Add(med.Name);
                lvItem.SubItems.Add(item.Value.ToString());
                lvItem.SubItems.Add(med.Price.ToString("c", ci));
                int price = item.Value * med.Price;
                totalPrice += price;
                lvItem.SubItems.Add(price.ToString("c", ci));
                lvCart.Items.Add(lvItem);
                i++;
            }
            int shipCost = 30000;
            tbShipCost.Text = shipCost.ToString("c", ci);
            totalPrice += shipCost;
            tbTotalPrice.Text = totalPrice.ToString("c", ci) ;
            tbName.Text = Customer.Instance.UserLogin.Name;
            tbName.Enabled = false;
            tbAddress.Text = Customer.Instance.UserLogin.Address;
            tbPhone.Text = Customer.Instance.UserLogin.Phone;
            cbBrand.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            string message = "Bạn có muốn xác nhận đơn hàng này không?";
            string title = "Xác nhận";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                DataTable medHandler = new DataTable();
                medHandler.Columns.Add("mdcId");
                medHandler.Columns.Add("quantity");
                foreach (KeyValuePair<string, int> item in Cart.Instance.ListItem)
                {
                    medHandler.Rows.Add(item.Key, item.Value);
                }
                User user = Customer.Instance.UserLogin;
                UserDAL.Instance.updateUserAddress(user.Email, tbAddress.Text);
                TransactionDAL.Instance.createTrans(medHandler, user.UserId,
                    DateTime.Now, Cart.Instance.TotalPrice + 30000, cbBrand.SelectedIndex + 1);
                Customer.Cart.Clear();
                Customer.Instance.loadCart();
                MessageBox.Show("Đơn hàng được tạo thành công ! Chờ xác nhận");
                this.Hide();
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "Cart")
                        Application.OpenForms[i].Close();
                }

            }
            


        }
    }
}
