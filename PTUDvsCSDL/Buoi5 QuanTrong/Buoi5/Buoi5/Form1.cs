using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buoi5.QuanLyHeThong;
using Buoi5.QuanLyThongTinSanPham;
using Buoi5.QuanLyDanhMuc;

namespace Buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mniQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung form = new FrmQuanLyNguoiDung();
            form.ShowDialog();
        }


        private void quảnLýMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyThongTinManHinh form = new FrmQuanLyThongTinManHinh();
            form.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhaCungCap form = new FrmQuanLyNhaCungCap();
            form.ShowDialog();
        }
    }
}
