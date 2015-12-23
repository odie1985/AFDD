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
    public partial class frm992 : Form
    {
        public frm992()
        {
            InitializeComponent();
        }

        private void btn9922_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9922)
                {
                    frm9922 AFDD9922 = (frm9922)form;
                    AFDD9922.Activate();
                    AFDD9922.Show();
                }
            }
        }

        private void btn9923_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9923)
                {
                    frm9923 AFDD9923 = (frm9923)form;
                    AFDD9923.Activate();
                    AFDD9923.Show();
                }
            }
        }

        private void btn9924_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9924)
                {
                    frm9924 AFDD9924 = (frm9924)form;
                    AFDD9924.Activate();
                    AFDD9924.Show();
                }
            }
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
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
    }
}
