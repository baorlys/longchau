namespace GUI
{
    partial class TransDetail
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
            this.colIndex = new System.Windows.Forms.ColumnHeader();
            this.colMdcId = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colQuantity = new System.Windows.Forms.ColumnHeader();
            this.colUnitPrice = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.lvTransDetail = new System.Windows.Forms.ListView();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colIndex
            // 
            this.colIndex.Text = "STT";
            this.colIndex.Width = 30;
            // 
            // colMdcId
            // 
            this.colMdcId.Text = "Mã sản phẩm";
            this.colMdcId.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Tên sản phẩm";
            this.colName.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Số lượng";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Text = "Đơn giá";
            this.colUnitPrice.Width = 80;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Thành tiền";
            this.colPrice.Width = 80;
            // 
            // lvTransDetail
            // 
            this.lvTransDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colMdcId,
            this.colName,
            this.colQuantity,
            this.colUnitPrice,
            this.colPrice});
            this.lvTransDetail.FullRowSelect = true;
            this.lvTransDetail.Location = new System.Drawing.Point(13, 52);
            this.lvTransDetail.Name = "lvTransDetail";
            this.lvTransDetail.Size = new System.Drawing.Size(555, 348);
            this.lvTransDetail.TabIndex = 5;
            this.lvTransDetail.UseCompatibleStateImageBehavior = false;
            this.lvTransDetail.View = System.Windows.Forms.View.Details;
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(417, 457);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(152, 23);
            this.tbTotalPrice.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TransDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 506);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.lvTransDetail);
            this.Name = "TransDetail";
            this.Text = "TransDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColumnHeader colIndex;
        private ColumnHeader colMdcId;
        private ColumnHeader colName;
        private ColumnHeader colQuantity;
        private ColumnHeader colUnitPrice;
        private ColumnHeader colPrice;
        private ListView lvTransDetail;
        private TextBox tbTotalPrice;
        private Button btnBack;
    }
}