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
    public partial class frmAFD632 : Form
    {
        public frmAFD632()
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

        private void btn63221_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD63221)
                {
                    frmAFD63221 AFD63221 = (frmAFD63221)form;
                    AFD63221.Activate();
                    AFD63221.Show();
                }
            }
        }

        private void btn63222_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD63222)
                {
                    frmAFD63222 AFD63222 = (frmAFD63222)form;
                    AFD63222.Activate();
                    AFD63222.Show();
                }
            }
        }

        private void btn63223_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD63223)
                {
                    frmAFD63223 AFD63223 = (frmAFD63223)form;
                    AFD63223.Activate();
                    AFD63223.Show();
                }
            }
        }
    }
}
