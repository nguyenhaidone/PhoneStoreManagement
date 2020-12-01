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
    public partial class UIBill : Form
    {
        public UIBill()
        {
            InitializeComponent();
        }
        CuaHangBanDiDongV1Entities phoneManagementDBEntities = new CuaHangBanDiDongV1Entities();
        ChiTietHDB chiTietHDB = new ChiTietHDB();
        HoaDonBan hoaDonBan = new HoaDonBan();
        public string imgPath;
        public string nameProduct;
        public double unitPrice;
        public double idProducts;
        private void UIBill_Load(object sender, EventArgs e)
        {
            showProduct();
        }

        private void showProduct()
        {
            {
                var showData = from db in phoneManagementDBEntities.SanPhams select db;
                dataGridView1.DataSource = showData.ToList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            try
            {
                imgPath = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                nameProduct = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                unitPrice = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[5].Value);
                pictureBox1.Image = Image.FromFile(@"" + imgPath + "");
                lbName.Text = nameProduct;
                lbUnitPrice.Text = unitPrice.ToString();
                lb2Name.Text = nameProduct;
                lb2UnitPrice.Text = unitPrice.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (lbUnitPrice.Text == "0")
            {
                MessageBox.Show(this, "This product was out stock, please choose other product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            } else
            {
                panel5.Enabled = true;
                lbID.Text = DateTime.Now.ToString().GetHashCode().ToString("x");
                lbIDProduct.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lbDate.Text = DateTime.Now.ToString();
            }
        }

        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            caclPrice();
        }

        private void caclPrice()
        {
            try
            {
                lbTotalPrice.Text = (Convert.ToDouble(lb2UnitPrice.Text) * Convert.ToDouble(numericUpDown1.Value) - Convert.ToDouble(lb2UnitPrice.Text) * Convert.ToDouble(numericUpDown1.Value) * Convert.ToDouble(txtDiscount.Text)).ToString();
            }
            catch(FormatException e)
            {
                MessageBox.Show(this, "Please input here", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            caclPrice();
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
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValid(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel5.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Are you sure about that?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                chiTietHDB.MaHDB = lbID.Text;
                chiTietHDB.MaSanPham = lbIDProduct.Text;
                chiTietHDB.SoLuong = Convert.ToInt32(numericUpDown1.Value);
                chiTietHDB.KhuyenMai = Convert.ToDouble(txtDiscount.Text);
                chiTietHDB.ThanhTien = Convert.ToDouble(lb2UnitPrice.Text) * Convert.ToInt32(numericUpDown1.Value);

                hoaDonBan.MaHDB = lbID.Text;
                hoaDonBan.MaNhanVien = txtIDSaler.Text;
                hoaDonBan.MaKhachHang = txtIdCustomer.Text;
                hoaDonBan.NgayBan = DateTime.Now;
                hoaDonBan.TongTien = Convert.ToDouble(lbTotalPrice.Text);

                phoneManagementDBEntities.ChiTietHDBs.Add(chiTietHDB);
                phoneManagementDBEntities.SaveChanges();
                phoneManagementDBEntities.HoaDonBans.Add(hoaDonBan);
                phoneManagementDBEntities.SaveChanges();

                SanPham sanPham = phoneManagementDBEntities.SanPhams.Find(lbIDProduct.Text);
                sanPham.SoLuong -= Convert.ToInt32(numericUpDown1.Value);
                phoneManagementDBEntities.SaveChanges();

                MessageBox.Show(this, "Buy success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showProduct();
            }
            panel3.Enabled = false;
            panel5.Enabled = false;
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rdbMaSP.Checked==false && rdbTenSP.Checked == false)
            {
                MessageBox.Show(this, "Please choose type of searching!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (txtSearch.Text != "")
                {
                    if (rdbMaSP.Checked == true && rdbTenSP.Checked==false)
                    {
                        var showResult = from dbSanPham in phoneManagementDBEntities.SanPhams
                                         where dbSanPham.MaSanPham == txtSearch.Text.ToString()
                                         select dbSanPham;
                        var searchResult = phoneManagementDBEntities.Database.SqlQuery<SanPham>("select * from SanPham where MaSanPham LIKE '" + txtSearch.Text.ToString() + "%'").ToList();
                        dataGridView1.DataSource = searchResult;
                    }
                    else if(rdbMaSP.Checked == false && rdbTenSP.Checked == true)
                    {
                        var showResult = from dbSanPham in phoneManagementDBEntities.SanPhams
                                         where dbSanPham.TenSanPham == txtSearch.Text.ToString()
                                         select dbSanPham;
                        var searchResult = phoneManagementDBEntities.Database.SqlQuery<SanPham>("select * from SanPham where TenSanPham LIKE '" + txtSearch.Text.ToString() + "%'").ToList();
                        dataGridView1.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show(this, "Please choose one of them!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please fill this text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
