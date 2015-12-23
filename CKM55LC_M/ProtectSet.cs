using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using log4net;

namespace Devices.AFDD
{
    /// <summary>
    /// ����������
    /// </summary>
    public class ProtectSet
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
        /// ����ʹ��
        /// </summary>
        public List<string> Protect_Enable
        {
            get
            {
                uint tmp;
                tmp = _cache_protect_set.Buf[MBREG.Protect_Enable - MBREG.Address_Protect_Set_Start];

                return Utilities.BitCodeToStringList(Utilities.Str_Protect_Enable, tmp);
            }
            set
            {
                ushort[] buf = new ushort[1];
                buf = Utilities.StringListToBitCode(Utilities.Str_Protect_Enable, value);
                pSetRegisterAsync((ushort)MBREG.Protect_Enable, 1, buf);
            }
        }

        public List<string> Protect_Mode
        {
            get
            {
                uint tmp;
                tmp = _cache_protect_set.Buf[MBREG.Protect_Mode_H - MBREG.Address_Protect_Set_Start];
                tmp <<= 16;
                tmp |= _cache_protect_set.Buf[MBREG.Protect_Mode_L - MBREG.Address_Protect_Set_Start];

                return Utilities.BitCodeToStringList_ProtectMode(Utilities.Str_Protect_Mode_List, tmp);
            }
            set
            {
                ushort[] buf = new ushort[2];
                buf = Utilities.StringListToBitCode_ProtectMode(value);
                pSetRegisterAsync((ushort)MBREG.Protect_Mode_L, 2, buf);
            }
        }

