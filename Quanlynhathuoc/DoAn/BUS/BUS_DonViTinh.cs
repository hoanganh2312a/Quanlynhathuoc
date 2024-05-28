using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_DonViTinh
    {
        DAL_DonViTinh dal_DonViTinh = new DAL_DonViTinh();
        public IQueryable layDSDonViTinh()
        {
            return dal_DonViTinh.layDSDonViTinh();
        }
        public bool themDonViTinh(DTO_DonViTinh nt)
        {
            return dal_DonViTinh.themDonViTinh(nt);
        }
        public bool xoaDonViTinh(string maDVT)
        {
            return dal_DonViTinh.xoaDonViTinh(maDVT);
        }
        public bool suaDonViTinh(DTO_DonViTinh nt)
        {
            return dal_DonViTinh.suaDonViTinh(nt);
        }
        public IQueryable LayDSDonViTinh_TheoMa(string ma)
        {
            return dal_DonViTinh.LayDSDonViTinh_TheoMa(ma);
        }
        public IQueryable LayDSDonViTinh_TheoTen(string ten)
        {
            return dal_DonViTinh.LayDSDonViTinh_TheoTen(ten);
        }
        public bool kiemTraMaDVTCoTonTai(string ma)
        {
            return dal_DonViTinh.kiemTraMaDVTCoTonTai(ma);
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            return dal_DonViTinh.kiemTraTenCoTonTai(ma);
        }
    }
}
