using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_thuc_hanh_lai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            dgv_LoaiHang.DataSource = Database.Query("select * from LoaiHang");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaLoaiHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert LoaiHang values ('"+txtMaLoaiHang.Text+"',N'"+txtTenLoaiHang.Text+"')";
            Database.Execute(sql);
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from LoaiHang where MaLoaiHang = '"+txtMaLoaiHang.Text+"'";
            Database.Execute(sql);
            load();
        }

        private void dgv_LoaiHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiHang.Text = dgv_LoaiHang.Rows[e.RowIndex].Cells["colMaLoaiHang"].Value.ToString();
            txtTenLoaiHang.Text = dgv_LoaiHang.Rows[e.RowIndex].Cells["colTenLoaiHang"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update LoaiHang set MaLoaiHang = '"+txtMaLoaiHang.Text+"', " +
                "TenLoaiHang = N'"+txtTenLoaiHang.Text+"' where MaLoaiHang = '"+dgv_LoaiHang.CurrentRow.Cells["colMaLoaiHang"].Value.ToString()+"'";
            Database.Execute(sql);
            load();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Ban co muon thoat khong", "Thoat khong", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                //this.Close();
            }
        }
    }
}
