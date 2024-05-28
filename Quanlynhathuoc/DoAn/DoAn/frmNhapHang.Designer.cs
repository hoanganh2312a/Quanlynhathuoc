namespace DoAn
{
    partial class frmNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgridVDanhSachThuoc = new System.Windows.Forms.DataGridView();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgridVHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNguoiGiao = new System.Windows.Forms.TextBox();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVDanhSachThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP HÀNG";
            // 
            // dtgridVDanhSachThuoc
            // 
            this.dtgridVDanhSachThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVDanhSachThuoc.Location = new System.Drawing.Point(2, 141);
            this.dtgridVDanhSachThuoc.Name = "dtgridVDanhSachThuoc";
            this.dtgridVDanhSachThuoc.RowHeadersWidth = 51;
            this.dtgridVDanhSachThuoc.RowTemplate.Height = 24;
            this.dtgridVDanhSachThuoc.Size = new System.Drawing.Size(779, 341);
            this.dtgridVDanhSachThuoc.TabIndex = 1;
            this.dtgridVDanhSachThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVDanhSachThuoc_CellClick);
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(188, 91);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(226, 32);
            this.cbNhaCungCap.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // dtgridVHoaDonNhap
            // 
            this.dtgridVHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVHoaDonNhap.Location = new System.Drawing.Point(2, 542);
            this.dtgridVHoaDonNhap.Name = "dtgridVHoaDonNhap";
            this.dtgridVHoaDonNhap.RowHeadersWidth = 51;
            this.dtgridVHoaDonNhap.RowTemplate.Height = 24;
            this.dtgridVHoaDonNhap.Size = new System.Drawing.Size(779, 214);
            this.dtgridVHoaDonNhap.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Người giao:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Người nhận:";
            // 
            // txtNguoiGiao
            // 
            this.txtNguoiGiao.Location = new System.Drawing.Point(153, 498);
            this.txtNguoiGiao.Name = "txtNguoiGiao";
            this.txtNguoiGiao.Size = new System.Drawing.Size(209, 32);
            this.txtNguoiGiao.TabIndex = 10;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(519, 498);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(209, 32);
            this.txtNguoiNhan.TabIndex = 11;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(519, 90);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(113, 33);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(647, 90);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 33);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtNguoiNhan);
            this.Controls.Add(this.txtNguoiGiao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgridVHoaDonNhap);
            this.Controls.Add(this.cbNhaCungCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgridVDanhSachThuoc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmNhapHang";
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVDanhSachThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVHoaDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgridVDanhSachThuoc;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgridVHoaDonNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNguoiGiao;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
    }
}