using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_NhaSanXuat
    {
        DAL_NhaSanXuat dal_NhaSanXuat = new DAL_NhaSanXuat();
        public IQueryable layDNhaSanXuat()
        {
            return dal_NhaSanXuat.layDNhaSanXuat();
        }
        public bool themNhaSanXuat(DTO_NhaSanXuat nt)
        {
            return dal_NhaSanXuat.themNhaSanXuat(nt);
        }
        public bool xoaNhaSanXuat(string maNSX)
        {
            return dal_NhaSanXuat.xoaNhaSanXuat(maNSX);
        }
        public bool suaNhaSanXuat(DTO_NhaSanXuat nt)
        {
            return dal_NhaSanXuat.suaNhaSanXuat(nt);
        }
        public IQueryable LayDSNhaSanXuat_TheoMa(string ma)
        {
            return dal_NhaSanXuat.LayDSNhaSanXuat_TheoMa(ma);
        }
        public IQueryable LayDSNhomThuoc_TheoTen(string ten)
        {
            return dal_NhaSanXuat.LayDSNhomThuoc_TheoTen(ten);
        }
        public bool kiemTraMaNSXCoTonTaitrongThuoc(string ma)
        {
            return dal_NhaSanXuat.kiemTraMaNSXCoTonTaitrongThuoc(ma);
        }
        public bool kiemTraMaNSXCoTonTai(string ma)
        {
            return dal_NhaSanXuat.kiemTraMaNSXCoTonTai(ma);
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            return dal_NhaSanXuat.kiemTraTenCoTonTai(ma);
        }
    }
}
