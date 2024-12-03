using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De7_bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tongtien = 0;
        int soluongtk = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtkhachhang.Text))
               
            {
                MessageBox.Show("Nhap khach sai");
                return;
            }
            if(!int.TryParse(txtdongia.Text, out int dongia) || dongia < 0)
            {
                MessageBox.Show("Nhap dongia sai");
                return;
            }
            if (!int.TryParse(txtsoluong.Text, out int soluong) || soluong < 0)
            {
                MessageBox.Show("Nhap soluong sai");
                return;
            }
            int thanhtien = dongia * soluong;
            
            if (checkBox1.Checked)
            {
                thanhtien = thanhtien * 97 / 100;
            }
            txtThanhtien.Text = thanhtien.ToString();
            tongtien += thanhtien;
            soluongtk = soluongtk + int.Parse(txtsoluong.Text);
            txttongtien.Text = tongtien.ToString();
            txtsoluongtk.Text = soluongtk.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtkhachhang.Clear();
            txtsoluong.Clear();
            txtdongia.Clear();
            checkBox1.Checked = false;
            txtThanhtien.Clear();
            txtkhachhang.Focus();
        }

    }
}
