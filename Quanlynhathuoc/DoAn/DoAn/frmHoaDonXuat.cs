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
    public partial class frmHoaDonXuat : Form
    {
        BUS_HoaDonXuat dt = new BUS_HoaDonXuat();
        BUS_BenhNhan BN = new BUS_BenhNhan();
        public frmHoaDonXuat()
        {
            InitializeComponent();
            cbIDBenhNhan.DataSource = BN.layDSBenhNhan();
            cbIDBenhNhan.DisplayMember = "hoTen";
            cbIDBenhNhan.ValueMember = "idBN";
        }

        private void grbCTHD_Enter(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHDX.Text = string.Empty;
            cbIDBenhNhan.SelectedIndex= 0;
            txtTongTienThuoc.Text = string.Empty;
            txtTongThue.Text = string.Empty;
            txtTongTienHD.Text = string.Empty;
            txtMaHDX.Focus();
            dtgridVHDX.DataSource = dt.layDSHoaDonXuat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHDX.Text != string.Empty)
            {
                DialogResult r = new DialogResult();
                r = MessageBox.Show("Bạn muốn xóa mã " + txtMaHDX + " hóa đơn xuất này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    string maHDX = txtMaHDX.Text;
                    dt.xoaHoaDonXuat(maHDX);
                    dtgridVHDX.DataSource = dt.layDSHoaDonXuat();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn xuất");
                txtMaHDX.Focus();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHDX.Text == string.Empty || cbIDBenhNhan.SelectedValue.ToString() == string.Empty || txtTongTienThuoc.Text == string.Empty || txtTongThue.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maHDX = txtMaHDX.Text;
                string idBN = cbIDBenhNhan.SelectedValue.ToString();
                float tongTienThuoc = float.Parse(txtTongTienThuoc.Text);
                DateTime ngayLap = dtpNgayLap.Value;
                float tongThue = float.Parse(txtTongThue.Text);
                if (dt.kiemTraMaHDXCoTonTai(maHDX) == true)
                {
                    DTO_HoaDonXuat HDX = new DTO_HoaDonXuat(maHDX, idBN, tongTienThuoc, tongThue, ngayLap);
                    dt.suaHoaDonXuat(HDX);
                    dtgridVHDX.DataSource = dt.layDSHoaDonXuat();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn cần sửa");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHDX.Text == string.Empty || cbIDBenhNhan.SelectedValue.ToString() == string.Empty || txtTongTienThuoc.Text == string.Empty || txtTongThue.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maHDX = txtMaHDX.Text;
                string idBN = cbIDBenhNhan.SelectedValue.ToString();
                float tongTienThuoc = float.Parse(txtTongTienThuoc.Text);
                DateTime ngayLap = dtpNgayLap.Value;
                float tongThue = float.Parse(txtTongThue.Text);
                if (dt.kiemTraMaHDXCoTonTai(maHDX) == false)
                {
                    DTO_HoaDonXuat HDX = new DTO_HoaDonXuat(maHDX, idBN, tongTienThuoc, tongThue, ngayLap);
                    dt.themHoaDonXuat(HDX);
                    dtgridVHDX.DataSource = dt.layDSHoaDonXuat();
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn xuất đã tồn tại");
                }
            }
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                    dtgridVHDX.DataSource = dt.LayDSHoaDonXuat_TheoMa(txtTimKiem.Text);
                    return;
                }
                else if (dt.kiemTraBNCoTonTai(txtTimKiem.Text))
                {
                    dtgridVHDX.DataSource = dt.LayDSHoaDonXuat_TheoMaBN(txtTimKiem.Text);
                    return;
                }
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHDX_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
            dtgridVHDX.DataSource = dt.layDSHoaDonXuat();
        }

        private void dtgridVHDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtMaHDX.Text = dtgridVHDX.Rows[kq].Cells[0].Value.ToString();
            txtTongTienThuoc.Text = dtgridVHDX.Rows[kq].Cells[2].Value.ToString();
            dtpNgayLap.Text = dtgridVHDX.Rows[kq].Cells[3].Value.ToString();
            txtTongThue.Text = dtgridVHDX.Rows[kq].Cells[4].Value.ToString();
            txtTongTienHD.Text = dtgridVHDX.Rows[kq].Cells[5].Value.ToString();
            cbIDBenhNhan.DataSource = BN.LayDSBenhNhan_TheoMa(dtgridVHDX.Rows[kq].Cells[1].Value.ToString());
            cbIDBenhNhan.DisplayMember = "hoTen";
            cbIDBenhNhan.ValueMember = "hoTen";
            string strNhom = cbIDBenhNhan.SelectedValue.ToString();
            cbIDBenhNhan.DataSource = BN.layDSBenhNhan();
            cbIDBenhNhan.DisplayMember = "hoTen";
            cbIDBenhNhan.ValueMember = "idBN";
            cbIDBenhNhan.SelectedIndex = cbIDBenhNhan.FindStringExact(strNhom);
        }
    }
}
