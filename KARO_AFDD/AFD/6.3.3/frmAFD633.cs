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
    public partial class frmAFD633 : Form
    {
        public frmAFD633()
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

        private void btn6331_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD6331)
                {
                    frmAFD6331 AFD6331 = (frmAFD6331)form;
                    AFD6331.Activate();
                    AFD6331.Show();
                }
            }
        }

        private void btn6332_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD6332)
                {
                    frmAFD6332 AFD6332 = (frmAFD6332)form;
                    AFD6332.Activate();
                    AFD6332.Show();
                }
            }
        }
    }
}
