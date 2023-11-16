using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanRuou
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            ChartBDC.Series["ChartBDC"].Points.Add(600000);
            ChartBDC.Series["ChartBDC"].Points[0].Label = "600000";
            ChartBDC.Series["ChartBDC"].Points[0].Color = Color.Blue;
            ChartBDC.Series["ChartBDC"].Points[0].AxisLabel = "Tháng 7";
            ChartBDC.Series["ChartBDC"].Points.Add(450000);
            ChartBDC.Series["ChartBDC"].Points[1].Label = "450000";
            ChartBDC.Series["ChartBDC"].Points[1].Color = Color.Blue;
            ChartBDC.Series["ChartBDC"].Points[1].AxisLabel = "Tháng 8";
            ChartBDC.Series["ChartBDC"].Points.Add(500000);
            ChartBDC.Series["ChartBDC"].Points[2].Label = "500000";
            ChartBDC.Series["ChartBDC"].Points[2].Color = Color.Blue;
            ChartBDC.Series["ChartBDC"].Points[2].AxisLabel = "Tháng 9";

            ChartBDC.Series["ChartBDC"].Points.Add(300000);
            ChartBDC.Series["ChartBDC"].Points[3].Label = "350000";
            ChartBDC.Series["ChartBDC"].Points[3].Color = Color.Blue;
            ChartBDC.Series["ChartBDC"].Points[3].AxisLabel = "Tháng 10";
        }
    }
}
