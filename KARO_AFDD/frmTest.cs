using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KARO_AFDD
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDITest DItest = new frmDITest();
            DItest.Activate();
            DItest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDOTest DOtest = new frmDOTest();
            DOtest.Activate();
            DOtest.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAndArcManual andArc = new frmAndArcManual();
            andArc.Activate();
            andArc.Show();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {

        }

        private void btnInstantAi_Click(object sender, EventArgs e)
        {
            frmInstantAi instantAi = new frmInstantAi();
            instantAi.Activate();
            instantAi.Show();
        }
    }
}
