using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        private QLBTDataContext db;
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QLBT";

        public DAL_TaiKhoan(QLBTDataContext db, string serverName, string dbName)
        {
            this.Db = db;
            this.ServerName = serverName;
            this.DbName = dbName;
        }
        public DAL_TaiKhoan()
        {
            string sql = "Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=True;";
            db = new QLBTDataContext(sql);
        }

        public QLBTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }


        public IQueryable layDSTaiKhoan()
        {
            IQueryable nt = from n in db.TaiKhoans
                            select new
                            {
                                TaiKhoan = n.TaiKhoan1,
                                MatKhau = n.MatKhau,
                                HoTen = n.HoTen,
                                NgayTao = n.NgayTao,
                                ChucVu = n.ChucVu
                            };
            return nt;
        }
        public IQueryable LayDSTaiKhoan_TheoMa(string ma)
        {
            IQueryable temp = from n in db.TaiKhoans
                              where n.TaiKhoan1 == ma
                              select new
                              {
                                  TaiKhoan = n.TaiKhoan1,
                                  MatKhau = n.MatKhau,
                                  HoTen = n.HoTen,
                                  NgayTao = n.NgayTao,
                                  ChucVu = n.ChucVu
                              };
            return temp;
        }
        public IQueryable LayDSTaiKhoan_TheoTen(string ma)
        {
            IQueryable temp = from n in db.TaiKhoans
                              where n.HoTen == ma
                              select new
                              {
                                  TaiKhoan = n.TaiKhoan1,
                                  MatKhau = n.MatKhau,
                                  HoTen = n.HoTen,
                                  NgayTao = n.NgayTao,
                                  ChucVu = n.ChucVu
                              };
            return temp;
        }
        public bool themTaiKhoan(DTO_TAIKHOAN n)
        {
            bool kq;
            try
            {
                TaiKhoan TK_insert = new TaiKhoan
                {
                    TaiKhoan1 = n.TaiKhoan,
                    MatKhau = n.MatKhau,
                    HoTen = n.HoTen,
                    NgayTao = n.NgayTao,
                    ChucVu = n.ChucVu
                };
                db.TaiKhoans.InsertOnSubmit(TK_insert);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return false;
        }
        public bool xoaTaiKhoan(string TK)
        {
            try
            {
                TaiKhoan nt = db.TaiKhoans.Single(d => d.TaiKhoan1 == TK);
                db.TaiKhoans.DeleteOnSubmit(nt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public bool suaTaiKhoan(DTO_TAIKHOAN n)
        {
            bool kq = false;
            try
            {
                TaiKhoan CTHDN = db.TaiKhoans.Single(d => d.TaiKhoan1 == n.TaiKhoan);
                CTHDN.MatKhau = n.MatKhau;
                CTHDN.HoTen = n.HoTen;
                CTHDN.NgayTao = n.NgayTao;
                CTHDN.ChucVu = n.ChucVu;
                db.SubmitChanges(); kq = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kq;
        }
        public bool CheckTaiKhoan(string taiKhoan, string matKhau, string chucVu)
        {
            var temp = from tk in db.TaiKhoans
                       where tk.TaiKhoan1 == taiKhoan && tk.MatKhau == matKhau
                       && tk.ChucVu == chucVu
                       select tk;

            if (temp.Count() == 1)
            {
                return true;
            }
            return false;
        }
        public bool kiemTraTKCoTonTai(string ma)
        {
            var temp = from s in db.TaiKhoans
                       where s.TaiKhoan1 == ma
                       select s;
            return temp.Count() > 0;
        }
        public bool kiemTraTenCoTonTai(string ma)
        {
            var temp = from s in db.TaiKhoans
                       where s.HoTen == ma
                       select s;
            return temp.Count() > 0;
        }
    }
}
