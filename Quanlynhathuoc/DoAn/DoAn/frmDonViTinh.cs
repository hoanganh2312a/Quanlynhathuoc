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
    public partial class frmDonViTinh : Form
    {
        BUS_DonViTinh dt = new BUS_DonViTinh();
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            dtgridVDVT.DataSource = dt.layDSDonViTinh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDVT.Text == string.Empty || txtTenDVT.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maDVT = txtMaDVT.Text;
                string tenDVT = txtTenDVT.Text;
                if (dt.kiemTraMaDVTCoTonTai(maDVT) == false)
                {
                    DTO_DonViTinh DVT = new DTO_DonViTinh(maDVT, tenDVT);
                    dt.themDonViTinh(DVT);
                    dtgridVDVT.DataSource = dt.layDSDonViTinh();
                }
                else
                {
                    MessageBox.Show("Mã đơn vị tính đã tồn tại");
                }
            }
           
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDVT.Text == string.Empty || txtTenDVT.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string maDVT = txtMaDVT.Text;
                string tenDVT = txtTenDVT.Text;
                if (dt.kiemTraMaDVTCoTonTai(maDVT) == true)
                {
                    DTO_DonViTinh DVT = new DTO_DonViTinh(maDVT, tenDVT);
                    dt.suaDonViTinh(DVT);
                    dtgridVDVT.DataSource = dt.layDSDonViTinh();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã đơn vị tính cần sửa");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDVT.Text != string.Empty)
            {
                DialogResult r = new DialogResult();
                r = MessageBox.Show("Bạn muốn xóa mã " + txtMaDVT + " đơn vị tính này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    string maDVT = txtMaDVT.Text;
                    dt.xoaDonViTinh(maDVT);
                    dtgridVDVT.DataSource = dt.layDSDonViTinh();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã đơn vị tính");
                txtMaDVT.Focus();
            }
            
        }

        private void dtgridVDVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtMaDVT.Text = dtgridVDVT.Rows[kq].Cells[0].Value.ToString();
            txtTenDVT.Text = dtgridVDVT.Rows[kq].Cells[1].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDVT.Text = null;
            txtTenDVT.Text = null;
            dtgridVDVT.DataSource = dt.layDSDonViTinh();
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

                if (dt.kiemTraMaDVTCoTonTai(txtTimKiem.Text))
                {
                    dtgridVDVT.DataSource = dt.LayDSDonViTinh_TheoMa(txtTimKiem.Text);
                    return;
                }
                else if (dt.kiemTraTenCoTonTai(txtTimKiem.Text))
                {
                    dtgridVDVT.DataSource = dt.LayDSDonViTinh_TheoTen(txtTimKiem.Text);
                    return;
                }
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }              
            }
        }
    }
}
