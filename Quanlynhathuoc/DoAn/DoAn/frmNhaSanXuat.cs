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
    public partial class frmNhaSanXuat : Form
    {
        BUS_NhaSanXuat dt = new BUS_NhaSanXuat();
        public frmNhaSanXuat()
        {
            InitializeComponent();
        }

        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            dtgridVNSX.DataSource = dt.layDNhaSanXuat();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNSX.Text == string.Empty || txtTenNSX.Text.ToString() == string.Empty || txtDiaChi.Text == string.Empty || txtDienThoai.Text.ToString() == string.Empty || txtEmail.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maNSX = txtMaNSX.Text;
                string tenNSX = txtTenNSX.Text;
                string diaChi = txtDiaChi.Text;
                string dienThoai = txtDienThoai.Text;
                string email = txtEmail.Text;
                if (dt.kiemTraMaNSXCoTonTai(maNSX) == false)
                {
                    DTO_NhaSanXuat nsx = new DTO_NhaSanXuat(maNSX, tenNSX, diaChi, dienThoai, email);
                    dt.themNhaSanXuat(nsx);
                    dtgridVNSX.DataSource = dt.layDNhaSanXuat();
                }
                else
                {
                    MessageBox.Show("Mã nhà sản xuất đã tồn tại");
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNSX.Text == string.Empty || txtTenNSX.Text.ToString() == string.Empty || txtDiaChi.Text == string.Empty || txtDienThoai.Text.ToString() == string.Empty || txtEmail.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maNSX = txtMaNSX.Text;
                string tenNSX = txtTenNSX.Text;
                string diaChi = txtDiaChi.Text;
                string dienThoai = txtDienThoai.Text;
                string email = txtEmail.Text;
                if (dt.kiemTraMaNSXCoTonTai(maNSX) == true)
                {
                    DTO_NhaSanXuat nsx = new DTO_NhaSanXuat(maNSX, tenNSX, diaChi, dienThoai, email);
                    dt.suaNhaSanXuat(nsx);
                    dtgridVNSX.DataSource = dt.layDNhaSanXuat();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhà sản xuất");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNSX.Text != string.Empty)
            {
                if (dt.kiemTraMaNSXCoTonTaitrongThuoc(txtMaNSX.Text) == false)
                {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("Bạn muốn xóa mã " + txtMaNSX + " nhà sản xuất này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        dt.xoaNhaSanXuat(txtMaNSX.Text);
                        dtgridVNSX.DataSource = dt.layDNhaSanXuat();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa mã" + txtMaNSX + " ?");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã nhà sản xuất");
                txtMaNSX.Focus();
            }
            
        }

        private void dtgridVNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtMaNSX.Text = dtgridVNSX.Rows[kq].Cells[0].Value.ToString();
            txtTenNSX.Text = dtgridVNSX.Rows[kq].Cells[1].Value.ToString();
            txtDiaChi.Text = dtgridVNSX.Rows[kq].Cells[2].Value.ToString();
            txtDienThoai.Text = dtgridVNSX.Rows[kq].Cells[3].Value.ToString();
            txtEmail.Text = dtgridVNSX.Rows[kq].Cells[4].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNSX.Text = string.Empty;
            txtTenNSX.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMaNSX.Focus();
            dtgridVNSX.DataSource = dt.layDNhaSanXuat();
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

                if (dt.kiemTraMaNSXCoTonTai(txtTimKiem.Text))
                {
                    dtgridVNSX.DataSource = dt.LayDSNhaSanXuat_TheoMa(txtTimKiem.Text);
                    return;
                }
                else if (dt.kiemTraTenCoTonTai(txtTimKiem.Text))
                {
                    dtgridVNSX.DataSource = dt.LayDSNhomThuoc_TheoTen(txtTimKiem.Text);
                    return;
                }
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }
    }
}
