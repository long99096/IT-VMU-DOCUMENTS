using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDuSQLNangCao
{
    public partial class FrmQuanLyNhanVien : Form
    {
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            loadCbbs();
            loaddgv();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadCbbs()
        {
            cbbGioiTinh.Text = "Nam";
            cbbChucVu.DataSource = Database.Query("select * from ChucVu");
            cbbPhongBan.DataSource = Database.Query("select * from PhongBan");
        }
        
        private void loaddgv()
        {
            dgvNhanVien.DataSource = Database.Query("select * from vNhanVien");
            btnSua.Enabled = btnXoa.Enabled = dgvNhanVien.Rows.Count > 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "exec ThemNhanVien @HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@HoTen", txtHoTen.Text);
            dictionary.Add("@NgaySinh", dateTimePicker1.Value);
            dictionary.Add("@GioiTinh", cbbGioiTinh.Text == "Nam" ? 1 : 0);
            dictionary.Add("@DiaChi", txtDiaChi.Text);
            dictionary.Add("@MaChucVu", cbbChucVu.SelectedValue);
            dictionary.Add("@MaPhongBan", cbbPhongBan.SelectedValue);
            try
            {
                Database.Execute(sql, dictionary);
                loaddgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql =
               "EXEC SuaNhanVien @MaNhanVien,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@MaNhanVien", dgvNhanVien.CurrentRow.Cells["colMaNhanVien"].Value);
            tuDien.Add("@HoTen", txtHoTen.Text);
            tuDien.Add("@NgaySinh", dateTimePicker1.Value);
            tuDien.Add("@GioiTinh", (cbbGioiTinh.Text == "Nam" ? 1 : 0));
            tuDien.Add("@DiaChi", txtDiaChi.Text);
            tuDien.Add("@MaChucVu", cbbChucVu.SelectedValue);
            tuDien.Add("@MaPhongBan", cbbPhongBan.SelectedValue);
            try
            {
                Database.Execute(sql, tuDien);
                loaddgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtHoTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colHoTen"].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dgvNhanVien.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString());
            txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            cbbGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colGioiTinh"].Value.ToString();
            cbbChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colChucVu"].Value.ToString();
            cbbPhongBan.Text = dgvNhanVien.Rows[e.RowIndex].Cells["colPhongBan"].Value.ToString();
        }
    }
}
