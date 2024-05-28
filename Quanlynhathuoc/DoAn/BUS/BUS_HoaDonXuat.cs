using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_HoaDonXuat
    {
        DAL_HoaDonXuat dal_HoaDonXuat = new DAL_HoaDonXuat();
        public IQueryable layDSHoaDonXuat()
        {
            return dal_HoaDonXuat.layDSHoaDonXuat();
        }
        public IQueryable LayDSHoaDonXuat_TheoMa(string ma)
        {
            return dal_HoaDonXuat.LayDSHoaDonXuat_TheoMa(ma);
        }
        public bool themHoaDonXuat(DTO_HoaDonXuat n)
        {
            return dal_HoaDonXuat.themHoaDonXuat(n);
        }
        public bool xoaHoaDonXuat(string maHDX)
        {
            return dal_HoaDonXuat.xoaHoaDonXuat(maHDX);
        }
        public bool suaHoaDonXuat(DTO_HoaDonXuat n)
        {
            return dal_HoaDonXuat.suaHoaDonXuat(n);
        }
        public bool kiemTraMaHDXCoTonTai(string ma)
        {
            return dal_HoaDonXuat.kiemTraMaHDXCoTonTai(ma);
        }
        public bool kiemTraBNCoTonTai(string ma)
        {
            return dal_HoaDonXuat.kiemTraBNCoTonTai(ma);
        }
        public IQueryable LayDSHoaDonXuat_TheoMaBN(string ma)
        {
            return dal_HoaDonXuat.LayDSHoaDonXuat_TheoMaBN(ma);
        }
    }
}
