﻿namespace DoAn
{
    partial class frmDangNhap
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
            this.grbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTaiKhoan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // grbTaiKhoan
            // 
            this.grbTaiKhoan.Controls.Add(this.txtTaiKhoan);
            this.grbTaiKhoan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTaiKhoan.Location = new System.Drawing.Point(164, 175);
            this.grbTaiKhoan.Name = "grbTaiKhoan";
            this.grbTaiKhoan.Size = new System.Drawing.Size(428, 67);
            this.grbTaiKhoan.TabIndex = 1;
            this.grbTaiKhoan.TabStop = false;
            this.grbTaiKhoan.Text = "Tài Khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(26, 26);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(384, 32);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(164, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(26, 26);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(384, 32);
            this.txtMatKhau.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(227, 434);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(140, 37);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbChucVu);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(164, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 67);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức vụ";
            // 
            // cbChucVu
            // 
            this.cbChucVu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(26, 26);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(384, 32);
            this.cbChucVu.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(400, 434);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 37);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbTaiKhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grbTaiKhoan.ResumeLayout(false);
            this.grbTaiKhoan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTaiKhoan;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Button btnThoat;
    }
}