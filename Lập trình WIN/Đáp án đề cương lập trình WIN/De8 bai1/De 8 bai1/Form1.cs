using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_8_bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKhachmoi_Click(object sender, EventArgs e)
        {
            txtten.Clear();
            txtsoluong.Clear();
            txtdongia.Clear();
            checkBox1.Checked = false;
            btnTinhtien.Enabled = false;
        }
        public static string chuanhoa(string input)
        {
            // Cắt khoảng trắng thừa hai đầu
            input = input.Trim();

            // Tách văn bản thành mảng các từ
            string[] words = input.Split(' ');

            // Chuẩn hóa mỗi từ (in hoa ký tự đầu, 1 khoảng trắng giữa các từ)
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            // Nối lại thành chuỗi văn bản đã chuẩn hóa
            return string.Join(" ", words);
        }
  
public static string viethoa(string text)
    {
        StringBuilder sb = new StringBuilder();
        bool isFirstLetter = true;

        foreach (char c in text)
        {
            if (isFirstLetter && char.IsLetter(c))
            {
                sb.Append(char.ToUpper(c));
                isFirstLetter = false;
            }
            else if (char.IsWhiteSpace(c))
            {
                sb.Append(c);
                isFirstLetter = true;
            }
            else
            {
                sb.Append(char.ToLower(c));
            }
        }

        return sb.ToString();
    }

    private void btnTinhtien_Click(object sender, EventArgs e)
        {
            int tien = int.Parse(txtsoluong.Text) * int.Parse(txtdongia.Text);
            string ten = txtten.Text.Trim();
            ten = System.Text.RegularExpressions.Regex.Replace(ten, @"\s+", " ");
            ten = viethoa(ten);
            ListViewItem item = new ListViewItem();
            item.Text = ten;
            listView1.Items.Add(item);
            item.SubItems.Add(tien.ToString());
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtten.Text))
            {
                btnTinhtien.Enabled = true;
            }
        }
    }
}
