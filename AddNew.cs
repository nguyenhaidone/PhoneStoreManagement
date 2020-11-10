using Net.Code.ADONet;
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
    public partial class AddNew : Form
    {

        CuaHangBanDiDongEntities dbAddNew = new CuaHangBanDiDongEntities();
        
        ChiTietHDN chiTietHDN = new ChiTietHDN();
        HoaDonNhap hoaDonNhap = new HoaDonNhap();
        public int state = 0;
        public string IDHoaDonNhap;
        public string IDChiTietHDN;
        public AddNew()
        {
            InitializeComponent();
            renewPanel();
            AddBinding();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void AddBinding()
        {
            txtIdImport.DataBindings.Add(new Binding("Text",dataGridView1.DataSource,"MaHDN"));
            txtIdSupplier.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaNCC"));
            txtIdProduct.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaSanPham"));
            txtPromo.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "KhuyenMai"));
            txtQuantity.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoLuong"));
            txtUnitPrice.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGia"));
            txtIdSaler.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaNhanVien"));
            lbAllPrice.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "ThanhTien"));
            lbDate.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "NgayNhap"));
            lbTotalPrice.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TongTien"));
            IDHoaDonNhap = txtIdImport.Text.ToString();
            IDChiTietHDN = txtIdImport.Text.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            renewPanel();
            groupBox1.Enabled = true;
            state = 1;
        }

        private void renewPanel()
        {
            txtIdImport.Text = "";
            txtIdProduct.Text = "";
            txtIdSaler.Text = "";
            txtIdSupplier.Text = "";
            txtPromo.Text = "0.5";
            txtQuantity.Text = "0";
            txtUnitPrice.Text = "0";
            lbDate.Text = DateTime.Now.ToString();
            lbAllPrice.Text = "0";
            lbTotalPrice.Text = "0";
            var showDataSource = from dbHoaDonNhaps in dbAddNew.HoaDonNhaps 
                                 join dbChiTietHDNs in dbAddNew.ChiTietHDNs
                                 on dbHoaDonNhaps.MaHDN equals dbChiTietHDNs.MaHDN select new { 
                                     dbHoaDonNhaps.MaHDN,
                                     dbHoaDonNhaps.MaNCC,
                                     dbHoaDonNhaps.MaNhanVien,
                                     dbHoaDonNhaps.NgayNhap,
                                     dbHoaDonNhaps.TongTien,

                                     dbChiTietHDNs.KhuyenMai,
                                     dbChiTietHDNs.MaSanPham,
                                     dbChiTietHDNs.SoLuong,
                                     dbChiTietHDNs.DonGia,
                                     dbChiTietHDNs.ThanhTien,
                                 };
            dataGridView1.DataSource = showDataSource.ToList();
            groupBox1.Enabled = false;
            IDHoaDonNhap = "";
            IDChiTietHDN = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(IDHoaDonNhap!="" && IDChiTietHDN != "")
            {
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
            if( IDHoaDonNhap!=null && IDChiTietHDN != null)
            {
                DialogResult dialogResult = MessageBox.Show(this, "Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ChiTietHDN dltChiTietHDN = dbAddNew.ChiTietHDNs.Where(p => p.MaHDN == (txtIdImport.Text).ToString()).SingleOrDefault();
                    HoaDonNhap dltHoaDonNhap = dbAddNew.HoaDonNhaps.Where(p => p.MaHDN == (txtIdImport.Text).ToString()).SingleOrDefault();
                    dbAddNew.ChiTietHDNs.Remove(dltChiTietHDN);
                    dbAddNew.HoaDonNhaps.Remove(dltHoaDonNhap);
                    dbAddNew.SaveChanges();
                    renewPanel();
                }
            }
            else
            {
                MessageBox.Show(this, "Please select row to delele", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                chiTietHDN.MaHDN = txtIdImport.Text;
                chiTietHDN.MaSanPham = txtIdProduct.Text;
                chiTietHDN.SoLuong = Convert.ToInt32(txtQuantity.Text);
                chiTietHDN.KhuyenMai = Convert.ToDouble(txtPromo.Text);
                chiTietHDN.ThanhTien = Convert.ToDouble((lbAllPrice.Text));
                chiTietHDN.DonGia = Convert.ToDouble(txtUnitPrice.Text);

                hoaDonNhap.MaHDN = txtIdImport.Text;
                hoaDonNhap.MaNCC = txtIdSupplier.Text;
                hoaDonNhap.MaNhanVien = txtIdSaler.Text;
                hoaDonNhap.NgayNhap = DateTime.Now;
                hoaDonNhap.TongTien = Convert.ToDouble(lbTotalPrice.Text);

                dbAddNew.ChiTietHDNs.Add(chiTietHDN);
                dbAddNew.SaveChanges();
                dbAddNew.HoaDonNhaps.Add(hoaDonNhap);
                dbAddNew.SaveChanges();
                renewPanel();
            }
            if(state == 2)
            {
                ChiTietHDN editChiTietHDN = dbAddNew.ChiTietHDNs.Find(IDHoaDonNhap);
                HoaDonNhap editHoaDonNhap = dbAddNew.HoaDonNhaps.Find(IDChiTietHDN);

                editChiTietHDN.MaHDN = txtIdImport.Text;
                editChiTietHDN.MaSanPham = txtIdProduct.Text;
                editChiTietHDN.SoLuong = Convert.ToInt32(txtQuantity.Text);
                editChiTietHDN.KhuyenMai = Convert.ToDouble(txtPromo.Text);
                editChiTietHDN.ThanhTien = Convert.ToDouble(lbTotalPrice.Text);
                editHoaDonNhap.MaHDN = txtIdImport.Text;
                editHoaDonNhap.MaNCC = txtIdSupplier.Text;
                editHoaDonNhap.MaNhanVien = txtIdSaler.Text;
                editHoaDonNhap.NgayNhap = Convert.ToDateTime(lbDate.Text);
                editHoaDonNhap.TongTien = Convert.ToDouble(lbAllPrice.Text);

                dbAddNew.SaveChanges();
                renewPanel();
            }
            
        }

        void calcPrice()
        {
            if (txtUnitPrice.Text != "" && txtQuantity.Text != "" && txtPromo.Text != "")
            {
                lbTotalPrice.Text = (Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtUnitPrice.Text)).ToString();
                lbAllPrice.Text = (Convert.ToDecimal(lbTotalPrice.Text) - Convert.ToDecimal(lbTotalPrice.Text) * Convert.ToDecimal(txtPromo.Text)).ToString();
            }
        }

        void IsValid(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            calcPrice();
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValid(sender, e);
        }

        private void lbTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            calcPrice();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValid(sender, e);
        }

        private void txtPromo_TextChanged(object sender, EventArgs e)
        {
            calcPrice();
        }

        private void txtPromo_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValid(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdImport.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtIdSupplier.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtIdSaler.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            lbDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            lbTotalPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtPromo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtIdProduct.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtUnitPrice.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            lbAllPrice.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

            IDHoaDonNhap = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            IDChiTietHDN = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                var showSearchResult = from dbHoaDonNhaps in dbAddNew.HoaDonNhaps
                                       join dbChiTietHDNs in dbAddNew.ChiTietHDNs
                                       on dbHoaDonNhaps.MaHDN equals dbChiTietHDNs.MaHDN
                                       where dbHoaDonNhaps.MaHDN == txtIdImport.Text && dbChiTietHDNs.MaHDN == txtIdImport.Text
                                       select new
                                       {
                                           dbHoaDonNhaps.MaHDN,
                                           dbHoaDonNhaps.MaNCC,
                                           dbHoaDonNhaps.MaNhanVien,
                                           dbHoaDonNhaps.NgayNhap,
                                           dbHoaDonNhaps.TongTien,
                                           dbChiTietHDNs.KhuyenMai,
                                           dbChiTietHDNs.MaSanPham,
                                           dbChiTietHDNs.SoLuong,
                                           dbChiTietHDNs.DonGia,
                                           dbChiTietHDNs.ThanhTien,
                                       };
            
            dataGridView1.DataSource = showSearchResult.ToList();
                groupBox1.Enabled = false;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            renewPanel();
            groupBox1.Enabled=true;
        }
    }
}
