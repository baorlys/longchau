using DAL;
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
    public partial class ListImport : Form
    {
        private string importId;

        public string ImportId { get => importId; set => importId = value; }

        public ListImport()
        {
            InitializeComponent();
            cbStatus.SelectedIndex = 3;
            loadData();
        }

        void loadData()
        {
            lvImports.Items.Clear();
            List<Import> imports = ImportDAL.Instance.GetImports(cbStatus.SelectedIndex);
            int i = 0;
            foreach (Import item in imports)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.UseItemStyleForSubItems = false;
                lvItem.SubItems.Add(item.ImportId);
                lvItem.SubItems.Add(item.RequestDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
                lvItem.SubItems.Add(item.MdcId);
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvItem.SubItems.Add(item.DateExpire.ToString("dd/MM/yyyy hh:mm:ss tt"));
                int status = item.Status;
                string str = "";
                Color color = Color.White;
                switch (status)
                {
                    case 0:
                        str = "Chờ duyệt";
                        color = Color.Yellow;
                        break;
                    case 1:
                        str = "Đã duyệt";
                        color = Color.LightBlue;
                        break;
                    case 2:
                        str = "Đã nhận";
                        color = Color.Green;
                        break;
                }
                lvItem.SubItems.Add(str);
                lvItem.SubItems[6].BackColor = color;
                lvImports.Items.Add(lvItem);
                i++;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lvImports_MouseClick(object sender, MouseEventArgs e)
        {
            btnCancle.Enabled = false;
            btnReceived.Enabled = false;
            ImportId = lvImports.SelectedItems[0].SubItems[1].Text;
            tbImportId.Text = ImportId;
            string status = lvImports.SelectedItems[0].SubItems[6].Text;
            tbStatus.Text = status;
            switch(status)
            {
                case "Chờ duyệt":
                    btnCancle.Enabled = true;
                    btnReceived.Enabled = false;
                    break;
                case "Đã duyệt":
                    btnReceived.Enabled = true;
                    btnCancle.Enabled = false;
                    break;
                case "Đã nhận":
                    btnCancle.Enabled = false;
                    btnReceived.Enabled = false;
                    break;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            string message = "Bạn có muốn huỷ yêu cầu này không?";
            string title = "Xác nhận";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                disableBtn();
                ImportDAL.Instance.cancelImport(ImportId);
                loadData();

            }

        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc đã nhận được hàng?";
            string title = "Xác nhận";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                disableBtn();
                ImportDAL.Instance.updateImport(ImportId);
                loadData();

            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void disableBtn()
        {
            tbImportId.Text = "";
            tbStatus.Text = "";
            btnCancle.Enabled = false;
            btnReceived.Enabled = false;
        }
    }
}
