using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonNhap
    {
        
        string maHDN, maNPP, nguoiGiao, nguoiNhan;
        double tongTienThuoc, tongThue, tongTienHD;
        DateTime ngayViet, ngayNhap;
        public DTO_HoaDonNhap()
        {

        }
        public DTO_HoaDonNhap(string maHDN, string maNPP, string nguoiGiao, string nguoiNhan, double tongTienThuoc, double tongThue, DateTime ngayViet, DateTime ngayNhap)
        {
            this.maHDN = maHDN;
            this.maNPP = maNPP;
            this.nguoiGiao = nguoiGiao;
            this.nguoiNhan = nguoiNhan;
            this.tongTienThuoc = tongTienThuoc;
            this.tongThue = tongThue;
            this.tongTienHD = tongTienThuoc + tongThue;
            this.ngayViet = ngayViet;
            this.ngayNhap = ngayNhap;
        }

        public string MaHDN { get => maHDN; set => maHDN = value; }
        public string MaNPP { get => maNPP; set => maNPP = value; }
        public string NguoiGiao { get => nguoiGiao; set => nguoiGiao = value; }
        public string NguoiNhan { get => nguoiNhan; set => nguoiNhan = value; }
        public double TongTienThuoc { get => tongTienThuoc; set => tongTienThuoc = value; }
        public double TongThue { get => tongThue; set => tongThue = value; }
        public double TongTienHD { get => tongTienHD; set => tongTienHD = value; }
        public DateTime NgayViet { get => ngayViet; set => ngayViet = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
    }
}
