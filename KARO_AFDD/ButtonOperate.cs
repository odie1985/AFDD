using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Automation.BDaq;

namespace KARO_AFDD
{
    class ButtonOperate
    {
        #region Button Operate
        /// <summary>
        /// 单一DO开关
        /// </summary>
        private void DO_SingleButton_Click(InstantDoCtrl instantDoCtrl, int[] m_portHex, DoBitInformation button)
        {
            ErrorCode err = ErrorCode.Success;
            DoBitInformation boxInfo = button;

            boxInfo.BitValue = (~(int)(boxInfo).BitValue) & 0x1;
            button = boxInfo;

            //refresh hex
            int state = m_portHex[boxInfo.PortNum - ConstVal.StartPort];
            // ~ 按位求补符号
            state &= ~(0x1 << boxInfo.BitNum);
            state |= boxInfo.BitValue << boxInfo.BitNum;

            m_portHex[boxInfo.PortNum - ConstVal.StartPort] = state;
            err = instantDoCtrl.Write(boxInfo.PortNum, (byte)state);
            if (err != ErrorCode.Success)
            {
                HandleError(err);
            }
        }

        private void DO_MultiButton_Click(InstantDoCtrl instantDoCtrl, int m_portHex, int m_portNum)
        {
            byte portData = 0;
            ErrorCode err = ErrorCode.Success;
            byte[] mask = instantDoCtrl.Features.DataMask;
            for (int i = 0; m_portNum < instantDoCtrl.Features.PortCount && i < ConstVal.PortCountShow; ++i)
            {
                err = instantDoCtrl.Write(m_portNum, (byte)m_portNum);
                if (err != ErrorCode.Success)
                {
                    HandleError(err);
                    return;
                }
                m_portHex = portData;
            }
        }


        /// <summary>
        /// 单一DO开关状态检测
        /// </summary>
        private int DO_buttonCheck(DoBitInformation button)
        {
            byte portData = 0;
            ErrorCode err = ErrorCode.Success;

            //err = instantDiCtrl1.Read(button.PortNum, out portData);
            int ioCheck = (portData >> button.BitNum) & 0x1;

            return ioCheck;
        }

        /// <summary>
        /// 检测所有开关闭合状况（只有S301闭合）
        /// </summary>
        private int DO_Allbutton_Check()
        {
            int checkTag = 0;
            byte portData = 0;
            int[] ioCheck = new int[16];

            ErrorCode err = ErrorCode.Success;

            for (int i = 0; i < 16; i++)
            {
                //err = instantDiCtrl1.Read(i, out portData);
                ioCheck[i] = portData;
            }

            for (int i = 0; i < 16; i++)
            {
                if (i != 2)
                {
                    if (ioCheck[i] == 0)
                    {
                        checkTag = 1;
                    }
                    else
                    {
                        checkTag = 0;
                    }
                }
                else if (i == 2)
                {
                    if (ioCheck[i] == 1)
                    {
                        checkTag = 1;
                    }
                    else
                    {
                        checkTag = 0;
                    }
                }
            }

            return checkTag;
        }

        #endregion
        private void HandleError(ErrorCode err)
        {
            if (err != ErrorCode.Success)
            {
                //MessageBox.Show("Sorry ! There are some errors happened, the error code is: " + err.ToString(), "AsynchronousOneBufferedAI");
            }
        }
    }
}
