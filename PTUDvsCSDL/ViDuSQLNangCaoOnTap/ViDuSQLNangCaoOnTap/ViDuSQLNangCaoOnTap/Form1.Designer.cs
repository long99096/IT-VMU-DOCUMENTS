
namespace ViDuSQLNangCaoOnTap
{
    partial class FrmQuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbPhongBan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpNgaySinhTK = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbPhongBanTK = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChiTK = new System.Windows.Forms.TextBox();
            this.cbbChucVuTK = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbGioiTinhTK = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHoTenTK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkHoTen = new System.Windows.Forms.CheckBox();
            this.checkNgaySinh = new System.Windows.Forms.CheckBox();
            this.checkDiaChi = new System.Windows.Forms.CheckBox();
            this.checkChucVu = new System.Windows.Forms.CheckBox();
            this.checkGioiTinh = new System.Windows.Forms.CheckBox();
            this.checkPhongBan = new System.Windows.Forms.CheckBox();
            this.checkMaNhanVien = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownMaNhanVienTK = new System.Windows.Forms.NumericUpDown();
            this.erpBaoLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaNhanVienTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpBaoLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbPhongBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.cbbChucVu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin nhan vien";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(104, 82);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngay sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phong ban";
            // 
            // cbbPhongBan
            // 
            this.cbbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhongBan.FormattingEnabled = true;
            this.cbbPhongBan.Location = new System.Drawing.Point(331, 158);
            this.cbbPhongBan.Name = "cbbPhongBan";
            this.cbbPhongBan.Size = new System.Drawing.Size(131, 24);
            this.cbbPhongBan.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chuc vu";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(104, 122);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(220, 22);
            this.txtDiaChi.TabIndex = 14;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(104, 158);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(131, 24);
            this.cbbChucVu.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dia chi";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(320, 45);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cbbGioiTinh.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gioi tinh";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(80, 45);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(158, 22);
            this.txtHoTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ho ten";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(21, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuc nang";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(398, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(200, 32);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNhanVien,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDiaChi,
            this.colChucVu,
            this.colPhongBan});
            this.dgvNhanVien.Location = new System.Drawing.Point(21, 362);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1008, 135);
            this.dgvNhanVien.TabIndex = 3;
            this.dgvNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_RowEnter);
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "Ma Nhan Vien";
            this.colMaNhanVien.MinimumWidth = 6;
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.ReadOnly = true;
            this.colMaNhanVien.Width = 125;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Ho Ten";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Width = 125;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgaySinh.HeaderText = "Ngay Sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Width = 125;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Gioi Tinh";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 125;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Dia Chi";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Width = 125;
            // 
            // colChucVu
            // 
            this.colChucVu.DataPropertyName = "TenChucVu";
            this.colChucVu.HeaderText = "Chuc Vu";
            this.colChucVu.MinimumWidth = 6;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.ReadOnly = true;
            this.colChucVu.Width = 125;
            // 
            // colPhongBan
            // 
            this.colPhongBan.DataPropertyName = "TenPhongBan";
            this.colPhongBan.HeaderText = "Phong Ban";
            this.colPhongBan.MinimumWidth = 6;
            this.colPhongBan.Name = "colPhongBan";
            this.colPhongBan.ReadOnly = true;
            this.colPhongBan.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownMaNhanVienTK);
            this.groupBox3.Controls.Add(this.checkMaNhanVien);
            this.groupBox3.Controls.Add(this.checkPhongBan);
            this.groupBox3.Controls.Add(this.checkGioiTinh);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.checkChucVu);
            this.groupBox3.Controls.Add(this.checkDiaChi);
            this.groupBox3.Controls.Add(this.checkNgaySinh);
            this.groupBox3.Controls.Add(this.checkHoTen);
            this.groupBox3.Controls.Add(this.dtpNgaySinhTK);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbbPhongBanTK);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDiaChiTK);
            this.groupBox3.Controls.Add(this.cbbChucVuTK);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbbGioiTinhTK);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtHoTenTK);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(512, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 299);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tim kiem";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(200, 71);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tim kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpNgaySinhTK
            // 
            this.dtpNgaySinhTK.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhTK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhTK.Location = new System.Drawing.Point(111, 105);
            this.dtpNgaySinhTK.Name = "dtpNgaySinhTK";
            this.dtpNgaySinhTK.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinhTK.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ngay sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Phong ban";
            // 
            // cbbPhongBanTK
            // 
            this.cbbPhongBanTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhongBanTK.FormattingEnabled = true;
            this.cbbPhongBanTK.Location = new System.Drawing.Point(109, 262);
            this.cbbPhongBanTK.Name = "cbbPhongBanTK";
            this.cbbPhongBanTK.Size = new System.Drawing.Size(131, 24);
            this.cbbPhongBanTK.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Chuc vu";
            // 
            // txtDiaChiTK
            // 
            this.txtDiaChiTK.Location = new System.Drawing.Point(111, 145);
            this.txtDiaChiTK.Name = "txtDiaChiTK";
            this.txtDiaChiTK.Size = new System.Drawing.Size(220, 22);
            this.txtDiaChiTK.TabIndex = 26;
            // 
            // cbbChucVuTK
            // 
            this.cbbChucVuTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVuTK.FormattingEnabled = true;
            this.cbbChucVuTK.Location = new System.Drawing.Point(111, 181);
            this.cbbChucVuTK.Name = "cbbChucVuTK";
            this.cbbChucVuTK.Size = new System.Drawing.Size(131, 24);
            this.cbbChucVuTK.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Dia chi";
            // 
            // cbbGioiTinhTK
            // 
            this.cbbGioiTinhTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinhTK.FormattingEnabled = true;
            this.cbbGioiTinhTK.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbbGioiTinhTK.Location = new System.Drawing.Point(99, 224);
            this.cbbGioiTinhTK.Name = "cbbGioiTinhTK";
            this.cbbGioiTinhTK.Size = new System.Drawing.Size(121, 24);
            this.cbbGioiTinhTK.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Gioi tinh";
            // 
            // txtHoTenTK
            // 
            this.txtHoTenTK.Location = new System.Drawing.Point(87, 68);
            this.txtHoTenTK.Name = "txtHoTenTK";
            this.txtHoTenTK.Size = new System.Drawing.Size(158, 22);
            this.txtHoTenTK.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ho ten";
            // 
            // checkHoTen
            // 
            this.checkHoTen.AutoSize = true;
            this.checkHoTen.Location = new System.Drawing.Point(346, 68);
            this.checkHoTen.Name = "checkHoTen";
            this.checkHoTen.Size = new System.Drawing.Size(110, 21);
            this.checkHoTen.TabIndex = 33;
            this.checkHoTen.Text = "checkHoTen";
            this.checkHoTen.UseVisualStyleBackColor = true;
            // 
            // checkNgaySinh
            // 
            this.checkNgaySinh.AutoSize = true;
            this.checkNgaySinh.Location = new System.Drawing.Point(346, 105);
            this.checkNgaySinh.Name = "checkNgaySinh";
            this.checkNgaySinh.Size = new System.Drawing.Size(128, 21);
            this.checkNgaySinh.TabIndex = 34;
            this.checkNgaySinh.Text = "checkNgaySinh";
            this.checkNgaySinh.UseVisualStyleBackColor = true;
            // 
            // checkDiaChi
            // 
            this.checkDiaChi.AutoSize = true;
            this.checkDiaChi.Location = new System.Drawing.Point(346, 149);
            this.checkDiaChi.Name = "checkDiaChi";
            this.checkDiaChi.Size = new System.Drawing.Size(108, 21);
            this.checkDiaChi.TabIndex = 35;
            this.checkDiaChi.Text = "checkDiaChi";
            this.checkDiaChi.UseVisualStyleBackColor = true;
            // 
            // checkChucVu
            // 
            this.checkChucVu.AutoSize = true;
            this.checkChucVu.Location = new System.Drawing.Point(346, 181);
            this.checkChucVu.Name = "checkChucVu";
            this.checkChucVu.Size = new System.Drawing.Size(116, 21);
            this.checkChucVu.TabIndex = 36;
            this.checkChucVu.Text = "checkChucVu";
            this.checkChucVu.UseVisualStyleBackColor = true;
            // 
            // checkGioiTinh
            // 
            this.checkGioiTinh.AutoSize = true;
            this.checkGioiTinh.Location = new System.Drawing.Point(346, 223);
            this.checkGioiTinh.Name = "checkGioiTinh";
            this.checkGioiTinh.Size = new System.Drawing.Size(120, 21);
            this.checkGioiTinh.TabIndex = 37;
            this.checkGioiTinh.Text = "checkGioiTinh";
            this.checkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // checkPhongBan
            // 
            this.checkPhongBan.AutoSize = true;
            this.checkPhongBan.Location = new System.Drawing.Point(341, 264);
            this.checkPhongBan.Name = "checkPhongBan";
            this.checkPhongBan.Size = new System.Drawing.Size(133, 21);
            this.checkPhongBan.TabIndex = 38;
            this.checkPhongBan.Text = "checkPhongBan";
            this.checkPhongBan.UseVisualStyleBackColor = true;
            // 
            // checkMaNhanVien
            // 
            this.checkMaNhanVien.AutoSize = true;
            this.checkMaNhanVien.Location = new System.Drawing.Point(341, 34);
            this.checkMaNhanVien.Name = "checkMaNhanVien";
            this.checkMaNhanVien.Size = new System.Drawing.Size(148, 21);
            this.checkMaNhanVien.TabIndex = 41;
            this.checkMaNhanVien.Text = "checkMaNhanVien";
            this.checkMaNhanVien.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "Ma nhan vien";
            // 
            // numericUpDownMaNhanVienTK
            // 
            this.numericUpDownMaNhanVienTK.Location = new System.Drawing.Point(142, 33);
            this.numericUpDownMaNhanVienTK.Name = "numericUpDownMaNhanVienTK";
            this.numericUpDownMaNhanVienTK.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMaNhanVienTK.TabIndex = 42;
            // 
            // erpBaoLoi
            // 
            this.erpBaoLoi.ContainerControl = this;
            // 
            // FrmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQuanLyNhanVien";
            this.Text = "FrmQuanLyNhanVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaNhanVienTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpBaoLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbPhongBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongBan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhTK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbPhongBanTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChiTK;
        private System.Windows.Forms.ComboBox cbbChucVuTK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbGioiTinhTK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHoTenTK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.CheckBox checkPhongBan;
        private System.Windows.Forms.CheckBox checkGioiTinh;
        private System.Windows.Forms.CheckBox checkChucVu;
        private System.Windows.Forms.CheckBox checkDiaChi;
        private System.Windows.Forms.CheckBox checkNgaySinh;
        private System.Windows.Forms.CheckBox checkHoTen;
        private System.Windows.Forms.CheckBox checkMaNhanVien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownMaNhanVienTK;
        private System.Windows.Forms.ErrorProvider erpBaoLoi;
    }
}

