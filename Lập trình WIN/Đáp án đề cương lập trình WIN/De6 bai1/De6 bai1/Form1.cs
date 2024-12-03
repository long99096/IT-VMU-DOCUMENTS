using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De6_bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtketqua.ReadOnly = true;
            checkCong.Checked = true;
            btntinh.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtso1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtso1.Text))
            {
                btntinh.Enabled = true;
            }
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtso1.Text);
            int so2 = int.Parse(txtso2.Text);
            if (checkCong.Checked == true)
            {
                int ketqua = so1 + so2;
                txtketqua.Text = ketqua.ToString();
            }
            else if (checkTru.Checked == true)
            {
                int ketqua = so1 - so2;
                txtketqua.Text = ketqua.ToString();
            }
            else if (checkNhan.Checked == true)
            {
                int ketqua = so1 * so2;
                txtketqua.Text = ketqua.ToString();
            }
            else if (checkChia.Checked == true)
            {
                int ketqua = so1 / so2;
                txtketqua.Text = ketqua.ToString();
            }
        }
    }
}
