namespace GUI
{
    partial class ListImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.lvImports = new System.Windows.Forms.ListView();
            this.col1 = new System.Windows.Forms.ColumnHeader();
            this.col2 = new System.Windows.Forms.ColumnHeader();
            this.col3 = new System.Windows.Forms.ColumnHeader();
            this.col4 = new System.Windows.Forms.ColumnHeader();
            this.col5 = new System.Windows.Forms.ColumnHeader();
            this.col6 = new System.Windows.Forms.ColumnHeader();
            this.col7 = new System.Windows.Forms.ColumnHeader();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnReceived = new System.Windows.Forms.Button();
            this.tbImportId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(43, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvImports
            // 
            this.lvImports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7});
            this.lvImports.FullRowSelect = true;
            this.lvImports.Location = new System.Drawing.Point(43, 66);
            this.lvImports.Name = "lvImports";
            this.lvImports.Size = new System.Drawing.Size(692, 348);
            this.lvImports.TabIndex = 5;
            this.lvImports.UseCompatibleStateImageBehavior = false;
            this.lvImports.View = System.Windows.Forms.View.Details;
            this.lvImports.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvImports_MouseClick);
            // 
            // col1
            // 
            this.col1.Text = "STT";
            this.col1.Width = 30;
            // 
            // col2
            // 
            this.col2.Text = "Mã nhập";
            this.col2.Width = 100;
            // 
            // col3
            // 
            this.col3.Text = "Ngày nhập";
            this.col3.Width = 150;
            // 
            // col4
            // 
            this.col4.Text = "Mã thuốc";
            this.col4.Width = 100;
            // 
            // col5
            // 
            this.col5.Text = "Số lượng";
            this.col5.Width = 80;
            // 
            // col6
            // 
            this.col6.Text = "Ngày hết hạn";
            this.col6.Width = 150;
            // 
            // col7
            // 
            this.col7.Text = "Trạng thái";
            this.col7.Width = 75;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Chờ duyệt",
            "Đã duyệt",
            "Đã nhận",
            "Tất cả"});
            this.cbStatus.Location = new System.Drawing.Point(614, 26);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 23);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tbStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnReceived);
            this.panel1.Controls.Add(this.tbImportId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(817, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 119);
            this.panel1.TabIndex = 9;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(63, 49);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(148, 23);
            this.tbStatus.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trạng thái";
            // 
            // btnCancle
            // 
            this.btnCancle.Enabled = false;
            this.btnCancle.Location = new System.Drawing.Point(63, 78);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(67, 23);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "Huỷ";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnReceived
            // 
            this.btnReceived.Enabled = false;
            this.btnReceived.Location = new System.Drawing.Point(149, 78);
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.Size = new System.Drawing.Size(62, 23);
            this.btnReceived.TabIndex = 10;
            this.btnReceived.Text = "Đã nhận";
            this.btnReceived.UseVisualStyleBackColor = true;
            this.btnReceived.Click += new System.EventHandler(this.btnReceived_Click);
            // 
            // tbImportId
            // 
            this.tbImportId.Location = new System.Drawing.Point(63, 9);
            this.tbImportId.Name = "tbImportId";
            this.tbImportId.Size = new System.Drawing.Size(148, 23);
            this.tbImportId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(908, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Xác nhận ";
            // 
            // ListImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvImports);
            this.Name = "ListImport";
            this.Text = "ListImport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private ListView lvImports;
        private ColumnHeader col1;
        private ColumnHeader col2;
        private ColumnHeader col3;
        private ColumnHeader col4;
        private ColumnHeader col5;
        private ColumnHeader col6;
        private ColumnHeader col7;
        private ComboBox cbStatus;
        private Label label1;
        private Panel panel1;
        private Button btnCancle;
        private Button btnReceived;
        private TextBox tbImportId;
        private Label label2;
        private TextBox tbStatus;
        private Label label3;
    }
}