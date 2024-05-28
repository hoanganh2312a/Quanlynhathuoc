namespace DoAn
{
    partial class frmHoaDonNhap
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgridVCTHDX = new System.Windows.Forms.DataGridView();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.cbMaNPP = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayViet = new System.Windows.Forms.DateTimePicker();
            this.txtTongTienHD = new System.Windows.Forms.TextBox();
            this.txtTongThue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTongTienThuoc = new System.Windows.Forms.TextBox();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtNguoiGiao = new System.Windows.Forms.TextBox();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVCTHDX)).BeginInit();
            this.grbCTHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(632, 387);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(137, 37);
            this.btnTim.TabIndex = 43;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(340, 390);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(256, 32);
            this.txtTimKiem.TabIndex = 42;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(634, 304);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 37);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(634, 252);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(137, 37);
            this.btnLamMoi.TabIndex = 40;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(634, 204);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 37);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(634, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 37);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Danh sách hóa đơn nhập";
            // 
            // dtgridVCTHDX
            // 
            this.dtgridVCTHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVCTHDX.Location = new System.Drawing.Point(1, 455);
            this.dtgridVCTHDX.Name = "dtgridVCTHDX";
            this.dtgridVCTHDX.RowHeadersWidth = 51;
            this.dtgridVCTHDX.RowTemplate.Height = 24;
            this.dtgridVCTHDX.Size = new System.Drawing.Size(777, 286);
            this.dtgridVCTHDX.TabIndex = 35;
            this.dtgridVCTHDX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVCTHDX_CellClick);
            // 
            // grbCTHD
            // 
            this.grbCTHD.Controls.Add(this.cbMaNPP);
            this.grbCTHD.Controls.Add(this.dtpNgayNhap);
            this.grbCTHD.Controls.Add(this.dtpNgayViet);
            this.grbCTHD.Controls.Add(this.txtTongTienHD);
            this.grbCTHD.Controls.Add(this.txtTongThue);
            this.grbCTHD.Controls.Add(this.label9);
            this.grbCTHD.Controls.Add(this.label10);
            this.grbCTHD.Controls.Add(this.label11);
            this.grbCTHD.Controls.Add(this.label12);
            this.grbCTHD.Controls.Add(this.txtTongTienThuoc);
            this.grbCTHD.Controls.Add(this.txtNguoiNhan);
            this.grbCTHD.Controls.Add(this.txtNguoiGiao);
            this.grbCTHD.Controls.Add(this.txtMaHDN);
            this.grbCTHD.Controls.Add(this.label8);
            this.grbCTHD.Controls.Add(this.label7);
            this.grbCTHD.Controls.Add(this.label6);
            this.grbCTHD.Controls.Add(this.label5);
            this.grbCTHD.Controls.Add(this.label3);
            this.grbCTHD.Location = new System.Drawing.Point(47, 72);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(565, 291);
            this.grbCTHD.TabIndex = 34;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Thông tin hóa đơn nhập";
            this.grbCTHD.Enter += new System.EventHandler(this.grbCTHD_Enter);
            // 
            // cbMaNPP
            // 
            this.cbMaNPP.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNPP.FormattingEnabled = true;
            this.cbMaNPP.Location = new System.Drawing.Point(115, 93);
            this.cbMaNPP.Name = "cbMaNPP";
            this.cbMaNPP.Size = new System.Drawing.Size(158, 24);
            this.cbMaNPP.TabIndex = 23;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(391, 181);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(158, 23);
            this.dtpNgayNhap.TabIndex = 22;
            // 
            // dtpNgayViet
            // 
            this.dtpNgayViet.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayViet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayViet.Location = new System.Drawing.Point(391, 140);
            this.dtpNgayViet.Name = "dtpNgayViet";
            this.dtpNgayViet.Size = new System.Drawing.Size(158, 23);
            this.dtpNgayViet.TabIndex = 21;
            // 
            // txtTongTienHD
            // 
            this.txtTongTienHD.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienHD.Location = new System.Drawing.Point(391, 90);
            this.txtTongTienHD.Name = "txtTongTienHD";
            this.txtTongTienHD.Size = new System.Drawing.Size(158, 23);
            this.txtTongTienHD.TabIndex = 20;
            // 
            // txtTongThue
            // 
            this.txtTongThue.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThue.Location = new System.Drawing.Point(391, 44);
            this.txtTongThue.Name = "txtTongThue";
            this.txtTongThue.Size = new System.Drawing.Size(158, 23);
            this.txtTongThue.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(290, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày nhập:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày Viết:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(290, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tổng tiền HD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(290, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tổng thuế:";
            // 
            // txtTongTienThuoc
            // 
            this.txtTongTienThuoc.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienThuoc.Location = new System.Drawing.Point(133, 235);
            this.txtTongTienThuoc.Name = "txtTongTienThuoc";
            this.txtTongTienThuoc.Size = new System.Drawing.Size(416, 23);
            this.txtTongTienThuoc.TabIndex = 13;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiNhan.Location = new System.Drawing.Point(115, 187);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(158, 23);
            this.txtNguoiNhan.TabIndex = 12;
            // 
            // txtNguoiGiao
            // 
            this.txtNguoiGiao.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiGiao.Location = new System.Drawing.Point(115, 139);
            this.txtNguoiGiao.Name = "txtNguoiGiao";
            this.txtNguoiGiao.Size = new System.Drawing.Size(158, 23);
            this.txtNguoiGiao.TabIndex = 11;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDN.Location = new System.Drawing.Point(115, 48);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(158, 23);
            this.txtMaHDN.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tổng tiền thuốc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Người Nhận:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Người Giao:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã NPP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HDN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 48);
            this.label1.TabIndex = 33;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN NHẬP";
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(634, 88);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 37);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgridVCTHDX);
            this.Controls.Add(this.grbCTHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmHoaDonNhap";
            this.Text = "Hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVCTHDX)).EndInit();
            this.grbCTHD.ResumeLayout(false);
            this.grbCTHD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgridVCTHDX;
        private System.Windows.Forms.GroupBox grbCTHD;
        private System.Windows.Forms.TextBox txtTongTienThuoc;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.TextBox txtNguoiGiao;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTienHD;
        private System.Windows.Forms.TextBox txtTongThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayViet;
        private System.Windows.Forms.ComboBox cbMaNPP;
    }
}