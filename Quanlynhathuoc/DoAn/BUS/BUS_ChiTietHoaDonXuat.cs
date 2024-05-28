using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_ChiTietHoaDonXuat
    {
        DAL_ChiTietHoaDonXuat dal_ChiTietHoaDonXuat = new DAL_ChiTietHoaDonXuat();
        public IQueryable layDSChiTietHoaDonXuat()
        {
            return dal_ChiTietHoaDonXuat.layDSChiTietHoaDonXuat();
        }
        public IQueryable LayDSChiTietHoaDonXuat_TheoMa(string ma)
        {
            return dal_ChiTietHoaDonXuat.LayDSChiTietHoaDonXuat_TheoMa(ma);
        }
        public IQueryable LayDSChiTietHoaDonXuat_TheoMaHDX(string ma)
        {
            return dal_ChiTietHoaDonXuat.LayDSChiTietHoaDonXuat_TheoMaHDX(ma);
        }
        public bool themChiTietHoaDonXuat(DTO_ChiTietHoaDonXuat n)
        {
            return dal_ChiTietHoaDonXuat.themChiTietHoaDonXuat(n);
        }
        public bool xoaChiTietHoaDonXuat(string maCTHDX)
        {
            return dal_ChiTietHoaDonXuat.xoaChiTietHoaDonXuat(maCTHDX);
        }
        public bool suaChiTietHoaDonXuat(DTO_ChiTietHoaDonXuat n)
        {
            return dal_ChiTietHoaDonXuat.suaChiTietHoaDonXuat(n);
        }
        public bool xoaChiTietHoaDonXuatTheoMaHDX(string maHDX)
        {
            return dal_ChiTietHoaDonXuat.xoaChiTietHoaDonXuatTheoMaHDX(maHDX);
        }
        public bool kiemTraMaHDXCoTonTai(string ma)
        {
            return dal_ChiTietHoaDonXuat.kiemTraMaHDXCoTonTai(ma);
        }
        public bool kiemTraMaCoTonTai(string ma)
        {
            return dal_ChiTietHoaDonXuat.kiemTraMaCoTonTai(ma);
        }
    }
}
