using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BenhNhan
    {
        int  tuoi;
        string idBN, hoTen, diaChi, dienThoai;
        public DTO_BenhNhan()
        {

        }

        public DTO_BenhNhan(string idBN, int tuoi, string hoTen, string diaChi, string dienThoai)
        {
            this.idBN = idBN;
            this.tuoi = tuoi;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
        }

        public string IdBN { get => idBN; set => idBN = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
    }
}
