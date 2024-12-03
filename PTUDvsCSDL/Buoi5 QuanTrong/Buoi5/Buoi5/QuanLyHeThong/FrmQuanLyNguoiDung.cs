using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5.QuanLyHeThong
{
    public partial class FrmQuanLyNguoiDung : Form
    {
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
            cbbQuyen.Text = "Quản lý";
            loadDgvNguoiDung();
        }
        private void loadDgvNguoiDung()
        {
            string sql = "SELECT TaiKhoan, " +
                "CASE Quyen WHEN 'A' THEN N'Quản trị' " +
                "WHEN 'M' THEN N'Quản lý' " +
                "WHEN 'B' THEN N'Khóa' END Quyen FROM NguoiDung";
            dgvNguoiDung.DataSource = Database.Query(sql);
        }

        private void dgvNguoiDung_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTaiKhoan.Text =
                dgvNguoiDung.Rows[e.RowIndex].Cells["colTaiKhoan"].Value.ToString();
            cbbQuyen.Text =
                dgvNguoiDung.Rows[e.RowIndex].Cells["colQuyen"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string quyen = "M";
            if (cbbQuyen.Text == "Quản trị")
                quyen = "A";
            else if (cbbQuyen.Text == "Khóa")
                quyen = "B";
            string taiKhoanDangChon =
                dgvNguoiDung.CurrentRow.Cells["colTaiKhoan"].Value.ToString();
            string sql = "";
            if (txtMatKhau.Text == "")
                sql = "UPDATE NguoiDung " +
                    "SET TaiKhoan='" + taiKhoan + "',Quyen='" + quyen + "'" +
                    "WHERE TaiKhoan='" + taiKhoanDangChon + "'";
            else
            {
                string matKhau = MyString.Encript(txtMatKhau.Text);
                sql = "UPDATE NguoiDung " +
                    "SET TaiKhoan='" + taiKhoan + "',Quyen='" + quyen + "'," +
                    "MatKhau='" + matKhau + "'" +
                    "WHERE TaiKhoan='" + taiKhoanDangChon + "'";
            }
            Database.Execute(sql);
            loadDgvNguoiDung();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = MyString.Encript(txtMatKhau.Text);
            string quyen = "M";
            if (cbbQuyen.Text == "Quản trị")
                quyen = "A";
            else if (cbbQuyen.Text == "Khóa")
                quyen = "B";
            string sql = "INSERT NguoiDung VALUES('" + taiKhoan
                + "','" + matKhau + "','" + quyen + "')";
            Database.Execute(sql);
            loadDgvNguoiDung();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete NguoiDung where TaiKhoan = '"+dgvNguoiDung.CurrentRow.Cells["colTaiKhoan"].Value.ToString()+"'" ;
            Database.Execute(sql);
            loadDgvNguoiDung();
        }
    }
}