using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Automation.BDaq;
using System.Threading;

namespace KARO_AFDD
{
    public partial class frmCarbidePath : Form
    {
        #region fields
        private int[] m_portHex = new int[ConstVal.PortCountShow] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int[] m_portNum = new int[ConstVal.PortCountShow] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        SimpleGraph m_simpleGraph_I;
        SimpleGraph m_simpleGraph_V;
        double[] m_dataScaled;
        double[] m_dataCalibration;
        double[] m_dataScaled_I;
        double[] m_dataScaled_V;

        TimeUnit m_timeUnit;

        string device1742 = "PCI-1742U,BID#0";
        string device1758DO = "PCI-1758UDO,BID#0";
        string device1758DI = "PCI-1758UDI,BID#0";
        int startChannel = 1;
        int channelCount = 4;
        int sampleCount = 3000; 
        int convertClkRatePerChan = 1000;

        delegate void UpdateUIDelegate();

        #endregion

        public frmCarbidePath()
        {
            InitializeComponent();
        }

        private void frmCarbidePath_Load(object sender, EventArgs e)
        {
            instantDoCtrl1.SelectedDevice = new DeviceInformation(device1758DO);
            instantDiCtrl1.SelectedDevice = new DeviceInformation(device1758DI);

            Control.CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(MainProgram);
            thread.IsBackground = true;
            thread.Start();
        }

        private void MainProgram()
        {

            if (!instantDoCtrl1.Initialized)
            {
                MessageBox.Show("No device be selected or device open failed!", "AsynchronousOneBufferedAI");
                this.Close();
                return;
            }

            InitializePortState();
        }

        private void InitializePortState()
        {
            byte portData = 0;
             
            int startPort = 0;
            ErrorCode err = ErrorCode.Success;
            byte[] mask = instantDoCtrl1.Features.DataMask;
            for (int i = 0; (i + ConstVal.StartPort) < instantDoCtrl1.Features.PortCount && i < ConstVal.PortCountShow; ++i)
            {
                err = instantDoCtrl1.Write(i + ConstVal.StartPort, (byte)m_portHex[i]);
                if (err != ErrorCode.Success)
                {
                    HandleError(err);
                    return;
                }

                m_portNum[i] = i + ConstVal.StartPort;
                m_portHex[i] = portData;
            }
        }

        private void btn12kV_Click(object sender, EventArgs e)
        {
            int t1 = int.Parse(txtT1.Text);
            if (DI_Check(2) == 1)
            {
                do
                {
                    DO_Click(0, 2);     //闭合S102
                } while ((int)DI_Check(0) == 2);
                System.Threading.Thread.Sleep(1000);

                do
                {
                    DO_Click(0, 3);     //闭合S101
                } while ((int)DI_Check(0) == 3);
                System.Threading.Thread.Sleep(t1 * 1000);

                do
                {
                    DO_Click(0, 2);     //断开S101
                } while ((int)DI_Check(0) == 2);
                System.Threading.Thread.Sleep(500);

                do
                {
                    DO_Click(0, 0);     //断开S102
                } while ((int)DI_Check(0) == 0);
            }
        }

        private void btn2kV_Click(object sender, EventArgs e)
        {
            int t2 = int.Parse(txtT2.Text);
            if (DI_Check(2) == 1)
            {
                do
                {
                    DO_Click(0, 4);     //闭合S103
                } while ((int)DI_Check(0) == 4);
                System.Threading.Thread.Sleep(1000);

                do
                {
                    DO_Click(0, 5);     //闭合S101
                } while ((int)DI_Check(0) == 5);
                System.Threading.Thread.Sleep(t2 * 1000);

                do
                {
                    DO_Click(0, 4);     //断开S101
                } while ((int)DI_Check(0) == 4);
                System.Threading.Thread.Sleep(500);

                do
                {
                    DO_Click(0, 0);     //断开S103
                } while ((int)DI_Check(0) == 0);
            }
        }

