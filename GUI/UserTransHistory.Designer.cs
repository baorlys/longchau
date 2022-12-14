namespace GUI
{
    partial class UserTransHistory
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
            this.lvTrans = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTrans
            // 
            this.lvTrans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTrans.FullRowSelect = true;
            this.lvTrans.Location = new System.Drawing.Point(12, 56);
            this.lvTrans.Name = "lvTrans";
            this.lvTrans.Size = new System.Drawing.Size(461, 382);
            this.lvTrans.TabIndex = 0;
            this.lvTrans.UseCompatibleStateImageBehavior = false;
            this.lvTrans.View = System.Windows.Forms.View.Details;
            this.lvTrans.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTrans_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã hoá đơn";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày tạo";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tổng tiền";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng thái";
            this.columnHeader4.Width = 100;
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Chưa giao",
            "Đang giao",
            "Bị huỷ",
            "Tất cả"});
            this.cbState.Location = new System.Drawing.Point(352, 12);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(121, 23);
            this.cbState.TabIndex = 1;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserTransHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.lvTrans);
            this.Name = "UserTransHistory";
            this.Text = "UserTransHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvTrans;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox cbState;
        private Button btnBack;
    }
}