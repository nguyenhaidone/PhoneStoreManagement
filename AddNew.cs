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

        PhoneStoreManagementEntities dbAddNew = new PhoneStoreManagementEntities();
        TBL_ChiTietHoaDonNhap tBL_ChiTietHDN = new TBL_ChiTietHoaDonNhap();
        TBL_HoaDonNhap tBL_HoaDonNhap = new TBL_HoaDonNhap();
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
            txtIdImport.DataBindings.Add(new Binding("Text",dataGridView1.DataSource,"MaHoaDonNhap"));
            txtIdSupplier.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaNCC"));
            txtIdProduct.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaSP"));
            txtPromo.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "KhuyenMai"));
            txtQuantity.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoLuong"));
            txtUnitPrice.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGia"));
            txtIdSaler.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaNV"));
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
            txtQuantity.Text = "1";
            txtUnitPrice.Text = "0";
            lbDate.Text = DateTime.Now.ToString();
            lbAllPrice.Text = "0";
            lbTotalPrice.Text = "0";
            var showDataSource = from dbHoaDonNhap in dbAddNew.TBL_HoaDonNhap 
                                 join dbChiTietHDN in dbAddNew.TBL_ChiTietHoaDonNhap
                                 on dbHoaDonNhap.MaHoaDonNhap equals dbChiTietHDN.MaHDN select new { 
                                     dbHoaDonNhap.MaHoaDonNhap,
                                     dbHoaDonNhap.MaNCC,
                                     dbHoaDonNhap.MaNV,
                                     dbHoaDonNhap.NgayNhap,
                                     dbHoaDonNhap.TongTien,
                                     dbChiTietHDN.KhuyenMai,
                                     dbChiTietHDN.MaSP,
                                     dbChiTietHDN.SoLuong,
                                     dbChiTietHDN.DonGia,
                                     dbChiTietHDN.ThanhTien,
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
                    TBL_ChiTietHoaDonNhap dltChiTietHDN = dbAddNew.TBL_ChiTietHoaDonNhap.Where(p => p.MaHDN == (txtIdImport.Text).ToString()).SingleOrDefault();
                    TBL_HoaDonNhap dltHoaDonNhap = dbAddNew.TBL_HoaDonNhap.Where(p => p.MaHoaDonNhap == (txtIdImport.Text).ToString()).SingleOrDefault();
                    dbAddNew.TBL_ChiTietHoaDonNhap.Remove(dltChiTietHDN);
                    dbAddNew.TBL_HoaDonNhap.Remove(dltHoaDonNhap);
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
                tBL_ChiTietHDN.MaHDN = txtIdImport.Text;
                tBL_ChiTietHDN.MaSP = txtIdProduct.Text;
                tBL_ChiTietHDN.SoLuong = Convert.ToInt32(txtQuantity.Text);
                tBL_ChiTietHDN.KhuyenMai = Convert.ToDouble(txtPromo.Text);
                tBL_ChiTietHDN.ThanhTien = Convert.ToDecimal((lbAllPrice.Text));
                tBL_ChiTietHDN.DonGia = Convert.ToDecimal(txtUnitPrice.Text);

                tBL_HoaDonNhap.MaHoaDonNhap = txtIdImport.Text;
                tBL_HoaDonNhap.MaNCC = txtIdSupplier.Text;
                tBL_HoaDonNhap.MaNV = txtIdSaler.Text;
                tBL_HoaDonNhap.NgayNhap = DateTime.Now;
                tBL_HoaDonNhap.TongTien = Convert.ToDecimal(lbTotalPrice.Text);

                dbAddNew.TBL_ChiTietHoaDonNhap.Add(tBL_ChiTietHDN);
                dbAddNew.SaveChanges();
                dbAddNew.TBL_HoaDonNhap.Add(tBL_HoaDonNhap);
                dbAddNew.SaveChanges();
                renewPanel();
            }
            if(state == 2)
            {
                TBL_ChiTietHoaDonNhap editChiTietHDN = dbAddNew.TBL_ChiTietHoaDonNhap.Find(IDHoaDonNhap);
                TBL_HoaDonNhap editHoaDonNhap = dbAddNew.TBL_HoaDonNhap.Find(IDChiTietHDN);

                editChiTietHDN.MaHDN = txtIdImport.Text;
                editChiTietHDN.MaSP = txtIdProduct.Text;
                editChiTietHDN.SoLuong = Convert.ToInt32(txtQuantity.Text);
                editChiTietHDN.KhuyenMai = Convert.ToDouble(txtPromo.Text);
                editChiTietHDN.ThanhTien = Convert.ToDecimal(lbTotalPrice.Text);
                editHoaDonNhap.MaHoaDonNhap = txtIdImport.Text;
                editHoaDonNhap.MaNCC = txtIdSupplier.Text;
                editHoaDonNhap.MaNV = txtIdSaler.Text;
                editHoaDonNhap.NgayNhap = Convert.ToDateTime(lbDate.Text);
                editHoaDonNhap.TongTien = Convert.ToDecimal(lbAllPrice.Text);

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
                var showSearchResult = from dbHoaDonNhap in dbAddNew.TBL_HoaDonNhap
                                       join dbChiTietHDN in dbAddNew.TBL_ChiTietHoaDonNhap
                                       on dbHoaDonNhap.MaHoaDonNhap equals dbChiTietHDN.MaHDN
                                       where dbHoaDonNhap.MaHoaDonNhap == txtIdImport.Text && dbChiTietHDN.MaHDN == txtIdImport.Text
                                       select new
                                       {
                                           dbHoaDonNhap.MaHoaDonNhap,
                                           dbHoaDonNhap.MaNCC,
                                           dbHoaDonNhap.MaNV,
                                           dbHoaDonNhap.NgayNhap,
                                           dbHoaDonNhap.TongTien,
                                           dbChiTietHDN.KhuyenMai,
                                           dbChiTietHDN.MaSP,
                                           dbChiTietHDN.SoLuong,
                                           dbChiTietHDN.DonGia,
                                           dbChiTietHDN.ThanhTien,
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
