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
    public partial class frmChiTietNhapThuoc : Form
    {
        string tenNPP, tenThuoc;
        bool kt;
        int n;
        public frmChiTietNhapThuoc()
        {
            InitializeComponent();         
        }
        public string TenNPP { get { return tenNPP; } set { tenNPP = value;} }

        public string TenThuoc { get => tenThuoc; set => tenThuoc = value; }
        public bool Kt { get => kt; set => kt = value; }
        public int N { get => n; set => n = value; }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            n = int.Parse(numericUpDown1.Value.ToString());
            Kt = true;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietNhapThuoc_Load(object sender, EventArgs e)
        {
            Kt = false;
            lbTenThuoc.Text = tenThuoc;
        }
    }
}
