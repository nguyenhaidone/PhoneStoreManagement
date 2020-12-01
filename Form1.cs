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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            /*ConnectDB.OpenConnection();*/
        }

        private void customizeDesign()
        {
            panelBanHangSubmenu.Visible = false;
            panelKhoHangSubmenu.Visible = false;
            panelBaoCaoSubmenu.Visible = false;
        }

        private void hideSubMenu() 
        { 
            if(panelBanHangSubmenu.Visible == true)
            {
                panelBanHangSubmenu.Visible = false;
            }
            if(panelKhoHangSubmenu.Visible == true)
            {
                panelKhoHangSubmenu.Visible = false;
            }
            if (panelBaoCaoSubmenu.Visible == true)
            {
                panelBaoCaoSubmenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBanHangSubmenu);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKhoHangSubmenu);
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBaoCaoSubmenu);
        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            /*WindowState = FormWindowState.Minimized;
            childForm.Dock = DockStyle.Fill;*/
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            openChildForm(new AboutStore());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildForm(new UIBill());
        }

        private void PhoneCatalogue_Click(object sender, EventArgs e)
        {
            openChildForm(new UIBill());
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            openChildForm(new AddNew());
        }

        private void Bills_Click(object sender, EventArgs e)
        {
            openChildForm(new Bills());
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            openChildForm(new Report1());
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            openChildForm(new Report2());
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            openChildForm(new Report3());
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            openChildForm(new Report4());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            openChildForm(new PhoneCatalog());
        }

        private void btnAboutStore_Click(object sender, EventArgs e)
        {
            openChildForm(new AboutStore());
        }
    }
    

}
