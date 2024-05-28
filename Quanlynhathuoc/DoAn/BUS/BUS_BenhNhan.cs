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
    public class BUS_BenhNhan
    {
        DAL_BenhNhan dal_BenhNhan = new DAL_BenhNhan();
        public IQueryable layDSBenhNhan()
        {
            return dal_BenhNhan.layDSBenhNhan();
        }
        public IQueryable LayDSBenhNhan_TheoMa(string ma)
        {
            return dal_BenhNhan.LayDSBenhNhan_TheoMa(ma);
        }
        public IQueryable LayDSBenhNhan_TheoTen(string ma)
        {
            return dal_BenhNhan.LayDSBenhNhan_TheoTen(ma);
        }
        public bool themBenhNhan(DTO_BenhNhan nt)
        {
            return dal_BenhNhan.themBenhNhan(nt);
        }
        public bool xoaBenhNhan(string idBenhNhan)
        {
            return dal_BenhNhan.xoaBenhNhan(idBenhNhan);
        }
        public bool suaBenhNhan(DTO_BenhNhan nt)
        {
            return dal_BenhNhan.suaBenhNhan(nt);
        }
        public bool kiemTraMaBNCoTonTaitrongHDX(string ma)
        {
            return dal_BenhNhan.kiemTraMaBNCoTonTaitrongHDX(ma);
        }
        public bool kiemTraMaBNCoTonTai(string ma)
        {
            return dal_BenhNhan.kiemTraMaBNCoTonTai(ma);
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            return dal_BenhNhan.kiemTraTenCoTonTai(ma);
        }
    }
}
