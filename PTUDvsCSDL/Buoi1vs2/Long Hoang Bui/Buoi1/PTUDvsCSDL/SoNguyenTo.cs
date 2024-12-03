using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDvsCSDL
{
    public partial class SoNguyenTo : Form
    {
        public SoNguyenTo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SoNguyenTo_Load(object sender, EventArgs e)
        {

        }
        private bool check(int x)
        {
            if (x < 2) return false;
            if (x == 2) return true;
            double sqrtX = Math.Sqrt(x);
            for(int i = 2; i <= sqrtX; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double n = (double)soN.Value;
            if (n <= 0) txtKQ.Text = "Nhap lai N di nhoc con";
            else
            {
                for(int i = 2; i < n; i++){
                    if (check(i))
                    {
                        txtKQ.Text += i + " ";
                    }
                }
            }
        }
    }
}
