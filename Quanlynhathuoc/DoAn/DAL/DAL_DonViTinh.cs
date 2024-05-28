using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_DonViTinh
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_DonViTinh(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_DonViTinh()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        public IQueryable layDSDonViTinh()
        {
            IQueryable nt = from n in db.DonViTinhs
            select new
                            {
                                maDVT = n.maDVT,
                                tenDVT = n.tenDVT
                            };
            return nt;
        }
        public IQueryable LayDSDonViTinh_TheoMa(string ma)
        {
            IQueryable temp = from n in db.DonViTinhs
                              where n.maDVT == ma
                              select new
                              {
                                  maDVT = n.maDVT,
                                  tenDVT = n.tenDVT
                              };
            return temp;
        }
        public IQueryable LayDSDonViTinh_TheoTen(string ten)
        {
            IQueryable temp = from n in db.DonViTinhs
                              where n.tenDVT == ten
                              select new
                              {
                                  maDVT = n.maDVT,
                                  tenDVT = n.tenDVT
                              };
            return temp;
        }
        public bool themDonViTinh(DTO_DonViTinh nt)
        {
            bool kq;
            try
            {
                DonViTinh DVT_insert = new DonViTinh
                {
                    maDVT = nt.MaDVT,
                    tenDVT = nt.TenDVT
                };
                db.DonViTinhs.InsertOnSubmit(DVT_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public bool xoaDonViTinh(string maDVT)
        {
            try
            {
                DonViTinh nt = db.DonViTinhs.Single(d => d.maDVT == maDVT);
                db.DonViTinhs.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaDonViTinh(DTO_DonViTinh nt)
        {
            bool kq = false;
            try
            {
                DonViTinh DVT = db.DonViTinhs.Single(d => d.maDVT == nt.MaDVT);
                DVT.tenDVT = nt.TenDVT;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool kiemTraMaDVTCoTonTai(string ma)
        {
            var temp = from s in db.DonViTinhs
                       where s.maDVT == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            var temp = from s in db.DonViTinhs
                       where s.tenDVT == ma
                       select s;
            return temp.Count() > 0;
        }
    }
}
