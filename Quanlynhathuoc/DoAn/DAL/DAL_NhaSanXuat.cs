using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaSanXuat
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_NhaSanXuat(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_NhaSanXuat()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        public IQueryable layDNhaSanXuat()
        {
            IQueryable nt = from n in db.NhaSanXuats
                            select new
                            {
                                MaNSX = n.maNSX,
                                TenNSX = n.tenNSX,
                                DiaChi = n.diaChi,
                                DienThoai = n.dienThoai,
                                Email = n.email
                            };
            return nt;
        }
        public IQueryable LayDSNhaSanXuat_TheoMa(string ma)
        {
            IQueryable temp = from n in db.NhaSanXuats
                              where n.maNSX == ma
                              select new
                              {
                                  MaNSX = n.maNSX,
                                  TenNSX = n.tenNSX,
                                  DiaChi = n.diaChi,
                                  DienThoai = n.dienThoai,
                                  Email = n.email
                              };
            return temp;
        }
        public IQueryable LayDSNhomThuoc_TheoTen(string ten)
        {
            IQueryable temp = from n in db.NhaSanXuats
                              where n.tenNSX == ten
                              select new
                              {
                                  MaNSX = n.maNSX,
                                  TenNSX = n.tenNSX,
                                  DiaChi = n.diaChi,
                                  DienThoai = n.dienThoai,
                                  Email = n.email
                              };
            return temp;
        }
        public bool themNhaSanXuat(DTO_NhaSanXuat nt)
        {
            bool kq;
            try
            {
                NhaSanXuat NSX_insert = new NhaSanXuat
                {
                    maNSX = nt.MaNSX,
                    tenNSX = nt.TenNSX,
                    diaChi = nt.DiaChi,
                    dienThoai = nt.DienThoai,
                    email = nt.Email
                };
                db.NhaSanXuats.InsertOnSubmit(NSX_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public bool xoaNhaSanXuat(string maNSX)
        {
            try
            {
                NhaSanXuat nt = db.NhaSanXuats.Single(d => d.maNSX == maNSX);
                db.NhaSanXuats.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaNhaSanXuat(DTO_NhaSanXuat nt)
        {
            bool kq = false;
            try
            {
                NhaSanXuat NSX = db.NhaSanXuats.Single(d => d.maNSX == nt.MaNSX);
                NSX.tenNSX = nt.TenNSX;
                NSX.diaChi = nt.DiaChi;
                NSX.dienThoai = nt.DienThoai;
                NSX.email = nt.Email;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool kiemTraMaNSXCoTonTaitrongThuoc(string ma)
        {
            var temp = from s in db.Thuocs
                       where s.maNSX == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraMaNSXCoTonTai(string ma)
        {
            var temp = from s in db.NhaSanXuats
                       where s.maNSX == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            var temp = from s in db.NhaSanXuats
                       where s.tenNSX == ma
                       select s;
            return temp.Count() > 0;
        }
    }
}
