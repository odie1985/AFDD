using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Automation.BDaq;

namespace KARO_AFDD
{
    public partial class Form1 : Form
    {
        #region fields
        private int[] m_portHex;
        private int[] m_portNum;

        DoBitInformation button_101 = new DoBitInformation();
        DoBitInformation button_102 = new DoBitInformation();
        DoBitInformation button_103 = new DoBitInformation();
        DoBitInformation button_104 = new DoBitInformation();
        DoBitInformation button_105 = new DoBitInformation();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int deviceNumber)
        {
            InitializeComponent();
            instantDoCtrl1.SelectedDevice = new DeviceInformation(deviceNumber);
            instantDiCtrl1.SelectedDevice = new DeviceInformation(deviceNumber);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_portNum = new int[ConstVal.PortCountShow] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            m_portHex = new int[ConstVal.PortCountShow] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            buttonTag_init();
            InitializePortState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(button_101);
            test1();           
        }

        private void test1()
        {
            if (buttonCheck(button_101) == 1)
            {
                button_Click(button_102);
                test2();
            }
            else
            {
                test1();
            }
        }

        private void test2()
        {
            if (buttonCheck(button_102) == 1)
            {
                button_Click(button_103);
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                test2();
            }
        }

        private void InitializePortState()
        {
            byte portData = 0;
            byte portDir = 0xFF;
 
            ErrorCode err = ErrorCode.Success;
            byte[] mask = instantDoCtrl1.Features.DataMask;
            for (int i = 0; (i + ConstVal.StartPort) < instantDoCtrl1.Features.PortCount && i < ConstVal.PortCountShow; ++i)
            {
                err = instantDoCtrl1.Read(i + ConstVal.StartPort, out portData);
                if (err != ErrorCode.Success)
                {
                    HandleError(err);
                    return;
                }

                m_portNum[i] = i + ConstVal.StartPort;
                m_portHex[i] = portData;

                if (instantDoCtrl1.PortDirection != null)
                {
                    portDir = (byte)instantDoCtrl1.PortDirection[i + ConstVal.StartPort].Direction;
                }
            }
        }

        private void button_Click(DoBitInformation button)
        {
            ErrorCode err = ErrorCode.Success;
            DoBitInformation boxInfo = button;

            boxInfo.BitValue = (~(int)(boxInfo).BitValue) & 0x1;
            button = boxInfo;

            //refresh hex
            int state = m_portHex[boxInfo.PortNum];
            // ~ 按位求补符号
            state &= ~(0x1 << boxInfo.BitNum);
            state |= boxInfo.BitValue << boxInfo.BitNum;

            m_portHex[boxInfo.PortNum - ConstVal.StartPort] = state;
            err = instantDoCtrl1.Write(boxInfo.PortNum, (byte)state);
            if (err != ErrorCode.Success)
            {
                HandleError(err);
            }
        }

        private int buttonCheck(DoBitInformation button)
        {
            byte portData = 0;
            ErrorCode err = ErrorCode.Success;

            err = instantDiCtrl1.Read(button.PortNum, out portData);
            int ioCheck = (portData >> button.BitNum) & 0x1;

            return ioCheck;
        }

        private void HandleError(ErrorCode err)
        {
            if (err != ErrorCode.Success)
            {
                MessageBox.Show("Sorry ! There are some errors happened, the error code is: " + err.ToString(), "AsynchronousOneBufferedAI");
            }
        }

        private void buttonTag_init()
        {
            button_101.BitNum = 0;
            button_101.BitValue = 0;
            button_101.PortNum = 0;

            button_102.BitNum = 1;
            button_102.BitValue = 0;
            button_102.PortNum = 0;

            button_103.BitNum = 2;
            button_103.BitValue = 0;
            button_103.PortNum = 0;

            button_104.BitNum = 3;
            button_104.BitValue = 0;
            button_104.PortNum = 0;

            button_105.BitNum = 5;
            button_105.BitValue = 0;
            button_105.PortNum = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDITest DItest = new frmDITest();
            DItest.Activate();
            DItest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDOTest DOtest = new frmDOTest();
            DOtest.Activate();
            DOtest.Show();
        }

    }
}