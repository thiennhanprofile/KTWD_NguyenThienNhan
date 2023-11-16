using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace QuanLyQuanRuou
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void FormA_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLQuanRuouDataSet.SanPham' table. You can move, or remove it, as needed.
            //this.sanPham1TableAdapter.Fill(this.qLQuanRuouDataSet.SanPham1);
            conn = new SqlConnection(@"Data Source=NHANUSER\SQLEXPRESS;Initial Catalog=QLQuanRuou;Integrated Security=True");
            conn.Open();
            Hienthi();
        }
        SqlConnection conn;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=NHANUSER\SQLEXPRESS;Initial Catalog=QLQuanRuou;Integrated Security=True");
            conn.Open();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT *FROM SanPham1";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDSSP.DataSource = dt;
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {

            
        }

        private void btnLocSP_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlTimKiem = "SELECT * FROM SanPham1 WHERE tensp LIKE '%' + @keyword + '%'";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
            cmd.Parameters.AddWithValue("@keyword", keyword);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvDSSP.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDSSP.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm");
                }
                int i;
                i = dgvDSSP.CurrentRow.Index;
                txtMaSP.Text = dgvDSSP.Rows[i].Cells[0].Value.ToString();
                txtTenSP.Text = dgvDSSP.Rows[i].Cells[1].Value.ToString();
                txtGiaTien.Text = dgvDSSP.Rows[i].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvDSSP.Rows[i].Cells[3].Value.ToString();
                txtThanhTien.Text = dgvDSSP.Rows[i].Cells[4].Value.ToString();


                double giaTien = Convert.ToDouble(txtGiaTien.Text);
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                txtThanhTien.Text = (giaTien * soLuong).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == txtTenSP.Text)
                    {
                        int soLuongCu = Convert.ToInt32(row.Cells[1].Value);
                        int soLuongMoi = Convert.ToInt32(txtSoLuong.Text);
                        row.Cells[1].Value = soLuongCu + soLuongMoi;
                        double giaTien = Convert.ToDouble(txtGiaTien.Text);
                        row.Cells[3].Value = (soLuongCu + soLuongMoi) * giaTien;
                        found = true;
                        MessageBox.Show("Đã thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add(txtTenSP.Text, txtSoLuong.Text, txtGiaTien.Text, txtThanhTien.Text, txtTenKH.Text, txtSdtKH.Text);
                    MessageBox.Show("Đã thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                dataGridView1.Rows.Add(txtTenSP.Text, txtSoLuong.Text, txtThanhTien.Text, txtTenKH.Text, txtSdtKH.Text);
                MessageBox.Show("Đã thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            txtTongTien.Text = sum.ToString("###,###");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                int rowindex = dataGridView1.SelectedCells[0].RowIndex;
                if (rowindex == -1 || rowindex >= dataGridView1.Rows.Count - 1)
                {
                    throw new Exception("Chưa chon sản phẩm");
                }
                dataGridView1.Rows.RemoveAt(rowindex);
                rowindex = -1;
                MessageBox.Show("Đã xóa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 1) // Kiểm tra xem có dòng để xóa không
                {
                    dataGridView1.Rows.Clear();
                    MessageBox.Show("Đã xóa tất cả các sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Chưa chọn sản phẩm");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTongTien.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaTien.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            FormTTMoMo f = new FormTTMoMo();
            f.Show();

                txtMaSP.Text = "";
                txtTenSP.Text = "";
                txtGiaTien.Text = "";
                txtSoLuong.Text = "";
                txtThanhTien.Text = "";
            }
        }
    }




















        /*        dgvDSDonHang.DataSource = dtHoaDon;
dgvDSDonHang.Columns["MaHD"].HeaderText = "Ma Hoa Đơn";
dgvDSDonHang.Columns["MaKH"].HeaderText = "Ma Hoa Dơn";
dgvDSDonHang.Columns["MaNV"].HeaderText = "Ma Hoa Đơn";
dgvDSDonHang.Columns["MaHD"].HeaderText = "Ma Hoa Dơn";
dgvDSDonHang.Columns["MaHD"].HeaderText = "Ma Hoa Đơn";
dgvDSDonHang.Columns["MaHD"].HeaderText = "Ma Hoa Đơn";
dgvDSDonHang.Columns["MaHD"].HeaderText = "Ma Hoa Đơn";*/
    
    

