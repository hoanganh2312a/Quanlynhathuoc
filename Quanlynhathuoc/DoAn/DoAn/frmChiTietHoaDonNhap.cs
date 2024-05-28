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
    public partial class frmChiTietHoaDonNhap : Form
    {
        BUS_ChiTietHoaDonNhap dt = new BUS_ChiTietHoaDonNhap();
        public frmChiTietHoaDonNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            dtgridVCTHDN.DataSource = dt.layDSChiTietHoaDonNhap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (txtMaCTHDN.Text == string.Empty || txtMaHDN.Text == string.Empty || txtIDThuoc.Text == string.Empty || numericUpDown1.Value.ToString() == string.Empty || txtGiaNhap.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maCTHDN = txtMaCTHDN.Text;
                string maHDN = txtMaHDN.Text;
                string idThuoc = txtIDThuoc.Text;
                int soLuong = int.Parse(numericUpDown1.Value.ToString());
                float giaNhap = float.Parse(txtGiaNhap.Text.ToString());
                if (dt.kiemTraMaCoTonTai(maCTHDN)==false)
                {
                    DTO_ChiTietHoaDonNhap CTHDN = new DTO_ChiTietHoaDonNhap(maCTHDN, maHDN, idThuoc, soLuong, giaNhap);
                    dt.themChiTietHoaDonNhap(CTHDN);
                    dtgridVCTHDN.DataSource = dt.layDSChiTietHoaDonNhap();
                }
                else
                {
                    MessageBox.Show("Mã chi tiết hóa đơn nhập đã tồn tại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (txtMaCTHDN.Text == string.Empty || txtMaHDN.Text == string.Empty || txtIDThuoc.Text == string.Empty || numericUpDown1.Value.ToString() == string.Empty || txtGiaNhap.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maCTHDN = txtMaCTHDN.Text;
                string maHDN = txtMaHDN.Text;
                string idThuoc = txtIDThuoc.Text;
                int soLuong = int.Parse(numericUpDown1.Value.ToString());
                float giaNhap = float.Parse(txtGiaNhap.Text.ToString());
                if (dt.kiemTraMaCoTonTai(maCTHDN) == true)
                {
                    DTO_ChiTietHoaDonNhap CTHDN = new DTO_ChiTietHoaDonNhap(maCTHDN, maHDN, idThuoc, soLuong, giaNhap);
                    dt.suaChiTietHoaDonNhap(CTHDN);
                    dtgridVCTHDN.DataSource = dt.layDSChiTietHoaDonNhap();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã chi tiết hóa đơn nhập");
                }
                
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {           
            if (txtMaCTHDN.Text != string.Empty)
            {
                DialogResult r = new DialogResult();
                r = MessageBox.Show("Bạn muốn xóa mã " + txtMaCTHDN+" chi tiết hóa đơn nhập này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    string maCTHDN = txtMaCTHDN.Text;
                    dt.xoaChiTietHoaDonNhap(maCTHDN);
                    dtgridVCTHDN.DataSource = dt.layDSChiTietHoaDonNhap();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên chi tiết sản phẩm cần xóa");
                txtMaCTHDN.Focus();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaCTHDN.Text = string.Empty;
            txtMaHDN.Text += string.Empty;
            txtIDThuoc.Text = string.Empty;
            numericUpDown1.Value = 0;
            txtGiaNhap.Text= string.Empty;
            dtgridVCTHDN.DataSource = dt.layDSChiTietHoaDonNhap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgridVCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtMaCTHDN.Text = dtgridVCTHDN.Rows[kq].Cells[0].Value.ToString();
            txtMaHDN.Text = dtgridVCTHDN.Rows[kq].Cells[1].Value.ToString();
            txtIDThuoc.Text = dtgridVCTHDN.Rows[kq].Cells[2].Value.ToString();
            numericUpDown1.Text = dtgridVCTHDN.Rows[kq].Cells[3].Value.ToString();
            txtGiaNhap.Text = dtgridVCTHDN.Rows[kq].Cells[4].Value.ToString();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm");
            }
            else
            {

                if (dt.kiemTraMaHDNCoTonTai(txtTimKiem.Text))
                {
                    dtgridVCTHDN.DataSource = dt.LayDSChiTietHoaDonNhap_TheoMaHDN(txtTimKiem.Text);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }
    }
}
