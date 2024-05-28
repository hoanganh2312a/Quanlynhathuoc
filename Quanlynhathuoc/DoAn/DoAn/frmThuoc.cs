using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DoAn
{
    public partial class frmThuoc : Form
    {
        BUS_Thuoc dt = new BUS_Thuoc();
        BUS_NhomThuoc nhom = new BUS_NhomThuoc();
        BUS_NhaSanXuat NSX = new BUS_NhaSanXuat();
        BUS_DonViTinh DVT = new BUS_DonViTinh();

        public frmThuoc()
        {
            InitializeComponent();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            
            dtgridVThuoc.DataSource = dt.layDSThuoc();
            dtgridVThuoc.Columns[0].Width = 80;
            dtgridVThuoc.Columns[1].Width = 100;

            cbNhom.DataSource = nhom.layDSNhomThuoc();
            cbNhom.DisplayMember = "tenNhom";
            cbNhom.ValueMember = "maNhom";

            cbSanXuat.DataSource = NSX.layDNhaSanXuat();
            cbSanXuat.DisplayMember = "tenNSX";
            cbSanXuat.ValueMember = "maNSX";

            cbDonViTinh.DataSource = DVT.layDSDonViTinh();
            cbDonViTinh.DisplayMember = "tenDVT";
            cbDonViTinh.ValueMember = "maDVT";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtidThuoc.Text == string.Empty || txtMaThuoc.Text.ToString() == string.Empty || txtTenThuoc.Text == string.Empty || txtGiaBan.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string idThuoc = txtidThuoc.Text;
                string maThuoc = txtMaThuoc.Text;
                string tenThuoc = txtTenThuoc.Text;
                string maNhom = cbNhom.SelectedValue.ToString();
                string nguonGoc = txtNguonGoc.Text;
                string maNSX = cbSanXuat.SelectedValue.ToString();
                int soLuong = int.Parse(numberSoLuong.Value.ToString());
                float giaBan = float.Parse(txtGiaBan.Text);
                string maDVT = cbDonViTinh.SelectedValue.ToString();
                string thanhPhan = txtThanhPhan.Text;
                string hamluong = txtHamLuong.Text;
                string congDung = txtCongDung.Text;
                string phanTacDung = txtPhanTacDung.Text;
                string cachDung = txtCachDung.Text;
                string chuY = txtChuY.Text;
                string hanSuDung = txtHanSuDung.Text;
                string baoQuan = txtBaoQuan.Text;
                string dangBaoChe = txtDangBaoChe.Text;
                if (dt.kiemTraMaThuocCoTonTai(idThuoc) == false)
                {
                    DTO_Thuoc thuoc = new DTO_Thuoc(idThuoc, maNhom, maNSX, soLuong, maDVT, maThuoc, tenThuoc, nguonGoc, thanhPhan, hamluong, congDung, phanTacDung, cachDung, chuY, hanSuDung, baoQuan, dangBaoChe, giaBan);
                    dt.ThemThuoc(thuoc);
                    dtgridVThuoc.DataSource = dt.layDSThuoc();
                }
                else
                {
                    MessageBox.Show("ID Thuốc đã tồn tại");
                }
            }
           
            
        }

        private void grbCTHD_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtidThuoc.Text == string.Empty || txtMaThuoc.Text.ToString() == string.Empty || txtTenThuoc.Text == string.Empty || txtGiaBan.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string idThuoc = txtidThuoc.Text;
                string maThuoc = txtMaThuoc.Text;
                string tenThuoc = txtTenThuoc.Text;
                string maNhom = cbNhom.SelectedValue.ToString();
                string nguonGoc = txtNguonGoc.Text;
                string maNSX = cbSanXuat.SelectedValue.ToString();
                int soLuong = int.Parse(numberSoLuong.Value.ToString());
                float giaBan = float.Parse(txtGiaBan.Text);
                string maDVT = cbDonViTinh.SelectedValue.ToString();
                string thanhPhan = txtThanhPhan.Text;
                string hamluong = txtHamLuong.Text;
                string congDung = txtCongDung.Text;
                string phanTacDung = txtPhanTacDung.Text;
                string cachDung = txtCachDung.Text;
                string chuY = txtChuY.Text;
                string hanSuDung = txtHanSuDung.Text;
                string baoQuan = txtBaoQuan.Text;
                string dangBaoChe = txtDangBaoChe.Text;
                if (dt.kiemTraMaThuocCoTonTai(idThuoc) == true)
                {
                    DTO_Thuoc thuoc = new DTO_Thuoc(idThuoc, maNhom, maNSX, soLuong, maDVT, maThuoc, tenThuoc, nguonGoc, thanhPhan, hamluong, congDung, phanTacDung, cachDung, chuY, hanSuDung, baoQuan, dangBaoChe, giaBan);
                    dt.SuaThuoc(thuoc);
                    dtgridVThuoc.DataSource = dt.layDSThuoc();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy id thuốc");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtidThuoc.Text != string.Empty)
            {
                DialogResult r = new DialogResult();
                r = MessageBox.Show("Bạn muốn xóa id thuốc " + txtidThuoc + " này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    string idThuoc = txtidThuoc.Text;
                    dt.xoaThuoc(idThuoc);
                    dtgridVThuoc.DataSource = dt.layDSThuoc();
                    MessageBox.Show("Xóa thuốc thành công");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập id thuốc cần xóa");
                txtidThuoc.Focus();
            }
        }

        private void dtgridVThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtidThuoc.Text = dtgridVThuoc.Rows[kq].Cells[0].Value.ToString();
            txtMaThuoc.Text = dtgridVThuoc.Rows[kq].Cells[1].Value.ToString();
            txtTenThuoc.Text = dtgridVThuoc.Rows[kq].Cells[2].Value.ToString();
            txtNguonGoc.Text = dtgridVThuoc.Rows[kq].Cells[4].Value.ToString();
            numberSoLuong.Text = dtgridVThuoc.Rows[kq].Cells[6].Value.ToString();
            txtGiaBan.Text = dtgridVThuoc.Rows[kq].Cells[7].Value.ToString();
            txtThanhPhan.Text = dtgridVThuoc.Rows[kq].Cells[9].Value.ToString();
            txtHamLuong.Text = dtgridVThuoc.Rows[kq].Cells[10].Value.ToString();
            txtCongDung.Text = dtgridVThuoc.Rows[kq].Cells[11].Value.ToString();
            txtPhanTacDung.Text = dtgridVThuoc.Rows[kq].Cells[12].Value.ToString();
            txtCachDung.Text = dtgridVThuoc.Rows[kq].Cells[13].Value.ToString();
            txtChuY.Text = dtgridVThuoc.Rows[kq].Cells[14].Value.ToString();
            txtHanSuDung.Text = dtgridVThuoc.Rows[kq].Cells[15].Value.ToString();
            txtBaoQuan.Text = dtgridVThuoc.Rows[kq].Cells[16].Value.ToString();
            txtDangBaoChe.Text = dtgridVThuoc.Rows[kq].Cells[17].Value.ToString();

            cbNhom.DataSource = nhom.LayDSNhomThuoc_TheoMaNhom(dtgridVThuoc.Rows[kq].Cells[3].Value.ToString());
            cbNhom.DisplayMember = "tenNhom";
            cbNhom.ValueMember = "tenNhom";
            string strNhom = cbNhom.SelectedValue.ToString();
            cbNhom.DataSource = nhom.layDSNhomThuoc();
            cbNhom.DisplayMember = "tenNhom";
            cbNhom.ValueMember = "maNhom";
            cbNhom.SelectedIndex = cbNhom.FindStringExact(strNhom);


            cbSanXuat.DataSource = NSX.LayDSNhaSanXuat_TheoMa(dtgridVThuoc.Rows[kq].Cells[5].Value.ToString());
            cbSanXuat.DisplayMember = "tenNSX";
            cbSanXuat.ValueMember = "maNSX";
            string strNSX = cbSanXuat.SelectedValue.ToString();
            cbSanXuat.DataSource = NSX.layDNhaSanXuat();
            cbSanXuat.DisplayMember = "tenNSX";
            cbSanXuat.ValueMember = "maNSX";
            cbSanXuat.SelectedIndex = cbSanXuat.FindStringExact(strNSX);

            cbDonViTinh.DataSource = DVT.LayDSDonViTinh_TheoMa(dtgridVThuoc.Rows[kq].Cells[8].Value.ToString());
            cbDonViTinh.DisplayMember = "tenDVT";
            cbDonViTinh.ValueMember = "maDVT";
            string strDVT = cbDonViTinh.SelectedValue.ToString();
            cbDonViTinh.DataSource = DVT.layDSDonViTinh();
            cbDonViTinh.DisplayMember = "tenDVT";
            cbDonViTinh.ValueMember = "maDVT";
            cbDonViTinh.SelectedIndex = cbDonViTinh.FindStringExact(strDVT);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtidThuoc.Text = string.Empty;
            txtMaThuoc.Text = string.Empty;
            txtTenThuoc.Text = string.Empty;
            txtNguonGoc.Text = string.Empty;
            numberSoLuong.Text = string.Empty;
            txtGiaBan.Text = string.Empty;
            txtThanhPhan.Text = string.Empty;
            txtHamLuong.Text = string.Empty;
            txtCongDung.Text = string.Empty;
            txtPhanTacDung.Text = string.Empty;
            txtCachDung.Text = string.Empty;
            txtChuY.Text = string.Empty;
            txtHanSuDung.Text = string.Empty;
            txtBaoQuan.Text = string.Empty;
            txtDangBaoChe.Text = string.Empty;
            cbNhom.SelectedIndex = 0;
            cbSanXuat.SelectedIndex = 0;
            cbDonViTinh.SelectedIndex = 0;
            txtidThuoc.Focus();
            dtgridVThuoc.DataSource = dt.layDSThuoc();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm");
            }
            else
            {

                if (dt.kiemTraMaThuocCoTonTai(txtTimKiem.Text))
                {
                    dtgridVThuoc.DataSource = dt.LayDSThuoc_TheoMaSP(txtTimKiem.Text);
                    return;
                }
                else if (dt.kiemTraTenCoTonTai(txtTimKiem.Text))
                {
                    dtgridVThuoc.DataSource = dt.LayDSThuoc_TheoTenSP(txtTimKiem.Text);
                    return;
                }
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
