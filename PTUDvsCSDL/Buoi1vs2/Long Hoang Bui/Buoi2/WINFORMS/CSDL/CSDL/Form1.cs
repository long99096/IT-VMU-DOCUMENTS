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

namespace CSDL
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connect();
            napDgvLoaiHang();
        }
        private void connect()
        {
            connection = new SqlConnection("server = LHB\\SQLEXPRESS; database = PTUDCSDLN01; integrated security = true");
            connection.Open();
        }
        
        private void napDgvLoaiHang()
        {
            string sql = "select * from LoaiHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvLoaiHang.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenLoaiHang.Text = txtTenLoaiHang.Text.Trim().ToLower();
            txtMaLoaiHang.Text = txtMaLoaiHang.Text.Trim().ToUpper();

            string lowertenloaihang = txtTenLoaiHang.Text;
            if(txtTenLoaiHang.Text.Length > 0)
            txtTenLoaiHang.Text = lowertenloaihang.Substring(0, 1).ToUpper() + lowertenloaihang.Substring(1);
            if (txtMaLoaiHang.Text == "" || txtTenLoaiHang.Text == "")
            {
                MessageBox.Show("Dien them thong tin di nhoc");
                return;
            }
            string sql = "insert LoaiHang values('"+txtMaLoaiHang.Text+"', N'"+txtTenLoaiHang.Text+"')";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            napDgvLoaiHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete LoaiHang where MaLoaiHang = '" + dgvLoaiHang.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            napDgvLoaiHang();
        }
    }
}
