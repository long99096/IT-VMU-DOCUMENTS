
namespace TUCACH1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThoiHan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaNgonNgu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoaiChungChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.Infor = new System.Windows.Forms.GroupBox();
            this.dgvLoaiChungChi = new System.Windows.Forms.DataGridView();
            this.colMaLoaiChungChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiChungChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erpBaoLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiChungChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpBaoLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThoiHan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbMaNgonNgu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenLoaiChungChi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin";
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.Location = new System.Drawing.Point(187, 122);
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(100, 22);
            this.txtThoiHan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thoi han";
            // 
            // cbbMaNgonNgu
            // 
            this.cbbMaNgonNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaNgonNgu.FormattingEnabled = true;
            this.cbbMaNgonNgu.Location = new System.Drawing.Point(187, 76);
            this.cbbMaNgonNgu.Name = "cbbMaNgonNgu";
            this.cbbMaNgonNgu.Size = new System.Drawing.Size(121, 24);
            this.cbbMaNgonNgu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ma ngon ngu";
            // 
            // txtTenLoaiChungChi
            // 
            this.txtTenLoaiChungChi.Location = new System.Drawing.Point(187, 36);
            this.txtTenLoaiChungChi.Name = "txtTenLoaiChungChi";
            this.txtTenLoaiChungChi.Size = new System.Drawing.Size(246, 22);
            this.txtTenLoaiChungChi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten loai chung chi";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(114, 220);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(347, 220);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(585, 220);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Infor
            // 
            this.Infor.Controls.Add(this.dgvLoaiChungChi);
            this.Infor.Location = new System.Drawing.Point(37, 256);
            this.Infor.Name = "Infor";
            this.Infor.Size = new System.Drawing.Size(721, 230);
            this.Infor.TabIndex = 4;
            this.Infor.TabStop = false;
            this.Infor.Text = "Infor";
            // 
            // dgvLoaiChungChi
            // 
            this.dgvLoaiChungChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiChungChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiChungChi,
            this.colTenLoaiChungChi,
            this.colMaNgonNgu,
            this.colTenNgonNgu,
            this.colThoiHan});
            this.dgvLoaiChungChi.Location = new System.Drawing.Point(9, 18);
            this.dgvLoaiChungChi.Name = "dgvLoaiChungChi";
            this.dgvLoaiChungChi.RowHeadersWidth = 51;
            this.dgvLoaiChungChi.RowTemplate.Height = 24;
            this.dgvLoaiChungChi.Size = new System.Drawing.Size(699, 203);
            this.dgvLoaiChungChi.TabIndex = 0;
            this.dgvLoaiChungChi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiChungChi_RowEnter);
            // 
            // colMaLoaiChungChi
            // 
            this.colMaLoaiChungChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaLoaiChungChi.DataPropertyName = "MaLoaiChungChi";
            this.colMaLoaiChungChi.HeaderText = "Ma loai chung  chi";
            this.colMaLoaiChungChi.MinimumWidth = 6;
            this.colMaLoaiChungChi.Name = "colMaLoaiChungChi";
            // 
            // colTenLoaiChungChi
            // 
            this.colTenLoaiChungChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoaiChungChi.DataPropertyName = "TenLoaiChungChi";
            this.colTenLoaiChungChi.HeaderText = "Ten loai chung chi";
            this.colTenLoaiChungChi.MinimumWidth = 6;
            this.colTenLoaiChungChi.Name = "colTenLoaiChungChi";
            // 
            // colMaNgonNgu
            // 
            this.colMaNgonNgu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNgonNgu.DataPropertyName = "MaNgonNgu";
            this.colMaNgonNgu.HeaderText = "Ma ngon ngu";
            this.colMaNgonNgu.MinimumWidth = 6;
            this.colMaNgonNgu.Name = "colMaNgonNgu";
            // 
            // colTenNgonNgu
            // 
            this.colTenNgonNgu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNgonNgu.DataPropertyName = "TenNgonNgu";
            this.colTenNgonNgu.HeaderText = "Ten ngon ngu";
            this.colTenNgonNgu.MinimumWidth = 6;
            this.colTenNgonNgu.Name = "colTenNgonNgu";
            // 
            // colThoiHan
            // 
            this.colThoiHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThoiHan.DataPropertyName = "ThoiHan";
            this.colThoiHan.HeaderText = "Thoi han";
            this.colThoiHan.MinimumWidth = 6;
            this.colThoiHan.Name = "colThoiHan";
            // 
            // erpBaoLoi
            // 
            this.erpBaoLoi.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.Infor);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FrmLoaiChungChi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Infor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiChungChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpBaoLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThoiHan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaNgonNgu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoaiChungChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox Infor;
        private System.Windows.Forms.DataGridView dgvLoaiChungChi;
        private System.Windows.Forms.ErrorProvider erpBaoLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiChungChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiChungChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiHan;
    }
}

