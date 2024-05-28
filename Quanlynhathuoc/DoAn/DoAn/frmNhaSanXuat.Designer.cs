namespace DoAn
{
    partial class frmNhaSanXuat
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
            this.dtgridVNSX = new System.Windows.Forms.DataGridView();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenNSX = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaNSX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVNSX)).BeginInit();
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
            this.txtTimKiem.Location = new System.Drawing.Point(328, 377);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(257, 32);
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
            this.label2.Size = new System.Drawing.Size(251, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Danh sách nhà sản xuất";
            // 
            // dtgridVNSX
            // 
            this.dtgridVNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVNSX.Location = new System.Drawing.Point(3, 439);
            this.dtgridVNSX.Name = "dtgridVNSX";
            this.dtgridVNSX.RowHeadersWidth = 51;
            this.dtgridVNSX.RowTemplate.Height = 24;
            this.dtgridVNSX.Size = new System.Drawing.Size(777, 309);
            this.dtgridVNSX.TabIndex = 24;
            this.dtgridVNSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVNSX_CellClick);
            // 
            // grbCTHD
            // 
            this.grbCTHD.Controls.Add(this.txtEmail);
            this.grbCTHD.Controls.Add(this.txtDienThoai);
            this.grbCTHD.Controls.Add(this.txtTenNSX);
            this.grbCTHD.Controls.Add(this.txtDiaChi);
            this.grbCTHD.Controls.Add(this.txtMaNSX);
            this.grbCTHD.Controls.Add(this.label8);
            this.grbCTHD.Controls.Add(this.label7);
            this.grbCTHD.Controls.Add(this.label6);
            this.grbCTHD.Controls.Add(this.label5);
            this.grbCTHD.Controls.Add(this.label3);
            this.grbCTHD.Location = new System.Drawing.Point(46, 68);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(565, 277);
            this.grbCTHD.TabIndex = 23;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Thông tin nhà sản xuất";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 32);
            this.txtEmail.TabIndex = 13;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(195, 176);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(344, 32);
            this.txtDienThoai.TabIndex = 12;
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.Location = new System.Drawing.Point(195, 83);
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Size = new System.Drawing.Size(344, 32);
            this.txtTenNSX.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(195, 128);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(344, 32);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtMaNSX
            // 
            this.txtMaNSX.Location = new System.Drawing.Point(195, 37);
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Size = new System.Drawing.Size(344, 32);
            this.txtMaNSX.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên NSX:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NSX:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "QUẢN LÝ NHÀ SẢN XUẤT";
            // 
            // frmNhaSanXuat
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
            this.Controls.Add(this.dtgridVNSX);
            this.Controls.Add(this.grbCTHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmNhaSanXuat";
            this.Text = "Nhà sản xuất";
            this.Load += new System.EventHandler(this.frmNhaSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVNSX)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgridVNSX;
        private System.Windows.Forms.GroupBox grbCTHD;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenNSX;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaNSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}