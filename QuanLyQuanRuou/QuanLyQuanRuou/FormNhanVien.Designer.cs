namespace QuanLyQuanRuou
{
    partial class FormNhanVien
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNV = new System.Windows.Forms.DateTimePicker();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtMucLuongNV = new System.Windows.Forms.TextBox();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSdtNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(30, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số đt nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNV);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtMucLuongNV);
            this.groupBox1.Controls.Add(this.txtDiaChiNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtSdtNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 186);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // dtpNV
            // 
            this.dtpNV.Location = new System.Drawing.Point(791, 44);
            this.dtpNV.Name = "dtpNV";
            this.dtpNV.Size = new System.Drawing.Size(200, 22);
            this.dtpNV.TabIndex = 3;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(791, 111);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(191, 22);
            this.txtChucVu.TabIndex = 1;
            // 
            // txtMucLuongNV
            // 
            this.txtMucLuongNV.Location = new System.Drawing.Point(791, 72);
            this.txtMucLuongNV.Name = "txtMucLuongNV";
            this.txtMucLuongNV.Size = new System.Drawing.Size(191, 22);
            this.txtMucLuongNV.TabIndex = 1;
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Location = new System.Drawing.Point(164, 149);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(191, 22);
            this.txtDiaChiNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(164, 72);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(191, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtSdtNV
            // 
            this.txtSdtNV.Location = new System.Drawing.Point(164, 111);
            this.txtSdtNV.Name = "txtSdtNV";
            this.txtSdtNV.Size = new System.Drawing.Size(191, 22);
            this.txtSdtNV.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(164, 35);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(191, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mức lương";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXuatExcel);
            this.groupBox2.Controls.Add(this.btnKhoiTao);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(13, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1129, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Location = new System.Drawing.Point(709, 35);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btnKhoiTao.TabIndex = 1;
            this.btnKhoiTao.Text = "Khởi tạo";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(558, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(379, 35);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(203, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSNV);
            this.groupBox3.Location = new System.Drawing.Point(13, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1129, 318);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhân viên";
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Location = new System.Drawing.Point(7, 22);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersWidth = 51;
            this.dgvDSNV.RowTemplate.Height = 24;
            this.dgvDSNV.Size = new System.Drawing.Size(1116, 290);
            this.dgvDSNV.TabIndex = 0;
            this.dgvDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNV_CellClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(875, 35);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(127, 23);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuât Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // FormC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1154, 690);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormC";
            this.Text = "FormC";
            this.Load += new System.EventHandler(this.FormC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSdtNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.DateTimePicker dtpNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMucLuongNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}