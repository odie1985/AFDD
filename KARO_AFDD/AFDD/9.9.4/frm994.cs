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
    public partial class frm994 : Form
    {
        public frm994()
        {
            InitializeComponent();
        }

        private void btn9942_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9942)
                {
                    frm9942 AFDD9942 = (frm9942)form;
                    AFDD9942.Activate();
                    AFDD9942.Show();
                }
            }
        }

        private void btn99431_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm99431)
                {
                    frm99431 AFDD99431 = (frm99431)form;
                    AFDD99431.Activate();
                    AFDD99431.Show();
                }
            }
        }

        private void btn9944_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9944)
                {
                    frm9944 AFDD9944 = (frm9944)form;
                    AFDD9944.Activate();
                    AFDD9944.Show();
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
