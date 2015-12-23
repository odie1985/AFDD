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
    public partial class frm993 : Form
    {
        public frm993()
        {
            InitializeComponent();
        }

        private void btn9931_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9931)
                {
                    frm9931 AFDD9931 = (frm9931)form;
                    AFDD9931.Activate();
                    AFDD9931.Show();
                }
            }
        }

        private void btn9932_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9932)
                {
                    frm9932 AFDD9932 = (frm9932)form;
                    AFDD9932.Activate();
                    AFDD9932.Show();
                }
            }
        }

        private void btn9933_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9933)
                {
                    frm9933 AFDD9933 = (frm9933)form;
                    AFDD9933.Activate();
                    AFDD9933.Show();
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
