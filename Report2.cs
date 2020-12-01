using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagement
{
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }
        CuaHangBanDiDongV1Entities dbReport2 = new CuaHangBanDiDongV1Entities();
        public int getPeriod;
        private void Report2_Load(object sender, EventArgs e)
        {
            getPeriod=Convert.ToInt32(comboBox1.Text);
            showReport();
        }

        public class VM
        {
            
            public string MaNhanVien { get; set; }
            public DateTime NgayNhap { get; set; }
            public double TongTien { get; set; }
        }

        private void showReport()
        {
            if (getPeriod == 1)
            {
                var showResult = dbReport2.Database.SqlQuery<VM>("select HoaDonNhap.MaNhanVien,HoaDonNhap.NgayNhap,HoaDonNhap.TongTien from SanPham join ChiTietHDN on SanPham.MaSanPham = ChiTietHDN.MaSanPham join HoaDonNhap on HoaDonNhap.MaHDN = HoaDonNhap.MaHDN where MONTH(HoaDonNhap.NgayNhap) = 1 or MONTH(HoaDonNhap.NgayNhap) = 2 or MONTH(HoaDonNhap.NgayNhap) = 3 group by HoaDonNhap.MaHDN, HoaDonNhap.MaNhanVien, HoaDonNhap.NgayNhap, HoaDonNhap.TongTien order by HoaDonNhap.TongTien desc").ToList();
                dataGridView1.DataSource = showResult;
            }
            if (getPeriod == 2)
            {
                var showResult = dbReport2.Database.SqlQuery<VM>("select HoaDonNhap.MaNhanVien,HoaDonNhap.NgayNhap,HoaDonNhap.TongTien from SanPham join ChiTietHDN on SanPham.MaSanPham = ChiTietHDN.MaSanPham join HoaDonNhap on HoaDonNhap.MaHDN = HoaDonNhap.MaHDN where MONTH(HoaDonNhap.NgayNhap) = 4 or MONTH(HoaDonNhap.NgayNhap) = 5 or MONTH(HoaDonNhap.NgayNhap) = 6 group by HoaDonNhap.MaHDN, HoaDonNhap.MaNhanVien, HoaDonNhap.NgayNhap, HoaDonNhap.TongTien order by HoaDonNhap.TongTien desc").ToList();
                dataGridView1.DataSource = showResult;
            }
            if (getPeriod == 3)
            {
                var showResult = dbReport2.Database.SqlQuery<VM>("select HoaDonNhap.MaNhanVien,HoaDonNhap.NgayNhap,HoaDonNhap.TongTien from SanPham join ChiTietHDN on SanPham.MaSanPham = ChiTietHDN.MaSanPham join HoaDonNhap on HoaDonNhap.MaHDN = HoaDonNhap.MaHDN where MONTH(HoaDonNhap.NgayNhap) = 7 or MONTH(HoaDonNhap.NgayNhap) = 8 or MONTH(HoaDonNhap.NgayNhap) = 9 group by HoaDonNhap.MaHDN, HoaDonNhap.MaNhanVien, HoaDonNhap.NgayNhap, HoaDonNhap.TongTien order by HoaDonNhap.TongTien desc").ToList();
                dataGridView1.DataSource = showResult;
            }
            if (getPeriod == 4)
            {
                var showResult = dbReport2.Database.SqlQuery<VM>("select HoaDonNhap.MaNhanVien,HoaDonNhap.NgayNhap,HoaDonNhap.TongTien from SanPham join ChiTietHDN on SanPham.MaSanPham = ChiTietHDN.MaSanPham join HoaDonNhap on HoaDonNhap.MaHDN = HoaDonNhap.MaHDN where MONTH(HoaDonNhap.NgayNhap) = 10 or MONTH(HoaDonNhap.NgayNhap) = 11 or MONTH(HoaDonNhap.NgayNhap) = 12 group by HoaDonNhap.MaHDN, HoaDonNhap.MaNhanVien, HoaDonNhap.NgayNhap, HoaDonNhap.TongTien order by HoaDonNhap.TongTien desc").ToList();
                dataGridView1.DataSource = showResult;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPeriod = Convert.ToInt32(comboBox1.Text);
            showReport();
        }
    }
}
