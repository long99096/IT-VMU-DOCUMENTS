using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tucach3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadgdvKhoHang();
            loadCbbs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void loadgdvKhoHang()
        {
            dgvKhoHang.DataSource = Database.Query("select * from vKhoHang");
            btnSua.Enabled = btnXoa.Enabled = dgvKhoHang.Rows.Count > 0; 
        }

        public void loadCbbs()
        {
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "MaNhanVien";
            cbbNhanVien.DataSource = Database.Query("select * from NhanVien_9");
        }

        private bool CheckForm()
        {
            erpBaoLoi.Clear();
            bool isFine = true;
            if (txtMaKhoHang.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtMaKhoHang, "Nhap ma kho hang");
                isFine = false;
            }
            if (txtTenKhoHang.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtTenKhoHang, "Nhap ten kho");
                isFine = false;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtDiaChi, "Nhap Dia Chi");
                isFine = false;
            }
            return isFine;
        }

        

        private void dgvKhoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhoHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoHang.Text = dgvKhoHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenKhoHang.Text = dgvKhoHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhoHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbbNhanVien.Text = dgvKhoHang.Rows[e.RowIndex].Cells[3].Value.ToString();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckForm()) return;
            string sql =
                "insert KhoHang_6 values (@MaKhoHang, @TenKhoHang, @DiaChi, @MaNhanVienPhuTrach)";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@MaKhoHang", txtMaKhoHang.Text);
            tuDien.Add("@TenKhoHang", txtTenKhoHang.Text);
            tuDien.Add("@DiaChi", txtDiaChi.Text);
            tuDien.Add("@MaNhanVienPhuTrach", cbbNhanVien.SelectedValue);
            Database.Execute(sql, tuDien);
            loadgdvKhoHang();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckForm()) return;
            string sql = "update KhoHang_6 set MaKhoHang = @MaKhoHang, TenKhoHang = @TenKhoHang, DiaChi = @DiaChi, MaNhanVienPhuTrach = @MaNhanVienPhuTrach" +
                " where MaKhoHang = @MaKhoHangMuonSua";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@MaKhoHangMuonSua", dgvKhoHang.CurrentRow.Cells[0].Value.ToString());
            tuDien.Add("@MaKhoHang", txtMaKhoHang.Text);
            tuDien.Add("@TenKhoHang", txtTenKhoHang.Text);
            tuDien.Add("@DiaChi", txtDiaChi.Text);
            tuDien.Add("@MaNhanVienPhuTrach", cbbNhanVien.SelectedValue);
            Database.Execute(sql, tuDien);
            loadgdvKhoHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete KhoHang_6 where MaKhoHang = @MaKhoHang";
            Dictionary<string, object> tuDien = new Dictionary<string, object>();
            tuDien.Add("@MaKhoHang", txtMaKhoHang.Text);
            Database.Execute(sql, tuDien);
            loadgdvKhoHang();
        }
    }
}
