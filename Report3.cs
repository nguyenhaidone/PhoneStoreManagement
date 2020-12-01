using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagement
{
    public partial class Report3 : Form
    {
        public Report3()
        {
            InitializeComponent();
        }
        CuaHangBanDiDongV1Entities dbReport3 = new CuaHangBanDiDongV1Entities();
        public int getYear;
        private void Report3_Load(object sender, EventArgs e)
        {
            getYear = Convert.ToInt32(comboBox1.Text);
            showReport3();
            
        }

        private void showReport3()
        {
            var ShowResult = from dbHoaDonBan in dbReport3.HoaDonBans
                             join dbChiTietHDB in dbReport3.ChiTietHDBs
                             on dbHoaDonBan.MaHDB equals dbChiTietHDB.MaHDB
                             where dbHoaDonBan.NgayBan.Value.Year == getYear
                             select new
                             {
                                 dbHoaDonBan.MaHDB,
                                 dbHoaDonBan.MaKhachHang,
                                 dbHoaDonBan.MaNhanVien,
                                 dbHoaDonBan.NgayBan,
                                 dbHoaDonBan.TongTien,
                                 dbChiTietHDB.MaSanPham,
                                 dbChiTietHDB.SoLuong,
                                 dbChiTietHDB.KhuyenMai,
                                 dbChiTietHDB.ThanhTien
                             };
            dataGridView1.DataSource = ShowResult.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getYear = Convert.ToInt32(comboBox1.Text);
            showReport3();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Detail";
            // tieu de  ID/NAME/
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List bills";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }
}
