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
using System.Data;

namespace _25_11_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loaddgv();
        }
        
        private void loaddgv()
        {
            dgvNhaCungCap.DataSource = Database.Query("select * from NhaCungCap");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "exec ThemNhaCungCap @TenNhaCungCap, @DiaChi, @DienThoai";

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@TenNhaCungCap", txtNhaCungCap.Text);
            dictionary.Add("@DiaChi", txtDiaChi.Text);
            dictionary.Add("@DienThoai", txtSoDienThoai.Text);

            try
            {
                Database.Execute(sql, dictionary);
                loaddgv();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from NhaCungCap where TenNhaCungCap like '%' + @TenNhaCungCap + '%' and DiaChi like '%' + @DiaChi + '%' and " +
                "DienThoai like '%' + @DienThoai + '%'";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@TenNhaCungCap",txtTenNhaCungCapTK.Text);
            dictionary.Add("@DiaChi", txtDiaChiTK.Text);
            dictionary.Add("@DienThoai", txtDienThoaiTK.Text);
            dgvNhaCungCap.DataSource = Database.Query(sql, dictionary);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
