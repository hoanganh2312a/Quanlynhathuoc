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
    public partial class frmHoaDonNhap : Form
    {
        BUS_HoaDonNhap dt = new BUS_HoaDonNhap();
        BUS_NhaPhanPhoi NPP = new BUS_NhaPhanPhoi();
        BUS_HoaDonNhap HDN = new BUS_HoaDonNhap();
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void grbCTHD_Enter(object sender, EventArgs e)
        {

        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            dtgridVCTHDX.DataSource = dt.layDSHoaDonNhap();
            //btnThem.Image = Image.FromFile();

            cbMaNPP.DataSource = NPP.layDSNhaPhanPhoi();
            cbMaNPP.DisplayMember = "tenNPP";
            cbMaNPP.ValueMember = "maNPP";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == string.Empty || cbMaNPP.Text == string.Empty || txtNguoiGiao.Text == string.Empty || txtNguoiNhan.Text.ToString() == string.Empty || txtTongTienThuoc.Text.ToString() == string.Empty || txtTongThue.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maHDN = txtMaHDN.Text;
                string maNPP = cbMaNPP.SelectedValue.ToString();
                string nguoiGiao = txtNguoiGiao.Text;
                string nguoiNhan = txtNguoiNhan.Text;
                float tongTienThuoc = float.Parse(txtTongTienThuoc.Text);
                float tongThue = float.Parse(txtTongThue.Text);
                DateTime ngayViet = dtpNgayViet.Value;
                DateTime ngayNhap = dtpNgayNhap.Value;
                if (dt.kiemTraMaHDNCoTonTai(maHDN) == false)
                {
                    DTO_HoaDonNhap HDN = new DTO_HoaDonNhap(maHDN, maNPP, nguoiGiao, nguoiNhan, tongTienThuoc, tongThue, ngayViet, ngayNhap);
                    dt.themHoaDonNhap(HDN);
                    dtgridVCTHDX.DataSource = dt.layDSHoaDonNhap();
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn nhập đã tồn tại");
                }
            }
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == string.Empty || cbMaNPP.Text == string.Empty || txtNguoiGiao.Text == string.Empty || txtNguoiNhan.Text.ToString() == string.Empty || txtTongTienThuoc.Text.ToString() == string.Empty || txtTongThue.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maHDN = txtMaHDN.Text;
                string maNPP = cbMaNPP.SelectedValue.ToString();
                string nguoiGiao = txtNguoiGiao.Text;
                string nguoiNhan = txtNguoiNhan.Text;
                float tongTienThuoc = float.Parse(txtTongTienThuoc.Text);
                float tongThue = float.Parse(txtTongThue.Text);
                DateTime ngayViet = dtpNgayViet.Value;
                DateTime ngayNhap = dtpNgayNhap.Value;
                if (dt.kiemTraMaHDNCoTonTai(maHDN) == true)
                {
                    DTO_HoaDonNhap HDN = new DTO_HoaDonNhap(maHDN, maNPP, nguoiGiao, nguoiNhan, tongTienThuoc, tongThue, ngayViet, ngayNhap);
                    dt.suaHoaDonNhap(HDN);
                    dtgridVCTHDX.DataSource = dt.layDSHoaDonNhap();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn nhập");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text != string.Empty)
            {
                if (dt.kiemTraMaHDNCoTonTaitrongCTHDN(txtMaHDN.Text)== false)
                {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("Bạn muốn xóa mã " + txtMaHDN + " hóa đơn nhập này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        string maHDN = txtMaHDN.Text;
                        dt.xoaHoaDonNhap(maHDN);
                        dtgridVCTHDX.DataSource = dt.layDSHoaDonNhap();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa mã" + txtMaHDN + " ?");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn nhập");
                txtMaHDN.Focus();
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHDN.Text = null;
            txtNguoiGiao.Text = null;
            txtNguoiNhan.Text = null;
            txtTongTienThuoc.Text = null;
            txtTongTienHD.Text = null;
            txtMaHDN.Focus();
            dtgridVCTHDX.DataSource = dt.layDSHoaDonNhap();


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgridVCTHDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtMaHDN.Text = dtgridVCTHDX.Rows[kq].Cells[0].Value.ToString();
            txtNguoiGiao.Text = dtgridVCTHDX.Rows[kq].Cells[2].Value.ToString();
            txtNguoiNhan.Text = dtgridVCTHDX.Rows[kq].Cells[3].Value.ToString();
            txtTongTienThuoc.Text = dtgridVCTHDX.Rows[kq].Cells[4].Value.ToString();
            txtTongThue.Text = dtgridVCTHDX.Rows[kq].Cells[5].Value.ToString();
            txtTongTienHD.Text = dtgridVCTHDX.Rows[kq].Cells[6].Value.ToString();
            dtpNgayViet.Text = dtgridVCTHDX.Rows[kq].Cells[7].Value.ToString();
            dtpNgayNhap.Text = dtgridVCTHDX.Rows[kq].Cells[8].Value.ToString();

            cbMaNPP.DataSource = NPP.LayDSNhaPhanPhoi_TheoMa(dtgridVCTHDX.Rows[kq].Cells[1].Value.ToString());
            cbMaNPP.DisplayMember = "tenNPP";
            cbMaNPP.ValueMember = "tenNPP";
            string strNhom = cbMaNPP.SelectedValue.ToString();
            cbMaNPP.DataSource = NPP.layDSNhaPhanPhoi();
            cbMaNPP.DisplayMember = "tenNPP";
            cbMaNPP.ValueMember = "maNPP";
            cbMaNPP.SelectedIndex = cbMaNPP.FindStringExact(strNhom);
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
                    dtgridVCTHDX.DataSource = dt.LayDSHoaDonNhap_TheoMa(txtTimKiem.Text);
                    return;
                }
                else if (dt.kiemTraNPPCoTonTai(txtTimKiem.Text))
                {
                    dtgridVCTHDX.DataSource = dt.LayDSHoaDonNhap_TheoMaNPP(txtTimKiem.Text);
                    return;
                }
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }
    }
}
