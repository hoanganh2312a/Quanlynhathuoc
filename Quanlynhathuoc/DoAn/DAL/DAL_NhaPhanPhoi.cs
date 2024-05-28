using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaPhanPhoi
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_NhaPhanPhoi(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_NhaPhanPhoi()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        public IQueryable layDSNhaPhanPhoi()
        {
            IQueryable nt = from n in db.NhaPhanPhois
                            select new
                            {
                                maNPP = n.maNPP,
                                tenNPP = n.tenNPP,
                                diaChi = n.diaChi,
                                dienThoai = n.dienThoai,
                                email = n.email,
                                maSoThue = n.maSoThue,
                                ghiChu = n.ghiChu
                            };
            return nt;
        }
        public IQueryable LayDSNhaPhanPhoi_TheoMa(string ma)
        {
            IQueryable temp = from n in db.NhaPhanPhois
                              where n.maNPP == ma
                              select new
                              {
                                  maNPP = n.maNPP,
                                  tenNPP = n.tenNPP,
                                  diaChi = n.diaChi,
                                  dienThoai = n.dienThoai,
                                  email = n.email,
                                  maSoThue = n.maSoThue,
                                  ghiChu = n.ghiChu
                              };
            return temp;
        }
        public IQueryable LayDSNhaPhanPhoi_TheoTen(string ma)
        {
            IQueryable temp = from n in db.NhaPhanPhois
                              where n.tenNPP == ma
                              select new
                              {
                                  maNPP = n.maNPP,
                                  tenNPP = n.tenNPP,
                                  diaChi = n.diaChi,
                                  dienThoai = n.dienThoai,
                                  email = n.email,
                                  maSoThue = n.maSoThue,
                                  ghiChu = n.ghiChu
                              };
            return temp;
        }
        public bool themNhaPhanPhoi(DTO_NhaPhanPhoi nt)
        {
            bool kq;
            try
            {
                NhaPhanPhoi NPP_insert = new NhaPhanPhoi
                {
                    maNPP = nt.MaNPP,
                    tenNPP = nt.TenNPP,
                    diaChi = nt.DiaChi,
                    dienThoai = nt.DienThoai,
                    email = nt.Email,
                    maSoThue = nt.MaSoThue,
                    ghiChu = nt.GhiChu
                };
                db.NhaPhanPhois.InsertOnSubmit(NPP_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public bool xoaNhaPhanPhoi(string maNPP)
        {
            try
            {
                NhaPhanPhoi nt = db.NhaPhanPhois.Single(d => d.maNPP == maNPP);
                db.NhaPhanPhois.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaNhaPhanPhoi(DTO_NhaPhanPhoi nt)
        {
            bool kq = false;
            try
            {
                NhaPhanPhoi DVT = db.NhaPhanPhois.Single(d => d.maNPP == nt.MaNPP);
                DVT.tenNPP = nt.TenNPP;
                DVT.diaChi = nt.DiaChi;
                DVT.dienThoai= nt.DienThoai;
                DVT.email = nt.Email;
                DVT.maSoThue = nt.MaSoThue;
                DVT.ghiChu = nt.GhiChu;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool kiemTraMaNPPCoTonTaitrongHDN(string ma)
        {
            var temp = from s in db.HoaDonNhaps
                       where s.maNPP == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraMaNPPCoTonTai(string ma)
        {
            var temp = from s in db.NhaPhanPhois
                       where s.maNPP == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            var temp = from s in db.NhaPhanPhois
                       where s.tenNPP == ma
                       select s;
            return temp.Count() > 0;
        }
    }
}
