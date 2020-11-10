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
    
    public partial class PhoneCatalog : Form
    {
        /*SPEntityState SPObjState = SPEntityState.Unchange;*/
        /**/
        public PhoneCatalog()
        {
            InitializeComponent();
            using (CuaHangBanDiDongEntities phoneManagementDBEntities = new CuaHangBanDiDongEntities())
            {
                var showData = from db in phoneManagementDBEntities.SanPhams select db;
                dataGridView1.DataSource = showData.ToList();
            }
        }

           
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            /*TBL_SanPham tBL_SanPhamModel = new TBL_SanPham();
            tBL_SanPhamModel.MaSP = "1";
            tBL_SanPhamModel.TenSP = "Iphone";
            tBL_SanPhamModel.MaLoai = "Iphone cl";
            tBL_SanPhamModel.MaNhanHieu = "Apple";
            tBL_SanPhamModel.GiaNhap = 1200;
            tBL_SanPhamModel.GiaBan = 1300;
            tBL_SanPhamModel.SoLuong = 23;
            tBL_SanPhamModel.ThoiGianBaoHanh = new DateTime(2008, 5, 1, 8, 30, 52);
            tBL_SanPhamModel.MaManHinh = "Iphone MH";
            tBL_SanPhamModel.AmThanh = "Bomd sound";
            tBL_SanPhamModel.Anh = "21312124124.psh";
            tBL_SanPhamModel.ChupAnh = "10px";


            using (PhoneManagementDBEntities phoneManagementDBEntities = new PhoneManagementDBEntities())
            {
                phoneManagementDBEntities.TBL_SanPham.Add(tBL_SanPhamModel);
                phoneManagementDBEntities.SaveChanges();
            }
*/
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
