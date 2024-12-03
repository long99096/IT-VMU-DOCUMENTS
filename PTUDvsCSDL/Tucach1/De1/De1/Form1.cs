using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace De1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loaddgvNhanVien();
        }

        private bool checkForm()
        {
            erpBaoLoi.Clear();
            bool isFine = true;
            if(txtTen.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtTen, "Chua nhap Ten");
                isFine = false;
            }
            return isFine;
        }
        private void loaddgvNhanVien()
        {
            dgvNhanVien.DataSource = Database.Query("select N.MaNhanVien, N.HoTen, N.NgaySinh, N.MaPhongBan, " +
                "P.TenPhongBan from NhanVien_9 N join PhongBan_0 P on N.MaPhongBan = P.MaPhongBan");
            //dgvNhanVien.DataSource = Database.Query("select * from NhanVien_9");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!checkForm()) return;
            string sql = "insert NhanVien_9 values('" + txtTen.Text + "', '" + dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd") + "', '" + cbbPhongBan.SelectedValue.ToString() + "')";
            Database.Execute(sql);
            loaddgvNhanVien();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbPhongBan.DisplayMember = "TenPhongBan";
            cbbPhongBan.ValueMember = "MaPhongBan";
            cbbPhongBan.DataSource = Database.Query("select * from PhongBan_0");
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colHoTen"].Value.ToString();
            dateTimePickerNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString());
            cbbPhongBan.SelectedValue = dgvNhanVien.Rows[e.RowIndex].Cells["colMaPhongBan"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!checkForm()) return;
            string sql = "update NhanVien_9 set HoTen = '" + txtTen.Text + "', NgaySinh = '" + dateTimePickerNgaySinh.Value.ToString("yyyy-MM-dd") + "', " +
                "MaPhongBan = '" + cbbPhongBan.SelectedValue.ToString() + "' where MaNhanVien = '" + dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value.ToString() + "'";
            Database.Execute(sql);
            loaddgvNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from NhanVien_9 where MaNhanVien = '" + dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value.ToString() + "'";
            Database.Execute(sql);
            loaddgvNhanVien();
        }
    }
}
