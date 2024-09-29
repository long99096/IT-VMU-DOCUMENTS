using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De7_bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '0')
            {
                txtb.Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "0")
            {
                MessageBox.Show("Nhap lai b");
            }
            else if (string.IsNullOrEmpty(txtb.Text))
            {
                txtb.Text = "1";
            }
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);           
            int c = int.Parse(txtc.Text);
            int d = int.Parse(txtd.Text);
            int tuso = a * d + b * c;
            int mauso = b * d;
            txttu.Text = tuso.ToString();
            txtmau.Text = mauso.ToString();
        }
        private int ucln(int a, int b)
        {
            if (b == 0) return a;
            return ucln(b, a % b);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            int c = int.Parse(txtc.Text);
            int d = int.Parse(txtd.Text);
            int tuso = a * d + b * c;
            int mauso = b * d;
            txtagon.Text = (a / ucln(a, b)).ToString();
            txtbgon.Text = (b / ucln(a, b)).ToString();
            txtcgon.Text = (c / ucln(c, d)).ToString();
            txtdgon.Text = (d / ucln(c, d)).ToString();
            txttugon.Text = (tuso / ucln(tuso, mauso)).ToString();
            txtmaugon.Text = (mauso / ucln(tuso, mauso)).ToString();
        }
    }
}
