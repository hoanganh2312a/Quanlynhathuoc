using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDonXuat
    {
        int  soLuong;
        double giaBan, thue;
        string maCTHDX, maHDX, idThuoc, donVi;
        public DTO_ChiTietHoaDonXuat()
        {

        }
        public DTO_ChiTietHoaDonXuat(string maCTHDX, string maHDX, string idThuoc, int soLuong, float giaBan, double thue, string donVi)
        {
            this.maCTHDX = maCTHDX;
            this.maHDX = maHDX;
            this.idThuoc = idThuoc;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
            this.thue = thue;
            this.donVi = donVi;
        }

        public string MaCTHDX { get => maCTHDX; set => maCTHDX = value; }
        public string MaHDX { get => maHDX; set => maHDX = value; }
        public string IdThuoc { get => idThuoc; set => idThuoc = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public double Thue { get => thue; set => thue = value; }
        public string DonVi { get => donVi; set => donVi = value; }
    }
}
