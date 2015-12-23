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
    public partial class frmAFDDManual : Form
    {
        public frmAFDDManual()
        {
            InitializeComponent();
        }

        private void btnCarbidePath_Click(object sender, EventArgs e)
        {
            frmCPath cPath = new frmCPath();
            cPath.Activate();
            cPath.Show();
        }
    }
}
