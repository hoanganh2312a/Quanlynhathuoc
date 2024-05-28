using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_NhomThuoc
    {
        DAL_NhomThuoc dal_NhomThuoc = new DAL_NhomThuoc();
        public IQueryable layDSNhomThuoc()
        {
            return dal_NhomThuoc.layDSNhomThuoc();
        }
        public bool themNhomThuoc(DTO_NhomThuoc nt)
        {
            return dal_NhomThuoc.themNhomThuoc(nt);
        }
        public bool xoaNhomThuoc(string maNhom)
        {
            return dal_NhomThuoc.xoaNhomThuoc(maNhom);
        }
        public bool suaNhomThuoc(DTO_NhomThuoc nt)
        {
            return dal_NhomThuoc.suaNhomThuoc(nt);
        }
        public IQueryable LayDSNhomThuoc_TheoMaNhom(string maNhom)
        {
            return dal_NhomThuoc.LayDSNhomThuoc_TheoMaNhom(maNhom);
        }
        public IQueryable LayDSNhomThuoc_TheoTenNhom(string tenNhom)
        {
            return dal_NhomThuoc.LayDSNhomThuoc_TheoTenNhom(tenNhom);
        }
        public bool kiemTraMaNTCoTonTaitrongThuoc(string ma)
        {
            return dal_NhomThuoc.kiemTraMaNTCoTonTaitrongThuoc(ma);
        }
        public bool kiemTraMaMNCoTonTai(string ma)
        {
            return dal_NhomThuoc.kiemTraMaMNCoTonTai(ma);
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            return dal_NhomThuoc.kiemTraTenCoTonTai(ma);
        }
    }
}
