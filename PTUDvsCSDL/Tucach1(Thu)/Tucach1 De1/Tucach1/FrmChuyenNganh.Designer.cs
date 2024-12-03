
namespace Tucach1
{
    partial class FrmChuyenNganh
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
            this.txtTenChuyenNganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaGiangVienPhuTrach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvChuyenNganh = new System.Windows.Forms.DataGridView();
            this.colMaChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGiangVienPhuTrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erpBaoLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpBaoLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaGiangVienPhuTrach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenChuyenNganh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin";
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTenChuyenNganh
            // 
            this.txtTenChuyenNganh.Location = new System.Drawing.Point(293, 90);
            this.txtTenChuyenNganh.Name = "txtTenChuyenNganh";
            this.txtTenChuyenNganh.Size = new System.Drawing.Size(232, 22);
            this.txtTenChuyenNganh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten chuyen nganh";
            // 
            // txtMaGiangVienPhuTrach
            // 
            this.txtMaGiangVienPhuTrach.Location = new System.Drawing.Point(293, 131);
            this.txtMaGiangVienPhuTrach.Name = "txtMaGiangVienPhuTrach";
            this.txtMaGiangVienPhuTrach.Size = new System.Drawing.Size(232, 22);
            this.txtMaGiangVienPhuTrach.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ma giang vien phu trach";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(141, 235);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(311, 235);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(472, 235);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvChuyenNganh
            // 
            this.dgvChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChuyenNganh,
            this.colTenChuyenNganh,
            this.colMaGiangVienPhuTrach});
            this.dgvChuyenNganh.Location = new System.Drawing.Point(66, 279);
            this.dgvChuyenNganh.Name = "dgvChuyenNganh";
            this.dgvChuyenNganh.RowHeadersWidth = 51;
            this.dgvChuyenNganh.RowTemplate.Height = 24;
            this.dgvChuyenNganh.Size = new System.Drawing.Size(655, 151);
            this.dgvChuyenNganh.TabIndex = 4;
            this.dgvChuyenNganh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenNganh_RowEnter);
            // 
            // colMaChuyenNganh
            // 
            this.colMaChuyenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaChuyenNganh.DataPropertyName = "MaChuyenNganh";
            this.colMaChuyenNganh.HeaderText = "Ma chuyen nganh";
            this.colMaChuyenNganh.MinimumWidth = 6;
            this.colMaChuyenNganh.Name = "colMaChuyenNganh";
            // 
            // colTenChuyenNganh
            // 
            this.colTenChuyenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenChuyenNganh.DataPropertyName = "TenChuyenNganh";
            this.colTenChuyenNganh.HeaderText = "Ten chuyen nganh";
            this.colTenChuyenNganh.MinimumWidth = 6;
            this.colTenChuyenNganh.Name = "colTenChuyenNganh";
            // 
            // colMaGiangVienPhuTrach
            // 
            this.colMaGiangVienPhuTrach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaGiangVienPhuTrach.DataPropertyName = "MaGiangVienPhuTrach";
            this.colMaGiangVienPhuTrach.HeaderText = "Ma giang vien phu trach";
            this.colMaGiangVienPhuTrach.MinimumWidth = 6;
            this.colMaGiangVienPhuTrach.Name = "colMaGiangVienPhuTrach";
            // 
            // erpBaoLoi
            // 
            this.erpBaoLoi.ContainerControl = this;
            // 
            // FrmChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChuyenNganh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmChuyenNganh";
            this.Text = "FrmChuyenNganh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpBaoLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaGiangVienPhuTrach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenChuyenNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGiangVienPhuTrach;
        private System.Windows.Forms.ErrorProvider erpBaoLoi;
    }
}