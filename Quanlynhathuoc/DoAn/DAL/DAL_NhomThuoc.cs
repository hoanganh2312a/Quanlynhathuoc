using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhomThuoc
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_NhomThuoc(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_NhomThuoc()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        public IQueryable layDSNhomThuoc()
        {
            IQueryable nt = from n in db.NhomThuocs
                            select new
                            {
                                MaNhom = n.maNhom,
                                TenNhom = n.tenNhom,
                                GhiChu = n.ghiChu
                            };
            return nt;
        }
        public IQueryable LayDSNhomThuoc_TheoMaNhom(string maNhom)
        {
            IQueryable temp = from t in db.NhomThuocs
                              where t.maNhom == maNhom
                              select new
                              {
                                  MaNhom = t.maNhom,
                                  TenNhom = t.tenNhom,
                                  GhiChu = t.ghiChu
                              };
            return temp;
        }
        public IQueryable LayDSNhomThuoc_TheoTenNhom(string tenNhom)
        {
            IQueryable temp = from t in db.NhomThuocs
                              where t.tenNhom == tenNhom
                              select new
                              {
                                  MaNhom = t.maNhom,
                                  TenNhom = t.tenNhom,
                                  GhiChu = t.ghiChu
                              };
            return temp;
        }
        public bool themNhomThuoc(DTO_NhomThuoc nt)
        {
            bool kq;
            try
            {
                NhomThuoc nhom_insert = new NhomThuoc
                {
                    maNhom = nt.MaNhom,
                    tenNhom = nt.TenNhom,
                    ghiChu = nt.GhiChu
                };
                db.NhomThuocs.InsertOnSubmit(nhom_insert);
                db.SubmitChanges();
                return true;          
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public bool xoaNhomThuoc(string maNhom)
        {
            try
            {
                NhomThuoc nt = db.NhomThuocs.Single(d => d.maNhom == maNhom);
                db.NhomThuocs.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaNhomThuoc(DTO_NhomThuoc nt)
        {
            bool kq = false;
            try
            {
                NhomThuoc nhom = db.NhomThuocs.Single(d => d.maNhom == nt.MaNhom);
                nhom.tenNhom = nt.TenNhom;
                nhom.ghiChu = nt.GhiChu;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool kiemTraMaNTCoTonTaitrongThuoc(string ma)
        {
            var temp = from s in db.Thuocs
                       where s.maNhom == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraMaMNCoTonTai(string ma)
        {
            var temp = from s in db.NhomThuocs
                       where s.maNhom == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            var temp = from s in db.NhomThuocs
                       where s.tenNhom == ma
                       select s;
            return temp.Count() > 0;
        }
    }
}
