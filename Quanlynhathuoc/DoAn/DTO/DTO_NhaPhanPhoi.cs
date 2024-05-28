using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaPhanPhoi
    {
        string maNPP;
        string tenNPP, diaChi, dienThoai, email, maSoThue, ghiChu;
        public DTO_NhaPhanPhoi()
        {

        }
        public DTO_NhaPhanPhoi(string maNPP, string tenNPP, string diaChi, string dienThoai, string email, string maSoThue, string ghiChu)
        {
            this.maNPP = maNPP;
            this.tenNPP = tenNPP;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.email = email;
            this.maSoThue = maSoThue;
            this.ghiChu = ghiChu;
        }

        public string MaNPP { get => maNPP; set => maNPP = value; }
        public string TenNPP { get => tenNPP; set => tenNPP = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string MaSoThue { get => maSoThue; set => maSoThue = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
