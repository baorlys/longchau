using DAL;
using DTO;
using Microsoft.Office.Interop.Excel;
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
using Button = System.Windows.Forms.Button;

namespace GUI
{
    public partial class Admin : Form
    {
        private static Admin instance;
        private User userLogin;
        private int transId;
        public CultureInfo ci = new CultureInfo("vi-VN");
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
            dgvMedicine.DataSource = MedicineDAL.Instance.loadMedicineByNameToDt(tbSearch.Text);
        }

        void loadRevenue(DateTime from, DateTime to)
        {
            lvRevenue.Items.Clear();
            List<Transaction> list = RevenueDAL.Instance.loadRevenue(from, to);
            int i = 1;
            int totalPrice = 0;
            foreach (Transaction item in list)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.SubItems.Add(item.TransId.ToString());
                lvItem.SubItems.Add(item.TransDate.ToString("dd/MM/yyyy hh:mm:ss tt"));
                lvItem.SubItems.Add(item.Name);
                lvItem.SubItems.Add(item.TotalPrice.ToString("c", ci));
                lvItem.SubItems.Add(item.BrandName);
                int state = item.State;
                switch (state)
                {
                    case 0:
                        lvItem.SubItems.Add("Chưa duyệt");
                        break;
                    case 1:
                        lvItem.SubItems.Add("Đã duyệt");
                        break;
                    case 2:
                        lvItem.SubItems.Add("Đã huỷ");
                        break;
                }
                totalPrice += item.TotalPrice;
                lvRevenue.Items.Add(lvItem);
                i++;
            }
            tbCountTrans.Text = (i - 1).ToString();
            tbTotalPriceRevenue.Text = totalPrice.ToString("c", ci);

        }

        void loadTrans(string? date, int state)
        {
            flpTrans.Controls.Clear();
            List<Transaction> listTrans = TransactionDAL.Instance.loadTransList(date, state);
            foreach (Transaction trans in listTrans)
            {
                Button btnTrans = new Button() { Width = TransactionDAL.TransWidth, Height = TransactionDAL.TransHeight };
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
            foreach (TransactionDetail item in transDetailList)
            {
                ListViewItem lvItem = new ListViewItem(item.MdcId.ToString());
                lvItem.SubItems.Add(item.Name.ToString());
                lvItem.SubItems.Add(item.Quantity.ToString());
                totalPrice += item.Price * item.Quantity;
                lvTrans.Items.Add(lvItem);
            }
            int shipCost = 30000;
            tbBrand.Text = brandName;
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
            tbPriceMed.Text = price.ToString("c", ci);
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
            string filename = dtpFrom.Value.ToString("dd-MM-yyyy") + "_" + dtpTo.Value.ToString("dd-MM-yyyy");
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true, FileName = filename })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Rows.AutoFit();
                    for (int j = 1; j <= lvRevenue.Columns.Count; j++)
                    {
                        ws.Columns.ColumnWidth = lvRevenue.Columns[j-1].Width;
                        ws.Cells[1, j] = lvRevenue.Columns[j - 1].Text;
                    }
                    int i = 2;
                    foreach (ListViewItem item in lvRevenue.Items)
                    {
                        for (int k = 1; k <= item.SubItems.Count; k++)
                        {
                            ws.Cells[i, k] = item.SubItems[k - 1].Text;
                        }
                        i++;
                    }
                    int m = lvRevenue.Columns.Count - 3;
                    ws.Cells[i, m] = "Tổng tiền";
                    ws.Cells[i, m].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                    ws.Cells[i, m + 1] = tbTotalPriceRevenue.Text;
                    ws.Cells[i, m + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                    ws.Cells[i, m + 2] = "Số hoá đơn";
                    ws.Cells[i, m + 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                    ws.Cells[i, m + 3] = tbCountTrans.Text;
                    ws.Cells[i, m + 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                    ws.Columns.AutoFit();

                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Xuất file thành công.");
                }
            }
        }

        private void yêuCầuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListImport listImport = new ListImport();
            listImport.ShowDialog();
        }
    }
}
