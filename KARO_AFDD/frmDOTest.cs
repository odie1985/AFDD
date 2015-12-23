using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Globalization;
using Automation.BDaq;

namespace KARO_AFDD
{
    public partial class frmDOTest : Form
    {
        #region
        private Label[] m_portNum;
        private Label[] m_portHex;
        private PictureBox[,] m_picDO;

        string device1758DO = "PCI-1758UDO,BID#0";
        string device1758DI = "PCI-1758UDI,BID#0";

        #endregion

        public frmDOTest()
        {
            InitializeComponent();
        }

        public frmDOTest(int deviceNumber)
        {
            InitializeComponent();
            instantDoCtrl1.SelectedDevice = new DeviceInformation(device1758DO);
            instantDiCtrl1.SelectedDevice = new DeviceInformation(device1758DI);
        }

        private void frmDOTest_Load(object sender, EventArgs e)
        {
            DOTest_init();
        }


        private void DOTest_init()
        {
            if (!instantDoCtrl1.Initialized)
            {
                MessageBox.Show("No device be selected or device open failed!", "StaticDO");
                this.Close();
                return;
            }

            this.Text = "Static DIO(" + instantDoCtrl1.SelectedDevice.Description + ")";

            m_portNum = new Label[ConstVal.PortCountShow] { PortNum0, PortNum1, PortNum2, PortNum3, PortNum4, PortNum5, PortNum6, PortNum7, PortNum8, PortNum9, PortNumA, PortNumB, PortNumC, PortNumD, PortNumE, PortNumF };
            m_portHex = new Label[ConstVal.PortCountShow] { PortHex0, PortHex1, PortHex2, PortHex3, PortHex4, PortHex5, PortHex6, PortHex7, PortHex8, PortHex9, PortHexA, PortHexB, PortHexC, PortHexD, PortHexE, PortHexF };

            m_picDO = new PictureBox[ConstVal.PortCountShow, 8]{
             {DO00, DO01, DO02, DO03, DO04, DO05, DO06, DO07},
             {DO10, DO11, DO12, DO13, DO14, DO15, DO16, DO17},
             {DO20, DO21, DO22, DO23, DO24, DO25, DO26, DO27},
             {DO30, DO31, DO32, DO33, DO34, DO35, DO36, DO37},
             {DO40, DO41, DO42, DO43, DO44, DO45, DO46, DO47},
             {DO50, DO51, DO52, DO53, DO54, DO55, DO56, DO57},
             {DO60, DO61, DO62, DO63, DO64, DO65, DO66, DO67},
             {DO70, DO71, DO72, DO73, DO74, DO75, DO76, DO77},
             {DO80, DO81, DO82, DO83, DO84, DO85, DO86, DO87},
             {DO90, DO91, DO92, DO93, DO94, DO95, DO96, DO97},
             {DOA0, DOA1, DOA2, DOA3, DOA4, DOA5, DOA6, DOA7},
             {DOB0, DOB1, DOB2, DOB3, DOB4, DOB5, DOB6, DOB7},
             {DOC0, DOC1, DOC2, DOC3, DOC4, DOC5, DOC6, DOC7},
             {DOD0, DOD1, DOD2, DOD3, DOD4, DOD5, DOD6, DOD7},
             {DOE0, DOE1, DOE2, DOE3, DOE4, DOE5, DOE6, DOE7},
             {DOF0, DOF1, DOF2, DOF3, DOF4, DOF5, DOF6, DOF7}
            };

            InitializePortState();
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

                m_portNum[i].Text = (i + ConstVal.StartPort).ToString();
                m_portHex[i].Text = portData.ToString("X2");

                if (instantDoCtrl1.PortDirection != null)
                {
                    portDir = (byte)instantDoCtrl1.PortDirection[i + ConstVal.StartPort].Direction;
                }

                // Set picture box state
                for (int j = 0; j < 8; ++j)
                {
                    if (((portDir >> j) & 0x1) == 0 || ((mask[i] >> j) & 0x1) == 0)  // Bit direction is input.
                    {
                        m_picDO[i, j].Image = imageList1.Images[2];
                        m_picDO[i, j].Enabled = false;
                    }
                    else
                    {
                        m_picDO[i, j].Click += new EventHandler(PictureBox_Click);
                        m_picDO[i, j].Tag = new DoBitInformation((portData >> j) & 0x1, i + ConstVal.StartPort, j);
                        m_picDO[i, j].Image = imageList1.Images[(portData >> j) & 0x1];
                    }
                    m_picDO[i, j].Invalidate();
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (instantDoCtrl1.SelectedDevice.DeviceNumber == -1)
            {
                instantDoCtrl1.SelectedDevice = new DeviceInformation(1);
            }
            ErrorCode err = ErrorCode.Success;
            PictureBox box = (PictureBox)sender;
            DoBitInformation boxInfo = (DoBitInformation)box.Tag;

            boxInfo.BitValue = (~(int)(boxInfo).BitValue) & 0x1;
            box.Tag = boxInfo;
            box.Image = imageList1.Images[boxInfo.BitValue];
            box.Invalidate();

            // refresh hex
            int state = Int32.Parse(m_portHex[boxInfo.PortNum - ConstVal.StartPort].Text, NumberStyles.AllowHexSpecifier);
            // ~ °´Î»Çó²¹·ûºÅ
            state &= ~(0x1 << boxInfo.BitNum);
            state |= boxInfo.BitValue << boxInfo.BitNum;

            m_portHex[boxInfo.PortNum - ConstVal.StartPort].Text = state.ToString("X2");
            err = instantDoCtrl1.Write(boxInfo.PortNum, (byte)state);
            if (err != ErrorCode.Success)
            {
                HandleError(err);
            }

            instantDoCtrl1.Cleanup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DO_Click(1, 128);
        }

        private void DO_Click(int port, int data)
        {
            ErrorCode err = ErrorCode.Success;
            //byte[] mask = instantDoCtrl1.Features.DataMask;

            err = instantDoCtrl1.Write(port, (byte)data);
            if (err != ErrorCode.Success)
            {
                HandleError(err);
                return;
            }
        }

        private byte DI_Check(int port)
        {
            byte data = 0;
            ErrorCode err = ErrorCode.Success;

            err = instantDiCtrl1.Read(port, out data);

            return data;
        }

        private void HandleError(ErrorCode err)
        {
            if (err != ErrorCode.Success)
            {
                MessageBox.Show("Sorry ! Some errors happened, the error code is: " + err.ToString());
            }
        }


    }

    public struct DoBitInformation
    {
        #region fields
        private int m_bitValue;
        private int m_portNum;
        private int m_bitNum;
        #endregion

        public DoBitInformation(int bitvalue, int portNum, int bitNum)
        {
            m_bitValue = bitvalue;
            m_portNum = portNum;
            m_bitNum = bitNum;
        }

        #region Properties
        public int BitValue
        {
            get { return m_bitValue; }
            set
            {
                m_bitValue = value & 0x1;
            }
        }
        public int PortNum
        {
            get { return m_portNum; }
            set
            {
                if ((value - ConstVal.StartPort) >= 0
                   && (value - ConstVal.StartPort) <= (ConstVal.PortCountShow - 1))
                {
                    m_portNum = value;
                }
            }
        }
        public int BitNum
        {
            get { return m_bitNum; }
            set
            {
                if (value >= 0 && value <= 7)
                {
                    m_bitNum = value;
                }
            }
        }
        #endregion
    }

}
