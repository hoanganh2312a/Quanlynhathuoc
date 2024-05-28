namespace DoAn
{
    partial class frmChiTietHoaDonXuat
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
            this.dtgridVCTHDX = new System.Windows.Forms.DataGridView();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtMaHDX = new System.Windows.Forms.TextBox();
            this.txtIDThuoc = new System.Windows.Forms.TextBox();
            this.txtMaCTHDX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVCTHDX)).BeginInit();
            this.grbCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(633, 467);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(137, 37);
            this.btnTim.TabIndex = 32;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(396, 470);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(189, 32);
            this.txtTimKiem.TabIndex = 31;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(633, 300);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 37);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(633, 248);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(137, 37);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(633, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 37);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(633, 142);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 37);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(633, 84);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 37);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Danh sách chi tiết hóa đơn Xuất";
            // 
            // dtgridVCTHDX
            // 
            this.dtgridVCTHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVCTHDX.Location = new System.Drawing.Point(2, 535);
            this.dtgridVCTHDX.Name = "dtgridVCTHDX";
            this.dtgridVCTHDX.RowHeadersWidth = 51;
            this.dtgridVCTHDX.RowTemplate.Height = 24;
            this.dtgridVCTHDX.Size = new System.Drawing.Size(777, 206);
            this.dtgridVCTHDX.TabIndex = 24;
            this.dtgridVCTHDX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVCTHDX_CellClick);
            // 
            // grbCTHD
            // 
            this.grbCTHD.Controls.Add(this.numericUpDown1);
            this.grbCTHD.Controls.Add(this.txtDonVi);
            this.grbCTHD.Controls.Add(this.txtThue);
            this.grbCTHD.Controls.Add(this.label4);
            this.grbCTHD.Controls.Add(this.label9);
            this.grbCTHD.Controls.Add(this.txtGiaBan);
            this.grbCTHD.Controls.Add(this.txtMaHDX);
            this.grbCTHD.Controls.Add(this.txtIDThuoc);
            this.grbCTHD.Controls.Add(this.txtMaCTHDX);
            this.grbCTHD.Controls.Add(this.label8);
            this.grbCTHD.Controls.Add(this.label7);
            this.grbCTHD.Controls.Add(this.label6);
            this.grbCTHD.Controls.Add(this.label5);
            this.grbCTHD.Controls.Add(this.label3);
            this.grbCTHD.Location = new System.Drawing.Point(46, 68);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(565, 369);
            this.grbCTHD.TabIndex = 23;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Thông tin chi tiết hóa đơn xuất";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(195, 176);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 18;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(195, 323);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(344, 32);
            this.txtDonVi.TabIndex = 17;
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(195, 275);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(344, 32);
            this.txtThue.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đơn vị:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Thuế:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(195, 224);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(344, 32);
            this.txtGiaBan.TabIndex = 13;
            // 
            // txtMaHDX
            // 
            this.txtMaHDX.Location = new System.Drawing.Point(195, 83);
            this.txtMaHDX.Name = "txtMaHDX";
            this.txtMaHDX.Size = new System.Drawing.Size(344, 32);
            this.txtMaHDX.TabIndex = 11;
            // 
            // txtIDThuoc
            // 
            this.txtIDThuoc.Location = new System.Drawing.Point(195, 128);
            this.txtIDThuoc.Name = "txtIDThuoc";
            this.txtIDThuoc.Size = new System.Drawing.Size(344, 32);
            this.txtIDThuoc.TabIndex = 11;
            // 
            // txtMaCTHDX
            // 
            this.txtMaCTHDX.Location = new System.Drawing.Point(195, 37);
            this.txtMaCTHDX.Name = "txtMaCTHDX";
            this.txtMaCTHDX.Size = new System.Drawing.Size(344, 32);
            this.txtMaCTHDX.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Giá bán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID Thuốc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã HDX:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã CTHDX:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "QUẢN LÝ CHI TIẾT HÓA ĐƠN XUẤT";
            // 
            // frmChiTietHoaDonXuat
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
            this.Name = "frmChiTietHoaDonXuat";
            this.Text = "Chi tiết hóa đơn xuất";
            this.Load += new System.EventHandler(this.frmChiTietHoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVCTHDX)).EndInit();
            this.grbCTHD.ResumeLayout(false);
            this.grbCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaHDX;
        private System.Windows.Forms.TextBox txtIDThuoc;
        private System.Windows.Forms.TextBox txtMaCTHDX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtGiaBan;
    }
}