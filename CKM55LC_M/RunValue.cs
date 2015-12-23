using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using log4net;

namespace Devices.AFDD
{
    public class RunValue
    {
        #region �����ֶ�

        #endregion

        #region �¼�����
        /// <summary>
        /// ���Ĵ����ص��¼�
        /// </summary>
        public event AsyncCallback GetCallBack;

        /// <summary>
        /// ��ȡ�Ĵ����¼�
        /// </summary>
        public event GetSetRegisterAsyncHandler GetRegisterAsync;
        public event GetSetRegisterHandler GetRegister;
        #endregion

        #region ����
        /// <summary>
        /// A�������A��
        /// </summary>
        public float Current_A
        {
            get
            {
                return _cache_run_value.Buf[MBREG.Current_A - MBREG.Address_Run_Value_Start];                
            }
        }

        /// <summary>
        /// B�������A��
        /// </summary>
        public float Current_B
        {
            get
            {
                return _cache_run_value.Buf[MBREG.Current_B - MBREG.Address_Run_Value_Start];
            }
        }

        /// <summary>
        /// C�������A��
        /// </summary>
        public float Current_C
        {
            get
            {
                return _cache_run_value.Buf[MBREG.Current_C - MBREG.Address_Run_Value_Start];
            }
        }

        /// <summary>
        /// ʣ�������A��
        /// </summary>
        public ushort Current_Residual
        {
            get
            {
                return _cache_run_value.Buf[MBREG.Current_Residual - MBREG.Address_Run_Value_Start];
            }
        }

        /// <summary>
        /// ������ƽ��ȣ�%��
        /// </summary>
        public ushort Ratio_Current_Imbalance
        {
            get
            {
                return _cache_run_value.Buf[MBREG.Ratio_Current_Imbalance - MBREG.Address_Run_Value_Start];
            }
        }

        /// <summary>
        /// A���ѹ��V��
        /// </summary>
        public ushort Voltage_A
        {
            get
            {
                return _cache_run_value.Buf[MBREG.Voltage_A - MBREG.Address_Run_Value_Start];
            }
        }

        /// <summary>
        /// B���ѹ��V��
        /// </summary>
        public ushort Voltage_B
        {
            get
            {
                return _cache_run_value.Buf[MBREG.Voltage_B - MBREG.Address_Run_Value_Start];
            }
        }

        /// <summary>
        /// C���ѹ��V��
        /// </summary>
        public ushort Voltage_C
        {
            get
            {
                return _cache_run_value.Buf[MBREG.Voltage_C - MBREG.Address_Run_Value_Start];
            }
        }

        /// <summary>
        /// ���۱ȣ��룩
        /// </summary>
        public ushort Ratio_Heat
        {
            get
            {
                return _cache_run_value.Buf[MBREG.Ratio_Heat - MBREG.Address_Run_Value_Start];
            }
        }

        /// <summary>
        /// �ڲ��¶ȣ��棩
        /// </summary>
        public float Temperature
        {
            get
            {
                ushort tmp = _cache_run_value.Buf[MBREG.Temperature - MBREG.Address_Run_Value_Start];
                return (float)Math.Round(tmp / 10D, 1);
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
                GetRegisterAsync((ushort)MBREG.Address_Run_Value_Start, (ushort)_cache_run_value.Buf.Length,
                            _cache_run_value.Buf, timeout, GetCallBack, this);
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
                GetRegister((ushort)MBREG.Address_Run_Value_Start, (ushort)_cache_run_value.Buf.Length,
                            _cache_run_value.Buf, timeout);
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
        private enum MBREG : ushort
        {
            Address_Run_Value_Start=0x0A,

            Current_A = 0x0A,
            Current_B = 0x0B,
            Current_C = 0x0C,
            Current_Residual = 0x0D,
            Ratio_Current_Imbalance = 0x0E,

            Voltage_A = 0x0F,
            Voltage_B = 0x10,
            Voltage_C = 0x11,

            Ratio_Heat = 0x12,
            Temperature = 0x13,

            Address_Run_Value_End = 0x13,
        }
        #endregion
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(RunValue));

        /// <summary>
        /// ��������
        /// </summary>
        private DeviceCache _cache_run_value
            = new DeviceCache(MBREG.Address_Run_Value_End - MBREG.Address_Run_Value_Start + 1);
            

        #endregion
    }
}
