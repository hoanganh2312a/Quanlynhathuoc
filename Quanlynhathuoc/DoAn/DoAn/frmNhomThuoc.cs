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
    public partial class frmNhomThuoc : Form
    {
        BUS_NhomThuoc dt = new BUS_NhomThuoc();
        int maNhom;
        public frmNhomThuoc()
        {
            InitializeComponent();
        }

        private void frmNhomThuoc_Load(object sender, EventArgs e)
        {
            dtgridVNhomThuoc.DataSource= dt.layDSNhomThuoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhomThuoc.Text == string.Empty || txtTenNhom.Text.ToString() == string.Empty || txtGhiChu.Text == string.Empty )
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maNhom = txtMaNhomThuoc.Text;
                string tenNhom = txtTenNhom.Text;
                string ghiChu = txtGhiChu.Text;
                if (dt.kiemTraMaMNCoTonTai(maNhom) == false)
                {
                    DTO_NhomThuoc nhom = new DTO_NhomThuoc(maNhom, tenNhom, ghiChu);
                    dt.themNhomThuoc(nhom);
                    dtgridVNhomThuoc.DataSource = dt.layDSNhomThuoc();
                }
                else
                {
                    MessageBox.Show("Mã nhà nhóm thuốc đã tồn tại");
                }
            }
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhomThuoc.Text == string.Empty || txtTenNhom.Text.ToString() == string.Empty || txtGhiChu.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maNhom = txtMaNhomThuoc.Text;
                string tenNhom = txtTenNhom.Text;
                string ghiChu = txtGhiChu.Text;
                if (dt.kiemTraMaMNCoTonTai(maNhom) == true)
                {
                    DTO_NhomThuoc nhom = new DTO_NhomThuoc(maNhom, tenNhom, ghiChu);
                    dt.suaNhomThuoc(nhom);
                    dtgridVNhomThuoc.DataSource = dt.layDSNhomThuoc();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhóm thuốc");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhomThuoc.Text != string.Empty)
            {
                if (dt.kiemTraMaNTCoTonTaitrongThuoc(txtMaNhomThuoc.Text) == false)
                {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("Bạn muốn xóa mã " + txtMaNhomThuoc + " nhóm thuốc này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        dt.xoaNhomThuoc(txtMaNhomThuoc.Text);
                        dtgridVNhomThuoc.DataSource = dt.layDSNhomThuoc();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa mã" + txtMaNhomThuoc + " ?");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã nhóm thuốc");
                txtMaNhomThuoc.Focus();
            }
            
        }

        private void dtgridVNhomThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtMaNhomThuoc.Text = dtgridVNhomThuoc.Rows[kq].Cells[0].Value.ToString();
            txtTenNhom.Text = dtgridVNhomThuoc.Rows[kq].Cells[1].Value.ToString();
            txtGhiChu.Text = dtgridVNhomThuoc.Rows[kq].Cells[2].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhomThuoc.Text = string.Empty;
            txtTenNhom.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtMaNhomThuoc.Focus();
            dtgridVNhomThuoc.DataSource = dt.layDSNhomThuoc();
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

                if (dt.kiemTraMaMNCoTonTai(txtTimKiem.Text))
                {
                    dtgridVNhomThuoc.DataSource = dt.LayDSNhomThuoc_TheoMaNhom(txtTimKiem.Text);
                    return;
                }
                else if (dt.kiemTraTenCoTonTai(txtTimKiem.Text))
                {
                    dtgridVNhomThuoc.DataSource = dt.LayDSNhomThuoc_TheoTenNhom(txtTimKiem.Text);
                    return;
                }
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }
    }
}
