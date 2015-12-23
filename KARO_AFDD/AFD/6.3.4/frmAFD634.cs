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
    public partial class frmAFD634 : Form
    {
        public frmAFD634()
        {
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
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

        private void bbtn63411_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD63411)
                {
                    frmAFD63411 AFD63411 = (frmAFD63411)form;
                    AFD63411.Activate();
                    AFD63411.Show();
                }
            }
        }

        private void btn63412_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD63412)
                {
                    frmAFD63412 AFD63412 = (frmAFD63412)form;
                    AFD63412.Activate();
                    AFD63412.Show();
                }
            }
        }

        private void btn63413_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD63413)
                {
                    frmAFD63413 AFD63413 = (frmAFD63413)form;
                    AFD63413.Activate();
                    AFD63413.Show();
                }
            }
        }
    }
}
