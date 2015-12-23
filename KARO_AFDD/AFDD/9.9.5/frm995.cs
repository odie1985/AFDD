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
    public partial class frm995 : Form
    {
        public frm995()
        {
            InitializeComponent();
        }

        private void btn9952_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9952)
                {
                    frm9952 AFDD9952 = (frm9952)form;
                    AFDD9952.Activate();
                    AFDD9952.Show();
                }
            }
        }

        private void btn9954_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frm9954)
                {
                    frm9954 AFDD9954 = (frm9954)form;
                    AFDD9954.Activate();
                    AFDD9954.Show();
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
