using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loaddgvChungChi();
        }

        private void loaddgvChungChi()
        {
            //dgvChungChi.DataSource = Database.Query("select * from ChungChi_6");
            dgvChungChi.DataSource = Database.Query(
    "SELECT C.MaChungChi, L.TenLoaiChungChi, N.HoTen, C.NgayCap, C.NoiCap, L.MaLoaiChungChi, N.MaNhanVien " +
    "FROM ChungChi_6 C " +
    "JOIN LoaiChungChi_9 L ON C.MaLoaiChungChi = L.MaLoaiChungChi " +
    "JOIN NhanVien_9 N ON N.MaNhanVien = C.MaNhanVien");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbbLoaiChungChi.DisplayMember = "TenLoaiChungChi";
            cbbLoaiChungChi.ValueMember = "MaLoaiChungChi";
            cbbLoaiChungChi.DataSource = Database.Query("select * from LoaiChungChi_9");

            cbbTenNhanVien.DisplayMember = "HoTen";
            cbbTenNhanVien.ValueMember = "MaNhanVien";
            cbbTenNhanVien.DataSource = Database.Query("select * from NhanVien_9");
        }
        private void dgvChungChi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbbLoaiChungChi.SelectedValue = dgvChungChi.Rows[e.RowIndex].Cells["colMaLoaiChungChi"].Value.ToString();
            cbbTenNhanVien.SelectedValue = dgvChungChi.Rows[e.RowIndex].Cells["colMaNhanVien"].Value.ToString();
            dateTimePickerNgayCap.Value = DateTime.Parse(dgvChungChi.Rows[e.RowIndex].Cells["colNgayCap"].Value.ToString());
            txtNoiCap.Text = dgvChungChi.Rows[e.RowIndex].Cells["colNoiCap"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert ChungChi_6 values ('" + cbbLoaiChungChi.SelectedValue.ToString() + "', " +
                "'" + cbbTenNhanVien.SelectedValue.ToString() + "', '" + dateTimePickerNgayCap.Value.ToString("yyyy-MM-dd") + "', '" + txtNoiCap.Text + "')";
            Database.Execute(sql);
            loaddgvChungChi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update ChungChi_6 set MaLoaiChungChi = '" + cbbLoaiChungChi.SelectedValue + "', MaNhanVien = '" + cbbTenNhanVien.SelectedValue + "', NgayCap = '" + dateTimePickerNgayCap.Value.ToString("yyyy-MM-dd") + "', NoiCap = '" + txtNoiCap.Text + "'" +
                "where MaChungChi = '" + dgvChungChi.CurrentRow.Cells["colMaChungChi"].Value.ToString() + "'";
            Database.Execute(sql);
            loaddgvChungChi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from ChungChi_6 where MaChungChi = '" + dgvChungChi.CurrentRow.Cells["colMaChungChi"].Value.ToString() + "'";
            Database.Execute(sql);
            loaddgvChungChi();
        }
    }
}
