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
    public partial class Phuongtrinhbac2 : Form
    {
        public Phuongtrinhbac2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a = (double)soA.Value;
            double b = (double)soB.Value;
            double c = (double)soC.Value;
            double kq = 0;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        txtKetQua.Text = "Phuong  trinh vo so nghiem";
                    }
                    else
                    {
                        txtKetQua.Text = "Phuong  trinh vo nghiem";
                    }
                }
                else
                {
                    kq = - c / b;
                    txtKetQua.Text = "Phuong  trinh co nghiem la " + kq;
                }
            }
            else
            {
                double del = b * b - 4 * a * c;
                if(del < 0)
                {
                    txtKetQua.Text = "Phuong trinh vo nghiem";
                }
                else if(del == 0)
                {
                    kq = -b / (2 * a);
                    txtKetQua.Text = "Phuong  trinh co nghiem don la " + kq;
                }
                else
                {
                    double nghiem1 = (-b + Math.Sqrt(del)) / (2 * a);
                    double nghiem2 = (-b - Math.Sqrt(del)) / (2 * a);
                    txtKetQua.Text = "Phuong  trinh co nghiem1 la " + nghiem1 + " Nghiem 2 la " + nghiem2;
                }
            }
            
        }
    }
}
