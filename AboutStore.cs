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
    public partial class AboutStore : Form
    {
        public AboutStore()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
            label4.Text = DateTime.Now.ToString("dddd , MMM dd yyy");
        }

        private void AboutStore_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
