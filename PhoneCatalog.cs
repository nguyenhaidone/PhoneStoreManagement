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
            using (CuaHangBanDiDongV1Entities phoneManagementDBEntities = new CuaHangBanDiDongV1Entities())
            {
                var showData = from db in phoneManagementDBEntities.SanPhams select db;
                dataGridView1.DataSource = showData.ToList();
            }
        }

        public string imgPath;



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PhoneCatalog_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            { 
                lbID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lbName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lbCataloges.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                lbBrandId.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                lbPriceExport.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                lbPriceImport.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                lbQuantity.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                lnDate.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                lbSoundCard.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                lbResolution.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                imgPath = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                pictureBox1.Image = Image.FromFile(@"" + imgPath + "");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
