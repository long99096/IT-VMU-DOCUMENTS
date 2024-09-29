using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De2_bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string s = txttenmon.Text;
            listBox1.Items.Add(s);
            txttenmon.Clear();
            txttenmon.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while(listBox1.SelectedItems.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItems[0]);
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var i in listBox1.Items)
            {
                listBox2.Items.Add(i);
            }
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while(listBox2.SelectedItems.Count > 0)
            {
                listBox1.Items.Add(listBox2.SelectedItems[0]);
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(var i in listBox2.Items)
            {
                listBox1.Items.Add(i);
            }
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Muon xoa khong", "Thong bao", MessageBoxButtons.YesNo);
            if(rs == DialogResult.Yes)
            {
                if (listBox1.SelectedItems.Count > 0)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
                if (listBox2.SelectedItems.Count > 0)
                {
                    listBox2.Items.Remove(listBox2.SelectedItems[0]);
                }
            }
        }
    }
}
