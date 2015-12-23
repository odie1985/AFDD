using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using log4net;

namespace Devices.AFDD
{
    /// <summary>
    /// ϵͳ������
    /// </summary>
    public class SystemSet
    {
        #region �����ֶ�
        #endregion

        #region �¼�����
        /// <summary>
        /// ��д�Ĵ����ص��¼�
        /// </summary>
        public event AsyncCallback GetCallBack;
        public event AsyncCallback SetCallBack;

        /// <summary>
        /// ��д�Ĵ����¼�
        /// </summary>
        public event GetSetRegisterAsyncHandler GetRegisterAsync;
        public event GetSetRegisterAsyncHandler SetRegisterAsync;
        public event GetSetRegisterHandler GetRegister;
        #endregion

        #region ����
        /// <summary>
        /// ͨѶ��ַ
        /// </summary>
        public ushort Device_Address
        {
            get
            {
                return _cache_system_set.Buf[MBREG.Device_Address - MBREG.Address_System_Set_Start];
            }
        }

        /// <summary>
        /// ͨѶ����
        /// </summary>
        public ushort Device_BaudRate
        {
            get
            {
                return _cache_system_set.Buf[MBREG.Device_BaudRate - MBREG.Address_System_Set_Start];
            }
        }

        /// <summary>
        /// ͨѶȨ��
        /// </summary>
        public ushort Communication_Keyboard_Enable
        {
            get
            {
                return _cache_system_set.Buf[MBREG.Communication_Keyboard_Enable - MBREG.Address_System_Set_Start];
            }
        }

        /// <summary>
        /// ������������
        /// </summary>
        public ushort Keyboard_Password
        {
            get
            {
                return _cache_system_set.Buf[MBREG.Keyboard_Password - MBREG.Address_System_Set_Start];
            }
            //set
            //{
            //    ushort[] buf = new ushort[] { value };
            //    pSetRegisterAsync((ushort)MBREG.Keyboard_Password, 1, buf);
            //}
        }

        /// <summary>
        /// Ĭ����ʾѡ��
        /// </summary>
        public List<string> Display_Parameter
        {
            get
            {
                uint tmp;
                tmp = _cache_system_set.Buf[MBREG.Display_Parameter - MBREG.Address_System_Set_Start];

                return Utilities.BitCodeToStringList(Utilities.Str_Display_Parameter, tmp);
            }
            set
            {
                ushort[] buf = new ushort[1];
                buf = Utilities.StringListToBitCode(Utilities.Str_Display_Parameter, value);
                pSetRegisterAsync((ushort)MBREG.Display_Parameter, 1, buf);
            }
        }
        #endregion

        #region ���캯��
        public SystemSet()
        {
            SetCallBack += new AsyncCallback(pSetCallBack);
        }
        #endregion

        #region ���з���
        /// <summary>
        /// ���豸��ȡ����
        /// </summary>
        public void GetRegistersAsync(int timeout)
        {
            if (Log.IsDebugEnabled) { Log.Debug("�첽��ȡϵͳ����"); }

            if (GetRegisterAsync != null)
            {
                GetRegisterAsync((ushort)MBREG.Address_System_Set_Start, (ushort)_cache_system_set.Buf.Length,
                            _cache_system_set.Buf, timeout, GetCallBack, this);
            }
            else
            {
                string str = this.ToString() + ".GetRegisterAsync has no provider";
                Log.Error(str);
                throw new Exception(str);
            }
        }

        public void GetRegisters(int timeout)
        {
            if (Log.IsDebugEnabled) { Log.Debug("ͬ����ȡϵͳ����"); }

            if (GetRegister != null)
            {
                GetRegister((ushort)MBREG.Address_System_Set_Start, (ushort)_cache_system_set.Buf.Length,
                            _cache_system_set.Buf, timeout);
            }
            else
            {
                string str = this.ToString() + ".GetRegister has no provider";
                Log.Error(str);
                throw new Exception(str);
            }
        }
        #endregion

        #region ��������
        /// <summary>
        /// д�Ĵ������첽��
        /// </summary>
        private void pSetRegisterAsync(ushort start_ad, ushort nums, ushort[] buf)
        {
            if (Log.IsDebugEnabled) { Log.DebugFormat("�첽д��ϵͳ����({0})=[{1}]", start_ad, buf[0]); }

            if (SetRegisterAsync != null)
            {
                SetRegisterAsync(start_ad, nums, buf, -1, SetCallBack, this);
            }
            else
            {
                string str = this.ToString() + ".SetRegisterAsync has no provider";
                Log.Error(str);
                throw new Exception(str);
            }
        }

        /// <summary>
        /// ���üĴ����ص����������ڶ��ؼĴ���ֵ
        /// </summary>
        private void pSetCallBack(IAsyncResult ar)
        {
            GetRegisters((int)Timeout.Never);
        }

        #endregion

        #region �����ֶ�

        #region modbus �Ĵ�������
        private enum MBREG : ushort
        {
            Address_System_Set_Start = 0x5A,

            Device_Address=0x5A,
            Device_BaudRate=0x5B,
            Communication_Keyboard_Enable = 0x5C,
            Keyboard_Password = 0x5D,
            Display_Parameter = 0x5E,
            Now_Time_L = 0x5F,
            Now_Time_M = 0x60,
            Now_Time_H = 0x61,
            System_Operate = 0x62,

            Address_System_Set_End = 0x62,
        }
        #endregion
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(SystemSet));

        /// <summary>
        /// ϵͳ����
        /// </summary>
        private DeviceCache _cache_system_set
            = new DeviceCache(MBREG.Address_System_Set_End - MBREG.Address_System_Set_Start + 1);


        #endregion

    }
}
