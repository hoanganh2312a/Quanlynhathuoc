using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BenhNhan
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_BenhNhan(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_BenhNhan()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        public IQueryable layDSBenhNhan()
        {
            IQueryable nt = from n in db.BenhNhans
                            select new
                            {
                                IDBN = n.idBN,
                                hoTen= n.hoTen,
                                tuoi = n.tuoi,
                                diaChi = n.diaChi,
                                dienThoai = n.dienThoai
                            };
            return nt;
        }
        public IQueryable LayDSBenhNhan_TheoMa(string ma)
        {
            IQueryable temp = from n in db.BenhNhans
                              where n.idBN == ma
                              select new
                              {
                                  IDBN = n.idBN,
                                  hoTen = n.hoTen,
                                  tuoi = n.tuoi,
                                  diaChi = n.diaChi,
                                  dienThoai = n.dienThoai
                              };
            return temp;
        }
        public IQueryable LayDSBenhNhan_TheoTen(string ma)
        {
            IQueryable temp = from n in db.BenhNhans
                              where n.hoTen == ma
                              select new
                              {
                                  IDBN = n.idBN,
                                  hoTen = n.hoTen,
                                  tuoi = n.tuoi,
                                  diaChi = n.diaChi,
                                  dienThoai = n.dienThoai
                              };
            return temp;
        }
        public bool themBenhNhan(DTO_BenhNhan nt)
        {
            bool kq;
            try
            {
                BenhNhan BN_insert = new BenhNhan
                {
                    idBN = nt.IdBN,
                    hoTen = nt.HoTen,
                    tuoi = nt.Tuoi,
                    diaChi = nt.DiaChi,
                    dienThoai = nt.DienThoai
                };
                db.BenhNhans.InsertOnSubmit(BN_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public bool xoaBenhNhan(string idBenhNhan)
        {
            try
            {
                BenhNhan nt = db.BenhNhans.Single(d => d.idBN == idBenhNhan);
                db.BenhNhans.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaBenhNhan(DTO_BenhNhan nt)
        {
            bool kq = false;
            try
            {
                BenhNhan BN = db.BenhNhans.Single(d => d.idBN == nt.IdBN);
                BN.hoTen = nt.HoTen;
                BN.tuoi = nt.Tuoi;
                BN.diaChi = nt.DiaChi;
                BN.dienThoai = nt.DienThoai;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool kiemTraMaBNCoTonTaitrongHDX(string ma)
        {
            var temp = from s in db.HoaDonXuats
                       where s.idBN == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraMaBNCoTonTai(string ma)
        {
            var temp = from s in db.BenhNhans
                       where s.idBN == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            var temp = from s in db.BenhNhans
                       where s.hoTen == ma
                       select s;
            return temp.Count() > 0;
        }
    }
}
