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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhomThuoc frm = new frmNhomThuoc();
            frm.ShowDialog();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.ShowDialog();
        }

        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuoc frm = new frmThuoc();
            frm.ShowDialog();
        }

        private void quảnLýNhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaSanXuat frm = new frmNhaSanXuat();
            frm.ShowDialog();
        }

        private void quảnLýNhàPhânPhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaPhanPhoi frm = new frmNhaPhanPhoi();
            frm.ShowDialog();
        }

        private void quảnLýHóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonXuat frm = new frmHoaDonXuat();
            frm.ShowDialog();
        }

        private void quảnLýHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap frm = new frmHoaDonNhap();
            frm.ShowDialog();
        }

        private void quảnLýĐơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonViTinh frm = new frmDonViTinh();
            frm.ShowDialog();
        }

        private void quảnLýChiTiếtHóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDonXuat frm = new frmChiTietHoaDonXuat();
            frm.ShowDialog();   
        }

        private void quảnLýChiTiếtHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDonNhap frm = new frmChiTietHoaDonNhap();
            frm.ShowDialog();
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyBenhNhan frm = new frmQuanLyBenhNhan();
            frm.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapHang frm = new frmNhapHang();
            frm.ShowDialog();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatHang frm = new frmXuatHang();
            frm.ShowDialog();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report report = new report();
            report.ShowDialog();
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report report = new report();
            report.ShowDialog();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report2 report = new report2();
            report.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
