
namespace Buoi5.QuanLyThongTinSanPham
{
    partial class FrmQuanLyThongTinManHinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudGia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cBNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoPhanGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudKichThuoc = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTanSoQuet = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudDoSang = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKichThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanSoQuet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoSang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nudDoSang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudTanSoQuet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudKichThuoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDoPhanGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBNhaSanXuat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Location = new System.Drawing.Point(64, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin màn hình";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(205, 33);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(264, 22);
            this.txtTenSanPham.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sản phẩm";
            // 
            // nudGia
            // 
            this.nudGia.Location = new System.Drawing.Point(205, 61);
            this.nudGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudGia.Name = "nudGia";
            this.nudGia.Size = new System.Drawing.Size(120, 22);
            this.nudGia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá";
            // 
            // cBNhaSanXuat
            // 
            this.cBNhaSanXuat.DisplayMember = "TenNhaSanXuat";
            this.cBNhaSanXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBNhaSanXuat.FormattingEnabled = true;
            this.cBNhaSanXuat.Location = new System.Drawing.Point(204, 89);
            this.cBNhaSanXuat.Name = "cBNhaSanXuat";
            this.cBNhaSanXuat.Size = new System.Drawing.Size(121, 24);
            this.cBNhaSanXuat.TabIndex = 4;
            this.cBNhaSanXuat.ValueMember = "MaNhaSanXuat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhà sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Độ phân giải";
            // 
            // txtDoPhanGia
            // 
            this.txtDoPhanGia.Location = new System.Drawing.Point(204, 119);
            this.txtDoPhanGia.Name = "txtDoPhanGia";
            this.txtDoPhanGia.Size = new System.Drawing.Size(264, 22);
            this.txtDoPhanGia.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kích thước";
            // 
            // nudKichThuoc
            // 
            this.nudKichThuoc.Location = new System.Drawing.Point(204, 147);
            this.nudKichThuoc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudKichThuoc.Name = "nudKichThuoc";
            this.nudKichThuoc.Size = new System.Drawing.Size(120, 22);
            this.nudKichThuoc.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tần số quét";
            // 
            // nudTanSoQuet
            // 
            this.nudTanSoQuet.Location = new System.Drawing.Point(204, 175);
            this.nudTanSoQuet.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTanSoQuet.Name = "nudTanSoQuet";
            this.nudTanSoQuet.Size = new System.Drawing.Size(120, 22);
            this.nudTanSoQuet.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Độ sáng";
            // 
            // nudDoSang
            // 
            this.nudDoSang.Location = new System.Drawing.Point(204, 203);
            this.nudDoSang.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudDoSang.Name = "nudDoSang";
            this.nudDoSang.Size = new System.Drawing.Size(120, 22);
            this.nudDoSang.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSanPham,
            this.colTenSanPham,
            this.colGia});
            this.dgv.Location = new System.Drawing.Point(64, 326);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(670, 157);
            this.dgv.TabIndex = 15;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã Sản Phẩm";
            this.colMaSanPham.MinimumWidth = 6;
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.Width = 125;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.colTenSanPham.MinimumWidth = 6;
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Width = 125;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "Gia";
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.Width = 125;
            // 
            // FrmQuanLyThongTinManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQuanLyThongTinManHinh";
            this.Text = "FrmQuanLyThongTinManHinh";
            this.Load += new System.EventHandler(this.FrmQuanLyThongTinManHinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKichThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanSoQuet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoSang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudDoSang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTanSoQuet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudKichThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoPhanGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBNhaSanXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
    }
}