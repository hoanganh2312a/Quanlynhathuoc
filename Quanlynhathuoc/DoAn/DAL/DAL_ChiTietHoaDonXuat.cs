using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietHoaDonXuat
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_ChiTietHoaDonXuat(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_ChiTietHoaDonXuat()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }


        public IQueryable layDSChiTietHoaDonXuat()
        {
            IQueryable nt = from n in db.chiTietHoaDonXuats
                            select new
                            {
                                maCTHDX = n.maCTHDX,
                                maHDX = n.maHDX,
                                idThuoc = n.idThuoc,
                                soLuong = n.soLuong,
                                giaBan = n.giaBan,
                                thue = n.thue,
                                donVi = n.donVi
                            };
            return nt;
        }
        public bool kiemTraMaHDXCoTonTai(string ma)
        {
            var temp = from s in db.chiTietHoaDonXuats
                       where s.maHDX == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraMaCoTonTai(string ma)
        {
            var temp = from s in db.chiTietHoaDonXuats
                       where s.maCTHDX == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool xoaChiTietHoaDonXuatTheoMaHDN(string maHDX)
        {
            try
            {
                chiTietHoaDonXuat nt = db.chiTietHoaDonXuats.Single(d => d.maHDX == maHDX);
                db.chiTietHoaDonXuats.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public IQueryable LayDSChiTietHoaDonXuat_TheoMa(string ma)
        {
            IQueryable temp = from n in db.chiTietHoaDonXuats
                              where n.maCTHDX == ma
                              select new
                              {
                                  maCTHDX = n.maCTHDX,
                                  maHDX = n.maHDX,
                                  idThuoc = n.idThuoc,
                                  soLuong = n.soLuong,
                                  giaBan = n.giaBan,
                                  thue = n.thue,
                                  donVi = n.donVi
                              };
            return temp;
        }
        public IQueryable LayDSChiTietHoaDonXuat_TheoMaHDX(string ma)
        {
            IQueryable temp = from n in db.chiTietHoaDonXuats
                              where n.maHDX == ma
                              select new
                              {
                                  maCTHDX = n.maCTHDX,
                                  maHDX = n.maHDX,
                                  idThuoc = n.idThuoc,
                                  soLuong = n.soLuong,
                                  giaBan = n.giaBan,
                                  thue = n.thue,
                                  donVi = n.donVi
                              };
            return temp;
        }
        public bool themChiTietHoaDonXuat(DTO_ChiTietHoaDonXuat n)
        {
            bool kq;
            try
            {
                chiTietHoaDonXuat CTHDX_insert = new chiTietHoaDonXuat
                {
                    maCTHDX = n.MaCTHDX,
                    maHDX = n.MaHDX,
                    idThuoc = n.IdThuoc,
                    soLuong = n.SoLuong,
                    giaBan = n.GiaBan,
                    thue = n.Thue,
                    donVi = n.DonVi
                };
                db.chiTietHoaDonXuats.InsertOnSubmit(CTHDX_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public bool xoaChiTietHoaDonXuat(string maCTHDX)
        {
            try
            {
                chiTietHoaDonXuat nt = db.chiTietHoaDonXuats.Single(d => d.maCTHDX == maCTHDX);
                db.chiTietHoaDonXuats.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaChiTietHoaDonXuat(DTO_ChiTietHoaDonXuat n)
        {
            bool kq = false;
            try
            {
                chiTietHoaDonXuat CTHDX = db.chiTietHoaDonXuats.Single(d => d.maCTHDX == n.MaCTHDX);
                CTHDX.maCTHDX = n.MaCTHDX;
                CTHDX.maHDX = n.MaCTHDX;
                CTHDX.idThuoc = n.IdThuoc;
                CTHDX.soLuong = n.SoLuong;
                CTHDX.giaBan = n.GiaBan;
                CTHDX.thue = n.Thue;
                CTHDX.donVi = n.DonVi;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool xoaChiTietHoaDonXuatTheoMaHDX(string maHDX)
        {
            try
            {
                chiTietHoaDonXuat nt = db.chiTietHoaDonXuats.Single(d => d.maHDX == maHDX);
                db.chiTietHoaDonXuats.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