        private void btnLamp_Click(object sender, EventArgs e)
        {
            int t2 = int.Parse(txtT2.Text);
            if (DI_Check(2) == 1)
            {
                do
                {
                    DO_Click(0, 16);     //闭合S105
                } while ((int)DI_Check(0) == 16);
                System.Threading.Thread.Sleep(1000);

                do
                {
                    DO_Click(0, 24);     //闭合S104
                } while ((int)DI_Check(0) == 24);
                System.Threading.Thread.Sleep(2000);
                
                do
                {
                    DO_Click(0, 0);     //断开S104 S105
                } while ((int)DI_Check(0) == 0);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int t1 = int.Parse(txtT1.Text);
            int t2 = int.Parse(txtT2.Text);

            //12kV
            if (DI_Check(2) == 1)
            {
                do
                {
                    DO_Click(0, 2);     //闭合S102
                } while ((int)DI_Check(0) == 2);
                System.Threading.Thread.Sleep(1000);

                do
                {
                    DO_Click(0, 3);     //闭合S101
                } while ((int)DI_Check(0) == 3);
                System.Threading.Thread.Sleep(t1 * 1000);

                do
                {
                    DO_Click(0, 2);     //断开S101
                } while ((int)DI_Check(0) == 2);
                System.Threading.Thread.Sleep(500);

                do
                {
                    DO_Click(0, 0);     //断开S102
                } while ((int)DI_Check(0) == 0);
            }

            //2kV
            if (DI_Check(2) == 1)
            {
                do
                {
                    DO_Click(0, 4);     //闭合S103
                } while ((int)DI_Check(0) == 4);
                System.Threading.Thread.Sleep(1000);

                do
                {
                    DO_Click(0, 5);     //闭合S101
                } while ((int)DI_Check(0) == 5);
                System.Threading.Thread.Sleep(t2 * 1000);

                do
                {
                    DO_Click(0, 4);     //断开S101
                } while ((int)DI_Check(0) == 4);
                System.Threading.Thread.Sleep(500);

                do
                {
                    DO_Click(0, 0);     //断开S103
                } while ((int)DI_Check(0) == 0);
            }

            //Lamp
            if (DI_Check(2) == 1)
            {
                do
                {
                    DO_Click(0, 16);     //闭合S105
                } while ((int)DI_Check(0) == 16);
                System.Threading.Thread.Sleep(1000);

                do
                {
                    DO_Click(0, 24);     //闭合S104
                } while ((int)DI_Check(0) == 24);
                System.Threading.Thread.Sleep(2000);

                do
                {
                    DO_Click(0, 0);     //断开S104 S105
                } while ((int)DI_Check(0) == 0);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            InitializePortState();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            instantDiCtrl1.Dispose();
            instantDoCtrl1.Dispose();
            this.Hide();
        }

        private void btnExhaustFan_Click(object sender, EventArgs e)
        {
            byte tmp = DI_Check(1);
            int checkDI = (int)tmp & 4;
            if (checkDI == 1)
            {
                DO_Click(1, DI_Check(1) + 4);
            }
            else
            {
                DO_Click(1, DI_Check(1) - 4);
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

        #region Button Operate

        /// <summary>
        /// DO开关控制
        /// </summary>
        private void DO_Click(int port, int data)
        {
            ErrorCode err = ErrorCode.Success;

            err = instantDoCtrl1.Write(port, (byte)data);
            if (err != ErrorCode.Success)
            {
                HandleError(err);
                return;
            }
        }

        /// <summary>
        /// DI状态检测
        /// </summary>
        private byte DI_Check(int port)
        {
            byte data = 0;
            ErrorCode err = ErrorCode.Success;

            err = instantDiCtrl1.Read(port, out data);

            return data;
        }

        #endregion

        private void HandleError(ErrorCode err)
        {
            if (err != ErrorCode.Success)
            {
                MessageBox.Show("Sorry ! There are some errors happened, the error code is: " + err.ToString(), "AsynchronousOneBufferedAI");
            }
        }

    }
}
