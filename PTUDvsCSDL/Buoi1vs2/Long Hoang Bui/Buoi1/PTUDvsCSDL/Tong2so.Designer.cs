namespace PTUDvsCSDL
{
    partial class Tong2so
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
            this.soA = new System.Windows.Forms.NumericUpDown();
            this.soB = new System.Windows.Forms.NumericUpDown();
            this.soTong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chao";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // soA
            // 
            this.soA.Location = new System.Drawing.Point(222, 55);
            this.soA.Name = "soA";
            this.soA.Size = new System.Drawing.Size(120, 20);
            this.soA.TabIndex = 1;
            // 
            // soB
            // 
            this.soB.Location = new System.Drawing.Point(436, 55);
            this.soB.Name = "soB";
            this.soB.Size = new System.Drawing.Size(120, 20);
            this.soB.TabIndex = 2;
            // 
            // soTong
            // 
            this.soTong.Location = new System.Drawing.Point(626, 55);
            this.soTong.Name = "soTong";
            this.soTong.ReadOnly = true;
            this.soTong.Size = new System.Drawing.Size(120, 20);
            this.soTong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhap a bang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhap b bang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tong a + b la";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(830, 43);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 40);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tinhs";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 129);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soTong);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.soA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown soA;
        private System.Windows.Forms.NumericUpDown soB;
        private System.Windows.Forms.NumericUpDown soTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTinh;
    }
}

