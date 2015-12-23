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
    public partial class frmAFDD : Form
    {
        public frmAFDD()
        {
            InitializeComponent();
        }

        private void btn992_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm992)
                {
                    frm992 AFDD992 = (frm992)form;
                    AFDD992.Activate();
                    AFDD992.Show();
                }
            }
        }

        private void btn993_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm993)
                {
                    frm993 AFDD993 = (frm993)form;
                    AFDD993.Activate();
                    AFDD993.Show();
                }
            }
        }

        private void btn994_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm994)
                {
                    frm994 AFDD994 = (frm994)form;
                    AFDD994.Activate();
                    AFDD994.Show();
                }
            }
        }

        private void btn995_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm995)
                {
                    frm995 AFDD995 = (frm995)form;
                    AFDD995.Activate();
                    AFDD995.Show();
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
    }
}
