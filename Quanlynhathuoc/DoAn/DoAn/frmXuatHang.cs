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
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;
using DevExpress.XtraPrinting.Native;
using DevExpress.Data.Linq.Helpers;

namespace DoAn
{
    public partial class frmXuatHang : Form
    {
        BUS_Thuoc dt = new BUS_Thuoc();
        BUS_HoaDonXuat HDX = new BUS_HoaDonXuat();
        BUS_ChiTietHoaDonXuat CTHDX = new BUS_ChiTietHoaDonXuat();
        BUS_BenhNhan BN = new BUS_BenhNhan();
        bool KiemTra = false;
        float tongTienThuoc = 0;
        int macthdx=1;
        string sl;
        public frmXuatHang()
        {
            InitializeComponent();
            cbBenhNhan.DataSource = BN.layDSBenhNhan();
            cbBenhNhan.DisplayMember = "hoTen";
            cbBenhNhan.ValueMember = "idBN";
        }
        public float GiaBan(int soLuong, float t)
        {
            return soLuong * t;
        }
        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            dtgridVDanhSachThuoc.DataSource = dt.layDSThuoc();
            KiemTra = false;
            sl = HDX.layDSHoaDonXuat().Count().ToString();
        }

        private void dtgridVDanhSachThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            frmChiTietXuatThuoc frm = new frmChiTietXuatThuoc();
            frm.TenThuoc = dtgridVDanhSachThuoc.Rows[kq].Cells[1].Value.ToString();
            frm.ShowDialog();
            string maHDX = cbBenhNhan.SelectedValue.ToString() + sl;
            if (frm.Kt == true)
            {
                
                string idBN = cbBenhNhan.SelectedValue.ToString();
                int Sl = frm.N;
                float tongTienThuocCT = 0;
                tongTienThuocCT = GiaBan(Sl, float.Parse(dtgridVDanhSachThuoc.Rows[kq].Cells[7].Value.ToString()));
                tongTienThuoc += tongTienThuocCT;
                double thue = tongTienThuoc * 0.9;
                string maCT = maHDX + "_" + idBN + "_" + macthdx;
                if (Sl <= int.Parse(dtgridVDanhSachThuoc.Rows[kq].Cells[6].Value.ToString()))
                {
                    if (KiemTra == false)
                    {
                        DTO_HoaDonXuat hdX = new DTO_HoaDonXuat(maHDX, idBN, tongTienThuoc, thue, DateTime.Now);
                        HDX.themHoaDonXuat(hdX);
                        KiemTra = true;
                    }
                    else
                    {
                        DTO_HoaDonXuat hdX = new DTO_HoaDonXuat(maHDX, idBN, tongTienThuoc, thue, DateTime.Now);
                        HDX.suaHoaDonXuat(hdX);
                    }
                    dt.SuaThuocNhapHang(dtgridVDanhSachThuoc.Rows[kq].Cells[0].Value.ToString(), Sl);
                    DTO_ChiTietHoaDonXuat cthdx = new DTO_ChiTietHoaDonXuat(maCT, maHDX, dtgridVDanhSachThuoc.Rows[kq].Cells[0].Value.ToString(), Sl, tongTienThuocCT, thue, frm.DonViTinh);
                    CTHDX.themChiTietHoaDonXuat(cthdx);
                    macthdx++;
                }
                else
                {
                    MessageBox.Show("Thuốc không đủ để xuất");
                }
            }
            dtgridVDanhSachThuoc.DataSource = dt.layDSThuoc();
            dtgridVHoaDonXuat.DataSource = CTHDX.LayDSChiTietHoaDonXuat_TheoMaHDX(maHDX);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất hàng thành công");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
