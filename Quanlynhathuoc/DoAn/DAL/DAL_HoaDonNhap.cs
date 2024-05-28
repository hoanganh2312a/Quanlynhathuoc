using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDonNhap
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_HoaDonNhap(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_HoaDonNhap()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }


        public IQueryable layDSHoaDonNhap()
        {
            IQueryable nt = from n in db.HoaDonNhaps
                            select new
                            {
                                maHDN = n.maHDN,
                                maNPP = n.maNPP,
                                nguoiGiao= n.nguoiGiao,
                                nguoiNhan = n.nguoiNhan,
                                tongTienThuoc = n.tongTienThuoc,
                                tongThue = n.tongThue,
                                tongTienHD = n.tongTienHD,
                                ngayViet = n.ngayViet,
                                ngayNhap = n.ngayNhap,
                            };
            return nt;
        }
        public IQueryable LayDSHoaDonNhap_TheoMa(string ma)
        {
            IQueryable temp = from n in db.HoaDonNhaps
                              where n.maHDN == ma
                              select new
                              {
                                  maHDN = n.maHDN,
                                  maNPP = n.maNPP,
                                  nguoiGiao = n.nguoiGiao,
                                  nguoiNhan = n.nguoiNhan,
                                  tongTienThuoc = n.tongTienThuoc,
                                  tongThue = n.tongThue,
                                  tongTienHD = n.tongTienHD,
                                  ngayViet = n.ngayViet,
                                  ngayNhap = n.ngayNhap,
                              };
            return temp;
        }
        public IQueryable LayDSHoaDonNhap_TheoMaNPP(string ma)
        {
            IQueryable temp = from n in db.HoaDonNhaps
                              where n.maNPP == ma
                              select new
                              {
                                  maHDN = n.maHDN,
                                  maNPP = n.maNPP,
                                  nguoiGiao = n.nguoiGiao,
                                  nguoiNhan = n.nguoiNhan,
                                  tongTienThuoc = n.tongTienThuoc,
                                  tongThue = n.tongThue,
                                  tongTienHD = n.tongTienHD,
                                  ngayViet = n.ngayViet,
                                  ngayNhap = n.ngayNhap,
                              };
            return temp;
        }
        public bool themHoaDonNhap(DTO_HoaDonNhap n)
        {
            bool kq;
            try
            {
                HoaDonNhap HDN_insert = new HoaDonNhap
                {
                    maHDN = n.MaHDN,
                    maNPP = n.MaNPP,
                    nguoiGiao = n.NguoiGiao,
                    nguoiNhan = n.NguoiNhan,
                    tongTienThuoc = n.TongTienThuoc,
                    tongThue = n.TongThue,
                    tongTienHD = n.TongTienHD,
                    ngayViet = n.NgayViet,
                    ngayNhap = n.NgayNhap
                };
                db.HoaDonNhaps.InsertOnSubmit(HDN_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public bool xoaHoaDonNhap(string maHDN)
        {
            try
            {
                HoaDonNhap nt = db.HoaDonNhaps.Single(d => d.maHDN == maHDN);
                db.HoaDonNhaps.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaHoaDonNhap(DTO_HoaDonNhap n)
        {
            bool kq = false;
            try
            {
                HoaDonNhap HDN = db.HoaDonNhaps.Single(d => d.maHDN == n.MaHDN);
                HDN.maNPP = n.MaNPP;
                HDN.nguoiGiao = n.NguoiGiao;
                HDN.nguoiNhan = n.NguoiNhan;
                HDN.tongTienThuoc = n.TongTienThuoc;
                HDN.tongThue = n.TongThue;
                HDN.tongTienHD = n.TongTienHD;
                HDN.ngayViet = n.NgayViet;
                HDN.ngayNhap = n.NgayNhap;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool kiemTraMaHDNCoTonTaitrongCTHDN(string ma)
        {
            var temp = from s in db.chiTietHoaDonNhaps
                       where s.maHDN == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraMaHDNCoTonTai(string ma)
        {
            var temp = from s in db.HoaDonNhaps
                       where s.maHDN == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraNPPCoTonTai(string ma)
        {
            var temp = from s in db.HoaDonNhaps
                       where s.maNPP == ma
                       select s;
            return temp.Count() > 0;
        }
    }
}
