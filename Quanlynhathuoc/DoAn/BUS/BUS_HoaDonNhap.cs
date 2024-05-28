using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap dal_HoaDonNhap = new DAL_HoaDonNhap();
        public IQueryable layDSHoaDonNhap()
        {
            return dal_HoaDonNhap.layDSHoaDonNhap();
        }
        public IQueryable LayDSHoaDonNhap_TheoMa(string ma)
        {
            return dal_HoaDonNhap.LayDSHoaDonNhap_TheoMa(ma);
        }
        public bool themHoaDonNhap(DTO_HoaDonNhap n)
        {
            return dal_HoaDonNhap.themHoaDonNhap(n);
        }
        public bool xoaHoaDonNhap(string maHDN)
        {
            return dal_HoaDonNhap.xoaHoaDonNhap(maHDN);
        }
        public bool suaHoaDonNhap(DTO_HoaDonNhap n)
        {
            return dal_HoaDonNhap.suaHoaDonNhap(n);
        }
        public bool kiemTraMaHDNCoTonTai(string ma)
        {
            return dal_HoaDonNhap.kiemTraMaHDNCoTonTai(ma);
        }
        public bool kiemTraNPPCoTonTai(string ma)
        {
            return dal_HoaDonNhap.kiemTraNPPCoTonTai(ma);
        }
        public IQueryable LayDSHoaDonNhap_TheoMaNPP(string ma)
        {
          
            return dal_HoaDonNhap.LayDSHoaDonNhap_TheoMaNPP(ma);
        }
        public bool kiemTraMaHDNCoTonTaitrongCTHDN(string ma)
        {
            return dal_HoaDonNhap.kiemTraMaHDNCoTonTaitrongCTHDN(ma);
        }
    }
}
