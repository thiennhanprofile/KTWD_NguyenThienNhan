using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanRuou
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timer1.Start();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            }

        private void pcThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Bạn có muốn thoát không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang());
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLSanPham());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công");
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaiKhoan());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe());
        }
    }
}
