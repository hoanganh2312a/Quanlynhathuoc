using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Thuoc
    {
        int  soLuong;
        string idThuoc, maNhom, maNSX, maThuoc, maDVT, tenThuoc, nguonGoc, thanhPhan, hamLuong, congDung, phanTacDung, cachDung, chuY, hanSuDung, baoQuan, dangBaoChe;
        float giaBan;
        public DTO_Thuoc() 
        {
            this.IdThuoc = null;
            this.MaNhom = null;
            this.MaNSX = null;
            this.SoLuong = 0;
            this.MaDVT = null;
            this.MaThuoc = null;
            this.TenThuoc = null;
            this.NguonGoc = null;
            this.ThanhPhan = null;
            this.HamLuong = null;
            this.CongDung = null;
            this.PhanTacDung = null;
            this.CachDung = null;
            this.ChuY = null;
            this.HanSuDung = null;
            this.BaoQuan = null;
            this.DangBaoChe = null;
            this.GiaBan = 0;
        }
        public DTO_Thuoc(string idThuoc, string maNhom, string maNSX, int soLuong, string maDVT, string maThuoc, string tenThuoc, string nguonGoc, string thanhPhan, string hamLuong, string congDung, string phanTacDung, string cachDung, string chuY, string hanSuDung, string baoQuan, string dangBaoChe, float giaBan)
        {
            this.IdThuoc = idThuoc;
            this.MaNhom = maNhom;
            this.MaNSX = maNSX;
            this.SoLuong = soLuong;
            this.MaDVT = maDVT;
            this.MaThuoc = maThuoc;
            this.TenThuoc = tenThuoc;
            this.NguonGoc = nguonGoc;
            this.ThanhPhan = thanhPhan;
            this.HamLuong = hamLuong;
            this.CongDung = congDung;
            this.PhanTacDung = phanTacDung;
            this.CachDung = cachDung;
            this.ChuY = chuY;
            this.HanSuDung = hanSuDung;
            this.BaoQuan = baoQuan;
            this.DangBaoChe = dangBaoChe;
            this.GiaBan = giaBan;
        }

        public string IdThuoc { get => idThuoc; set => idThuoc = value; }
        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string MaNSX { get => maNSX; set => maNSX = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaDVT { get => maDVT; set => maDVT = value; }
        public string MaThuoc { get => maThuoc; set => maThuoc = value; }
        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public string NguonGoc { get => nguonGoc; set => nguonGoc = value; }
        public string ThanhPhan { get => thanhPhan; set => thanhPhan = value; }
        public string HamLuong { get => hamLuong; set => hamLuong = value; }
        public string CongDung { get => congDung; set => congDung = value; }
        public string PhanTacDung { get => phanTacDung; set => phanTacDung = value; }
        public string CachDung { get => cachDung; set => cachDung = value; }
        public string ChuY { get => chuY; set => chuY = value; }
        public string HanSuDung { get => hanSuDung; set => hanSuDung = value; }
        public string BaoQuan { get => baoQuan; set => baoQuan = value; }
        public string DangBaoChe { get => dangBaoChe; set => dangBaoChe = value; }
        public float GiaBan { get => giaBan; set => giaBan = value; }
    }      
}
