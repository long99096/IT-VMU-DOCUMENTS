using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5.QuanLyHeThong
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = MyString.Encript(txtMauKhau.Text);
            string sql = "select MauKhau from NguoiDung where " + "TaiKhoan = '" + taikhoan + "'";
            DataTable table = Database.Query(sql);
            if(table.Rows.Count == 0)
            {
                MessageBox.Show("Khong ton tai nguoi dung");
            }
            else if(table.Rows[0][0].ToString() == matkhau)
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
            {
                MessageBox.Show("Sai mat khau");
            }
        }
    }
}
