namespace DoAn
{
    partial class frmNhomThuoc
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
            this.dtgridVNhomThuoc = new System.Windows.Forms.DataGridView();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaNhomThuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVNhomThuoc)).BeginInit();
            this.grbCTHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(633, 374);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(137, 37);
            this.btnTim.TabIndex = 32;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(306, 377);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(279, 32);
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
            this.label2.Location = new System.Drawing.Point(59, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Danh sách nhóm thuốc";
            // 
            // dtgridVNhomThuoc
            // 
            this.dtgridVNhomThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVNhomThuoc.Location = new System.Drawing.Point(3, 439);
            this.dtgridVNhomThuoc.Name = "dtgridVNhomThuoc";
            this.dtgridVNhomThuoc.RowHeadersWidth = 51;
            this.dtgridVNhomThuoc.RowTemplate.Height = 24;
            this.dtgridVNhomThuoc.Size = new System.Drawing.Size(777, 309);
            this.dtgridVNhomThuoc.TabIndex = 24;
            this.dtgridVNhomThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVNhomThuoc_CellClick);
            // 
            // grbCTHD
            // 
            this.grbCTHD.Controls.Add(this.txtTenNhom);
            this.grbCTHD.Controls.Add(this.txtGhiChu);
            this.grbCTHD.Controls.Add(this.txtMaNhomThuoc);
            this.grbCTHD.Controls.Add(this.label6);
            this.grbCTHD.Controls.Add(this.label5);
            this.grbCTHD.Controls.Add(this.label3);
            this.grbCTHD.Location = new System.Drawing.Point(46, 68);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(565, 277);
            this.grbCTHD.TabIndex = 23;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Thông tin nhóm thuốc";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(215, 83);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(324, 32);
            this.txtTenNhom.TabIndex = 11;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(215, 128);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(324, 32);
            this.txtGhiChu.TabIndex = 11;
            // 
            // txtMaNhomThuoc
            // 
            this.txtMaNhomThuoc.Location = new System.Drawing.Point(215, 37);
            this.txtMaNhomThuoc.Name = "txtMaNhomThuoc";
            this.txtMaNhomThuoc.Size = new System.Drawing.Size(324, 32);
            this.txtMaNhomThuoc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên nhóm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhóm thuốc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "QUẢN LÝ NHÓM THUỐC";
            // 
            // frmNhomThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgridVNhomThuoc);
            this.Controls.Add(this.grbCTHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmNhomThuoc";
            this.Text = "Nhóm thuốc";
            this.Load += new System.EventHandler(this.frmNhomThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVNhomThuoc)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgridVNhomThuoc;
        private System.Windows.Forms.GroupBox grbCTHD;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaNhomThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}