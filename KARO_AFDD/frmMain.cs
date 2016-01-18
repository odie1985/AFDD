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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CreateForms();
            CreaterDefaultForm();
        }
        
        private void CreateForms()
        {            
            CreateCarbidePathForm();
            CreateAFDDForm();
            CreateAFDForm();
            CreateAndArcForm();
        }

        private void CreaterDefaultForm()
        {
            frmDefault formdefault = null;
            Form[] f =this.MdiChildren;
            if(f != null && f.Length > 0)
            {
                foreach (Form form in f)
                {
                    if (form is frmDefault)
                    {
                        formdefault = (frmDefault)form;
                        formdefault.Show();
                        formdefault.Activate();
                    }
                    if (formdefault == null)
                    {
                        formdefault = new frmDefault();
                        formdefault.MdiParent = this;
                        formdefault.WindowState = FormWindowState.Normal;
                        formdefault.Show();
                        formdefault.Activate();
                    }
                }
            }
        }
        
        private void CreateCarbidePathForm()
        {
            frmCarbidePath carbidePath = new frmCarbidePath();
            carbidePath.MdiParent = this;
            carbidePath.WindowState = FormWindowState.Normal;
        }

        private void CreateAFDDForm()
        {
            frmAFDD AFDD = new frmAFDD();
            AFDD.MdiParent = this;
            AFDD.WindowState = FormWindowState.Normal;
            Create992Form();
            Create993Form();
            Create994Form();
            Create995Form();
        }

        private void CreateAFDForm()
        {
            frmAFD AFD = new frmAFD();
            AFD.MdiParent = this;
            AFD.WindowState = FormWindowState.Normal;
            CreateAFD632Form();
            CreateAFD633Form();
            CreateAFD634Form();
            CreateAndArcForm();
        }

        private void CreateAFD632Form()
        {
            frmAFD632 AFD632 = new frmAFD632();
            AFD632.MdiParent = this;
            AFD632.WindowState = FormWindowState.Normal;
            CreateAFD6322Form();
        }

        private void CreateAFD633Form()
        {
            frmAFD633 AFD633 = new frmAFD633();
            AFD633.MdiParent = this;
            AFD633.WindowState = FormWindowState.Normal;
            CreateAFD6331Form();
            CreateAFD6332Form();
        }

        private void CreateAFD6331Form()
        {
            frmAFD6331 AFD6331 = new frmAFD6331();
            AFD6331.MdiParent = this;
            AFD6331.WindowState = FormWindowState.Normal;

            frmAFD63311 AFD63311 = new frmAFD63311();
            frmAFD63312 AFD63312 = new frmAFD63312();
            frmAFD63313 AFD63313 = new frmAFD63313();
            frmAFD63314 AFD63314 = new frmAFD63314();
            frmAFD63315 AFD63315 = new frmAFD63315();
            frmAFD63316 AFD63316 = new frmAFD63316();
            frmAFD63317 AFD63317 = new frmAFD63317();
            frmAFD63318 AFD63318 = new frmAFD63318();
            frmAFD63319 AFD63319 = new frmAFD63319();

            AFD63311.MdiParent = AFD63312.MdiParent = AFD63313.MdiParent = AFD63314.MdiParent
            = AFD63315.MdiParent = AFD63316.MdiParent = AFD63317.MdiParent = AFD63318.MdiParent = AFD63319.MdiParent = this;
            AFD63311.WindowState = AFD63312.WindowState = AFD63313.WindowState = AFD63314.WindowState
            = AFD63315.WindowState = AFD63316.WindowState = AFD63317.WindowState = AFD63318.WindowState = AFD63319.WindowState = FormWindowState.Normal;
        }

        private void CreateAFD6332Form()
        {
            frmAFD6332 AFD6332 = new frmAFD6332();
            AFD6332.MdiParent = this;
            AFD6332.WindowState = FormWindowState.Normal;
        }

        private void CreateAFD634Form()
        {
            frmAFD634 AFD634 = new frmAFD634();
            AFD634.MdiParent = this;
            AFD634.WindowState = FormWindowState.Normal;

            CreateAFD63411Form();
            CreateAFD63412Form();
            CreateAFD63413Form();
        }

        private void CreateAFD63411Form()
        {
            frmAFD63411 AFD63411 = new frmAFD63411();
            AFD63411.MdiParent = this;
            AFD63411.WindowState = FormWindowState.Normal;

            frmAFD634111 frmAFD634111 = new frmAFD634111();
            frmAFD634112 frmAFD634112 = new frmAFD634112();
            frmAFD634113 frmAFD634113 = new frmAFD634113();

            frmAFD634111.MdiParent = frmAFD634112.MdiParent = frmAFD634113.MdiParent = this;
            frmAFD634111.WindowState = frmAFD634112.WindowState = frmAFD634113.WindowState = FormWindowState.Normal;
        }

        private void CreateAFD63412Form()
        {
            frmAFD63412 AFD63412 = new frmAFD63412();
            AFD63412.MdiParent = this;
            AFD63412.WindowState = FormWindowState.Normal;
        }

        private void CreateAFD63413Form()
        {
            frmAFD63413 AFD63413 = new frmAFD63413();
            AFD63413.MdiParent = this;
            AFD63413.WindowState = FormWindowState.Normal;
        }

        private void CreateAFD6322Form()
        {
            frmAFD63221 AFD63221 = new frmAFD63221();
            frmAFD63222 AFD63222 = new frmAFD63222();
            frmAFD63223 AFD63223 = new frmAFD63223();
            AFD63221.MdiParent = AFD63222.MdiParent = AFD63223.MdiParent = this;
            AFD63223.WindowState = AFD63222.WindowState = AFD63223.WindowState = FormWindowState.Normal;
        }

        private void CreateAndArcForm()
        {
            frmAndArcManual andArc = new frmAndArcManual();
            andArc.MdiParent = this;
            andArc.WindowState = FormWindowState.Normal;
        }

        private void Create992Form()
        {
            frm992 frm992 = new frm992();
            frm9922 frm9922 = new frm9922();
            frm9923 frm9923 = new frm9923();
            frm9924 frm9924 = new frm9924();

            frm992.MdiParent = frm9922.MdiParent = frm9923.MdiParent = frm9924.MdiParent = this;
            frm992.WindowState = frm9922.WindowState = frm9923.WindowState = frm9924.WindowState = FormWindowState.Normal;
        }

        private void Create993Form()
        {
            frm993 frm993 = new frm993();
            frm9931 frm9931 = new frm9931();
            frm9932 frm9932 = new frm9932();
            frm9933 frm9933 = new frm9933();

            frm993.MdiParent = frm9931.MdiParent = frm9932.MdiParent = frm9933.MdiParent = this;
            frm993.WindowState = frm9931.WindowState = frm9932.WindowState = frm9933.WindowState = FormWindowState.Normal;
        }

        private void Create994Form()
        {
            frm994 frm994 = new frm994();
            frm99431 frm99431 = new frm99431();
            frm9944 frm9944 = new frm9944();

            frm994.MdiParent = frm99431.MdiParent = frm9944.MdiParent  = this;
            frm994.WindowState = frm99431.WindowState = frm9944.WindowState = FormWindowState.Normal;

            Create9942Form();
        }

        private void Create9942Form()
        {
            frm9942 frm9942 = new frm9942();
            frm9942.MdiParent = this;
            frm9942.WindowState = FormWindowState.Normal;

            frm99421 frm99421 = new frm99421();
            frm99422 frm99422 = new frm99422();
            frm99423 frm99423 = new frm99423();
            frm99424 frm99424 = new frm99424();
            frm99425 frm99425 = new frm99425();
            frm99426 frm99426 = new frm99426();
            frm99427 frm99427 = new frm99427();
            frm99428 frm99428 = new frm99428();

            frm99421.MdiParent = frm99422.MdiParent = frm99423.MdiParent = frm99424.MdiParent
            = frm99425.MdiParent = frm99426.MdiParent = frm99427.MdiParent = frm99428.MdiParent = this;
            frm99421.WindowState = frm99422.WindowState = frm99423.WindowState = frm99424.WindowState
            = frm99425.WindowState = frm99426.WindowState = frm99427.WindowState = frm99428.WindowState = FormWindowState.Normal;
        }

        private void Create995Form()
        {
            frm995 frm995 = new frm995();
            frm995.MdiParent = this;
            frm995.WindowState = FormWindowState.Normal;

            Create9952Form();
            Create9954Form();
        }

        private void Create9952Form()
        {
            frm9952 frm9952 = new frm9952();
            frm9952.MdiParent = this;
            frm9952.WindowState = FormWindowState.Normal;
        }

        private void Create9954Form()
        {
            frm9954 frm9954 = new frm9954();
            frm9954.MdiParent = this;
            frm9954.WindowState = FormWindowState.Normal;

            frm99541 frm99541 = new frm99541();
            frm99542 frm99542 = new frm99542();
            frm99543 frm99543 = new frm99543();
            frm99544 frm99544 = new frm99544();
            frm99545 frm99545 = new frm99545();
            frm99546 frm99546 = new frm99546();
            frm99547 frm99547 = new frm99547();

            frm99541.MdiParent = frm99542.MdiParent = frm99543.MdiParent = frm99544.MdiParent
            = frm99545.MdiParent = frm99546.MdiParent = frm99547.MdiParent = this;
            frm99541.WindowState = frm99542.WindowState = frm99543.WindowState = frm99544.WindowState
            = frm99545.WindowState = frm99546.WindowState = frm99547.WindowState = FormWindowState.Normal;
        }
    }
}
