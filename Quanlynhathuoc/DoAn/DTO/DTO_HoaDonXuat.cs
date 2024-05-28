using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonXuat
    {
        string maHDX, idBN;
        double tongTienThuoc, tongThue, tongTienHD;
        DateTime ngayLap;
        public DTO_HoaDonXuat()
        {

        }
        public DTO_HoaDonXuat(string maHDX, string idBN, double tongTienThuoc, double tongThue, DateTime ngayLap)
        {
            this.maHDX = maHDX;
            this.idBN = idBN;
            this.tongTienThuoc = tongTienThuoc;
            this.tongThue = tongThue;
            this.tongTienHD = tongTienThuoc+tongThue;
            this.ngayLap = ngayLap;
        }

        public string MaHDX { get => maHDX; set => maHDX = value; }
        public string IdBN { get => idBN; set => idBN = value; }
        public double TongTienThuoc { get => tongTienThuoc; set => tongTienThuoc = value; }
        public double TongThue { get => tongThue; set => tongThue = value; }
        public double TongTienHD { get => tongTienHD; set => tongTienHD = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
    }
}
