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
    public partial class frmAFD63411 : Form
    {
        public frmAFD63411()
        {
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
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

        private void btn634111_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD634111)
                {
                    frmAFD634111 AFD634111 = (frmAFD634111)form;
                    AFD634111.Activate();
                    AFD634111.Show();
                }
            }
        }

        private void btn634112_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD634112)
                {
                    frmAFD634112 AFD634112 = (frmAFD634112)form;
                    AFD634112.Activate();
                    AFD634112.Show();
                }
            }
        }

        private void btn634113_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD634113)
                {
                    frmAFD634113 AFD634113 = (frmAFD634113)form;
                    AFD634113.Activate();
                    AFD634113.Show();
                }
            }
        }
    }
}
