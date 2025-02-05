﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDuSQLNangCaoOnTap
{
    public partial class FrmQuanLyNhanVien : Form
    {
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            loaddgvNhanVien();
            loadCbbs();
        }

        private bool CheckForm()
        {
            erpBaoLoi.Clear();
            bool isFine = true;
            if (txtHoTen.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtHoTen, "Nhap Ho Ten");
                isFine = false;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtDiaChi, "Nhap Dia Chi");
                isFine = false;
            }
            return isFine;
        }

        private void loaddgvNhanVien()
        {
            dgvNhanVien.DataSource = Database.Query("select * from vNhanVien");
            btnSua.Enabled = btnXoa.Enabled = dgvNhanVien.Rows.Count > 0;
        }

        private void loadCbbs()
        {
            cbbGioiTinh.Text = "Nam";

            cbbChucVu.ValueMember = "MaChucVu";
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.DataSource = Database.Query("select * from ChucVu");

            cbbPhongBan.ValueMember = "MaPhongBan";
            cbbPhongBan.DisplayMember = "TenPhongBan";
            cbbPhongBan.DataSource = Database.Query("select * from PhongBan");

            cbbChucVuTK.ValueMember = "MaChucVu";
            cbbChucVuTK.DisplayMember = "TenChucVu";
            cbbChucVuTK.DataSource = Database.Query("select * from ChucVu");

            cbbPhongBanTK.ValueMember = "MaPhongBan";
            cbbPhongBanTK.DisplayMember = "TenPhongBan";
            cbbPhongBanTK.DataSource = Database.Query("select * from PhongBan");
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckForm()) return;
            string sql =
                "EXEC ThemNhanVien @HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@HoTen", txtHoTen.Text);
            tuDien.Add("@NgaySinh", dtpNgaySinh.Value.ToString());
            tuDien.Add("@GioiTinh", (cbbGioiTinh.Text == "Nam" ? 1 : 0));
            tuDien.Add("@DiaChi", txtDiaChi.Text);
            tuDien.Add("@MaChucVu", cbbChucVu.SelectedValue);
            tuDien.Add("@MaPhongBan", cbbPhongBan.SelectedValue);
            try
            {
                Database.Execute(sql, tuDien);
                loaddgvNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckForm()) return;
            string sql = "EXEC SuaNhanVien @MaNhanVien,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@MaNhanVien", dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value.ToString());
            tuDien.Add("@HoTen", txtHoTen.Text);
            tuDien.Add("@NgaySinh", dtpNgaySinh.Value);
            tuDien.Add("@GioiTinh", (cbbGioiTinh.Text == "Nam" ? 1 : 0));
            tuDien.Add("@DiaChi", txtDiaChi.Text);
            tuDien.Add("@MaChucVu", cbbChucVu.SelectedValue);
            tuDien.Add("@MaPhongBan", cbbPhongBan.SelectedValue);
            try
            {
                Database.Execute(sql, tuDien);
                loaddgvNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql =
                "EXEC XoaNhanVien @MaNhanVien";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@MaNhanVien", dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value);
            try
            {
                Database.Execute(sql, tuDien);
                loaddgvNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colHoTen"].Value.ToString();
            cbbGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colGioiTinh"].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString());
            txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            cbbChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colChucVu"].Value.ToString();
            cbbPhongBan.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colPhongBan"].Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM dbo.TimKiemNhanVien(@MaNhanVien,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan)";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            if (checkMaNhanVien.Checked)
                tuDien.Add("@MaNhanVien", numericUpDownMaNhanVienTK.Value);
            else
                tuDien.Add("@MaNhanVien", DBNull.Value);
            if (checkHoTen.Checked)
                tuDien.Add("@HoTen", txtHoTenTK.Text);
            else
                tuDien.Add("@HoTen", "");
            if (checkNgaySinh.Checked)
                tuDien.Add("@NgaySinh", dtpNgaySinhTK.Value);
            else
                tuDien.Add("@NgaySinh", DBNull.Value);
            if (checkGioiTinh.Checked)
                tuDien.Add("@GioiTinh", (cbbGioiTinhTK.Text == "Nam" ? 1 : 0));
            else
                tuDien.Add("@GioiTinh", DBNull.Value);
            if (checkDiaChi.Checked)
                tuDien.Add("@DiaChi", txtDiaChiTK.Text);
            else
                tuDien.Add("@DiaChi", "");
            if (checkChucVu.Checked)
                tuDien.Add("@MaChucVu", cbbChucVuTK.SelectedValue);
            else
                tuDien.Add("@MaChucVu", DBNull.Value);
            if (checkPhongBan.Checked)
                tuDien.Add("@MaPhongBan", cbbPhongBanTK.SelectedValue);
            else
                tuDien.Add("@MaPhongBan", DBNull.Value);
            dgvNhanVien.DataSource = Database.Query(sql, tuDien);
        }
        
    }
}
