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
    public partial class Report4 : Form
    {
        public Report4()
        {
            InitializeComponent();
        }
        CuaHangBanDiDongV1Entities dbReport4 = new CuaHangBanDiDongV1Entities();
        public int getMonth;

        private void Report4_Load(object sender, EventArgs e)
        {
            getMonth = Convert.ToInt32(comboBox1.Text);
            showReport();
        }

        public class VM
        {
            public string MaNhanVien { get; set; }
            public string TenNhanVien { get; set; }
            public string GioiTinh { get; set; }
            public double TongTien { get; set; }
        }

        private void showReport()
        {
            var showResultSearch = dbReport4.Database.SqlQuery<VM>("select NhanVien.MaNhanVien,NhanVien.TenNhanVien,NhanVien.GioiTinh,SUM(HoaDonBan.TongTien) as TongTien from ChiTietHDB join HoaDonBan on ChiTietHDB.MaHDB = HoaDonBan.MaHDB join NhanVien on HoaDonBan.MaNhanVien = NhanVien.MaNhanVien where MONTH(HoaDonBan.NgayBan) = " + getMonth + " group by NhanVien.MaNhanVien, NhanVien.TenNhanVien, NhanVien.GioiTinh order by TongTien ").ToList();
            dataGridView1.DataSource = showResultSearch;
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
