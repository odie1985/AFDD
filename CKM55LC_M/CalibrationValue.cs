using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using log4net;

namespace Devices.AFDD
{
    /// <summary>
    /// ��������������
    /// </summary>
    public class CalibrationValue
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
        public event GetSetRegisterHandler SetRegister;
        #endregion

        #region ����
        /// <summary>
        /// ��·����ϵ��
        /// </summary>
        public short Short_Multiple
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.Short_Multiple - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.Short_Multiple, 1, buf);
            }
        }

        /// <summary>
        /// ʣ�����ϵ��K
        /// </summary>
        public short Residual_K
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.Residual_K - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.Residual_K, 1, buf);
            }
        }

        /// <summary>
        /// ʣ�����ϵ��B
        /// </summary>
        public short Residual_B
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.Residual_B - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.Residual_B, 1, buf);
            }
        }

        /// <summary>
        /// A�����ϵ��K
        /// </summary>
        public short CurrentA_K
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.CurrentA_K - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.CurrentA_K, 1, buf);
            }
        }

        /// <summary>
        /// A�����ϵ��B
        /// </summary>
        public short CurrentA_B
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.CurrentA_B - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.CurrentA_B, 1, buf);
            }
        }

        /// <summary>
        /// B�����ϵ��K
        /// </summary>
        public short CurrentB_K
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.CurrentB_K - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.CurrentB_K, 1, buf);
            }
        }

        /// <summary>
        /// B�����ϵ��B
        /// </summary>
        public short CurrentB_B
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.CurrentB_B - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.CurrentB_B, 1, buf);
            }
        }

        /// <summary>
        /// C�����ϵ��K
        /// </summary>
        public short CurrentC_K
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.CurrentC_K - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.CurrentC_K, 1, buf);
            }
        }

        /// <summary>
        /// C�����ϵ��B
        /// </summary>
        public short CurrentC_B
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.CurrentC_B - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.CurrentC_B, 1, buf);
            }
        }

        /// <summary>
        /// A���ѹϵ��K
        /// </summary>
        public short VoltageA_K
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.VoltageA_K - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.VoltageA_K, 1, buf);
            }
        }

        /// <summary>
        /// A���ѹϵ��B
        /// </summary>
        public short VoltageA_B
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.VoltageA_B - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.VoltageA_B, 1, buf);
            }
        }

        /// <summary>
        /// B���ѹϵ��K
        /// </summary>
        public short VoltageB_K
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.VoltageB_K - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.VoltageB_K, 1, buf);
            }
        }

        /// <summary>
        /// B���ѹϵ��B
        /// </summary>
        public short VoltageB_B
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.VoltageB_B - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.VoltageB_B, 1, buf);
            }
        }

        /// <summary>
        /// C���ѹϵ��K
        /// </summary>
        public short VoltageC_K
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.VoltageC_K - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.VoltageC_K, 1, buf);
            }
        }

        /// <summary>
        /// C���ѹϵ��B
        /// </summary>
        public short VoltageC_B
        {
            get
            {
                return (short)_cache_calibration_value.Buf[MBREG.VoltageC_B - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.VoltageC_B, 1, buf);
            }
        }

        /// <summary>
        /// ����բʱ�䣨s��
        /// </summary>
        public float Largest_Closing_Time
        {
            get
            {
                return _cache_calibration_value.Buf[MBREG.Largest_Closing_Time - MBREG.Address_Calibration_Value_Start];
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)(value) };
                pSetRegisterAsync((ushort)MBREG.Largest_Closing_Time, 1, buf);
            }
        }

        /// <summary>
        /// ��բ�����ʱ
        /// </summary>
        public float Closing_Delay
        {
            get
            {
                ushort tmp = _cache_calibration_value.Buf[MBREG.Closing_Delay - MBREG.Address_Calibration_Value_Start];
                return (float)Math.Round(tmp / 10F, 1);
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf); 
                ushort[] buf = new ushort[] { (ushort)(value * 10) };
                pSetRegisterAsync((ushort)MBREG.Closing_Delay, 1, buf);
            }
        }

        /// <summary>
        /// �ر�У׼����
        /// </summary>
        public ushort Calibration_Disable
        {
            get
            {
                return _cache_calibration_value.Buf[MBREG.Calibration_Disable - MBREG.Address_Calibration_Value_Start]; ;
            }
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xC0EF };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.Calibration_Disable, 1, buf);
            }
        }

        /// <summary>
        /// ������
        /// </summary>
        public ushort License
        {
            set
            {
                ushort[] subuf = new ushort[] { 0xD0D0, 0xACED };
                pSetRegister((ushort)MBREG.Super_Write, 2, subuf);
                ushort[] buf = new ushort[] { (ushort)value };
                pSetRegister((ushort)MBREG.License, 1, buf);
            }
        }

        /// <summary>
        /// A���������RMSֵ
        /// </summary>
        public ushort Smp_CurrentA
        {
            get
            {
                return _cache_calibration_value.Buf[MBREG.Smp_CurrentA - MBREG.Address_Calibration_Value_Start];
            }
        }

        /// <summary>
        /// B���������RMSֵ
        /// </summary>
        public ushort Smp_CurrentB
        {
            get
            {
                return _cache_calibration_value.Buf[MBREG.Smp_CurrentB - MBREG.Address_Calibration_Value_Start];
            }
        }

        /// <summary>
        /// C���������RMSֵ
        /// </summary>
        public ushort Smp_CurrentC
        {
            get
            {
                return _cache_calibration_value.Buf[MBREG.Smp_CurrentC - MBREG.Address_Calibration_Value_Start];
            }
        }

        /// <summary>
        /// ʣ���������RMSֵ
        /// </summary>
        public ushort Smp_Residual
        {
            get
            {
                return _cache_calibration_value.Buf[MBREG.Smp_Residual - MBREG.Address_Calibration_Value_Start];
            }
        }

        /// <summary>
        /// A���ѹ����RMSֵ
        /// </summary>
        public ushort Smp_VoltageA
        {
            get
            {
                return _cache_calibration_value.Buf[MBREG.Smp_VoltageA - MBREG.Address_Calibration_Value_Start];
            }
        }

        /// <summary>
        /// B���ѹ����RMSֵ
        /// </summary>
        public ushort Smp_VoltageB
        {
            get
            {
                return _cache_calibration_value.Buf[MBREG.Smp_VoltageB - MBREG.Address_Calibration_Value_Start];
            }
        }

        /// <summary>
        /// C���ѹ����RMSֵ
        /// </summary>
        public ushort Smp_VoltageC
        {
            get
            {
                return _cache_calibration_value.Buf[MBREG.Smp_VoltageC - MBREG.Address_Calibration_Value_Start];
            }
        }

        #endregion

        #region ���캯��
        public CalibrationValue()
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
            if (Log.IsDebugEnabled) { Log.Debug("�첽��ȡ��������,����ֵRMSֵ"); }

            if (GetRegisterAsync != null)
            {
                GetRegisterAsync((ushort)MBREG.Address_Calibration_Value_Start, (ushort)_cache_calibration_value.Buf.Length,
                            _cache_calibration_value.Buf, timeout, GetCallBack, this);
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
            if (Log.IsDebugEnabled) { Log.Debug("ͬ����ȡ��������,����ֵRMSֵ"); }

            if (GetRegister != null)
            {
                GetRegister((ushort)MBREG.Address_Calibration_Value_Start, (ushort)_cache_calibration_value.Buf.Length,
                            _cache_calibration_value.Buf, timeout);
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
            if (Log.IsDebugEnabled) { Log.DebugFormat("�첽д���������({0})=[{1}]", start_ad, buf[0]); }

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
        /// д�Ĵ�����ͬ����
        /// </summary>
        private void pSetRegister(ushort start_ad, ushort nums, ushort[] buf)
        {
            if (Log.IsDebugEnabled) { Log.DebugFormat("ͬ��д��У׼����({0})=[{1}]", start_ad, buf[0]); }

            if (SetRegister != null)
            {
                SetRegister(start_ad, nums, buf, -1);
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
            Super_Write = 0xFE,
            Super_Command = 0xFF,

            Address_Calibration_Value_Start = 0xA0,

            Short_Multiple = 0xA0,
            Residual_K = 0xA1,
            Residual_B = 0xA2,

            CurrentA_K = 0xA3,
            CurrentA_B = 0xA4,
            CurrentB_K = 0xA5,
            CurrentB_B = 0xA6,
            CurrentC_K = 0xA7,
            CurrentC_B = 0xA8,

            VoltageA_K = 0xA9,
            VoltageA_B = 0xAA,
            VoltageB_K = 0xAB,
            VoltageB_B = 0xAC,
            VoltageC_K = 0xAD,
            VoltageC_B = 0xAE,

            Largest_Closing_Time = 0xAF,
            Closing_Delay = 0xB0,
            Calibration_Disable = 0xB1,

            Smp_CurrentA = 0xB2,
            Smp_CurrentB = 0xB3,
            Smp_CurrentC = 0xB4,
            Smp_Residual = 0xB5,
            Smp_VoltageA = 0xB6,
            Smp_VoltageB = 0xB7,
            Smp_VoltageC = 0xB8,

            Address_Calibration_Value_End = 0xB8,

            License = 940,
        }
        #endregion
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(CalibrationValue));

        /// <summary>
        /// ��������
        /// </summary>
        private DeviceCache _cache_calibration_value
                            = new DeviceCache(MBREG.Address_Calibration_Value_End - MBREG.Address_Calibration_Value_Start + 1);


        #endregion

    }
}
