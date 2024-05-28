using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhomThuoc
    {
        string maNhom;
        string tenNhom, ghiChu;

        public DTO_NhomThuoc()
        {
            this.maNhom = null;
            this.tenNhom = null;
            this.ghiChu = null;
        }
        public DTO_NhomThuoc( string tenNhom, string ghiChu)
        {
            this.tenNhom = tenNhom;
            this.ghiChu = ghiChu;
        }
        public DTO_NhomThuoc(string maNhom, string tenNhom, string ghiChu)
        {
            this.maNhom = maNhom;
            this.tenNhom = tenNhom;
            this.ghiChu = ghiChu;
        }

        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
