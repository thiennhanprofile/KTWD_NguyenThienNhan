using Org.BouncyCastle.Asn1.Crmf;
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

namespace QuanLyQuanRuou
{
    public partial class FormTaiKhoan : Form
    {

        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void tcDoiMK_Click(object sender, EventArgs e)
        {

        }

        private void tcDangKi_Click(object sender, EventArgs e)
        {

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
        }
        SqlConnection conn = new SqlConnection(@"Data Source=NHANUSER\SQLEXPRESS;Initial Catalog=QLQuanRuou;Integrated Security=True");

        private void btnXacNhanMK_Click(object sender, EventArgs e)
        {
            conn.Open();

            string updateQuery = "UPDATE NguoiDung SET MatKhau = N'" + txtMatKhauMoi.Text + "' WHERE TaiKhoan = N'" + txtTaiKhoanHienTai.Text + "' AND MatKhau = N'" + txtMatKhauHienTai.Text + "'";

            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    txtTaiKhoanHienTai.Clear();
                    txtMatKhauHienTai.Clear();
                    txtMatKhauMoi.Clear();
                    txtNhapLaiMK.Clear();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất");

            Application.Exit();


        }

        private void btnDangKiTK_Click(object sender, EventArgs e)
        {
            conn.Open();
            string checktk = txtTaiKhoanDK.Text.Trim();
            string checkmk = txtMatKhauDK.Text.Trim();


            if (string.IsNullOrEmpty(checktk)|| string.IsNullOrEmpty(checkmk))
            {
                MessageBox.Show("Vui lòng nhập thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsExistingUser(txtTaiKhoanHienTai.Text))
            {
                // Nếu tài khoản chưa tồn tại, thực hiện đăng ký mới
                string insertQuery = "INSERT INTO NguoiDung (TaiKhoan, MatKhau) VALUES (@TaiKhoan, @MatKhau)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoanDK.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatKhauDK.Text);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký tài khoản thành công");
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký tài khoản thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý ngoại lệ SQL
                        MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
            }

        private bool IsExistingUser(string taiKhoan)
        {
            // Kiểm tra xem tài khoản có tồn tại trong cơ sở dữ liệu không
            string selectQuery = "SELECT COUNT(*) FROM NguoiDung WHERE TaiKhoan = N'" + taiKhoan + "'";

            using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void ClearTextBoxes()
        {
            txtTaiKhoanHienTai.Clear();
            txtMatKhauHienTai.Clear();
            txtMatKhauMoi.Clear();
            txtNhapLaiMK.Clear();
        }
    }
}
