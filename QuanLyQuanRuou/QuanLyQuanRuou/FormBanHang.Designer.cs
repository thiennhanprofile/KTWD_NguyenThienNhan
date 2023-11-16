namespace QuanLyQuanRuou
{
    partial class FormBanHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSdtKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatiensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtiensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQuanRuouDataSet = new QuanLyQuanRuou.QLQuanRuouDataSet();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLocSP = new System.Windows.Forms.Button();
            this.sanPham1TableAdapter = new QuanLyQuanRuou.QLQuanRuouDataSetTableAdapters.SanPhamTableAdapter();
            this.sanPhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLQuanRuouDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanRuouDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanRuouDataSet.SanPham1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanRuouDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SĐT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên KH :";
            // 
            // txtSdtKH
            // 
            this.txtSdtKH.Location = new System.Drawing.Point(130, 38);
            this.txtSdtKH.Name = "txtSdtKH";
            this.txtSdtKH.Size = new System.Drawing.Size(190, 22);
            this.txtSdtKH.TabIndex = 2;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(130, 75);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(190, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSdtKH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 329);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tensp,
            this.soluongsp,
            this.giatiensp,
            this.thanhtiensp,
            this.tenkh,
            this.sdtkh});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.Width = 200;
            // 
            // soluongsp
            // 
            this.soluongsp.HeaderText = "Số lượng";
            this.soluongsp.MinimumWidth = 6;
            this.soluongsp.Name = "soluongsp";
            this.soluongsp.Width = 50;
            // 
            // giatiensp
            // 
            this.giatiensp.HeaderText = "Giá tiền";
            this.giatiensp.MinimumWidth = 6;
            this.giatiensp.Name = "giatiensp";
            this.giatiensp.Width = 70;
            // 
            // thanhtiensp
            // 
            this.thanhtiensp.HeaderText = "Thành tiền";
            this.thanhtiensp.MinimumWidth = 6;
            this.thanhtiensp.Name = "thanhtiensp";
            this.thanhtiensp.Width = 80;
            // 
            // tenkh
            // 
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.MinimumWidth = 6;
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 150;
            // 
            // sdtkh
            // 
            this.sdtkh.HeaderText = "Số điện thoại";
            this.sdtkh.MinimumWidth = 6;
            this.sdtkh.Name = "sdtkh";
            this.sdtkh.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvDSSP);
            this.groupBox3.Location = new System.Drawing.Point(582, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 329);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm";
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Location = new System.Drawing.Point(7, 22);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.RowHeadersWidth = 51;
            this.dgvDSSP.RowTemplate.Height = 24;
            this.dgvDSSP.Size = new System.Drawing.Size(553, 307);
            this.dgvDSSP.TabIndex = 0;
            this.dgvDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellClick);
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.qLQuanRuouDataSet;
            // 
            // qLQuanRuouDataSet
            // 
            this.qLQuanRuouDataSet.DataSetName = "QLQuanRuouDataSet";
            // 
            // 
            // 
            this.qLQuanRuouDataSet.SanPham1.TableName = "SanPham";
            this.qLQuanRuouDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(413, 65);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 37);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(24, 550);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 45);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(582, 550);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(161, 55);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Tải sản phẩm";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.Location = new System.Drawing.Point(394, 629);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(161, 55);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng tiền :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(96, 662);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(166, 22);
            this.txtTongTien.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtThanhTien);
            this.groupBox4.Controls.Add(this.txtGiaTien);
            this.groupBox4.Controls.Add(this.txtSoLuong);
            this.groupBox4.Controls.Add(this.txtTenSP);
            this.groupBox4.Controls.Add(this.txtMaSP);
            this.groupBox4.Controls.Add(this.txtTimKiem);
            this.groupBox4.Controls.Add(this.btnLocSP);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Location = new System.Drawing.Point(580, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 203);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lọc sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gía tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã sản phẩm";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(439, 154);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(114, 22);
            this.txtThanhTien.TabIndex = 7;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Enabled = false;
            this.txtGiaTien.Location = new System.Drawing.Point(181, 153);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(147, 22);
            this.txtGiaTien.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(181, 125);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(147, 22);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Enabled = false;
            this.txtTenSP.Location = new System.Drawing.Point(181, 97);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(147, 22);
            this.txtTenSP.TabIndex = 3;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(181, 59);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(147, 22);
            this.txtMaSP.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(23, 21);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(305, 22);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnLocSP
            // 
            this.btnLocSP.Location = new System.Drawing.Point(353, 19);
            this.btnLocSP.Name = "btnLocSP";
            this.btnLocSP.Size = new System.Drawing.Size(130, 24);
            this.btnLocSP.TabIndex = 0;
            this.btnLocSP.Text = "Lọc sản phẩm";
            this.btnLocSP.UseVisualStyleBackColor = true;
            this.btnLocSP.Click += new System.EventHandler(this.btnLocSP_Click);
            // 
            // sanPham1TableAdapter
            // 
            this.sanPham1TableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamBindingSource1
            // 
            this.sanPhamBindingSource1.DataMember = "SanPham";
            this.sanPhamBindingSource1.DataSource = this.qLQuanRuouDataSet;
            // 
            // qLQuanRuouDataSetBindingSource
            // 
            this.qLQuanRuouDataSetBindingSource.DataSource = this.qLQuanRuouDataSet;
            this.qLQuanRuouDataSetBindingSource.Position = 0;
            // 
            // sanPhamBindingSource2
            // 
            this.sanPhamBindingSource2.DataMember = "SanPham";
            this.sanPhamBindingSource2.DataSource = this.qLQuanRuouDataSet;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoaDon.Location = new System.Drawing.Point(394, 551);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(161, 54);
            this.btnHoaDon.TabIndex = 10;
            this.btnHoaDon.Text = "Hủy HĐ";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1154, 690);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormBanHang";
            this.Text = "FormA";
            this.Load += new System.EventHandler(this.FormA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanRuouDataSet.SanPham1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanRuouDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQuanRuouDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSdtKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Button btnLocSP;
        private System.Windows.Forms.TextBox txtTimKiem;
        private QLQuanRuouDataSet qLQuanRuouDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private QLQuanRuouDataSetTableAdapters.SanPhamTableAdapter sanPham1TableAdapter;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.BindingSource sanPhamBindingSource1;
        private System.Windows.Forms.BindingSource qLQuanRuouDataSetBindingSource;
        private System.Windows.Forms.BindingSource sanPhamBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatiensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtiensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtkh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHoaDon;
    }
}