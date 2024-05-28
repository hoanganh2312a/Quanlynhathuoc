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
    public class BUS_NhaPhanPhoi
    {
        DAL_NhaPhanPhoi dal_NhaPhanPhoi = new DAL_NhaPhanPhoi();
        public IQueryable layDSNhaPhanPhoi()
        {
            return dal_NhaPhanPhoi.layDSNhaPhanPhoi();
        }
        public IQueryable LayDSNhaPhanPhoi_TheoMa(string ma)
        {
            return dal_NhaPhanPhoi.LayDSNhaPhanPhoi_TheoMa(ma);
        }
        public bool themNhaPhanPhoi(DTO_NhaPhanPhoi nt)
        {
            return dal_NhaPhanPhoi.themNhaPhanPhoi(nt);
        }
        public bool xoaNhaPhanPhoi(string maNPP)
        {
            return dal_NhaPhanPhoi.xoaNhaPhanPhoi(maNPP);
        }
        public bool suaNhaPhanPhoi(DTO_NhaPhanPhoi nt)
        {
            return dal_NhaPhanPhoi.suaNhaPhanPhoi(nt);
        }
        public bool kiemTraMaNPPCoTonTaitrongHDN(string ma)
        {
            return dal_NhaPhanPhoi.kiemTraMaNPPCoTonTaitrongHDN(ma);
        }
        public bool kiemTraMaNPPCoTonTai(string ma)
        {
            return dal_NhaPhanPhoi.kiemTraMaNPPCoTonTai(ma);
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            return dal_NhaPhanPhoi.kiemTraTenCoTonTai(ma);
        }
        public IQueryable LayDSNhaPhanPhoi_TheoTen(string ma)
        {
            return dal_NhaPhanPhoi.LayDSNhaPhanPhoi_TheoTen(ma);
        }
    }
}
