using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5.QuanLyDanhMuc
{
    public partial class FrmQuanLyNhaCungCap : Form
    {
        public FrmQuanLyNhaCungCap()
        {
            InitializeComponent();
            loaddgvNhaCungCap();
        }

        private void loaddgvNhaCungCap()
        {
            dgvNhaCungCap.DataSource = Database.Query("select * from NhaCungCap");
            btnSua.Enabled = btnXoa.Enabled = dgvNhaCungCap.Rows.Count > 0;
        }

        private bool checkForm()
        {
            erpBaoLoi.Clear();
            bool isFine = true;
            if (txtTen.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtTen, "Chua dien ten nha cung cap");
                isFine = false;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtDiaChi, "Chua dien dia chi nha cung cap");
                isFine = false;
            }
            if (mtxtSDT.Text.Trim() == "")
            {
                erpBaoLoi.SetError(mtxtSDT, "Chua dien SDT nha cung cap");
                isFine = false;
            }
            return isFine;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiem tra trung ten nha cung cap
            string sql = "select * from NhaCungCap where TenNhaCungCap = N'" + txtTen.Text + "'";
            bool error = false;
            if(Database.Query(sql).Rows.Count > 0)
            {
                erpBaoLoi.SetError(txtTen, "Trung ten nha cung cap");
                error = true;
            }
            sql = "select * from NhaCungCap where DienThoai = N'" + mtxtSDT.Text + "'";
        
            if (Database.Query(sql).Rows.Count > 0)
            {
                erpBaoLoi.SetError(mtxtSDT, "Trung SDT nha cung cap");
                error = true;
            }
            if (error) return;
            if (checkForm() == false) return;
            Database.Execute("insert NhaCungCap values(N'" + txtTen.Text + "', N'" + txtDiaChi.Text + "', '" + mtxtSDT.Text + "')");
            loaddgvNhaCungCap();
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhaCungCap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["colTenNhaCungCap"].Value.ToString();
            txtDiaChi.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            mtxtSDT.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["colSDT"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkForm() == false) return;
            Database.Execute("update NhaCungCap set TenNhaCungCap = N'"+txtTen.Text+"', DiaChi = N'"+txtDiaChi.Text+"'," +
                " DienThoai = "+mtxtSDT.Text+" where MaNhaCungCap = "+dgvNhaCungCap.CurrentRow.Cells["colMaNhaCungCap"].Value.ToString()+"");
            loaddgvNhaCungCap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete NhaCungCap where MaNhaCungCap = " + colMaNhaCungCap;
            loaddgvNhaCungCap();
        }

        private void FrmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {

        }
    }
}
