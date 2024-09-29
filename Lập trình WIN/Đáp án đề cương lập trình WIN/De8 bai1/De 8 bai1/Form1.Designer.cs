
namespace De_8_bai1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.btnKhachmoi = new System.Windows.Forms.Button();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(121, 77);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(215, 22);
            this.txtten.TabIndex = 0;
            this.txtten.TextChanged += new System.EventHandler(this.txtten_TextChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(121, 137);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(215, 22);
            this.txtsoluong.TabIndex = 1;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(121, 189);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(215, 22);
            this.txtdongia.TabIndex = 2;
            // 
            // btnKhachmoi
            // 
            this.btnKhachmoi.Location = new System.Drawing.Point(121, 276);
            this.btnKhachmoi.Name = "btnKhachmoi";
            this.btnKhachmoi.Size = new System.Drawing.Size(112, 23);
            this.btnKhachmoi.TabIndex = 3;
            this.btnKhachmoi.Text = "Khach moi";
            this.btnKhachmoi.UseVisualStyleBackColor = true;
            this.btnKhachmoi.Click += new System.EventHandler(this.btnKhachmoi_Click);
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.Location = new System.Drawing.Point(267, 276);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(112, 23);
            this.btnTinhtien.TabIndex = 4;
            this.btnTinhtien.Text = "Tinh tien";
            this.btnTinhtien.UseVisualStyleBackColor = true;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(439, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(284, 313);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ten khach hang";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thanh tien";
            this.columnHeader2.Width = 114;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(121, 239);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "-5%";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.btnKhachmoi);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button btnKhachmoi;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

