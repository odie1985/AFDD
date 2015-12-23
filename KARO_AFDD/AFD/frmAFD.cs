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
    public partial class frmAFD : Form
    {
        public frmAFD()
        {
            InitializeComponent();
        }

        private void btnFalseAlarm_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD633)
                {
                    frmAFD633 AFD633 = (frmAFD633)form;
                    AFD633.Activate();
                    AFD633.Show();
                }
            }
        }

        private void btnLoadInhibitory_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD634)
                {
                    frmAFD634 AFD634 = (frmAFD634)form;
                    AFD634.Activate();
                    AFD634.Show();
                }
            }
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmDefault)
                {
                    frmDefault frmDefault = (frmDefault)form;
                    frmDefault.Activate();
                    frmDefault.Show();
                }
            }
        }

        private void btnArcFalse_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD632)
                {
                    frmAFD632 AFD632 = (frmAFD632)form;
                    AFD632.Activate();
                    AFD632.Show();
                }
            }
        }
    }
}
