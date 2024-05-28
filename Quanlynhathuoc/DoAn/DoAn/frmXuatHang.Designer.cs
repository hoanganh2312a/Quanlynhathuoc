namespace DoAn
{
    partial class frmXuatHang
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dtgridVHoaDonXuat = new System.Windows.Forms.DataGridView();
            this.cbBenhNhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgridVDanhSachThuoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVHoaDonXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVDanhSachThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(647, 79);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 33);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(519, 79);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(113, 33);
            this.btnXacNhan.TabIndex = 24;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dtgridVHoaDonXuat
            // 
            this.dtgridVHoaDonXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVHoaDonXuat.Location = new System.Drawing.Point(2, 531);
            this.dtgridVHoaDonXuat.Name = "dtgridVHoaDonXuat";
            this.dtgridVHoaDonXuat.RowHeadersWidth = 51;
            this.dtgridVHoaDonXuat.RowTemplate.Height = 24;
            this.dtgridVHoaDonXuat.Size = new System.Drawing.Size(779, 214);
            this.dtgridVHoaDonXuat.TabIndex = 19;
            // 
            // cbBenhNhan
            // 
            this.cbBenhNhan.FormattingEnabled = true;
            this.cbBenhNhan.Location = new System.Drawing.Point(198, 493);
            this.cbBenhNhan.Name = "cbBenhNhan";
            this.cbBenhNhan.Size = new System.Drawing.Size(226, 32);
            this.cbBenhNhan.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bệnh Nhân:";
            // 
            // dtgridVDanhSachThuoc
            // 
            this.dtgridVDanhSachThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVDanhSachThuoc.Location = new System.Drawing.Point(2, 130);
            this.dtgridVDanhSachThuoc.Name = "dtgridVDanhSachThuoc";
            this.dtgridVDanhSachThuoc.RowHeadersWidth = 51;
            this.dtgridVDanhSachThuoc.RowTemplate.Height = 24;
            this.dtgridVDanhSachThuoc.Size = new System.Drawing.Size(779, 341);
            this.dtgridVDanhSachThuoc.TabIndex = 16;
            this.dtgridVDanhSachThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVDanhSachThuoc_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 15;
            this.label1.Text = "XUẤT HÀNG";
            // 
            // frmXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dtgridVHoaDonXuat);
            this.Controls.Add(this.cbBenhNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgridVDanhSachThuoc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmXuatHang";
            this.Text = "Xuất hàng";
            this.Load += new System.EventHandler(this.frmXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVHoaDonXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVDanhSachThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dtgridVHoaDonXuat;
        private System.Windows.Forms.ComboBox cbBenhNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgridVDanhSachThuoc;
        private System.Windows.Forms.Label label1;
    }
}