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
using DevExpress.Data.Linq.Helpers;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn
{
    public partial class frmNhapHang : Form
    {
        BUS_Thuoc dt = new BUS_Thuoc();
        BUS_NhaPhanPhoi NPP = new BUS_NhaPhanPhoi();
        BUS_HoaDonNhap HDN = new BUS_HoaDonNhap();
        BUS_ChiTietHoaDonNhap CTHDN = new BUS_ChiTietHoaDonNhap();
        bool KiemTra = false;
        int maCTHDN = 1;
        float tongTienThuoc = 0;
        string sl;

        public float GiaBan(int soLuong, float t)
        {
            return soLuong * t;
        }
        public frmNhapHang()
        {
            InitializeComponent();
            cbNhaCungCap.DataSource = NPP.layDSNhaPhanPhoi();
            cbNhaCungCap.DisplayMember = "tenNPP";
            cbNhaCungCap.ValueMember= "maNPP";
            frmChiTietNhapThuoc frm = new frmChiTietNhapThuoc();
            frm.TenNPP = cbNhaCungCap.SelectedValue.ToString();
            
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            sl = HDN.layDSHoaDonNhap().Count().ToString();
            dtgridVDanhSachThuoc.DataSource = dt.layDSThuoc();
            KiemTra = false;
        }

        private void dtgridVDanhSachThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            frmChiTietNhapThuoc frm = new frmChiTietNhapThuoc();
            frm.TenThuoc = dtgridVDanhSachThuoc.Rows[kq].Cells[1].Value.ToString();
            frm.ShowDialog();
            string maHDN = cbNhaCungCap.SelectedValue.ToString() + sl;
            if (frm.Kt == true)
            {
                
                string maNPP = cbNhaCungCap.SelectedValue.ToString();
                int Sl = frm.N;
                string nguoiGiao = txtNguoiGiao.Text;
                string nguoiNhan = txtNguoiNhan.Text;
                float tongTienThuocCT = 0;             
                tongTienThuocCT = GiaBan(Sl, float.Parse(dtgridVDanhSachThuoc.Rows[kq].Cells[7].Value.ToString()));
                tongTienThuoc += tongTienThuocCT;
                double thue = tongTienThuoc * 0.9;
                string maCT = maHDN +"_"+ maNPP + "_" + maCTHDN;
                if (KiemTra == false)
                {                 
                    DTO_HoaDonNhap hdn = new DTO_HoaDonNhap(maHDN, maNPP, nguoiGiao, nguoiNhan, tongTienThuoc, thue, DateTime.Now, DateTime.Now);
                    HDN.themHoaDonNhap(hdn);
                    KiemTra = true;
                }
                else
                {
                    DTO_HoaDonNhap hdn = new DTO_HoaDonNhap(maHDN, maNPP, nguoiGiao, nguoiNhan, tongTienThuoc, thue, DateTime.Now, DateTime.Now);
                    HDN.suaHoaDonNhap(hdn);
                }
                dt.SuaThuocXuatHang(dtgridVDanhSachThuoc.Rows[kq].Cells[0].Value.ToString(), Sl);
                DTO_ChiTietHoaDonNhap cthdn = new DTO_ChiTietHoaDonNhap(maCT, maHDN, dtgridVDanhSachThuoc.Rows[kq].Cells[0].Value.ToString(), Sl, tongTienThuocCT);
                CTHDN.themChiTietHoaDonNhap(cthdn);
                maCTHDN++;
            }
            dtgridVDanhSachThuoc.DataSource = dt.layDSThuoc();
            dtgridVHoaDonNhap.DataSource = CTHDN.LayDSChiTietHoaDonNhap_TheoMaHDN(maHDN);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập hàng thành công");
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
