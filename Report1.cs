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
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }
        CuaHangBanDiDongV1Entities dbReport1 = new CuaHangBanDiDongV1Entities();
        public int getMonth;
        private void Report1_Load(object sender, EventArgs e)
        {
            getMonth = Convert.ToInt32(comboBox1.Text);
            showReport();
        }

        public class VM1
        {
            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public int TongSo { get; set; }
        }

        private void showReport()
        {
            var ShowResult = dbReport1.Database.SqlQuery<VM1>("select SanPham.MaSanPham,SanPham.TenSanPham, SUM(ChiTietHDB.SoLuong) as TongSo from SanPham join ChiTietHDB on SanPham.MaSanPham = ChiTietHDB.MaSanPham join HoaDonBan on ChiTietHDB.MaHDB = HoaDonBan.MaHDB where MONTH(HoaDonBan.NgayBan) = " + getMonth + " group by SanPham.MaSanPham, SanPham.TenSanPham order by TongSo").ToList();
            dataGridView1.DataSource = ShowResult;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getMonth = Convert.ToInt32(comboBox1.Text);
            showReport();
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
