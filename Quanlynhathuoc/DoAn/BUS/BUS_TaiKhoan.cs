using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dal_TaiKhoan = new DAL_TaiKhoan();
        public IQueryable layDSTaiKhoan()
        {
            return dal_TaiKhoan.layDSTaiKhoan();
        }
        public IQueryable LayDSTaiKhoan_TheoMa(string ma)
        {
            return dal_TaiKhoan.LayDSTaiKhoan_TheoMa(ma);
        }
        public bool themTaiKhoan(DTO_TAIKHOAN n)
        {
            return dal_TaiKhoan.themTaiKhoan(n);
        }
        public bool xoaTaiKhoan(string TK)
        {
            return dal_TaiKhoan.xoaTaiKhoan(TK);
        }
        public bool suaTaiKhoan(DTO_TAIKHOAN n)
        {
            return dal_TaiKhoan.suaTaiKhoan(n);
        }
        public bool CheckTaiKhoan(string taiKhoan, string matKhau, string chucVu)
        {
            return dal_TaiKhoan.CheckTaiKhoan(taiKhoan,matKhau,chucVu);
        }
        public IQueryable LayDSTaiKhoan_TheoTen(string ma)
        {
            return dal_TaiKhoan.LayDSTaiKhoan_TheoTen(ma);
        }
        public bool kiemTraTKCoTonTai(string ma)
        {
            return dal_TaiKhoan.kiemTraTKCoTonTai(ma);
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            return dal_TaiKhoan.kiemTraTenCoTonTai(ma);
        }
    }
}
