namespace DoAn
{
    partial class frmDonViTinh
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
            this.dtgridVDVT = new System.Windows.Forms.DataGridView();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.txtTenDVT = new System.Windows.Forms.TextBox();
            this.txtMaDVT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVDVT)).BeginInit();
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
            this.txtTimKiem.Location = new System.Drawing.Point(309, 377);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(276, 32);
            this.txtTimKiem.TabIndex = 31;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(633, 308);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 37);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(633, 253);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(137, 37);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(633, 196);
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
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Danh sách đơn vị tính";
            // 
            // dtgridVDVT
            // 
            this.dtgridVDVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVDVT.Location = new System.Drawing.Point(3, 439);
            this.dtgridVDVT.Name = "dtgridVDVT";
            this.dtgridVDVT.RowHeadersWidth = 51;
            this.dtgridVDVT.RowTemplate.Height = 24;
            this.dtgridVDVT.Size = new System.Drawing.Size(777, 309);
            this.dtgridVDVT.TabIndex = 24;
            this.dtgridVDVT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVDVT_CellClick);
            // 
            // grbCTHD
            // 
            this.grbCTHD.Controls.Add(this.txtTenDVT);
            this.grbCTHD.Controls.Add(this.txtMaDVT);
            this.grbCTHD.Controls.Add(this.label5);
            this.grbCTHD.Controls.Add(this.label3);
            this.grbCTHD.Location = new System.Drawing.Point(46, 68);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(565, 277);
            this.grbCTHD.TabIndex = 23;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Thông tin đơn vị tính";
            // 
            // txtTenDVT
            // 
            this.txtTenDVT.Location = new System.Drawing.Point(213, 83);
            this.txtTenDVT.Name = "txtTenDVT";
            this.txtTenDVT.Size = new System.Drawing.Size(326, 32);
            this.txtTenDVT.TabIndex = 11;
            // 
            // txtMaDVT
            // 
            this.txtMaDVT.Location = new System.Drawing.Point(213, 37);
            this.txtMaDVT.Name = "txtMaDVT";
            this.txtMaDVT.Size = new System.Drawing.Size(326, 32);
            this.txtMaDVT.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên DVT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đơn vị tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "QUẢN LÝ ĐƠN VỊ TÍNH";
            // 
            // frmDonViTinh
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
            this.Controls.Add(this.dtgridVDVT);
            this.Controls.Add(this.grbCTHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDonViTinh";
            this.Text = "Đơn Vị Tính";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVDVT)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgridVDVT;
        private System.Windows.Forms.GroupBox grbCTHD;
        private System.Windows.Forms.TextBox txtTenDVT;
        private System.Windows.Forms.TextBox txtMaDVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}