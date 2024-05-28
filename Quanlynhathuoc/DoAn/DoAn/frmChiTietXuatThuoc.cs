using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmChiTietXuatThuoc : Form
    {
        BUS_DonViTinh DVT = new BUS_DonViTinh();
        string tenThuoc, donViTinh;
        bool kt;
        int n;
        public frmChiTietXuatThuoc()
        {
            InitializeComponent();
            cbDVT.DataSource = DVT.layDSDonViTinh();
            cbDVT.DisplayMember = "tenDVT";
            cbDVT.ValueMember = "maDVT";
        }

        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public bool Kt { get => kt; set => kt = value; }
        public int N { get => n; set => n = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }

        private void frmChiTietXuatThuoc_Load(object sender, EventArgs e)
        {
            Kt = false;
            lbTenThuoc.Text = tenThuoc;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            n = int.Parse(numericUpDown1.Value.ToString());
            donViTinh = cbDVT.Text;
            Kt = true;
            this.Close();
        }
    }
}
