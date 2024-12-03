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
    public partial class BCNN : Form
    {
        public BCNN()
        {
            InitializeComponent();
        }

        private int timUCLN(int a, int b)
        {
            if (b == 0) return a;
            return timUCLN(b, a % b);
        }

        private int timBCNN(int a, int b)
        {
            return a / timUCLN(a, b) * b;
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            txtBCNN.Text = timBCNN(a, b).ToString();
        }
    }
}
