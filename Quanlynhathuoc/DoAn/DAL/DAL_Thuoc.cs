using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Thuoc
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_Thuoc(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_Thuoc()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }

        public IQueryable layDSThuoc()
        {
            IQueryable thuoc = from t in db.Thuocs
                               select new
                               {
                                   ID = t.iDThuoc,
                                   MaThuoc = t.maThuoc,
                                   tenThuoc = t.tenThuoc,
                                   maNhom = t.maNhom,
                                   nguonGoc = t.nguonGoc,
                                   maNSX = t.maNSX,
                                   soLuong = t.soLuong,
                                   giaBan = t.giaBan,
                                   maDVT = t.maDVT,
                                   thanhPhan = t.thanhPhan,
                                   hamluong = t.hamluong,
                                   congDung = t.congDung,
                                   phanTacDung = t.phanTacDung,
                                   cachDung = t.cachDung,
                                   chuY = t.chuY,
                                   hanSuDung = t.hanSuDung,
                                   baoQuan = t.baoQuan,
                                   dangBaoChe = t.dangBaoChe
                               };
            return thuoc;
        }
        public IQueryable LayDSThuoc_TheoMaSP(string idThuoc)
        {
            IQueryable temp = from t in db.Thuocs
                              where t.iDThuoc == idThuoc
                              select new
                              {
                                  ID = t.iDThuoc,
                                  MaThuoc = t.maThuoc,
                                  tenThuoc = t.tenThuoc,
                                  maNhom = t.maNhom,
                                  nguonGoc = t.nguonGoc,
                                  maNSX = t.maNSX,
                                  soLuong = t.soLuong,
                                  giaBan = t.giaBan,
                                  maDVT = t.maDVT,
                                  thanhPhan = t.thanhPhan,
                                  hamluong = t.hamluong,
                                  congDung = t.congDung,
                                  phanTacDung = t.phanTacDung,
                                  cachDung = t.cachDung,
                                  chuY = t.chuY,
                                  hanSuDung = t.hanSuDung,
                                  baoQuan = t.baoQuan,
                                  dangBaoChe = t.dangBaoChe
                              };
            return temp;
        }
        public IQueryable LayDSThuoc_TheoTenSP(string idThuoc)
        {
            IQueryable temp = from t in db.Thuocs
                              where t.tenThuoc == idThuoc
                              select new
                              {
                                  ID = t.iDThuoc,
                                  MaThuoc = t.maThuoc,
                                  tenThuoc = t.tenThuoc,
                                  maNhom = t.maNhom,
                                  nguonGoc = t.nguonGoc,
                                  maNSX = t.maNSX,
                                  soLuong = t.soLuong,
                                  giaBan = t.giaBan,
                                  maDVT = t.maDVT,
                                  thanhPhan = t.thanhPhan,
                                  hamluong = t.hamluong,
                                  congDung = t.congDung,
                                  phanTacDung = t.phanTacDung,
                                  cachDung = t.cachDung,
                                  chuY = t.chuY,
                                  hanSuDung = t.hanSuDung,
                                  baoQuan = t.baoQuan,
                                  dangBaoChe = t.dangBaoChe
                              };
            return temp;
        }
        public bool ThemThuoc(DTO_Thuoc t)
        {
            try
            {

                Thuoc t_insert = new Thuoc
                {
                    iDThuoc = t.IdThuoc,
                    maThuoc = t.MaThuoc,
                    tenThuoc = t.TenThuoc,
                    maNhom = t.MaNhom,
                    nguonGoc = t.NguonGoc,
                    maNSX = t.MaNSX,
                    soLuong = t.SoLuong,
                    giaBan = t.GiaBan,
                    maDVT = t.MaDVT,
                    thanhPhan = t.ThanhPhan,
                    hamluong = t.HamLuong,
                    congDung = t.CongDung,
                    phanTacDung = t.PhanTacDung,
                    cachDung = t.CachDung,
                    chuY = t.ChuY,
                    hanSuDung = t.HanSuDung,
                    baoQuan = t.BaoQuan,
                    dangBaoChe = t.DangBaoChe
                };

                db.Thuocs.InsertOnSubmit(t_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Throw Exception
                throw ex;
            }
            return false;
        }
        public bool xoaThuoc(string idThuoc)
        {
            try
            {
                Thuoc t = db.Thuocs.Single(d => d.iDThuoc == idThuoc);
                db.Thuocs.DeleteOnSubmit(t);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool SuaThuoc(DTO_Thuoc t)
        {
            bool kq = false;
            try
            {
                Thuoc thuoc = db.Thuocs.Single(d => d.iDThuoc == t.IdThuoc);
                thuoc.maThuoc = t.MaThuoc;
                thuoc.tenThuoc = t.TenThuoc;
                thuoc.maNhom = t.MaNhom;
                thuoc.nguonGoc = t.NguonGoc;
                thuoc.maNSX = t.MaNSX;
                thuoc.soLuong = t.SoLuong;
                thuoc.giaBan = t.GiaBan;
                thuoc.maDVT = t.MaDVT;
                thuoc.thanhPhan = t.ThanhPhan;
                thuoc.hamluong = t.HamLuong;
                thuoc.congDung = t.CongDung;
                thuoc.phanTacDung = t.PhanTacDung;
                thuoc.cachDung = t.CachDung;
                thuoc.chuY = t.ChuY;
                thuoc.hanSuDung = t.HanSuDung;
                thuoc.baoQuan = t.BaoQuan;
                thuoc.dangBaoChe = t.DangBaoChe;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool SuaThuocNhapHang(string idthuoc, int sl)
        {
            bool kq = false;
            try
            {
                Thuoc thuoc = db.Thuocs.Single(d => d.iDThuoc == idthuoc);
                thuoc.soLuong = thuoc.soLuong - sl;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool SuaThuocXuatHang(string idthuoc, int sl)
        {
            bool kq = false;
            try
            {
                Thuoc thuoc = db.Thuocs.Single(d => d.iDThuoc == idthuoc);
                thuoc.soLuong += sl;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool kiemTraMaThuocCoTonTai(string ma)
        {
            var temp = from s in db.Thuocs
                       where s.iDThuoc == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            var temp = from s in db.Thuocs
                       where s.tenThuoc == ma
                       select s;
            return temp.Count() > 0;
        }
    }
}
