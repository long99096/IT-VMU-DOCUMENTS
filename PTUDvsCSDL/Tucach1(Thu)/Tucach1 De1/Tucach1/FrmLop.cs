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
    public partial class FrmLop : Form
    {
        public FrmLop()
        {
            InitializeComponent();
            loaddgvLop();
        }

        private bool checkForm()
        {
            erpBaoLoi.Clear();
            bool isFine = true;
            if(txtTenLop.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtTenLop, "Chua nhap ten lop");
                isFine = false;
            }
            if(txtMaCVHT.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtMaCVHT, "Chua nhap Ma CVHT");
                isFine = false;
            }
            if(txtNamBatDau.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtNamBatDau, "Chua nhap nam bat dau");
                isFine = false;
            }
            return isFine;
        }
        private void loaddgvLop()
        {
            dgvLop.DataSource = Database.Query("select * from Lop");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkForm() == false) return;
            string sql = "insert Lop values (N'" + txtTenLop.Text + "', '" + txtMaCVHT.Text + "', '" + txtNamBatDau.Text + "')";
            Database.Execute(sql);
            loaddgvLop();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkForm() == false) return;
            string sql = "update Lop set TenLop = '" + txtTenLop.Text + "', MaCVHT = '" + txtMaCVHT.Text + "', NamBatDau = '" + txtNamBatDau.Text + "' where TenLop = '" + dgvLop.CurrentRow.Cells["colTenLop"].Value.ToString() + "'";
            Database.Execute(sql);
            loaddgvLop();
        }

        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTenLop.Text = dgvLop.Rows[e.RowIndex].Cells["colTenLop"].Value.ToString();
            txtMaCVHT.Text = dgvLop.Rows[e.RowIndex].Cells["colMaCVHT"].Value.ToString();
            txtNamBatDau.Text = dgvLop.Rows[e.RowIndex].Cells["colNamBatDau"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete Lop where TenLop = '" + dgvLop.CurrentRow.Cells["colTenLop"].Value.ToString() + "'";
            Database.Execute(sql);
            loaddgvLop();
        }
    }
}
