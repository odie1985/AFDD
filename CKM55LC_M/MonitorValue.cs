using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using log4net;

namespace Devices.AFDD
{
    /// <summary>
    /// ���Ӳ�����
    /// </summary>
    public class MonitorValue
    {
        #region �����ֶ�
        /// <summary>
        /// �ۺ�״̬
        /// </summary>
        public enum GENSTATUS
        {
            open = 0,
            close = 1,
            TurnOpen = 2,
            TurnClose = 3,
            Fault = 4,
            Tripped = 5,
            Alarm = 6,
            Warn = 7,
            Test = 8,
            ReClosingDelaying = 9,
            ReClosingLock = 10,
        };

        /// <summary>
        /// ����״̬
        /// </summary>
        public enum FAULTSTATUS
        {
            ShortCurrent = 0,
            OverCurrent = 2,
            OverLoad = 2,
            ResidualCurrent = 3,
            UnbalancedCurrent = 4,
            PhaseLost = 5,
            NLost = 6,
            OverVoltage = 7,
			UnderVoltage = 8,
            MachineryDamage = 9,
            CoilDamage = 10,
            OpenStatusAlarm = 14,
            OverLoadWarn = 15,
        }

        /// <summary>
        /// ��λָʾ
        /// </summary>
        public enum PHASEINDIC
        {
            PhaseN = 12,
            PhaseC = 13,
            PhaseB = 14,
            PhaseA = 15,
        }
        #endregion

        #region �¼�����
        /// <summary>
        /// ���Ĵ����ص��¼�
        /// </summary>
        public event AsyncCallback GetCallBack;

        /// <summary>
        /// ���Ĵ����¼�
        /// </summary>
        public event GetSetRegisterAsyncHandler GetRegisterAsync;
        public event GetSetRegisterHandler GetRegister;
        #endregion

        #region ����
        /// <summary>
        /// ����ͷ״̬
        /// </summary>
        public byte Status_MC
        {
            get
            {
                ushort tmp = _cache_monitor_value.Buf[MBREG.Status_Contact - MBREG.Address_Monitor_Value_Start];
                tmp &= 0x0001;
                return (byte)tmp;
            }
        }

        /// <summary>
        /// DO״̬
        /// </summary>
        public byte Status_DO
        {
            get
            {
                ushort tmp = _cache_monitor_value.Buf[MBREG.Status_Contact - MBREG.Address_Monitor_Value_Start];
                tmp &= 0x0100;
                tmp >>= 8;
                return (byte)tmp;
            }
        }

        /// <summary>
        /// �ۺ�״̬
        /// </summary>
        public List<GENSTATUS> Status_General
        {
            get
            {
                ushort tmp;
                tmp = _cache_monitor_value.Buf[MBREG.Status_General - MBREG.Address_Monitor_Value_Start];

                return Utilities.BitCodeToEnumGen(tmp);
            }
        }

        /// <summary>
        /// ����״̬
        /// </summary>
        public List<FAULTSTATUS> Status_Fault
        {
            get
            {
                ushort tmp;
                tmp = _cache_monitor_value.Buf[MBREG.Status_Fault - MBREG.Address_Monitor_Value_Start];

                return Utilities.BitCodeToEnumFault(tmp);
            }            
        }

        /// <summary>
        /// ��λָʾ
        /// </summary>
        public List<PHASEINDIC> Phase_Indicator
        {
            get
            {
                ushort tmp;
                tmp = _cache_monitor_value.Buf[MBREG.Phase_Indicator - MBREG.Address_Monitor_Value_Start];

                return Utilities.BitCodeToEnumPhase(tmp);
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
            if (Log.IsDebugEnabled) { Log.Debug("�첽��ȡ���Ӳ���"); }

            if (GetRegisterAsync != null)
            {
                GetRegisterAsync((ushort)MBREG.Address_Monitor_Value_Start, (ushort)_cache_monitor_value.Buf.Length,
                            _cache_monitor_value.Buf, timeout, GetCallBack, this);
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
            if (Log.IsDebugEnabled) { Log.Debug("ͬ����ȡ���Ӳ���"); }

            if (GetRegister != null)
            {
                GetRegister((ushort)MBREG.Address_Monitor_Value_Start, (ushort)_cache_monitor_value.Buf.Length,
                            _cache_monitor_value.Buf, timeout);
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

        #endregion

        #region �����ֶ�

        #region modbus �Ĵ�������
        /// <summary>
        /// modbus �Ĵ�������
        /// </summary>
        private enum MBREG : ushort
        {
            Address_Monitor_Value_Start = 0x00,

            Status_Contact = 0x00,
            Status_General = 0x01,
            Status_Fault = 0x02,
            Phase_Indicator = 0x03,

            Address_Monitor_Value_End = 0x03,
        }
        #endregion
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(MonitorValue));

        /// <summary>
        /// ���Ӳ���
        /// </summary>
        private DeviceCache _cache_monitor_value
                            = new DeviceCache(MBREG.Address_Monitor_Value_End - MBREG.Address_Monitor_Value_Start + 1);


        #endregion

    }
}
