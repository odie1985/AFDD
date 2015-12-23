using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Automation.BDaq;

namespace KARO_AFDD
{
    public partial class frmCalibrationValue : Form
    {
        #region fields
        int startChannel = 0;
        const int channelCount = 4;
        double[] scaledData = new double[channelCount];

        int channelA_K = 0;
        int channelB_K = 0;
        int channelC_K = 0;
        int channelD_K = 0;

        int channelA_B = 0;
        int channelB_B = 0;
        int channelC_B = 0;
        int channelD_B = 0;

        ErrorCode errorCode = ErrorCode.Success;
        #endregion

        // 函数 y * 1024 = (kx + b) * 1024
        private class Fun
        {
            public double x1 = 0;
            public double y1 = 0;
            public double x2 = 0;
            public double y2 = 0;
            public double k = 0;
            public double b = 0;
        }

        private Fun A = new Fun();
        private Fun B = new Fun();
        private Fun C = new Fun();
        private Fun D = new Fun();

        private bool retry = false;

        public frmCalibrationValue()
        {
            InitializeComponent();
        }

        public frmCalibrationValue(int deviceNumber)
        {
            InitializeComponent();
            instantAiCtrl1.SelectedDevice = new DeviceInformation(deviceNumber);
        }

        private void frmCalibrationValue_Load(object sender, EventArgs e)
        {
            int channelCountMax = instantAiCtrl1.Features.ChannelCountMax;

            btnStep1.Enabled = true;
            btnStep2.Enabled = false;
            btnStep3.Enabled = false;
            btnStep4.Enabled = false;
            lblbStep5.Text = "";

            
        }

        private void btnStep1_Click(object sender, EventArgs e)
        {
            try
            {
                A.y1 = double.Parse(txtY1.Text);
                B.y1 = A.y1;
                C.y1 = A.y1;
                D.y1 = A.y1;
            }
            catch (System.Exception)
            {
                MessageBox.Show("错误：电流输入错误!");
                return;
            }

            errorCode = instantAiCtrl1.Read(startChannel, channelCount, scaledData);

            int sumA = 0;
            int sumB = 0;
            int sumC = 0;
            int sumD = 0;
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);      // wait for refresh device
                sumA += (int)scaledData[0];
                sumB += (int)scaledData[1];
                sumC += (int)scaledData[2];
                sumD += (int)scaledData[3];
            }

            A.x1 = sumA >> 2;
            B.x1 = sumB >> 2;
            C.x1 = sumC >> 2;
            D.x1 = sumD >> 2;

            txtSmp1.Text = string.Format("A={0},B={1},C={2},D={3}", A.x1, B.x1, C.x1, D.x1);

            btnStep2.Enabled = true;
            btnStep1.Enabled = false;
        }

        private void btnStep2_Click(object sender, EventArgs e)
        {
            btnStep3.Enabled = true;
            btnStep2.Enabled = false;
        }

        private void btnStep3_Click(object sender, EventArgs e)
        {
            try
            {
                A.y2 = double.Parse(txtY2.Text);
                B.y2 = A.y2;
                C.y2 = A.y2;
                D.y2 = A.y2;
            }
            catch (System.Exception)
            {
                MessageBox.Show("错误：电流输入错误!");
                return;
            }

            errorCode = instantAiCtrl1.Read(startChannel, channelCount, scaledData);

            int sumA = 0;
            int sumB = 0;
            int sumC = 0;
            int sumD = 0;
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);      // wait for refresh device
                sumA += (int)scaledData[0];
                sumB += (int)scaledData[1];
                sumC += (int)scaledData[2];
                sumD += (int)scaledData[3];
            }

            A.x2 = sumA >> 2;
            B.x2 = sumB >> 2;
            C.x2 = sumC >> 2;
            D.x2 = sumD >> 2;

            txtSmp2.Text = string.Format("A={0},B={1},C={2},D={3}", A.x2, B.x2, C.x2, D.x2);

            btnStep4.Enabled = true;
            btnStep3.Enabled = false;
        }

        private void btnStep4_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                if (chkA.Checked)
                {
                    calcKB(ref A);
                    str += string.Format("A.K={0},A.B={1},", A.k, A.b);
                }

                if (chkB.Checked)
                {
                    calcKB(ref B);
                    str += string.Format("B.K={0},B.B={1},", B.k, B.b);
                }

                if (chkC.Checked)
                {
                    calcKB(ref C);
                    str += string.Format("C.K={0},C.B={1},", C.k, C.b);
                }
                if (chkD.Checked)
                {
                    calcKB(ref D);
                    str += string.Format("D.K={0},D.B={1},", D.k, D.b);
                }

                txtKB.Text = str;
                btnStep4.Enabled = false;

                setKB();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStep5_Click(object sender, EventArgs e)
        {
            if (retry)
            {
                setKB();
            }
            else
            {
                Close();
            }
        }

        private void setKB()
        {

            lblbStep5.Text = "正在设置...";

            if (chkA.Checked)
            {
                channelA_K = (short)A.k;
                channelA_B = (short)A.b;
            }

            if (chkB.Checked)
            {
                channelB_K = (short)B.k;
                channelB_B = (short)B.b;
            }

            if (chkC.Checked)
            {
                channelC_K = (short)C.k;
                channelC_B = (short)C.b;
            }
            if (chkD.Checked)
            {
                channelD_K = (short)D.k;
                channelD_B = (short)D.b;
            }

            for (int i = 0; i < 5; i++)
            {
                int err = 0;

                Thread.Sleep(300);

                if (chkA.Checked)
                {
                    if (channelA_K != (short)A.k ||
                        channelA_B != (short)A.b )
                    {
                        err = 1;
                    }
                }

                if (chkB.Checked)
                {
                    if (channelB_K != (short)B.k ||
                        channelC_B != (short)B.b )
                    {
                        err = 1;
                    }
                }

                if (chkC.Checked)
                {
                    if (channelC_K != (short)C.k ||
                        channelC_B != (short)C.b )
                    {
                        err = 1;
                    }
                }
                if (chkD.Checked)
                {
                    if (channelD_K != (short)D.k ||
                        channelD_B != (short)D.b)
                    {
                        err = 1;
                    }
                }

                if (err == 0)
                {
                    lblbStep5.Text = "校准完成.";
                    btnStep5.Text = "关闭";
                    retry = false;
                    return;
                }
            }

            retry = true;

            lblbStep5.Text = "设置失败，请重试!";
            btnStep5.Text = "重试";
        }

        private void calcKB(ref Fun f)
        {
            if (Math.Abs(f.x2 - f.x1) <= 30)
            {
                throw new Exception("错误：两次采样值差小于30！");
            }

            f.k = (f.y2 - f.y1) / (f.x2 - f.x1);
            f.b = f.y2 - f.k * f.x2;

            f.k = Math.Round(f.k * 16384);
            f.b = Math.Round(f.b * 16384);
        }

        private void EnterToTab_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
