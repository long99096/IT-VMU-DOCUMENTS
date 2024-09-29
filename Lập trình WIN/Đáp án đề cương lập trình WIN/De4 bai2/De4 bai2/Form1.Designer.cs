
namespace De4_bai2
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtlop = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoalop = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnXoasinhvien = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(311, 25);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(188, 22);
            this.txtten.TabIndex = 0;
            this.txtten.TextChanged += new System.EventHandler(this.txtten_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoalop);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtlop);
            this.groupBox1.Location = new System.Drawing.Point(129, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lop";
            // 
            // txtlop
            // 
            this.txtlop.Location = new System.Drawing.Point(97, 21);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(169, 22);
            this.txtlop.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(371, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoalop
            // 
            this.btnXoalop.Location = new System.Drawing.Point(371, 66);
            this.btnXoalop.Name = "btnXoalop";
            this.btnXoalop.Size = new System.Drawing.Size(75, 23);
            this.btnXoalop.TabIndex = 3;
            this.btnXoalop.Text = "Xoa lop";
            this.btnXoalop.UseVisualStyleBackColor = true;
            this.btnXoalop.Click += new System.EventHandler(this.btnXoalop_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(129, 321);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(541, 100);
            this.listBox1.TabIndex = 3;
            // 
            // btnDangky
            // 
            this.btnDangky.Location = new System.Drawing.Point(236, 281);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(75, 23);
            this.btnDangky.TabIndex = 4;
            this.btnDangky.Text = "Dang ky";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnXoasinhvien
            // 
            this.btnXoasinhvien.Location = new System.Drawing.Point(446, 281);
            this.btnXoasinhvien.Name = "btnXoasinhvien";
            this.btnXoasinhvien.Size = new System.Drawing.Size(75, 23);
            this.btnXoasinhvien.TabIndex = 4;
            this.btnXoasinhvien.Text = "Xoa thanh vien";
            this.btnXoasinhvien.UseVisualStyleBackColor = true;
            this.btnXoasinhvien.Click += new System.EventHandler(this.btnXoasinhvien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoasinhvien);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoalop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox txtlop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnXoasinhvien;
    }
}

