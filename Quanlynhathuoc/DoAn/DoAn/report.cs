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
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace DoAn
{
    public partial class report : Form
    {
        BUS_HoaDonXuat hdx = new BUS_HoaDonXuat();
        public report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdx.LayDSHoaDonXuat_TheoMaBN(textBox1.Text);
            return;
        }

        private void report_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hdx.layDSHoaDonXuat();
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
            cmd.CommandText = "sp_inHoaDonBN";
            cmd.Connection= con;
            cmd.Parameters.AddWithValue("@idBN", dataGridView1.Rows[kq].Cells[1].Value.ToString());
            sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            con.Close();

            XtraReport1 report1 = new XtraReport1();
            report1.DataSource = dt;
            report1.ShowPreviewDialog();
        }
    }
}
