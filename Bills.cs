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
        CuaHangBanDiDongV1Entities dbBills = new CuaHangBanDiDongV1Entities();
        ChiTietHDB chiTietHDB = new ChiTietHDB();
        HoaDonBan hoaDonBan = new HoaDonBan();
        public int state=0;
        public string IDHoaDonBan;
        public string IDChiTietHDB;

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
            groupBox1.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            renewPanel();
            groupBox1.Enabled = true;
            state = 1;
            txtIdExport.Text = DateTime.Now.ToString().GetHashCode().ToString("x");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(state == 1)
            {
                chiTietHDB.MaHDB = txtIdExport.Text;
                chiTietHDB.MaSanPham = txtIdProduct.Text;
                chiTietHDB.SoLuong = Convert.ToInt32(txtQuantity.Text);
                chiTietHDB.KhuyenMai = Convert.ToDouble(txtIdPromo.Text);
                chiTietHDB.ThanhTien = Convert.ToDouble(lbAllPrice.Text);

                hoaDonBan.MaHDB = txtIdExport.Text;
                hoaDonBan.MaKhachHang = txtIdCustomer.Text;
                hoaDonBan.MaNhanVien = txtIdSaler.Text;
                hoaDonBan.NgayBan = DateTime.Now;
                hoaDonBan.TongTien = Convert.ToDouble(lbTotalPrice.Text);

                dbBills.ChiTietHDBs.Add(chiTietHDB);
                dbBills.SaveChanges();

                dbBills.HoaDonBans.Add(hoaDonBan);
                dbBills.SaveChanges();

                renewPanel();
            }
            if (state == 2)
            {
                ChiTietHDB editChiTietHDB = dbBills.ChiTietHDBs.Find(IDChiTietHDB);
                HoaDonBan editHoaDonBan = dbBills.HoaDonBans.Find(IDHoaDonBan);

                editChiTietHDB.MaHDB = editChiTietHDB.MaHDB;
                editChiTietHDB.MaSanPham = txtIdProduct.Text;
                editChiTietHDB.SoLuong = Convert.ToInt32(txtQuantity.Text);
                editChiTietHDB.KhuyenMai = Convert.ToDouble(txtIdPromo.Text);
                editChiTietHDB.ThanhTien = Convert.ToDouble(lbAllPrice.Text);

                editHoaDonBan.MaHDB = editHoaDonBan.MaHDB;
                editHoaDonBan.MaKhachHang = txtIdCustomer.Text;
                editHoaDonBan.MaNhanVien = txtIdSaler.Text;
                editHoaDonBan.NgayBan = DateTime.Now;
                editHoaDonBan.TongTien = Convert.ToDouble(lbTotalPrice.Text);

                dbBills.SaveChanges();
                renewPanel();
            } 
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*IDHoaDonBan = txtIdExport.Text.ToString();
            IDChiTietHDB = txtIdExport.Text.ToString();*/
            if (IDHoaDonBan != "" && IDChiTietHDB != "")
            {
                txtIdExport.Enabled = false;
                groupBox1.Enabled = true;
                state = 2;
            }
            else
            {
                MessageBox.Show(this, "Please select row to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IDHoaDonBan != null && IDChiTietHDB != null)
            {
                DialogResult dialogResult = MessageBox.Show(this, "Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ChiTietHDB dltChiTietHDB = dbBills.ChiTietHDBs.Where(p => p.MaHDB == (txtIdExport.Text).ToString()).SingleOrDefault();
                    HoaDonBan dltHoaDonBan = dbBills.HoaDonBans.Where(p => p.MaHDB == (txtIdExport.Text).ToString()).SingleOrDefault();
                    dbBills.ChiTietHDBs.Remove(dltChiTietHDB);
                    dbBills.HoaDonBans.Remove(dltHoaDonBan);
                    dbBills.SaveChanges();
                    renewPanel();
                }
            }
            else
            {
                MessageBox.Show(this, "Please select row to delele", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdExport.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtIdPromo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtIdProduct.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            lbAllPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtIdCustomer.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtIdSaler.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            lbDate.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            lbTotalPrice.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            IDHoaDonBan = txtIdExport.Text.ToString();
            IDChiTietHDB = txtIdExport.Text.ToString();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            renewPanel();
            groupBox1.Enabled = true;
            txtIdCustomer.Enabled = false;
            txtIdProduct.Enabled = false;
            txtIdPromo.Enabled = false;
            txtIdSaler.Enabled = false;
            txtQuantity.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var showSearchResult = from dbHoaDonBan in dbBills.HoaDonBans
                                   join dbChiTietHDB in dbBills.ChiTietHDBs
                                   on dbHoaDonBan.MaHDB equals dbChiTietHDB.MaHDB
                                   where dbHoaDonBan.MaHDB == txtIdExport.Text && dbChiTietHDB.MaHDB == txtIdExport.Text
                                   select new
                                   {
                                       dbHoaDonBan.MaHDB,
                                       dbHoaDonBan.MaKhachHang,
                                       dbHoaDonBan.MaNhanVien,
                                       dbHoaDonBan.NgayBan,
                                       dbHoaDonBan.TongTien,
                                       dbChiTietHDB.KhuyenMai,
                                       dbChiTietHDB.MaSanPham,
                                       dbChiTietHDB.SoLuong,
                                       dbChiTietHDB.ThanhTien
                                   };
            dataGridView1.DataSource = showSearchResult.ToList();
            groupBox1.Enabled = false;
        }
    }
}
