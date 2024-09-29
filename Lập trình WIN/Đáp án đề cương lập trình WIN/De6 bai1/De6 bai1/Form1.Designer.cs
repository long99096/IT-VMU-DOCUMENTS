
namespace De6_bai1
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
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.MaskedTextBox();
            this.checkCong = new System.Windows.Forms.CheckBox();
            this.checkTru = new System.Windows.Forms.CheckBox();
            this.checkNhan = new System.Windows.Forms.CheckBox();
            this.checkChia = new System.Windows.Forms.CheckBox();
            this.txtketqua = new System.Windows.Forms.MaskedTextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(162, 76);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(172, 22);
            this.txtso1.TabIndex = 0;
            this.txtso1.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(162, 128);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(172, 22);
            this.txtso2.TabIndex = 1;
            // 
            // checkCong
            // 
            this.checkCong.AutoSize = true;
            this.checkCong.Location = new System.Drawing.Point(504, 78);
            this.checkCong.Name = "checkCong";
            this.checkCong.Size = new System.Drawing.Size(63, 21);
            this.checkCong.TabIndex = 2;
            this.checkCong.Text = "Cong";
            this.checkCong.UseVisualStyleBackColor = true;
            // 
            // checkTru
            // 
            this.checkTru.AutoSize = true;
            this.checkTru.Location = new System.Drawing.Point(504, 128);
            this.checkTru.Name = "checkTru";
            this.checkTru.Size = new System.Drawing.Size(52, 21);
            this.checkTru.TabIndex = 3;
            this.checkTru.Text = "Tru";
            this.checkTru.UseVisualStyleBackColor = true;
            // 
            // checkNhan
            // 
            this.checkNhan.AutoSize = true;
            this.checkNhan.Location = new System.Drawing.Point(504, 171);
            this.checkNhan.Name = "checkNhan";
            this.checkNhan.Size = new System.Drawing.Size(64, 21);
            this.checkNhan.TabIndex = 4;
            this.checkNhan.Text = "Nhan";
            this.checkNhan.UseVisualStyleBackColor = true;
            // 
            // checkChia
            // 
            this.checkChia.AutoSize = true;
            this.checkChia.Location = new System.Drawing.Point(504, 221);
            this.checkChia.Name = "checkChia";
            this.checkChia.Size = new System.Drawing.Size(58, 21);
            this.checkChia.TabIndex = 5;
            this.checkChia.Text = "Chia";
            this.checkChia.UseVisualStyleBackColor = true;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(162, 231);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(172, 22);
            this.txtketqua.TabIndex = 6;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(162, 314);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 7;
            this.btntinh.Text = "Tinh";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.checkChia);
            this.Controls.Add(this.checkNhan);
            this.Controls.Add(this.checkTru);
            this.Controls.Add(this.checkCong);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.MaskedTextBox txtso2;
        private System.Windows.Forms.CheckBox checkCong;
        private System.Windows.Forms.CheckBox checkTru;
        private System.Windows.Forms.CheckBox checkNhan;
        private System.Windows.Forms.CheckBox checkChia;
        private System.Windows.Forms.MaskedTextBox txtketqua;
        private System.Windows.Forms.Button btntinh;
    }
}

