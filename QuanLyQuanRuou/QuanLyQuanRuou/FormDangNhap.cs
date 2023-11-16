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


namespace QuanLyQuanRuou
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NHANUSER\SQLEXPRESS;Initial Catalog=QLQuanRuou;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;

                // Sử dụng truy vấn có tham số để ngăn chặn SQL injection
                string sql = "SELECT * FROM NguoiDung WHERE Taikhoan = @tk AND Matkhau = @mk";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tk", tk);
                cmd.Parameters.AddWithValue("@mk", mk);

                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read())
                {
                    MessageBox.Show("Đăng nhập thành công");
                    FormMain f = new FormMain();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                con.Close(); // Luôn đóng kết nối, dù có lỗi xảy ra hay không
            }

        }
    }
}

