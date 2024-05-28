using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TAIKHOAN
    {
        string taiKhoan, matKhau, hoTen, chucVu;
        DateTime ngayTao;
        public DTO_TAIKHOAN()
        {
            this.taiKhoan = null;
            this.matKhau = null;
            this.hoTen = null;
            this.chucVu = null;
            this.ngayTao = DateTime.Now;
        }
        public DTO_TAIKHOAN(string taiKhoan, string matKhau, string hoTen, string chucVu, DateTime ngayTao)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.hoTen = hoTen;
            this.chucVu = chucVu;
            this.ngayTao = ngayTao;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
    }
}
