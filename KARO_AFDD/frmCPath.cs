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
    public partial class frmCPath : Form
    {
        #region
        private Label[] m_portNum;
        private Label[] m_portHex;
        private PictureBox[,] m_picDO;

        #endregion

        public frmCPath()
        {
            InitializeComponent();
        }

        public frmCPath(int deviceNumber)
        {
            InitializeComponent();
            instantDoCtrl1.SelectedDevice = new DeviceInformation(deviceNumber);
        }
        
        private void frmCPath_Load(object sender, EventArgs e)
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

            this.Text = "Static DO(" + instantDoCtrl1.SelectedDevice.Description + ")";


            m_picDO = new PictureBox[1, 5]{
             {DO00, DO01, DO02, DO03, DO12},
            };

            InitializePortState();
        }

        private void InitializePortState()
        {
            byte portData = 0;
            byte portDir = 0xFF;
            ErrorCode err = ErrorCode.Success;
            byte[] mask = instantDoCtrl1.Features.DataMask;
            for (int i = 0; i < instantDoCtrl1.Features.PortCount && i < 1; ++i)
            {
                err = instantDoCtrl1.Read(i, out portData);
                if (err != ErrorCode.Success)
                {
                    HandleError(err);
                    return;
                }

                if (instantDoCtrl1.PortDirection != null)
                {
                    portDir = (byte)instantDoCtrl1.PortDirection[i].Direction;
                }

                // Set picture box state
                for (int j = 0; j < 5; ++j)
                {
                    if (((portDir >> j) & 0x1) == 0 || ((mask[i] >> j) & 0x1) == 0)  // Bit direction is input.
                    {
                        m_picDO[i, j].Image = imageList1.Images[2];
                        m_picDO[i, j].Enabled = false;
                    }
                    else
                    {
                        m_picDO[i, j].Click += new EventHandler(PictureBox_Click);
                        m_picDO[i, j].Tag = new DoBitInformation((portData >> j) & 0x1, i, j);
                        m_picDO[i, j].Image = imageList1.Images[(portData >> j) & 0x1];
                    }
                    m_picDO[i, j].Invalidate();
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            ErrorCode err = ErrorCode.Success;
            PictureBox box = (PictureBox)sender;
            DoBitInformation boxInfo = (DoBitInformation)box.Tag;

            boxInfo.BitValue = (~(int)(boxInfo).BitValue) & 0x1;
            box.Tag = boxInfo;
            box.Image = imageList1.Images[boxInfo.BitValue];
            box.Invalidate();

            // refresh hex
            int state = Int32.Parse(m_portHex[boxInfo.PortNum - ConstVal.StartPort].Text, NumberStyles.AllowHexSpecifier);
            // ~ 按位求补符号
            state &= ~(0x1 << boxInfo.BitNum);
            state |= boxInfo.BitValue << boxInfo.BitNum;

            m_portHex[boxInfo.PortNum - ConstVal.StartPort].Text = state.ToString("X2");
            err = instantDoCtrl1.Write(boxInfo.PortNum, (byte)state);
            if (err != ErrorCode.Success)
            {
                HandleError(err);
            }
        }
        
        private void HandleError(ErrorCode err)
        {
            if (err != ErrorCode.Success)
            {
                MessageBox.Show("Sorry ! Some errors happened, the error code is: " + err.ToString());
            }
        }

    //}

    //public struct DoBitInformation
    //{
    //    #region fields
    //    private int m_bitValue;
    //    private int m_portNum;
    //    private int m_bitNum;
    //    #endregion

    //    public DoBitInformation(int bitvalue, int portNum, int bitNum)
    //    {
    //        m_bitValue = bitvalue;
    //        m_portNum = portNum;
    //        m_bitNum = bitNum;
    //    }

    //    #region Properties
    //    public int BitValue
    //    {
    //        get { return m_bitValue; }
    //        set
    //        {
    //            m_bitValue = value & 0x1;
    //        }
    //    }
    //    public int PortNum
    //    {
    //        get { return m_portNum; }
    //        set
    //        {
    //            if ((value - ConstVal.StartPort) >= 0
    //               && (value - ConstVal.StartPort) <= (ConstVal.PortCountShow - 1))
    //            {
    //                m_portNum = value;
    //            }
    //        }
    //    }
    //    public int BitNum
    //    {
    //        get { return m_bitNum; }
    //        set
    //        {
    //            if (value >= 0 && value <= 7)
    //            {
    //                m_bitNum = value;
    //            }
    //        }
    //    }
    //    #endregion
    }
}
