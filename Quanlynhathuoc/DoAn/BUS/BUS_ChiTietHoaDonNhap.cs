using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_ChiTietHoaDonNhap
    {
        DAL_ChiTietHoaDonNhap dal_ChiTietHoaDonNhap = new DAL_ChiTietHoaDonNhap();
        public IQueryable layDSChiTietHoaDonNhap()
        {

            return dal_ChiTietHoaDonNhap.layDSChiTietHoaDonNhap();
        }
        public IQueryable LayDSChiTietHoaDonNhap_TheoMaHDN(string ma)
        {
            return dal_ChiTietHoaDonNhap.LayDSChiTietHoaDonNhap_TheoMaHDN(ma);
        }
        public bool themChiTietHoaDonNhap(DTO_ChiTietHoaDonNhap n)
        {
            return dal_ChiTietHoaDonNhap.themChiTietHoaDonNhap(n);
        }
        public bool xoaChiTietHoaDonNhap(string maCTHDN)
        {
            return dal_ChiTietHoaDonNhap.xoaChiTietHoaDonNhap(maCTHDN);
        }
        public bool suaChiTietHoaDonNhap(DTO_ChiTietHoaDonNhap n)
        {
            return dal_ChiTietHoaDonNhap.suaChiTietHoaDonNhap(n);
        }
        public bool xoaChiTietHoaDonNhapTheoMaHDN(string maHDN)
        {
            return dal_ChiTietHoaDonNhap.xoaChiTietHoaDonNhapTheoMaHDN(maHDN);
        }
        public bool kiemTraMaCoTonTai(string ma)
        {
            return dal_ChiTietHoaDonNhap.kiemTraMaCoTonTai(ma);
        }
        public bool kiemTraMaHDNCoTonTai(string ma)
        {
            return dal_ChiTietHoaDonNhap.kiemTraMaHDNCoTonTai(ma);
        }
       
    }
}
