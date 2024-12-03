namespace PTUDvsCSDL
{
    partial class Phuongtrinhbac2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soA = new System.Windows.Forms.NumericUpDown();
            this.soB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.soC = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.soA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giai phuong trinh bac 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhap a";
            // 
            // soA
            // 
            this.soA.Location = new System.Drawing.Point(61, 110);
            this.soA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.soA.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.soA.Name = "soA";
            this.soA.Size = new System.Drawing.Size(120, 20);
            this.soA.TabIndex = 2;
            // 
            // soB
            // 
            this.soB.Location = new System.Drawing.Point(238, 110);
            this.soB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.soB.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.soB.Name = "soB";
            this.soB.Size = new System.Drawing.Size(120, 20);
            this.soB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhap b";
            // 
            // soC
            // 
            this.soC.Location = new System.Drawing.Point(402, 110);
            this.soC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.soC.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.soC.Name = "soC";
            this.soC.Size = new System.Drawing.Size(120, 20);
            this.soC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhap c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ket qua";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(621, 110);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 10;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(117, 215);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(516, 29);
            this.txtKetQua.TabIndex = 11;
            // 
            // Phuongtrinhbac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 356);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Phuongtrinhbac2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.soA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown soA;
        private System.Windows.Forms.NumericUpDown soB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown soC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}