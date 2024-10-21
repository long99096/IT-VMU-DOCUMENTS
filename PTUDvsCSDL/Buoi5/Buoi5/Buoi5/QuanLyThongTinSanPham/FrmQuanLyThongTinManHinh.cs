using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5.QuanLyThongTinSanPham
{
    public partial class FrmQuanLyThongTinManHinh : Form
    {
        public FrmQuanLyThongTinManHinh()
        {
            InitializeComponent();
            loadcBNhaSanXuat();
            loaddgv();
        }

        private void FrmQuanLyThongTinManHinh_Load(object sender, EventArgs e)
        {

        }

        private void loadcBNhaSanXuat()
        {
            cBNhaSanXuat.DataSource = Database.Query("select * from NhaSanXuat");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert SanPham (LoaiSanPham, TenSanPham, Gia, SoLuong, MaNhaSanXuat) values " +
                "('SC', N'" + txtTenSanPham.Text + "', "+nudGia.Value.ToString()+", 0, '"+cBNhaSanXuat.SelectedValue.ToString()+"')";
            Database.Execute(sql);
            string maSanPham = Database.Query("select max(MaSanPham) from SanPham").Rows[0][0].ToString();
            sql = "insert ManHinh values (" + maSanPham + ", 'SC', '" + txtDoPhanGia.Text + "', " + nudKichThuoc.Value.ToString() + ", "+nudTanSoQuet.Value.ToString()+", "+nudDoSang.Value.ToString()+")";
            Database.Execute(sql);
            loaddgv();
        }

        private void loaddgv()
        {
            dgv.DataSource = Database.Query("select ManHinh.MaSanPham, TenSanPham, Gia, TenNhaSanXuat, Gia, DoPhanGiai, KichThuoc, TanSoQuet, DoSang from SanPham inner join NhaSanXuat on SanPham.MaNhaSanXuat = NhaSanXuat.MaNhaSanXuat inner join ManHinh on SanPham.MaSanPham = ManHinh.MaSanPham");
        }
    }
}
