using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HoaDonXuat
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_HoaDonXuat(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_HoaDonXuat()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }


        public IQueryable layDSHoaDonXuat()
        {
            IQueryable nt = from n in db.HoaDonXuats
                            select new
                            {
                                MaHDX = n.maHDX,
                                BenhNhan = n.idBN,
                                TongTienThuoc = n.tongTienThuoc,
                                NgayLap = n.ngayLap,
                                TongThue = n.tongThue,
                                TongTienHD = n.tongTienHD,
                            };
            return nt;
        }
        public IQueryable LayDSHoaDonXuat_TheoMa(string ma)
        {
            IQueryable temp = from n in db.HoaDonXuats
                              where n.maHDX == ma
                              select new
                              {
                                  MaHDX = n.maHDX,
                                  IDBenhNhan = n.idBN,
                                  TongTienThuoc = n.tongTienThuoc,
                                  NgayLap = n.ngayLap,
                                  TongThue = n.tongThue,
                                  TongTienHD = n.tongTienHD,
                              };
            return temp;
        }
        public IQueryable LayDSHoaDonXuat_TheoMaBN(string ma)
        {
            IQueryable temp = from n in db.HoaDonXuats
                              where n.idBN == ma
                              select new
                              {
                                  MaHDX = n.maHDX,
                                  IDBenhNhan = n.idBN,
                                  TongTienThuoc = n.tongTienThuoc,
                                  NgayLap = n.ngayLap,
                                  TongThue = n.tongThue,
                                  TongTienHD = n.tongTienHD,
                              };
            return temp;
        }
        public bool themHoaDonXuat(DTO_HoaDonXuat n)
        {
            bool kq;
            try
            {
                HoaDonXuat HDX_insert = new HoaDonXuat
                {
                    maHDX = n.MaHDX,
                    idBN = n.IdBN,
                    tongTienThuoc = n.TongTienThuoc,
                    ngayLap = n.NgayLap,
                    tongThue = n.TongThue,
                    tongTienHD = n.TongTienHD
                };
                db.HoaDonXuats.InsertOnSubmit(HDX_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public bool xoaHoaDonXuat(string maHDX)
        {
            try
            {
                HoaDonXuat nt = db.HoaDonXuats.Single(d => d.maHDX == maHDX);
                db.HoaDonXuats.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaHoaDonXuat(DTO_HoaDonXuat n)
        {
            bool kq = false;
            try
            {
                HoaDonXuat HDN = db.HoaDonXuats.Single(d => d.maHDX == n.MaHDX);
                HDN.maHDX = n.MaHDX;
                HDN.idBN = n.IdBN;
                HDN.tongTienThuoc = n.TongTienThuoc;
                HDN.ngayLap = n.NgayLap;
                HDN.tongThue = n.TongThue;
                HDN.tongTienHD = n.TongTienHD;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool kiemTraMaHDXCoTonTai(string ma)
        {
            var temp = from s in db.HoaDonXuats
                       where s.maHDX == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraBNCoTonTai(string ma)
        {
            var temp = from s in db.HoaDonXuats
                       where s.idBN == ma
                       select s;
            return temp.Count() > 0;
        }
    }
}
