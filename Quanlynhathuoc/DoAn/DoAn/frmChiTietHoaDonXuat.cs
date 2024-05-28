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
    public partial class frmChiTietHoaDonXuat : Form
    {
        BUS_ChiTietHoaDonXuat dt = new BUS_ChiTietHoaDonXuat();
        public frmChiTietHoaDonXuat()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDonXuat_Load(object sender, EventArgs e)
        {
            dtgridVCTHDX.DataSource = dt.layDSChiTietHoaDonXuat();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCTHDX.Text == string.Empty || txtMaHDX.Text == string.Empty || txtIDThuoc.Text == string.Empty || numericUpDown1.Value.ToString() == string.Empty || txtGiaBan.Text.ToString() == string.Empty || txtThue.Text.ToString() == string.Empty || txtDonVi.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maCTHDX = txtMaCTHDX.Text;
                string maHDX = txtMaHDX.Text;
                string idThuoc = txtIDThuoc.Text;
                int soLuong = int.Parse(numericUpDown1.Value.ToString());
                float giaBan = int.Parse(txtGiaBan.Text.ToString());
                float thue = int.Parse(txtThue.Text.ToString());
                string donVi = txtDonVi.Text.ToString();
                if (dt.kiemTraMaCoTonTai(maCTHDX) == false)
                {
                    DTO_ChiTietHoaDonXuat CTHDX = new DTO_ChiTietHoaDonXuat(maCTHDX, maHDX, idThuoc, soLuong, giaBan, thue, donVi);
                    dt.themChiTietHoaDonXuat(CTHDX);
                    dtgridVCTHDX.DataSource = dt.layDSChiTietHoaDonXuat();
                }
                else
                {
                    MessageBox.Show("Mã chi tiết hóa đơn xuất đã tồn tại");
                }
            }
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCTHDX.Text == string.Empty || txtMaHDX.Text == string.Empty || txtIDThuoc.Text == string.Empty || numericUpDown1.Value.ToString() == string.Empty || txtGiaBan.Text.ToString() == string.Empty || txtThue.Text.ToString() == string.Empty || txtDonVi.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maCTHDX = txtMaCTHDX.Text;
                string maHDX = txtMaHDX.Text;
                string idThuoc = txtIDThuoc.Text;
                int soLuong = int.Parse(numericUpDown1.Value.ToString());
                float giaBan = int.Parse(txtGiaBan.Text.ToString());
                float thue = int.Parse(txtThue.Text.ToString());
                string donVi = txtDonVi.Text.ToString();
                if (dt.kiemTraMaCoTonTai(maCTHDX) == true)
                {
                    DTO_ChiTietHoaDonXuat CTHDX = new DTO_ChiTietHoaDonXuat(maCTHDX, maHDX, idThuoc, soLuong, giaBan, thue, donVi);
                    dt.suaChiTietHoaDonXuat(CTHDX);
                    dtgridVCTHDX.DataSource = dt.layDSChiTietHoaDonXuat();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã chi tiết hóa đơn xuất");
                }

            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCTHDX.Text != string.Empty)
            {
                DialogResult r = new DialogResult();
                r = MessageBox.Show("Bạn muốn xóa mã " + txtMaCTHDX + " chi tiết hóa đơn xuất này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    string maCTHDX = txtMaCTHDX.Text;
                    dt.xoaChiTietHoaDonXuat(maCTHDX);
                    dtgridVCTHDX.DataSource = dt.layDSChiTietHoaDonXuat();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên chi tiết sản phẩm cần xóa");
                txtMaCTHDX.Focus();
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaCTHDX.Text = string.Empty;
            txtMaHDX.Text = string.Empty;
            txtIDThuoc.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
            txtThue.Text = string.Empty;
            txtDonVi.Text = string.Empty;
            numericUpDown1.Value = 0;
            txtMaCTHDX.Focus();
            dtgridVCTHDX.DataSource = dt.layDSChiTietHoaDonXuat();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgridVCTHDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtMaCTHDX.Text = dtgridVCTHDX.Rows[kq].Cells[0].Value.ToString();
            txtMaHDX.Text = dtgridVCTHDX.Rows[kq].Cells[1].Value.ToString();
            txtIDThuoc.Text = dtgridVCTHDX.Rows[kq].Cells[2].Value.ToString();
            numericUpDown1.Text = dtgridVCTHDX.Rows[kq].Cells[3].Value.ToString();
            txtGiaBan.Text = dtgridVCTHDX.Rows[kq].Cells[4].Value.ToString();
            txtThue.Text = dtgridVCTHDX.Rows[kq].Cells[5].Value.ToString();
            txtDonVi.Text = dtgridVCTHDX.Rows[kq].Cells[6].Value.ToString();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm");
            }
            else
            {

                if (dt.kiemTraMaHDXCoTonTai(txtTimKiem.Text))
                {
                    dtgridVCTHDX.DataSource = dt.LayDSChiTietHoaDonXuat_TheoMaHDX(txtTimKiem.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }
    }
}
