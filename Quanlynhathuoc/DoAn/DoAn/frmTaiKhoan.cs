using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DoAn
{
    public partial class frmTaiKhoan : Form
    {
        BUS_TaiKhoan dt = new BUS_TaiKhoan();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dtgridVTaiKhoan.DataSource = dt.layDSTaiKhoan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == string.Empty || txtMatKhau.Text.ToString() == string.Empty || txtHoTen.Text == string.Empty || txtChucVu.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string taiKhoan = txtTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                string hoTen = txtHoTen.Text;
                DateTime ngayTao = dtpNgayTao.Value;
                string chucVu = txtChucVu.Text;
                if (dt.kiemTraTKCoTonTai(taiKhoan) == false)
                {
                    DTO_TAIKHOAN tk = new DTO_TAIKHOAN(taiKhoan, matKhau, hoTen, chucVu, ngayTao);
                    dt.themTaiKhoan(tk);
                    dtgridVTaiKhoan.DataSource = dt.layDSTaiKhoan();
                }
                else
                {
                    MessageBox.Show("tài khoản đã tồn tại");
                }
            }
           
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == string.Empty || txtMatKhau.Text.ToString() == string.Empty || txtHoTen.Text == string.Empty || txtChucVu.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string taiKhoan = txtTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                string hoTen = txtHoTen.Text;
                DateTime ngayTao = dtpNgayTao.Value;
                string chucVu = txtChucVu.Text;
                if (dt.kiemTraTKCoTonTai(taiKhoan) == true)
                {
                    DTO_TAIKHOAN tk = new DTO_TAIKHOAN(taiKhoan, matKhau, hoTen, chucVu, ngayTao);
                    dt.suaTaiKhoan(tk);
                    dtgridVTaiKhoan.DataSource = dt.layDSTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản cần sửa");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != string.Empty)
            {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("Bạn muốn xóa tài khoản " + txtTaiKhoan + " này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        string taiKhoan = txtTaiKhoan.Text;
                        dt.xoaTaiKhoan(taiKhoan);
                        dtgridVTaiKhoan.DataSource = dt.layDSTaiKhoan();
                    }             
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tài khoản cần xóa");
                txtTaiKhoan.Focus();
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtChucVu.Text = string.Empty;
            dtpNgayTao.Value = DateTime.Now;
            txtTaiKhoan.Focus();
            dtgridVTaiKhoan.DataSource = dt.layDSTaiKhoan();
        }

        private void dtgridVTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtTaiKhoan.Text = dtgridVTaiKhoan.Rows[kq].Cells[0].Value.ToString();
            txtMatKhau.Text = dtgridVTaiKhoan.Rows[kq].Cells[1].Value.ToString();
            txtHoTen.Text = dtgridVTaiKhoan.Rows[kq].Cells[2].Value.ToString();
            txtChucVu.Text = dtgridVTaiKhoan.Rows[kq].Cells[4].Value.ToString();
            dtpNgayTao.Text = dtgridVTaiKhoan.Rows[kq].Cells[3].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm");
            }
            else
            {

                if (dt.kiemTraTKCoTonTai(txtTimKiem.Text))
                {
                    dtgridVTaiKhoan.DataSource = dt.LayDSTaiKhoan_TheoMa(txtTimKiem.Text);
                    return;
                }
                else if (dt.kiemTraTenCoTonTai(txtTimKiem.Text))
                {
                    dtgridVTaiKhoan.DataSource = dt.LayDSTaiKhoan_TheoTen(txtTimKiem.Text);
                    return;
                }
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }
    }
}