        /// <summary>
        /// ����λ���ݣ�%��
        /// </summary>
        public ushort Reset_Enable_Heat_Level
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.Reset_Enable_Heat_Level - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Reset_Enable_Heat_Level, 1, buf);
            }
        }

        /// <summary>
        /// ����λ��ʱ��s��
        /// </summary>
        public ushort Reset_Enable_Heat_Delay
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.Reset_Enable_Heat_Delay - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Reset_Enable_Heat_Delay, 1, buf);
            }
        }

        /// <summary>
        /// ����ʱ��������Ir1��A��
        /// </summary>
        public ushort LongDelay_Ir1
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.LongDelay_Ir1 - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.LongDelay_Ir1, 1, buf);
            }
        }

        /// <summary>
        /// ����ʱ����ʱ��t1��s��
        /// </summary>
        public ushort LongDelay_t1
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.LongDelay_t1 - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegisterAsync((ushort)MBREG.LongDelay_t1, 1, buf);
            }
        }

        /// <summary>
        ///  ����ʱԤ��������ֵ��%��
        /// </summary>
        public ushort LongDelay_Warning_Level
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.LongDelay_Warning_Level - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.LongDelay_Warning_Level, 1, buf);
            }
        }

        /// <summary>
        /// ����ʱ��������Ir2��A��
        /// </summary>
        public ushort ShortDelay_Ir2
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.ShortDelay_Ir2 - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.ShortDelay_Ir2, 1, buf);
            }
        }

        /// <summary>
        /// ����ʱ����ʱ��t2��s��
        /// </summary>
        public float ShortDelay_Time_t2
        {
            get
            {
                ushort tmp = _cache_protect_set.Buf[MBREG.ShortDelay_Time_t2 - MBREG.Address_Protect_Set_Start];
                return (float)Math.Round(tmp / 100F, 1);
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)(value * 100) };
                pSetRegisterAsync((ushort)MBREG.ShortDelay_Time_t2, 1, buf);
            }
        }

        /// <summary>
        /// ˲ʱ��������Ir3��A��
        /// </summary>
        public ushort Instant_Current_Ir3
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.Instant_Current_Ir3 - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Instant_Current_Ir3, 1, buf);
            }
        }
        
        /// <summary>
        /// ʣ���������ֵ��mA��
        /// </summary>
        public ushort Residual_Fault_Level
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.Residual_Fault_Level - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Residual_Fault_Level, 1, buf);
            }
        }

        /// <summary>
        /// ʣ�������ʱʱ�䣨s��
        /// </summary>
        public double Residual_Fault_Delay
        {
            get
            {
                ushort tmp = _cache_protect_set.Buf[MBREG.Residual_Fault_Delay - MBREG.Address_Protect_Set_Start];
                return (double)Math.Round(tmp / 100D, 2);
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)(value * 100) };
                pSetRegisterAsync((ushort)MBREG.Residual_Fault_Delay, 1, buf);
            }
        }

        /// <summary>
        /// ��ƽ���������ֵ��%��
        /// </summary>
        public ushort Imbalance_Fault_Level
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.Imbalance_Fault_Level - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Imbalance_Fault_Level, 1, buf);
            }
        }

        /// <summary>
        /// ��ƽ�������ʱʱ�䣨s��
        /// </summary>
        public ushort Imbalance_Fault_Delay
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.Imbalance_Fault_Delay - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Imbalance_Fault_Delay, 1, buf);
            }
        }

        /// <summary>
        /// ȱ���������ֵ��A��
        /// </summary>
        public ushort Phase_Fault_Level
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.Phase_Fault_Level - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Phase_Fault_Level, 1, buf);
            }
        }

        /// <summary>
        /// ȱ����ʱʱ�䣨s��
        /// </summary>
        public ushort Phase_Fault_Delay
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.Phase_Fault_Delay - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Phase_Fault_Delay, 1, buf);
            }
        }

        /// <summary>
        /// ������ʱʱ�䣨s��
        /// </summary>
        public ushort Zero_Fault_Delay
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.Zero_Fault_Delay - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Zero_Fault_Delay, 1, buf);
            }
        }

        /// <summary>
        /// ��ѹ����ֵ��V��
        /// </summary>
        public ushort OverVoltage_Fault_Level
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.OverVoltage_Fault_Level - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.OverVoltage_Fault_Level, 1, buf);
            }
        }

        /// <summary>
        /// ��ѹ��ʱʱ�䣨s��
        /// </summary>
        public ushort OverVoltage_Fault_Delay
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.OverVoltage_Fault_Delay - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.OverVoltage_Fault_Delay, 1, buf);
            }
        }

        /// <summary>
        /// Ƿѹ����ֵ��V��
        /// </summary>
        public ushort UnderVoltage_Fault_Level
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.UnderVoltage_Fault_Level - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.UnderVoltage_Fault_Level, 1, buf);
            }
        }

        /// <summary>
        /// Ƿѹ��ʱʱ�䣨s��
        /// </summary>
        public ushort UnderVoltage_Fault_Delay
        {
            get
            {
                return _cache_protect_set.Buf[MBREG.UnderVoltage_Fault_Delay - MBREG.Address_Protect_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.UnderVoltage_Fault_Delay, 1, buf);
            }
        }


        #endregion

        #region ���캯��
        public ProtectSet()
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
            if (Log.IsDebugEnabled) { Log.Debug("�첽��ȡ��������"); }

            if (GetRegisterAsync != null)
            {
                GetRegisterAsync((ushort)MBREG.Address_Protect_Set_Start, (ushort)_cache_protect_set.Buf.Length,
                            _cache_protect_set.Buf, timeout, GetCallBack, this);
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
            if (Log.IsDebugEnabled) { Log.Debug("ͬ����ȡ��������"); }

            if (GetRegister != null)
            {
                GetRegister((ushort)MBREG.Address_Protect_Set_Start, (ushort)_cache_protect_set.Buf.Length,
                            _cache_protect_set.Buf, timeout);
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
            if (Log.IsDebugEnabled) { Log.DebugFormat("�첽д�뱣������({0})=[{1}]", start_ad, buf[0]); }

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
        /// <summary>
        /// modbus �Ĵ�������
        /// </summary>
        private enum MBREG : ushort
        {
            Address_Protect_Set_Start = 0x24,

            Protect_Enable = 0x24,
            Protect_Mode_L = 0x25,
            Protect_Mode_H = 0x26,
            Reset_Enable_Heat_Level = 0x27,
            Reset_Enable_Heat_Delay = 0x28,

            LongDelay_Ir1 = 0x29,
            LongDelay_t1 = 0x2A,
            LongDelay_Warning_Level = 0x2B,

            ShortDelay_Ir2 = 0x2C,
            ShortDelay_Time_t2 = 0x2D,
            Instant_Current_Ir3 = 0x2E,

            Residual_Fault_Level = 0x2F,
            Residual_Fault_Delay = 0x30,
            Imbalance_Fault_Level = 0x31,
            Imbalance_Fault_Delay = 0x32,

            Phase_Fault_Level = 0x33,
            Phase_Fault_Delay = 0x34,
            Zero_Fault_Delay = 0x35,

            OverVoltage_Fault_Level = 0x36,
            OverVoltage_Fault_Delay = 0x37,
            UnderVoltage_Fault_Level = 0x38,
            UnderVoltage_Fault_Delay = 0x39,

            Address_Protect_Set_End = 0x39,
        }
        #endregion
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(ProtectSet));

        /// <summary>
        /// ��������
        /// </summary>
        private DeviceCache _cache_protect_set
            = new DeviceCache(MBREG.Address_Protect_Set_End - MBREG.Address_Protect_Set_Start + 1);


        #endregion

    }
}
