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
    public partial class frmQuanLyBenhNhan : Form
    {
        BUS_BenhNhan dt = new BUS_BenhNhan();
        public frmQuanLyBenhNhan()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            dtgridVBenhNhan.DataSource = dt.layDSBenhNhan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtIDBenhNhan.Text == string.Empty || txtHoTen.Text.ToString() == string.Empty || txtTuoi.Text == string.Empty || txtDiaChi.Text == string.Empty || txtSoDienThoai.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string idBN = txtIDBenhNhan.Text;
                string hoTen = txtHoTen.Text;
                int tuoi = int.Parse(txtTuoi.Text);
                string diaChi = txtDiaChi.Text;
                string dienThoai = txtSoDienThoai.Text;
                if (dt.kiemTraMaBNCoTonTai(idBN) == false)
                {
                    DTO_BenhNhan BN = new DTO_BenhNhan(idBN, tuoi, hoTen, diaChi, dienThoai);
                    dt.themBenhNhan(BN);
                    dtgridVBenhNhan.DataSource = dt.layDSBenhNhan();
                }
                else
                {
                    MessageBox.Show("id bệnh nhân đã tồn tại");
                }
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtIDBenhNhan.Text == string.Empty || txtHoTen.Text.ToString() == string.Empty || txtTuoi.Text == string.Empty || txtDiaChi.Text == string.Empty || txtSoDienThoai.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                string idBN = txtIDBenhNhan.Text;
                string hoTen = txtHoTen.Text;
                int tuoi = int.Parse(txtTuoi.Text);
                string diaChi = txtDiaChi.Text;
                string dienThoai = txtSoDienThoai.Text;
                if (dt.kiemTraMaBNCoTonTai(idBN) == true)
                {
                    DTO_BenhNhan BN = new DTO_BenhNhan(idBN, tuoi, hoTen, diaChi, dienThoai);
                    dt.suaBenhNhan(BN);
                    dtgridVBenhNhan.DataSource = dt.layDSBenhNhan();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy id bệnh nhân cần sửa");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDBenhNhan.Text != string.Empty)
            {
                if (dt.kiemTraMaBNCoTonTaitrongHDX(txtIDBenhNhan.Text) == false)
                {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("Bạn muốn xóa mã " + txtIDBenhNhan + " bệnh nhân này?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        string idBN = txtIDBenhNhan.Text;
                        dt.xoaBenhNhan(idBN);
                        dtgridVBenhNhan.DataSource = dt.layDSBenhNhan();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa mã" + txtIDBenhNhan + " ?");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã bệnh nhân");
                txtIDBenhNhan.Focus();
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtIDBenhNhan.Text = null;
            txtHoTen.Text = null;
            txtTuoi.Text = null;
            txtDiaChi.Text = null;
            txtSoDienThoai.Text = null;
            txtIDBenhNhan.Focus();
            dtgridVBenhNhan.DataSource = dt.layDSBenhNhan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgridVBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            txtIDBenhNhan.Text = dtgridVBenhNhan.Rows[kq].Cells[0].Value.ToString();
            txtHoTen.Text = dtgridVBenhNhan.Rows[kq].Cells[1].Value.ToString();
            txtTuoi.Text = dtgridVBenhNhan.Rows[kq].Cells[2].Value.ToString();
            txtDiaChi.Text = dtgridVBenhNhan.Rows[kq].Cells[3].Value.ToString();
            txtSoDienThoai.Text = dtgridVBenhNhan.Rows[kq].Cells[4].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm");
            }
            else
            {

                if (dt.kiemTraMaBNCoTonTai(txtTimKiem.Text))
                {
                    dtgridVBenhNhan.DataSource = dt.LayDSBenhNhan_TheoMa(txtTimKiem.Text);
                    return;
                }
                else if (dt.kiemTraTenCoTonTai(txtTimKiem.Text))
                {
                    dtgridVBenhNhan.DataSource = dt.LayDSBenhNhan_TheoTen(txtTimKiem.Text);
                    return;
                }
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm");
                }
            }
        }
    }
}
