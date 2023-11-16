namespace QuanLyQuanRuou
{
    partial class FormTTMoMo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnTaoQR = new System.Windows.Forms.Button();
            this.pcQR = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcQR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên người nhận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập số tiền";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(169, 40);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(219, 22);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.Text = "0342247178";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(169, 72);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(219, 22);
            this.txtTen.TabIndex = 1;
            this.txtTen.Text = "Nguyễn Thiện Nhân";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(169, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "nguyenthiennhan188@gmail.com";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(169, 144);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(219, 22);
            this.txtSoTien.TabIndex = 1;
            // 
            // btnTaoQR
            // 
            this.btnTaoQR.Location = new System.Drawing.Point(299, 172);
            this.btnTaoQR.Name = "btnTaoQR";
            this.btnTaoQR.Size = new System.Drawing.Size(89, 36);
            this.btnTaoQR.TabIndex = 2;
            this.btnTaoQR.Text = "Tạo QR";
            this.btnTaoQR.UseVisualStyleBackColor = true;
            this.btnTaoQR.Click += new System.EventHandler(this.btnTaoQR_Click);
            // 
            // pcQR
            // 
            this.pcQR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcQR.BackColor = System.Drawing.Color.DimGray;
            this.pcQR.Location = new System.Drawing.Point(447, 96);
            this.pcQR.Name = "pcQR";
            this.pcQR.Size = new System.Drawing.Size(250, 250);
            this.pcQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcQR.TabIndex = 3;
            this.pcQR.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thanh Toán QR";
            // 
            // FormTTMoMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcQR);
            this.Controls.Add(this.btnTaoQR);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormTTMoMo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTTMoMo";
            ((System.ComponentModel.ISupportInitialize)(this.pcQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnTaoQR;
        private System.Windows.Forms.PictureBox pcQR;
        private System.Windows.Forms.Label label5;
    }
}