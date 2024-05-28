using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace DoAn
{
    public partial class frmDangNhap : Form
    {
        BUS_TaiKhoan dt = new BUS_TaiKhoan();
        frmTrangChu frm = new frmTrangChu();
        public frmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar= '*';
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string[] cv = { "admin" ,"Quản lý", "Nhân viên" };
            cbChucVu.DataSource = cv;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txtTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtMatKhau.Focus();
            }
            else
            {
                if (dt.CheckTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, cbChucVu.Text))
                {
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Bạn muốn thoát ứng dụng?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
