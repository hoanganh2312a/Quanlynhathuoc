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
    public partial class frmNhaPhanPhoi : Form
    {
        BUS_NhaPhanPhoi dt = new BUS_NhaPhanPhoi();
        public frmNhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void frmNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            dtgridVNPP.DataSource = dt.layDSNhaPhanPhoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNPP.Text == string.Empty || txtTenNPP.Text.ToString() == string.Empty || txtDiaChi.Text == string.Empty || txtDienThoai.Text.ToString() == string.Empty || txtEmail.Text.ToString() == string.Empty || txtMaSoThue.Text.ToString() == string.Empty || txtGhiChu.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maNPP = txtMaNPP.Text;
                string tenNPP = txtTenNPP.Text;
                string diaChi = txtDiaChi.Text;
                string dienThoai = txtDienThoai.Text;
                string email = txtEmail.Text;
                string maSoThue = txtMaSoThue.Text;
                string ghiChu = txtGhiChu.Text;
                if (dt.kiemTraMaNPPCoTonTai(maNPP) == false)
                {
                    DTO_NhaPhanPhoi NPP = new DTO_NhaPhanPhoi(maNPP, tenNPP, diaChi, dienThoai, email, maSoThue, ghiChu);
                    dt.themNhaPhanPhoi(NPP);
                    dtgridVNPP.DataSource = dt.layDSNhaPhanPhoi();
                }
                else
                {
                    MessageBox.Show("Mã nhà phân phối đã tồn tại");
                }
            }
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNPP.Text == string.Empty || txtTenNPP.Text.ToString() == string.Empty || txtDiaChi.Text == string.Empty || txtDienThoai.Text.ToString() == string.Empty || txtEmail.Text.ToString() == string.Empty || txtMaSoThue.Text.ToString() == string.Empty || txtGhiChu.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maNPP = txtMaNPP.Text;
                string tenNPP = txtTenNPP.Text;
                string diaChi = txtDiaChi.Text;
                string dienThoai = txtDienThoai.Text;
                string email = txtEmail.Text;
                string maSoThue = txtMaSoThue.Text;
                string ghiChu = txtGhiChu.Text;
                if (dt.kiemTraMaNPPCoTonTai(maNPP) == true)
                {
                    DTO_NhaPhanPhoi NPP = new DTO_NhaPhanPhoi(maNPP, tenNPP, diaChi, dienThoai, email, maSoThue, ghiChu);
                    dt.suaNhaPhanPhoi(NPP);
                    dtgridVNPP.DataSource = dt.layDSNhaPhanPhoi();
                }
                else
                {
                    MessageBox.Show("Mã nhà phân phối đã tồn tại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNPP.Text != string.Empty)
            {
                if (dt.kiemTraMaNPPCoTonTaitrongHDN(txtMaNPP.Text) == false)
                {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("Bạn muốn xóa mã " + txtMaNPP + " nhà phân phối này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        string maNPP = txtMaNPP.Text;
                        dt.xoaNhaPhanPhoi(maNPP);
                        dtgridVNPP.DataSource = dt.layDSNhaPhanPhoi();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa mã" + txtMaNPP + " ?");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã nhà phân phối");
                txtMaNPP.Focus();
            }
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNPP.Text = null;
            txtTenNPP.Text = null;
            txtDiaChi.Text = null;
            txtDienThoai.Text = null;
            txtEmail.Text = null;
            txtMaSoThue.Text = null;
            txtGhiChu.Text = null;
            txtMaNPP.Focus();
            dtgridVNPP.DataSource = dt.layDSNhaPhanPhoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgridVNPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtMaNPP.Text = dtgridVNPP.Rows[kq].Cells[0].Value.ToString();
            txtTenNPP.Text = dtgridVNPP.Rows[kq].Cells[1].Value.ToString();
            txtDiaChi.Text = dtgridVNPP.Rows[kq].Cells[2].Value.ToString();
            txtDienThoai.Text = dtgridVNPP.Rows[kq].Cells[3].Value.ToString();
            txtEmail.Text = dtgridVNPP.Rows[kq].Cells[4].Value.ToString();
            txtMaSoThue.Text = dtgridVNPP.Rows[kq].Cells[5].Value.ToString();
            txtGhiChu.Text = dtgridVNPP.Rows[kq].Cells[6].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm");
            }
            else
            {

                if (dt.kiemTraMaNPPCoTonTai(txtTimKiem.Text))
                {
                    dtgridVNPP.DataSource = dt.LayDSNhaPhanPhoi_TheoMa(txtTimKiem.Text);
                    return;
                }
                else if (dt.kiemTraTenCoTonTai(txtTimKiem.Text))
                {
                    dtgridVNPP.DataSource = dt.LayDSNhaPhanPhoi_TheoTen(txtTimKiem.Text);
                    return;
                }
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }
    }
}
