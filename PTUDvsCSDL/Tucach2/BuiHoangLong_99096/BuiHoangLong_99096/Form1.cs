﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuiHoangLong_99096
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
            loaddgvSanPham();
            loadCbbs();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool CheckForm()
        {
            erpBaoLoi.Clear();
            bool isFine = true;
            if (txtMaSanPham.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtMaSanPham, "Nhap ma san pham");
                isFine = false;
            }
            if (txtTenSanPham.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtTenSanPham, "Nhap ten san pham");
                isFine = false;
            }
            return isFine;
        }

        public void loadCbbs()
        {
            cbbNhaCungCap.ValueMember = "MaNhaCungCap";
            cbbNhaCungCap.DisplayMember = "TenNhaCungCap";
            cbbNhaCungCap.DataSource = Database.Query("select * from NhaCungCap_9");

            cbbNhaSanXuat.ValueMember = "MaNhaSanXuat";
            cbbNhaSanXuat.DisplayMember = "TenNhaSanXuat";
            cbbNhaSanXuat.DataSource = Database.Query("select * from NhaSanXuat_6");
        }

        public void loaddgvSanPham()
        {
            dgvSanPham.DataSource = Database.Query("select * from vSanPham");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "select * from SanPham_0 where TenSanPham = N'" + txtTenSanPham.Text + "'";
            bool error = false;
            if (Database.Query(sql).Rows.Count > 0)
            {
                erpBaoLoi.SetError(txtTenSanPham, "Trung ten san pham");
                error = true;
            }
            if (error) return;
            if (!CheckForm()) return;
            sql = "insert SanPham_0 values (@MaSanPham,@TenSanPham,@MaNhaCungCap,@MaNhaSanXuat)";
            Dictionary<string, object> Dictionary = new Dictionary<string, object>();
            Dictionary.Add("@MaSanPham", txtMaSanPham.Text);
            Dictionary.Add("@TenSanPham", txtTenSanPham.Text);
            Dictionary.Add("@MaNhaCungCap", cbbNhaCungCap.SelectedValue);
            Dictionary.Add("@MaNhaSanXuat", cbbNhaSanXuat.SelectedValue);
            Database.Execute(sql, Dictionary);
            loaddgvSanPham();
        }

        private void dgvSanPham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSanPham.Text = dgvSanPham.Rows[e.RowIndex].Cells["colMaSanPham"].Value.ToString();
            txtTenSanPham.Text = dgvSanPham.Rows[e.RowIndex].Cells["colTenSanPham"].Value.ToString();
            cbbNhaCungCap.Text = dgvSanPham.Rows[e.RowIndex].Cells["colNhaCungCap"].Value.ToString();
            cbbNhaSanXuat.Text = dgvSanPham.Rows[e.RowIndex].Cells["colNhaSanXuat"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (!CheckForm()) return;
            string sql = "select * from SanPham_0 where TenSanPham = N'" + txtTenSanPham.Text + "'";
            bool error = false;
            if (Database.Query(sql).Rows.Count > 0)
            {
                erpBaoLoi.SetError(txtTenSanPham, "Trung ten san pham");
                error = true;
            }
            if (error) return;
            if (!CheckForm()) return;
            sql = "update SanPham_0 set MaSanPham = @MaSanPham, TenSanPham =  @TenSanPham,MaNhaCungCap = @MaNhaCungCap,MaNhaSanXuat = @MaNhaSanXuat " +
                "where MaSanPham = @MaSanPham";
            Dictionary<string, object> Dictionary = new Dictionary<string, object>();
            Dictionary.Add("@MaSanPham", dgvSanPham.CurrentRow.Cells["colMaSanPham"].Value.ToString());
            Dictionary.Add("@TenSanPham", txtTenSanPham.Text);
            Dictionary.Add("@MaNhaCungCap", cbbNhaCungCap.SelectedValue);
            Dictionary.Add("@MaNhaSanXuat", cbbNhaSanXuat.SelectedValue);
            Database.Execute(sql, Dictionary);
            loaddgvSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from SanPham_0 where MaSanPham = @MaSanPham";
            Dictionary<string, object> Dictionary = new Dictionary<string, object>();
            Dictionary.Add("@MaSanPham", dgvSanPham.CurrentRow.Cells["colMaSanPham"].Value.ToString());
            Database.Execute(sql, Dictionary);
            loaddgvSanPham();
        }
    }
}
