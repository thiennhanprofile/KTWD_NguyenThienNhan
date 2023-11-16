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
using System.Windows.Input;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyQuanRuou
{
    public partial class FormQLSanPham : Form
    {
        public FormQLSanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void FormQLSanPham_Load(object sender, EventArgs e)
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
            dgvQLSanPham.DataSource = dt;
        }

        private void dgvQLSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO SanPham1 VALUES ('"+ txtMaSP.Text + "',N'"+ txtTenSP.Text + "','"+ txtGiaTien.Text + "','"+ txtSoLuong.Text + "','"+ txtThanhTien.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Hienthi();
            

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM SanPham1 WHERE masp = '" + txtMaSP.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE SanPham1 SET masp ='" + txtMaSP.Text + "',tensp =N'"+ txtTenSP.Text + "',giatien='"+ txtGiaTien.Text + "',soluong='"+ txtSoLuong.Text + "',thanhtien='" + txtThanhTien.Text + "' where masp ='" + txtMaSP.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Hienthi();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaTien.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {     
                Application.Exit();

            }
        }

        private void dgvQLSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvQLSanPham.Rows.Count - 1)
                {
                    throw new Exception("Chưa chon sản phẩm");
                }
                int i;
                i = dgvQLSanPham.CurrentRow.Index;
                txtMaSP.Text = dgvQLSanPham.Rows[i].Cells[0].Value.ToString();
                txtTenSP.Text = dgvQLSanPham.Rows[i].Cells[1].Value.ToString();
                txtGiaTien.Text = dgvQLSanPham.Rows[i].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvQLSanPham.Rows[i].Cells[3].Value.ToString();
                txtThanhTien.Text = dgvQLSanPham.Rows[i].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
        public void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvQLSanPham.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvQLSanPham.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvQLSanPham.Rows.Count; i++)

            {
                for (int j = 0; j < dgvQLSanPham.Columns.Count; j++)
                {

                    application.Cells[i + 2, j + 1] = dgvQLSanPham.Rows[i].Cells[j].Value;
                }
                application.Columns.AutoFit();
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;
            }
        }


        private void btnXuatExcel_Click_1(object sender, EventArgs e)
        {
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
}
