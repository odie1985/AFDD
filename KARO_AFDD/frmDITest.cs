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
    public partial class frmDITest : Form
    {
        #region
        private Label[] m_portNum;
        private Label[] m_portHex;
        private PictureBox[,] m_pictrueBox;
        private const int m_startPort = 0;
        private const int m_portCountShow = 16;

        string device1758DI = "PCI-1758UDI,BID#0";

        #endregion

        public frmDITest()
        {
            InitializeComponent();
        }

        public frmDITest(int deviceNumber)
        {
            InitializeComponent();

            instantDiCtrl1.SelectedDevice = new DeviceInformation(device1758DI);
        }

        private void frmDITest_Load(object sender, EventArgs e)
        {
            if (!instantDiCtrl1.Initialized)
            {
                MessageBox.Show("No device be selected or device open failed!", "StaticDI");
                this.Close();
                return;
            }

            this.Text = "Static DI(" + instantDiCtrl1.SelectedDevice.Description + ")";

            m_portNum = new Label[m_portCountShow] { PortNum0, PortNum1, PortNum2, PortNum3, PortNum4, PortNum5, PortNum6, PortNum7, PortNum8, PortNum9, PortNumA, PortNumB, PortNumC, PortNumD, PortNumE, PortNumF };
            m_portHex = new Label[m_portCountShow] { PortHex0, PortHex1, PortHex2, PortHex3, PortHex4, PortHex5, PortHex6, PortHex7, PortHex8, PortHex9, PortHexA, PortHexB, PortHexC, PortHexD, PortHexE, PortHexF };
            m_pictrueBox = new PictureBox[m_portCountShow, 8]{
             {DI00, DI01, DI02, DI03, DI04, DI05, DI06, DI07},
             {DI10, DI11, DI12, DI13, DI14, DI15, DI16, DI17},
             {DI20, DI21, DI22, DI23, DI24, DI25, DI26, DI27},
             {DI30, DI31, DI32, DI33, DI34, DI35, DI36, DI37},
             {DI40, DI41, DI42, DI43, DI44, DI45, DI46, DI47},
             {DI50, DI51, DI52, DI53, DI54, DI55, DI56, DI57},
             {DI60, DI61, DI62, DI63, DI64, DI65, DI66, DI67},
             {DI70, DI71, DI72, DI73, DI74, DI75, DI76, DI77},
             {DI80, DI81, DI82, DI83, DI84, DI85, DI86, DI87},
             {DI90, DI91, DI92, DI93, DI94, DI95, DI96, DI97},
             {DIA0, DIA1, DIA2, DIA3, DIA4, DIA5, DIA6, DIA7},
             {DIB0, DIB1, DIB2, DIB3, DIB4, DIB5, DIB6, DIB7},
             {DIC0, DIC1, DIC2, DIC3, DIC4, DIC5, DIC6, DIC7},
             {DID0, DID1, DID2, DID3, DID4, DID5, DID6, DID7},
             {DIE0, DIE1, DIE2, DIE3, DIE4, DIE5, DIE6, DIE7},
             {DIF0, DIF1, DIF2, DIF3, DIF4, DIF5, DIF6, DIF7}
            };

            timer1.Enabled = true;
        }

       private void timer1_Tick(object sender, EventArgs e)
       {
          // read Di port state
          byte portData = 0;
          //ErrorCode 定义所有可能的错误代码。
          ErrorCode err = ErrorCode.Success;

          //PortCount获取可用的数字量输入端口或数字量输出端口的总个数。
          for (int i = 0; (i + m_startPort) < instantDiCtrl1.Features.PortCount && i < m_portCountShow; ++i)
          {
             //读取指定DI端口的数据。  
             //public ErrorCode Read(int port, out byte data)
             err = instantDiCtrl1.Read(i + m_startPort, out portData);
             if (err != ErrorCode.Success)
             {
                timer1.Enabled = false;
                HandleError(err);
                return;
             }

             m_portNum[i].Text = (i + m_startPort).ToString();
             m_portHex[i].Text = portData.ToString("X2");

             // Set picture box state
             for (int j = 0; j < 8; ++j)
             {
                m_pictrueBox[i,j].Image = imageList1.Images[(portData >> j) & 0x1];
                m_pictrueBox[i,j].Invalidate();
             }
          }
       }

      private void HandleError(ErrorCode err)
      {
         if (err != ErrorCode.Success)
         {
            MessageBox.Show("Sorry ! Some errors happened, the error code is: " + err.ToString(), "Static DI");
         }
      }
   }
}