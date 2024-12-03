using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1_bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string s = comboBox1.Text + " " + txttendem.Text + " " + txtten.Text;
            listBox1.Items.Add(s);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Muon xoa khong", " Thong bao", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }
    }
}
