using BUS;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class report2 : Form
    {
        BUS_HoaDonNhap hdn = new BUS_HoaDonNhap();
        public report2()
        {
            InitializeComponent();
        }

        private void report2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdn.layDSHoaDonNhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdn.LayDSHoaDonNhap_TheoMa(textBox1.Text);
            return;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kq = e.RowIndex;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GQTRKCK\\SQLEXPRESS;Initial Catalog=QLBT;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_inHoaDonNhap";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@maHDN", dataGridView1.Rows[kq].Cells[0].Value.ToString());
            sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            con.Close();

            XtraReport2 report1 = new XtraReport2();
            report1.DataSource = dt;
            report1.ShowPreviewDialog();
        }
    }
}
