namespace DoAn
{
    partial class frmHoaDonXuat
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgridVHDX = new System.Windows.Forms.DataGridView();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTienHD = new System.Windows.Forms.TextBox();
            this.txtTongThue = new System.Windows.Forms.TextBox();
            this.txtTongTienThuoc = new System.Windows.Forms.TextBox();
            this.txtMaHDX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIDBenhNhan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVHDX)).BeginInit();
            this.grbCTHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(634, 471);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(137, 37);
            this.btnTim.TabIndex = 43;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(321, 474);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(265, 32);
            this.txtTimKiem.TabIndex = 42;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
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
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(634, 88);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 37);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Danh sách hóa đơn xuất";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtgridVHDX
            // 
            this.dtgridVHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVHDX.Location = new System.Drawing.Point(3, 539);
            this.dtgridVHDX.Name = "dtgridVHDX";
            this.dtgridVHDX.RowHeadersWidth = 51;
            this.dtgridVHDX.RowTemplate.Height = 24;
            this.dtgridVHDX.Size = new System.Drawing.Size(777, 206);
            this.dtgridVHDX.TabIndex = 35;
            this.dtgridVHDX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVHDX_CellClick);
            // 
            // grbCTHD
            // 
            this.grbCTHD.Controls.Add(this.cbIDBenhNhan);
            this.grbCTHD.Controls.Add(this.dtpNgayLap);
            this.grbCTHD.Controls.Add(this.label9);
            this.grbCTHD.Controls.Add(this.txtTongTienHD);
            this.grbCTHD.Controls.Add(this.txtTongThue);
            this.grbCTHD.Controls.Add(this.txtTongTienThuoc);
            this.grbCTHD.Controls.Add(this.txtMaHDX);
            this.grbCTHD.Controls.Add(this.label8);
            this.grbCTHD.Controls.Add(this.label7);
            this.grbCTHD.Controls.Add(this.label6);
            this.grbCTHD.Controls.Add(this.label5);
            this.grbCTHD.Controls.Add(this.label3);
            this.grbCTHD.Location = new System.Drawing.Point(47, 72);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(565, 369);
            this.grbCTHD.TabIndex = 34;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Thông tin hóa đơn xuất";
            this.grbCTHD.Enter += new System.EventHandler(this.grbCTHD_Enter);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(217, 277);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(322, 32);
            this.dtpNgayLap.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ngày lập:";
            // 
            // txtTongTienHD
            // 
            this.txtTongTienHD.Location = new System.Drawing.Point(217, 224);
            this.txtTongTienHD.Name = "txtTongTienHD";
            this.txtTongTienHD.Size = new System.Drawing.Size(322, 32);
            this.txtTongTienHD.TabIndex = 13;
            // 
            // txtTongThue
            // 
            this.txtTongThue.Location = new System.Drawing.Point(217, 176);
            this.txtTongThue.Name = "txtTongThue";
            this.txtTongThue.Size = new System.Drawing.Size(322, 32);
            this.txtTongThue.TabIndex = 12;
            // 
            // txtTongTienThuoc
            // 
            this.txtTongTienThuoc.Location = new System.Drawing.Point(217, 128);
            this.txtTongTienThuoc.Name = "txtTongTienThuoc";
            this.txtTongTienThuoc.Size = new System.Drawing.Size(322, 32);
            this.txtTongTienThuoc.TabIndex = 11;
            // 
            // txtMaHDX
            // 
            this.txtMaHDX.Location = new System.Drawing.Point(217, 37);
            this.txtMaHDX.Name = "txtMaHDX";
            this.txtMaHDX.Size = new System.Drawing.Size(322, 32);
            this.txtMaHDX.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tổng tiền HD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tổng thuế";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tổng tiền thuốc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID bệnh nhân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HDX:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 48);
            this.label1.TabIndex = 33;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN XUẤT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbIDBenhNhan
            // 
            this.cbIDBenhNhan.FormattingEnabled = true;
            this.cbIDBenhNhan.Location = new System.Drawing.Point(217, 79);
            this.cbIDBenhNhan.Name = "cbIDBenhNhan";
            this.cbIDBenhNhan.Size = new System.Drawing.Size(322, 32);
            this.cbIDBenhNhan.TabIndex = 16;
            // 
            // frmHoaDonXuat
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
            this.Controls.Add(this.dtgridVHDX);
            this.Controls.Add(this.grbCTHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmHoaDonXuat";
            this.Text = "Hóa đơn xuất";
            this.Load += new System.EventHandler(this.frmHoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVHDX)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgridVHDX;
        private System.Windows.Forms.GroupBox grbCTHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongTienHD;
        private System.Windows.Forms.TextBox txtTongThue;
        private System.Windows.Forms.TextBox txtTongTienThuoc;
        private System.Windows.Forms.TextBox txtMaHDX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cbIDBenhNhan;
    }
}