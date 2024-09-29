using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De8_bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            while (listBox2.SelectedItems.Count > 0)
            {
                listBox1.Items.Add(listBox2.SelectedItems[0]);
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var i in listBox2.Items)
            {
                listBox1.Items.Add(i);
            }
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox2.Items.Count == 0)
            {
                listketqua.Items.Add(txtten.Text);
                listketqua.Items.Add("---Cac mon da chon---");
                listketqua.Items.Add("Chua chon mon nao");
            }
            else
            {
                listketqua.Items.Add(txtten.Text);
                listketqua.Items.Add("---Cac mon da chon---");
                StringBuilder chuoi = new StringBuilder();
                foreach(var i in listBox2.Items)
                {
                    chuoi.Append(i.ToString() + ", ");
                }
                listketqua.Items.Add(chuoi);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
            listketqua.Items.Clear();
            txtten.Clear();
        }
    }
}
