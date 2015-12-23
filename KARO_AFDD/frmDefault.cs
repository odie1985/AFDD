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
    public partial class frmDefault : Form
    {
        public frmDefault()
        {
            InitializeComponent();
        }

        private void btnCarbidePath_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmCarbidePath)
                {
                    frmCarbidePath carbidePath = (frmCarbidePath)form;
                    carbidePath.Activate();
                    carbidePath.Show();
                }
            }
        }

        private void btnAFDD_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFDD)
                {
                    frmAFDD AFDD = (frmAFDD)form;
                    AFDD.Activate();
                    AFDD.Show();
                }
            }
        }

        private void btnAFD_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD)
                {
                    frmAFD AFD = (frmAFD)form;
                    AFD.Activate();
                    AFD.Show();
                }
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            frmTest test = new frmTest();
            test.Activate();
            test.Show();
        }
    }
}
