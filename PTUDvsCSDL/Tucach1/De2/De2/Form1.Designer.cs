
namespace De2
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
            this.Infor = new System.Windows.Forms.GroupBox();
            this.dgvChungChi = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenNhanVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiChungChi = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayCap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.colMaChungChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoaiChungChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiChungChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChungChi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Infor
            // 
            this.Infor.Controls.Add(this.dgvChungChi);
            this.Infor.Location = new System.Drawing.Point(44, 265);
            this.Infor.Name = "Infor";
            this.Infor.Size = new System.Drawing.Size(721, 230);
            this.Infor.TabIndex = 9;
            this.Infor.TabStop = false;
            this.Infor.Text = "Infor";
            // 
            // dgvChungChi
            // 
            this.dgvChungChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChungChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChungChi,
            this.colMaLoaiChungChi,
            this.colLoaiChungChi,
            this.colMaNhanVien,
            this.colTenNhanVien,
            this.colNgayCap,
            this.colNoiCap});
            this.dgvChungChi.Location = new System.Drawing.Point(9, 18);
            this.dgvChungChi.Name = "dgvChungChi";
            this.dgvChungChi.RowHeadersWidth = 51;
            this.dgvChungChi.RowTemplate.Height = 24;
            this.dgvChungChi.Size = new System.Drawing.Size(699, 203);
            this.dgvChungChi.TabIndex = 0;
            this.dgvChungChi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChungChi_RowEnter);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(592, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(354, 229);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(121, 229);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayCap);
            this.groupBox1.Controls.Add(this.cbbLoaiChungChi);
            this.groupBox1.Controls.Add(this.txtNoiCap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbTenNhanVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin";
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(187, 161);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(200, 22);
            this.txtNoiCap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngay cap";
            // 
            // cbbTenNhanVien
            // 
            this.cbbTenNhanVien.FormattingEnabled = true;
            this.cbbTenNhanVien.Location = new System.Drawing.Point(187, 76);
            this.cbbTenNhanVien.Name = "cbbTenNhanVien";
            this.cbbTenNhanVien.Size = new System.Drawing.Size(121, 24);
            this.cbbTenNhanVien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhan Vien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chung chi";
            // 
            // cbbLoaiChungChi
            // 
            this.cbbLoaiChungChi.FormattingEnabled = true;
            this.cbbLoaiChungChi.Location = new System.Drawing.Point(187, 36);
            this.cbbLoaiChungChi.Name = "cbbLoaiChungChi";
            this.cbbLoaiChungChi.Size = new System.Drawing.Size(121, 24);
            this.cbbLoaiChungChi.TabIndex = 6;
            // 
            // dateTimePickerNgayCap
            // 
            this.dateTimePickerNgayCap.Location = new System.Drawing.Point(187, 122);
            this.dateTimePickerNgayCap.Name = "dateTimePickerNgayCap";
            this.dateTimePickerNgayCap.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNgayCap.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Noi cap";
            // 
            // colMaChungChi
            // 
            this.colMaChungChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaChungChi.DataPropertyName = "MaChungChi";
            this.colMaChungChi.HeaderText = "Ma chung chi";
            this.colMaChungChi.MinimumWidth = 6;
            this.colMaChungChi.Name = "colMaChungChi";
            // 
            // colMaLoaiChungChi
            // 
            this.colMaLoaiChungChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaLoaiChungChi.DataPropertyName = "MaLoaiChungChi";
            this.colMaLoaiChungChi.HeaderText = "Ma loai chung chi";
            this.colMaLoaiChungChi.MinimumWidth = 6;
            this.colMaLoaiChungChi.Name = "colMaLoaiChungChi";
            // 
            // colLoaiChungChi
            // 
            this.colLoaiChungChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLoaiChungChi.DataPropertyName = "TenLoaiChungChi";
            this.colLoaiChungChi.HeaderText = "Ten loai chung chi";
            this.colLoaiChungChi.MinimumWidth = 6;
            this.colLoaiChungChi.Name = "colLoaiChungChi";
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "Ma nhan vien";
            this.colMaNhanVien.MinimumWidth = 6;
            this.colMaNhanVien.Name = "colMaNhanVien";
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNhanVien.DataPropertyName = "HoTen";
            this.colTenNhanVien.HeaderText = "Ten nhan vien";
            this.colTenNhanVien.MinimumWidth = 6;
            this.colTenNhanVien.Name = "colTenNhanVien";
            // 
            // colNgayCap
            // 
            this.colNgayCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgayCap.DataPropertyName = "NgayCap";
            this.colNgayCap.HeaderText = "Ngay cap";
            this.colNgayCap.MinimumWidth = 6;
            this.colNgayCap.Name = "colNgayCap";
            // 
            // colNoiCap
            // 
            this.colNoiCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNoiCap.DataPropertyName = "NoiCap";
            this.colNoiCap.HeaderText = "Noi cap";
            this.colNoiCap.MinimumWidth = 6;
            this.colNoiCap.Name = "colNoiCap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.Infor);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FrmChungChi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Infor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChungChi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Infor;
        private System.Windows.Forms.DataGridView dgvChungChi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayCap;
        private System.Windows.Forms.ComboBox cbbLoaiChungChi;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChungChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiChungChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiChungChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiCap;
    }
}

