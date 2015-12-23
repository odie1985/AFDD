using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Devices.AFDD
{
    public class ReclosingSet
    {
        #region �����ֶ�
        #endregion

        #region �¼�����
        /// <summary>
        /// ���Ĵ����ص��¼�
        /// </summary>
        public event AsyncCallback GetCallBack;
        public event AsyncCallback SetCallBack;

        /// <summary>
        /// ���Ĵ����¼�
        /// </summary>
        public event GetSetRegisterAsyncHandler GetRegisterAsync;
        public event GetSetRegisterHandler GetRegister;
        public event GetSetRegisterAsyncHandler SetRegisterAsync;
        #endregion

        #region ����
        /// <summary>
        /// �غ�բʹ��
        /// </summary>
        public List<string> Reclosing_Enable
        {
            get
            {
                uint tmp;
                tmp = _cache_reclosing_set.Buf[MBREG.Reclosing_Enable - MBREG.Address_Reclosing_Set_Start];

                return Utilities.BitCodeToStringList(Utilities.Str_Reclosing_Enable, tmp);
            }
            set
            {
                ushort[] buf = new ushort[1];
                buf = Utilities.StringListToBitCode(Utilities.Str_Reclosing_Enable, value);
                pSetRegisterAsync((ushort)MBREG.Reclosing_Enable, 1, buf);
            }
        }

        /// <summary>
        /// ʣ������غ�բ��ʱ��s��
        /// </summary>
        public ushort Residual_Reclosing_Delay
        {
            get
            {
                return _cache_reclosing_set.Buf[MBREG.Residual_Reclosing_Delay - MBREG.Address_Reclosing_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Residual_Reclosing_Delay, 1, buf);
            }
        }

        /// <summary>
        /// ʣ�����30min��������
        /// </summary>
        public ushort Residual_30min_Lock
        {
            get
            {
                return _cache_reclosing_set.Buf[MBREG.Residual_30min_Lock - MBREG.Address_Reclosing_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Residual_30min_Lock, 1, buf);
            }
        }

        /// <summary>
        /// ��ѹ�غ�բ��ѹֵ��V��
        /// </summary>
        public ushort OverVoltage_Reclosing_Level
        {
            get
            {
                return _cache_reclosing_set.Buf[MBREG.OverVoltage_Reclosing_Level - MBREG.Address_Reclosing_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.OverVoltage_Reclosing_Level, 1, buf);
            }
        }

        /// <summary>
        /// ��ѹ�غ�բ��ʱ��s��
        /// </summary>
        public ushort OverVoltage_Reclosing_Delay
        {
            get
            {
                return _cache_reclosing_set.Buf[MBREG.OverVoltage_Reclosing_Delay - MBREG.Address_Reclosing_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.OverVoltage_Reclosing_Delay, 1, buf);
            }
        }

        /// <summary>
        /// Ƿѹ�غ�բ��ѹֵ��V��
        /// </summary>
        public ushort UnderVoltage_Reclosing_Level
        {
            get
            {
                return _cache_reclosing_set.Buf[MBREG.UnderVoltage_Reclosing_Level - MBREG.Address_Reclosing_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.UnderVoltage_Reclosing_Level, 1, buf);
            }
        }

        /// <summary>
        /// Ƿѹ�غ�բ��ʱ��s��
        /// </summary>
        public ushort UnderVoltage_Reclosing_Delay
        {
            get
            {
                return _cache_reclosing_set.Buf[MBREG.UnderVoltage_Reclosing_Delay - MBREG.Address_Reclosing_Set_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.UnderVoltage_Reclosing_Delay, 1, buf);
            }
        }

        #endregion

        #region ���캯��
        #endregion

        #region ���з���
        /// <summary>
        /// ���豸��ȡ����
        /// </summary>
        public void GetRegistersAsync(int timeout)
        {
            if (Log.IsDebugEnabled) { Log.Debug("�첽��ȡ���в���"); }

            if (GetRegisterAsync != null)
            {
                GetRegisterAsync((ushort)MBREG.Address_Reclosing_Set_Start, (ushort)_cache_reclosing_set.Buf.Length,
                            _cache_reclosing_set.Buf, timeout, GetCallBack, this);
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
            if (Log.IsDebugEnabled) { Log.Debug("ͬ����ȡ���в���"); }

            if (GetRegister != null)
            {
                GetRegister((ushort)MBREG.Address_Reclosing_Set_Start, (ushort)_cache_reclosing_set.Buf.Length,
                            _cache_reclosing_set.Buf, timeout);
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
        private void pSetRegisterAsync(ushort start_ad, ushort nums, ushort[] buf)
        {
            if (Log.IsDebugEnabled)
            {
                Log.DebugFormat("�첽д���غ�բ����({0})=({1})", start_ad, buf[0]);
            }

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
        #endregion

        #region �����ֶ�

        #region modbus �Ĵ�������
        private enum MBREG : ushort
        {
            Address_Reclosing_Set_Start = 0x46,

            Reclosing_Enable = 0x46,
            Residual_Reclosing_Delay = 0x47,
            Residual_30min_Lock = 0x48,

            OverVoltage_Reclosing_Level = 0x49,
            OverVoltage_Reclosing_Delay = 0x4A,
            UnderVoltage_Reclosing_Level = 0x4B,
            UnderVoltage_Reclosing_Delay = 0x4C,

            Address_Reclosing_Set_End = 0x4C,
        }
        #endregion
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(ReclosingSet));

        /// <summary>
        /// ��������
        /// </summary>
        private DeviceCache _cache_reclosing_set
            = new DeviceCache(MBREG.Address_Reclosing_Set_End - MBREG.Address_Reclosing_Set_Start + 1);


        #endregion

    }
}
