using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaSanXuat
    {
        string maNSX;
        string tenNSX, diaChi, dienThoai, email;
        public DTO_NhaSanXuat()
        {
        }
        public DTO_NhaSanXuat(string maNSX, string tenNSX, string diaChi, string dienThoai, string email)
        {
            this.maNSX = maNSX;
            this.tenNSX = tenNSX;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.email = email;
        }

        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string TenNSX { get => tenNSX; set => tenNSX = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
    }
}
