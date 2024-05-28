using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Thuoc
    {
        DAL_Thuoc DAL_Thuoc= new DAL_Thuoc();
        public IQueryable layDSThuoc()
        {
            return DAL_Thuoc.layDSThuoc();
        }
        public bool ThemThuoc(DTO_Thuoc t)
        {                   
            return DAL_Thuoc.ThemThuoc(t);
        }
        public bool xoaThuoc(string idThuoc)
        {
            return DAL_Thuoc.xoaThuoc(idThuoc);
        }
        public bool SuaThuoc(DTO_Thuoc t)
        {          
            return DAL_Thuoc.SuaThuoc(t);
        }
        public bool kiemTraMaThuocCoTonTai(string ma)
        {
            return DAL_Thuoc.kiemTraMaThuocCoTonTai(ma);
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            return DAL_Thuoc.kiemTraTenCoTonTai(ma);
        }
        public IQueryable LayDSThuoc_TheoMaSP(string idThuoc)
        {
            return DAL_Thuoc.LayDSThuoc_TheoMaSP(idThuoc);
        }
        public IQueryable LayDSThuoc_TheoTenSP(string idThuoc)
        {
            return DAL_Thuoc.LayDSThuoc_TheoTenSP(idThuoc);
        }
        public bool SuaThuocNhapHang(string idthuoc, int sl)
        {
            return DAL_Thuoc.SuaThuocNhapHang(idthuoc,sl);
        }
        public bool SuaThuocXuatHang(string idthuoc, int sl)
        {
            return  DAL_Thuoc.SuaThuocXuatHang(idthuoc, sl);
        }
    }
}
