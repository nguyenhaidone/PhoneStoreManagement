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

    public partial class Bills : Form
    {
        CuaHangBanDiDongEntities dbBills = new CuaHangBanDiDongEntities();
        ChiTietHDB chiTietHDB = new ChiTietHDB();
        HoaDonNhap hoaDonNhap = new HoaDonNhap();
        
        public Bills()
        {
            InitializeComponent();
            renewPanel();
        }

        private void renewPanel()
        {
            txtIdCustomer.Text = "";
            txtIdExport.Text = "";
            txtIdProduct.Text = "";
            txtIdPromo.Text = "";
            txtIdSaler.Text = "";
            txtQuantity.Text = "";
            lbAllPrice.Text = "0";
            lbDate.Text = DateTime.Now.ToString();
            lbTotalPrice.Text = "0";
            var showDataSource = from dbHoaDonBans in dbBills.ChiTietHDBs
                                 join dbChiTietHDBs in dbBills.HoaDonBans
                                 on dbHoaDonBans.MaHDB equals dbChiTietHDBs.MaHDB
                                 select new
                                 {
                                     dbHoaDonBans.MaHDB,
                                     dbHoaDonBans.KhuyenMai,
                                     dbHoaDonBans.MaSanPham,
                                     dbHoaDonBans.SoLuong,
                                     dbHoaDonBans.ThanhTien,
                                     dbChiTietHDBs.MaKhachHang,
                                     dbChiTietHDBs.MaNhanVien,
                                     dbChiTietHDBs.NgayBan,
                                     dbChiTietHDBs.TongTien,
                                 };
            dataGridView1.DataSource = showDataSource.ToList();
        }
    }
}
