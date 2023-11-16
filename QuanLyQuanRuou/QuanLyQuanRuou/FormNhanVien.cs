using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyQuanRuou
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        private void FormC_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=NHANUSER\SQLEXPRESS;Initial Catalog=QLQuanRuou;Integrated Security=True");
            conn.Open();
            Hienthi();
        }
        public void Hienthi()
        {
            string sqlSelect = "SELECT *FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDSNV.DataSource = dt;
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDSNV.Rows.Count - 1)
                {
                    throw new Exception("Chưa chon sản phẩm");
                }
                int i;
                i = dgvDSNV.CurrentRow.Index;
                txtMaNV.Text = dgvDSNV.Rows[i].Cells[0].Value.ToString();
                txtTenNV.Text = dgvDSNV.Rows[i].Cells[1].Value.ToString();
                txtSdtNV.Text = dgvDSNV.Rows[i].Cells[2].Value.ToString();
                txtDiaChiNV.Text = dgvDSNV.Rows[i].Cells[3].Value.ToString();
                dtpNV.Text = dgvDSNV.Rows[i].Cells[4].Value.ToString();
                txtMucLuongNV.Text = dgvDSNV.Rows[i].Cells[5].Value.ToString();
                txtChucVu.Text = dgvDSNV.Rows[i].Cells[6].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSdtNV.Text = "";
            txtDiaChiNV.Text = "";
            dtpNV.Text = "";
            txtMucLuongNV.Text = "";
            txtChucVu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE NHANVIEN SET manv = @MaNV, tennv = @TenNV, sdtnv = @SdtNV, diachinv = @DiaChiNV, ngaysinhnv = @NgaySinhNV,mucluongnv = @MucLuongNV, chucvunv= @ChucVuNV WHERE manv = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Thêm tham số và giá trị tương ứng
            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
            cmd.Parameters.AddWithValue("@SdtNV", txtSdtNV.Text);
            cmd.Parameters.AddWithValue("@DiaChiNV", txtDiaChiNV.Text);

            // Chuyển đổi giá trị ngày tháng về định dạng 'YYYY-MM-DD'
            cmd.Parameters.AddWithValue("@NgaySinhNV", DateTime.Parse(dtpNV.Text).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@MucLuongNV", txtMucLuongNV.Text);
            cmd.Parameters.AddWithValue("@ChucVuNV", txtChucVu.Text);


            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string checkIfExistsQuery = "SELECT COUNT(*) FROM NHANVIEN WHERE manv = @MaNV";
            SqlCommand checkIfExistsCmd = new SqlCommand(checkIfExistsQuery, conn);
            checkIfExistsCmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);

            int existingRecords = (int)checkIfExistsCmd.ExecuteScalar();

            if (existingRecords > 0)
            {
                // Nếu manv đã tồn tại, có thể thông báo lỗi hoặc thực hiện xử lý khác tùy vào yêu cầu của bạn
                MessageBox.Show("Mã nhân viên đã tồn tại. Không thể thêm mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Nếu manv không tồn tại, thực hiện truy vấn INSERT INTO
                string sql = "INSERT INTO NHANVIEN (manv, tennv, sdtnv, diachinv, ngaysinhnv, mucluongnv, chucvunv) VALUES (@MaNV, @TenNV, @SdtNV, @DiaChiNV, @NgaySinhNV, @MucLuongNV, @ChucVuNV)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Thêm tham số và giá trị tương ứng
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@SdtNV", txtSdtNV.Text);
                cmd.Parameters.AddWithValue("@DiaChiNV", txtDiaChiNV.Text);

                // Chuyển đổi giá trị ngày tháng về định dạng 'YYYY-MM-DD'
                cmd.Parameters.AddWithValue("@NgaySinhNV", DateTime.Parse(dtpNV.Text).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@MucLuongNV", txtMucLuongNV.Text);
                cmd.Parameters.AddWithValue("@ChucVuNV", txtChucVu.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM NHANVIEN WHERE manv = '" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Hienthi();
        }
        public void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvDSNV.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvDSNV.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvDSNV.Rows.Count; i++)

            {
                for (int j = 0; j < dgvDSNV.Columns.Count; j++)
                {

                    application.Cells[i + 2, j + 1] = dgvDSNV.Rows[i].Cells[j].Value;
                }
                application.Columns.AutoFit();
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel ( *.xlsx)| *.xlsx|Excel 2003 ( *.xls)| *.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuat file thanh cong!");
                }
                catch (Exception ex)

                { MessageBox.Show("Xuat file khong thanh cong!\n" + ex.Message); }
            }
        }

    }
}