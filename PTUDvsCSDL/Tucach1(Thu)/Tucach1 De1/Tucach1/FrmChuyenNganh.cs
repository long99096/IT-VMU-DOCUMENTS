using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tucach1
{
    public partial class FrmChuyenNganh : Form
    {
        public FrmChuyenNganh()
        {
            InitializeComponent();
            loaddgvChuyenNganh();
        }

        private bool checkForm()
        {
            erpBaoLoi.Clear();
            bool isFine = true;
            if(txtTenChuyenNganh.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtTenChuyenNganh, "Chua nhap ten chuyen nganh");
                isFine = false;
            }
            if(txtMaGiangVienPhuTrach.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtMaGiangVienPhuTrach, "Chua nhap ma giang vien phu trach");
                isFine = false;
            }
            return isFine;
        }
        private void loaddgvChuyenNganh()
        {
            dgvChuyenNganh.DataSource = Database.Query("select * from ChuyenNganh");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkForm() == false) return;
            string sql = "insert ChuyenNganh values (N'" + txtTenChuyenNganh.Text + "','" + txtMaGiangVienPhuTrach.Text + "')";
            Database.Execute(sql);
            loaddgvChuyenNganh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkForm() == false) return;
            string sql = "update ChuyenNganh set TenChuyenNganh = '" + txtTenChuyenNganh.Text + "', MaGiangVienPhuTrach = '" + txtMaGiangVienPhuTrach.Text + "' where TenChuyenNganh = '"+dgvChuyenNganh.CurrentRow.Cells["colTenChuyenNganh"].Value.ToString() +"'";
            Database.Execute(sql);
            loaddgvChuyenNganh();
        }

        private void dgvChuyenNganh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTenChuyenNganh.Text = dgvChuyenNganh.Rows[e.RowIndex].Cells["colTenChuyenNganh"].Value.ToString();
            txtMaGiangVienPhuTrach.Text = dgvChuyenNganh.Rows[e.RowIndex].Cells["colMaGiangVienPhuTrach"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete ChuyenNganh where  TenChuyenNganh = '" + dgvChuyenNganh.CurrentRow.Cells["colTenChuyenNganh"].Value.ToString() + "'";
            Database.Execute(sql);
            loaddgvChuyenNganh();
        }
    }
}
