using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonViTinh
    {
        string maDVT,tenDVT;
        public DTO_DonViTinh()
        {

        }
        public DTO_DonViTinh(string maDVT, string tenDVT)
        {
            this.maDVT = maDVT;
            this.tenDVT = tenDVT;
        }

        public string MaDVT { get => maDVT; set => maDVT = value; }
        public string TenDVT { get => tenDVT; set => tenDVT = value; }
    }
}
