namespace DoAn
{
    partial class frmThuoc
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
            this.dtgridVThuoc = new System.Windows.Forms.DataGridView();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.txtidThuoc = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDangBaoChe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.numberSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbDonViTinh = new System.Windows.Forms.ComboBox();
            this.cbSanXuat = new System.Windows.Forms.ComboBox();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNguonGoc = new System.Windows.Forms.TextBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhanTacDung = new System.Windows.Forms.RichTextBox();
            this.txtCongDung = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHamLuong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtThanhPhan = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChuY = new System.Windows.Forms.RichTextBox();
            this.txtCachDung = new System.Windows.Forms.RichTextBox();
            this.txtBaoQuan = new System.Windows.Forms.RichTextBox();
            this.txtHanSuDung = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVThuoc)).BeginInit();
            this.grbCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(833, 598);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(137, 37);
            this.btnTim.TabIndex = 54;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(342, 600);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(450, 32);
            this.txtTimKiem.TabIndex = 53;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(995, 597);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 37);
            this.btnThoat.TabIndex = 52;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(1323, 525);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(137, 37);
            this.btnLamMoi.TabIndex = 51;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1168, 525);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 37);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1323, 482);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 37);
            this.btnSua.TabIndex = 49;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1168, 482);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 37);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Danh sách thuốc";
            // 
            // dtgridVThuoc
            // 
            this.dtgridVThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVThuoc.Location = new System.Drawing.Point(-1, 641);
            this.dtgridVThuoc.Name = "dtgridVThuoc";
            this.dtgridVThuoc.RowHeadersWidth = 51;
            this.dtgridVThuoc.RowTemplate.Height = 24;
            this.dtgridVThuoc.Size = new System.Drawing.Size(1482, 211);
            this.dtgridVThuoc.TabIndex = 46;
            this.dtgridVThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridVThuoc_CellClick);
            // 
            // grbCTHD
            // 
            this.grbCTHD.Controls.Add(this.txtidThuoc);
            this.grbCTHD.Controls.Add(this.label19);
            this.grbCTHD.Controls.Add(this.txtDangBaoChe);
            this.grbCTHD.Controls.Add(this.label4);
            this.grbCTHD.Controls.Add(this.txtGiaBan);
            this.grbCTHD.Controls.Add(this.numberSoLuong);
            this.grbCTHD.Controls.Add(this.cbDonViTinh);
            this.grbCTHD.Controls.Add(this.cbSanXuat);
            this.grbCTHD.Controls.Add(this.cbNhom);
            this.grbCTHD.Controls.Add(this.label9);
            this.grbCTHD.Controls.Add(this.label10);
            this.grbCTHD.Controls.Add(this.label11);
            this.grbCTHD.Controls.Add(this.label12);
            this.grbCTHD.Controls.Add(this.txtNguonGoc);
            this.grbCTHD.Controls.Add(this.txtTenThuoc);
            this.grbCTHD.Controls.Add(this.txtMaThuoc);
            this.grbCTHD.Controls.Add(this.label7);
            this.grbCTHD.Controls.Add(this.label6);
            this.grbCTHD.Controls.Add(this.label5);
            this.grbCTHD.Controls.Add(this.label3);
            this.grbCTHD.Location = new System.Drawing.Point(47, 72);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(1413, 209);
            this.grbCTHD.TabIndex = 45;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Thông tin hóa đơn nhập";
            this.grbCTHD.Enter += new System.EventHandler(this.grbCTHD_Enter);
            // 
            // txtidThuoc
            // 
            this.txtidThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidThuoc.Location = new System.Drawing.Point(166, 51);
            this.txtidThuoc.Name = "txtidThuoc";
            this.txtidThuoc.Size = new System.Drawing.Size(158, 32);
            this.txtidThuoc.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(35, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 24);
            this.label19.TabIndex = 32;
            this.label19.Text = "ID Thuốc:";
            // 
            // txtDangBaoChe
            // 
            this.txtDangBaoChe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangBaoChe.Location = new System.Drawing.Point(591, 108);
            this.txtDangBaoChe.Name = "txtDangBaoChe";
            this.txtDangBaoChe.Size = new System.Drawing.Size(215, 32);
            this.txtDangBaoChe.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Dạng bào chế:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(591, 51);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(215, 32);
            this.txtGiaBan.TabIndex = 29;
            // 
            // numberSoLuong
            // 
            this.numberSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSoLuong.Location = new System.Drawing.Point(1324, 102);
            this.numberSoLuong.Name = "numberSoLuong";
            this.numberSoLuong.Size = new System.Drawing.Size(47, 32);
            this.numberSoLuong.TabIndex = 28;
            // 
            // cbDonViTinh
            // 
            this.cbDonViTinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDonViTinh.FormattingEnabled = true;
            this.cbDonViTinh.Location = new System.Drawing.Point(1093, 101);
            this.cbDonViTinh.Name = "cbDonViTinh";
            this.cbDonViTinh.Size = new System.Drawing.Size(101, 32);
            this.cbDonViTinh.TabIndex = 27;
            // 
            // cbSanXuat
            // 
            this.cbSanXuat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSanXuat.FormattingEnabled = true;
            this.cbSanXuat.Location = new System.Drawing.Point(1093, 49);
            this.cbSanXuat.Name = "cbSanXuat";
            this.cbSanXuat.Size = new System.Drawing.Size(278, 32);
            this.cbSanXuat.TabIndex = 26;
            // 
            // cbNhom
            // 
            this.cbNhom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Location = new System.Drawing.Point(591, 160);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(215, 32);
            this.cbNhom.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Giá bán:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1212, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(944, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Đơn vị tính:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(964, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Sản xuất:";
            // 
            // txtNguonGoc
            // 
            this.txtNguonGoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguonGoc.Location = new System.Drawing.Point(1093, 158);
            this.txtNguonGoc.Name = "txtNguonGoc";
            this.txtNguonGoc.Size = new System.Drawing.Size(278, 32);
            this.txtNguonGoc.TabIndex = 12;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenThuoc.Location = new System.Drawing.Point(166, 160);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(158, 32);
            this.txtTenThuoc.TabIndex = 11;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuoc.Location = new System.Drawing.Point(166, 109);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(158, 32);
            this.txtMaThuoc.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(945, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nguồn gốc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nhóm:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã thuốc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 48);
            this.label1.TabIndex = 44;
            this.label1.Text = "QUẢN LÝ THUỐC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhanTacDung);
            this.groupBox1.Controls.Add(this.txtCongDung);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtHamLuong);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtThanhPhan);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(47, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 140);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công dụng - Hạn chế";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPhanTacDung
            // 
            this.txtPhanTacDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanTacDung.Location = new System.Drawing.Point(1093, 48);
            this.txtPhanTacDung.Name = "txtPhanTacDung";
            this.txtPhanTacDung.Size = new System.Drawing.Size(314, 86);
            this.txtPhanTacDung.TabIndex = 57;
            this.txtPhanTacDung.Text = "";
            // 
            // txtCongDung
            // 
            this.txtCongDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongDung.Location = new System.Drawing.Point(591, 48);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(296, 86);
            this.txtCongDung.TabIndex = 56;
            this.txtCongDung.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(908, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Phản tác dụng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(457, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 24);
            this.label13.TabIndex = 16;
            this.label13.Text = "Cộng dụng:";
            // 
            // txtHamLuong
            // 
            this.txtHamLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHamLuong.Location = new System.Drawing.Point(165, 102);
            this.txtHamLuong.Name = "txtHamLuong";
            this.txtHamLuong.Size = new System.Drawing.Size(158, 32);
            this.txtHamLuong.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 24);
            this.label16.TabIndex = 14;
            this.label16.Text = "Hàm lượng:";
            // 
            // txtThanhPhan
            // 
            this.txtThanhPhan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhPhan.Location = new System.Drawing.Point(166, 48);
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Size = new System.Drawing.Size(158, 32);
            this.txtThanhPhan.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(19, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 24);
            this.label20.TabIndex = 0;
            this.label20.Text = "Thành phần:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChuY);
            this.groupBox2.Controls.Add(this.txtCachDung);
            this.groupBox2.Controls.Add(this.txtBaoQuan);
            this.groupBox2.Controls.Add(this.txtHanSuDung);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(47, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1101, 140);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chú ý - cách dùng - bảo quản";
            // 
            // txtChuY
            // 
            this.txtChuY.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuY.Location = new System.Drawing.Point(730, 30);
            this.txtChuY.Name = "txtChuY";
            this.txtChuY.Size = new System.Drawing.Size(350, 42);
            this.txtChuY.TabIndex = 59;
            this.txtChuY.Text = "";
            // 
            // txtCachDung
            // 
            this.txtCachDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCachDung.Location = new System.Drawing.Point(165, 31);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(350, 42);
            this.txtCachDung.TabIndex = 58;
            this.txtCachDung.Text = "";
            // 
            // txtBaoQuan
            // 
            this.txtBaoQuan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaoQuan.Location = new System.Drawing.Point(730, 80);
            this.txtBaoQuan.Name = "txtBaoQuan";
            this.txtBaoQuan.Size = new System.Drawing.Size(350, 42);
            this.txtBaoQuan.TabIndex = 57;
            this.txtBaoQuan.Text = "";
            // 
            // txtHanSuDung
            // 
            this.txtHanSuDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanSuDung.Location = new System.Drawing.Point(164, 79);
            this.txtHanSuDung.Name = "txtHanSuDung";
            this.txtHanSuDung.Size = new System.Drawing.Size(351, 42);
            this.txtHanSuDung.TabIndex = 56;
            this.txtHanSuDung.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(608, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "Bảo quản:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 24);
            this.label15.TabIndex = 16;
            this.label15.Text = "Hạn sử dụng:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(646, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 24);
            this.label17.TabIndex = 14;
            this.label17.Text = "Chú ý:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(26, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "Cách dùng:";
            // 
            // frmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dtgridVThuoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbCTHD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmThuoc";
            this.Text = "Thuốc";
            this.Load += new System.EventHandler(this.frmThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVThuoc)).EndInit();
            this.grbCTHD.ResumeLayout(false);
            this.grbCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dtgridVThuoc;
        private System.Windows.Forms.GroupBox grbCTHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNguonGoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.NumericUpDown numberSoLuong;
        private System.Windows.Forms.ComboBox cbDonViTinh;
        private System.Windows.Forms.ComboBox cbSanXuat;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtPhanTacDung;
        private System.Windows.Forms.RichTextBox txtCongDung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHamLuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtThanhPhan;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtChuY;
        private System.Windows.Forms.RichTextBox txtCachDung;
        private System.Windows.Forms.RichTextBox txtBaoQuan;
        private System.Windows.Forms.RichTextBox txtHanSuDung;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtidThuoc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDangBaoChe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label3;
    }
}