using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDonNhap
    {
        string maCTHDN, maHDN, idThuoc;
        int soLuong;
        float giaNhap;
        public DTO_ChiTietHoaDonNhap() { }
        public DTO_ChiTietHoaDonNhap(string maCTHDN, string maHDN, string idThuoc, int soLuong, float giaNhap)
        {
            this.maCTHDN = maCTHDN;
            this.maHDN = maHDN;
            this.idThuoc = idThuoc;
            this.soLuong = soLuong;
            this.giaNhap = giaNhap;
        }

        public string MaCTHDN { get => maCTHDN; set => maCTHDN = value; }
        public string MaHDN { get => maHDN; set => maHDN = value; }
        public string IdThuoc { get => idThuoc; set => idThuoc = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float GiaNhap { get => giaNhap; set => giaNhap = value; }
    }
}
