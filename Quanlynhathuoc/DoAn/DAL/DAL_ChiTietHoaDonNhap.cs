using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_ChiTietHoaDonNhap
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_ChiTietHoaDonNhap(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_ChiTietHoaDonNhap()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }


        public IQueryable layDSChiTietHoaDonNhap()
        {
            IQueryable nt = from n in db.chiTietHoaDonNhaps
                            select new
                            {
                                maCTHDN = n.maCTHDN,
                                maHDN = n.maHDN,
                                idThuoc = n.idThuoc,
                                soLuong = n.soLuong,
                                giaNhap = n.giaNhap
                            };
            return nt;
        }
        public IQueryable LayDSChiTietHoaDonNhap_TheoMaHDN(string ma)
        {
            IQueryable temp = from n in db.chiTietHoaDonNhaps
                              where n.maHDN == ma
                              select new
                              {
                                  maCTHDN = n.maCTHDN,
                                  maHDN = n.maHDN,
                                  idThuoc = n.idThuoc,
                                  soLuong = n.soLuong,
                                  giaNhap = n.giaNhap
                              };
            return temp;
        }
        public bool kiemTraMaHDNCoTonTai(string ma)
        {
            var temp = from s in db.chiTietHoaDonNhaps
                       where s.maHDN == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraMaCoTonTai(string ma)
        {
            var temp = from s in db.chiTietHoaDonNhaps
                       where s.maCTHDN == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool themChiTietHoaDonNhap(DTO_ChiTietHoaDonNhap n)
        {
            bool kq;
            try
            {
                chiTietHoaDonNhap HDN_insert = new chiTietHoaDonNhap
                {
                    maCTHDN = n.MaCTHDN,
                    maHDN = n.MaHDN,
                    idThuoc = n.IdThuoc,
                    soLuong = n.SoLuong,
                    giaNhap = n.GiaNhap
                };
                db.chiTietHoaDonNhaps.InsertOnSubmit(HDN_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool xoaChiTietHoaDonNhapTheoMaHDN(string maHDN)
        {
            try
            {
                chiTietHoaDonNhap nt = db.chiTietHoaDonNhaps.Single(d => d.maHDN == maHDN);
                db.chiTietHoaDonNhaps.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool xoaChiTietHoaDonNhap(string maCTHDN)
        {
            try
            {
                chiTietHoaDonNhap nt = db.chiTietHoaDonNhaps.Single(d => d.maCTHDN == maCTHDN);
                db.chiTietHoaDonNhaps.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaChiTietHoaDonNhap(DTO_ChiTietHoaDonNhap n)
        {
            bool kq = false;
            try
            {
                chiTietHoaDonNhap CTHDN = db.chiTietHoaDonNhaps.Single(d => d.maCTHDN == n.MaCTHDN);
                CTHDN.maHDN = n.MaHDN;
                CTHDN.idThuoc = n.IdThuoc;
                CTHDN.soLuong = n.SoLuong;
                CTHDN.giaNhap = n.GiaNhap;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
    }
}
