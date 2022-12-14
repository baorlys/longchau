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
namespace GUI
{
    public partial class Admin : Form
    {
        private static Admin instance;
        private User userLogin;
        private int transId;
        public User UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; }
        }

        public int TransId { get => transId; set => transId = value; }
        public static Admin Instance
        {
            get { if (instance == null) instance = new Admin(); return instance; }
            set { Admin.instance = value; }
        }
        private Admin() { }
        public Admin(User userLogin)
        {
            InitializeComponent();
            adminToolStripMenuItem.Text += " (" + userLogin.Name + ")";
            this.UserLogin = userLogin;
            cbState.SelectedIndex = 0;
            loadDTP();
            loadMedicine();
            loadTrans(null, 0);
            loadRevenue(dtpFrom.Value, dtpTo.Value);
        }

        #region Method
        public void loadMedicine()
        {
            if(tbSearch.Text == null)
            {
                dgvMedicine.DataSource = MedicineDAL.Instance.loadMedicine();
            }
            dgvMedicine.DataSource = MedicineDAL.Instance.loadMedicineByNameToDt(tbSearch.Text);
        }

        void loadRevenue(DateTime from, DateTime to)
        {
            dgvRevenue.DataSource = RevenueDAL.Instance.loadRevenueToDt(from,to);
            RevenueDAL revDAL = RevenueDAL.Instance;
            List<Revenue> listRev = revDAL.loadRevenue(from, to);
            tbCountTrans.Text = revDAL.countNumberTrans(listRev).ToString();
            CultureInfo ci = new CultureInfo("vi-VN");
            tbTotalPriceRevenue.Text = revDAL.getTotalPriceRev(listRev).ToString("c",ci);
        }

        void loadTrans(string? date, int state)
        {
            flpTrans.Controls.Clear();
            List<Transaction> listTrans = TransactionDAL.Instance.loadTransList(date, state);
            foreach(Transaction trans in listTrans) {
                Button btnTrans = new Button() { Width = TransactionDAL.TransWidth, Height = TransactionDAL.TransHeight};
                btnTrans.Click += btnTrans_Click;
                btnTrans.Tag = trans;
                string stateStr = "";
                switch (trans.State)
                {
                    case 0:
                        btnTrans.BackColor = Color.Yellow;
                        stateStr = "Chưa giao";
                        break;
                    case 1:
                        btnTrans.BackColor = Color.Green;
                        stateStr = "Đã giao";
                        break;
                    case 2:
                        btnTrans.BackColor = Color.Gray;
                        stateStr = "Đã huỷ";
                        break;
                }
                btnTrans.Text = "HD" + trans.TransId + Environment.NewLine + stateStr; 

                flpTrans.Controls.Add(btnTrans);
            }
        }

        void showTransDetail(int transId, string brandName)
        {
            lvTrans.Items.Clear();
            List<TransactionDetail> transDetailList = TransactionDetailDAL.Instance.loadTransDetail(transId);
            float totalPrice = 0;
            foreach (TransactionDetail item in transDetailList) {
                ListViewItem lvItem = new ListViewItem(item.MdcId.ToString());
                lvItem.SubItems.Add(item.Name.ToString());
                lvItem.SubItems.Add(item.Quantity.ToString());
                totalPrice += item.Price * item.Quantity;
                lvTrans.Items.Add(lvItem);
            }
            int shipCost = 30000;
            tbBrand.Text = brandName;
            CultureInfo ci = new CultureInfo("vi-VN");
            tbShipCost.Text = shipCost.ToString("c", ci);
            totalPrice += shipCost;
            tbTotalPrice.Text = totalPrice.ToString("c", ci);

        }

        void loadDTP()
        {
            DateTime today = DateTime.Now;
            dtpTrans.Value = today;
            dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1);
        }
        #endregion

        #region Events
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
        }
        private void btnGetTrans_Click(object sender, EventArgs e)
        {
            string? date = dtpTrans.Value.ToShortDateString();
            flpTrans.Controls.Clear();
            if (cbWithOutDate.Checked) date = null;
            loadTrans(date, cbState.SelectedIndex);
        }

        void btnTrans_Click(object sender, EventArgs e)
        {
            int transId = ((sender as Button).Tag as Transaction).TransId;
            string brandName = ((sender as Button).Tag as Transaction).BrandName;
            TransId = transId;
            showTransDetail(transId, brandName);
        }

        #endregion

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            loadRevenue(dtpFrom.Value, dtpTo.Value);
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(userLogin);
            userInfo.ShowDialog();
        }



        private void btnConfirmTrans_Click(object sender, EventArgs e)
        {
            TransactionDAL.Instance.confirmTrans(TransId, 1);
            lvTrans.Items.Clear();
            loadTrans(null, 0);
        }

        private void btnDelTrans_Click(object sender, EventArgs e)
        {
            TransactionDAL.Instance.confirmTrans(TransId, 2);
            lvTrans.Items.Clear();
            loadTrans(null, 0);
        }

        private void txbFind_TextChanged(object sender, EventArgs e)
        {
            loadMedicine();
        }



        private void dgvMedicine_SelectionChanged(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("vi-VN");
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return; //Or clear your TextBoxes
            tbIdMed.Text = dgvMedicine.CurrentRow.Cells[0].Value.ToString();
            tbNameMed.Text = dgvMedicine.CurrentRow.Cells[1].Value.ToString();
            int price = (int)dgvMedicine.CurrentRow.Cells[8].Value;
            tbPriceMed.Text = price.ToString("c",ci);
            tbQuantityMed.Text = dgvMedicine.CurrentRow.Cells[9].Value.ToString();
            dtpDateExpireMed.Value = Convert.ToDateTime(dgvMedicine.CurrentRow.Cells[5].Value.ToString());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                dgvMedicine.DataSource = MedicineDAL.Instance.loadMedicineByNameToDt(tbSearch.Text);
                return;
            }
            if (checkAboutExpire.Checked)
            {
                dgvMedicine.DataSource = MedicineDAL.Instance.getMdcAboutToExpire((int)nudCheckQuantity.Value);
                return;
            }
            dgvMedicine.DataSource = MedicineDAL.Instance.loadMedicineByNameToDt(tbSearch.Text);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportMed importMed = new ImportMed(tbIdMed.Text);
            importMed.ShowDialog();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Thống kê doanh thu";
            for (int i = 1; i < dgvRevenue.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvRevenue.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvRevenue.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvRevenue.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvRevenue.Rows[i].Cells[j].Value.ToString();
                }
            }
            string filename = dtpFrom.Value.ToString("MM-dd-yyyy") + "_" + dtpTo.Value.ToString("MM-dd-yyyy") + ".xls";
            // save the application  
            workbook.SaveAs("C:\\Users\\Techzones\\Documents\\Workplace\\IT\\Software Technology\\final_longchau\\Excel_report\\" + filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
    }
}
