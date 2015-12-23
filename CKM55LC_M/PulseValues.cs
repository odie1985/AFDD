using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using log4net;

namespace Devices.AFDD
{
    public class PulseValues
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
        /// ��ȡ�Ĵ����¼�
        /// </summary>
        public event GetSetRegisterAsyncHandler GetRegisterAsync;
        public event GetSetRegisterAsyncHandler SetRegisterAsync;
        public event GetSetRegisterHandler GetRegister;
        public event GetSetRegisterHandler SetRegister;
        #endregion

        #region ����
        /// <summary>
        /// �ֶ����Ƶ�ʣ�Hz��
        /// </summary>
        public ushort Manual_Output_Frequency
        {
            get
            {
                ushort tmp =  _cache_pulse_value.Buf[MBREG.Manual_Output_Frequency - MBREG.Address_Pulse_Value_Start];
                tmp *= 10;
                return tmp;
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)(value / 10) };
                pSetRegisterAsync((ushort)MBREG.Manual_Output_Frequency, 1, buf);
            }
        }

        /// <summary>
        /// �ֶ��������
        /// </summary>
        public ushort Manual_Output_Count
        {
            get
            {
                ushort tmp;
                tmp = _cache_pulse_value.Buf[MBREG.Manual_Output_Count_H - MBREG.Address_Pulse_Value_Start];
                tmp <<= 16;
                tmp |= _cache_pulse_value.Buf[MBREG.Manual_Output_Count_L - MBREG.Address_Pulse_Value_Start];
                return tmp;
            }
            set
            {
                ushort[] buf = new ushort[] { value }; 
                pSetRegisterAsync((ushort)MBREG.Manual_Output_Count_L, 2, buf);
            }
        }


        /// <summary>
        /// �ֶ����ʱ�䣨s��
        /// </summary>
        public ushort Manual_Output_Time
        {
            get
            {
                ushort tmp =  _cache_pulse_value.Buf[MBREG.Manual_Output_Time - MBREG.Address_Pulse_Value_Start];
                tmp /= 100;
                return tmp;
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)(value * 100) };
                pSetRegisterAsync((ushort)MBREG.Manual_Output_Time, 1, buf);
            }
        }

        /// <summary>
        /// �ֶ��������
        /// </summary>
        public ushort Manual_Output_Direction
        {
            get
            {
                return _cache_pulse_value.Buf[MBREG.Manual_Output_Direction - MBREG.Address_Pulse_Value_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Manual_Output_Direction, 1, buf);
            }
        }

        /// <summary>
        /// �ֶ�ÿ�ΰ�������������㶯��
        /// </summary>
        public ushort Manual_Point_Press_Pulse
        {
            get
            {
                return _cache_pulse_value.Buf[MBREG.Manual_Point_Press_Pulse - MBREG.Address_Pulse_Value_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Manual_Point_Press_Pulse, 1, buf);
            }
        }

        /// <summary>
        /// �Զ����ǰ���׶�һƵ�ʣ�Hz��
        /// </summary>
        public ushort Auto_Output_Forward_Step_1_Frequency
        {
            get
            {
                ushort tmp = _cache_pulse_value.Buf[MBREG.Auto_Output_Forward_Step_1_Frequency - MBREG.Address_Pulse_Value_Start];
                tmp *= 10;
                return tmp;
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)(value / 10) };
                pSetRegisterAsync((ushort)MBREG.Auto_Output_Forward_Step_1_Frequency, 1, buf);
            }
        }

        /// <summary>
        /// �Զ����ǰ���׶�һ����
        /// </summary>
        public ushort Auto_Output_Forward_Step_1_Count
        {
            get
            {
                return _cache_pulse_value.Buf[MBREG.Auto_Output_Forward_Step_1_Count - MBREG.Address_Pulse_Value_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Auto_Output_Forward_Step_1_Count, 1, buf);
            }
        }

        /// <summary>
        /// �Զ����ǰ���׶ζ�Ƶ�ʣ�Hz��
        /// </summary>
        public ushort Auto_Output_Forward_Step_2_Frequency
        {
            get
            {
                ushort tmp = _cache_pulse_value.Buf[MBREG.Auto_Output_Forward_Step_2_Frequency - MBREG.Address_Pulse_Value_Start];
                tmp *= 10;
                return tmp;
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)(value / 10) };
                pSetRegisterAsync((ushort)MBREG.Auto_Output_Forward_Step_2_Frequency, 1, buf);
            }
        }

        /// <summary>
        /// �Զ����ǰ���׶ζ�����
        /// </summary>
        public ushort Auto_Output_Forward_Step_2_Count
        {
            get
            {
                return _cache_pulse_value.Buf[MBREG.Auto_Output_Forward_Step_2_Count - MBREG.Address_Pulse_Value_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Auto_Output_Forward_Step_2_Count, 1, buf);
            }
        }

        /// <summary>
        /// �Զ����ǰ���׶���Ƶ�ʣ�Hz��
        /// </summary>
        public ushort Auto_Output_Forward_Step_3_Frequency
        {
            get
            {
                ushort tmp = _cache_pulse_value.Buf[MBREG.Auto_Output_Forward_Step_3_Frequency - MBREG.Address_Pulse_Value_Start];
                tmp *= 10;
                return tmp;
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)(value / 10) };
                pSetRegisterAsync((ushort)MBREG.Auto_Output_Forward_Step_3_Frequency, 1, buf);
            }
        }

        /// <summary>
        /// �Զ����ǰ���׶�������
        /// </summary>
        public ushort Auto_Output_Forward_Step_3_Count
        {
            get
            {
                return _cache_pulse_value.Buf[MBREG.Auto_Output_Forward_Step_3_Count - MBREG.Address_Pulse_Value_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Auto_Output_Forward_Step_3_Count, 1, buf);
            }
        }

        /// <summary>
        /// �Զ�������ؽ׶�Ƶ��
        /// </summary>
        public ushort Auto_Output_Return_Frequency
        {
            get
            {
                ushort tmp = _cache_pulse_value.Buf[MBREG.Auto_Output_Return_Frequency - MBREG.Address_Pulse_Value_Start];
                tmp *= 10;
                return tmp;
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)(value / 10) };
                pSetRegisterAsync((ushort)MBREG.Auto_Output_Return_Frequency, 1, buf);
            }
        }

        /// <summary>
        /// �Զ�������ؽ׶�������
        /// </summary>
        public ushort Auto_Output_Return_Step_3_Count
        {
            get
            {
                return _cache_pulse_value.Buf[MBREG.Auto_Output_Return_Step_3_Count - MBREG.Address_Pulse_Value_Start];
            }
            set
            {
                ushort[] buf = new ushort[] { value };
                pSetRegisterAsync((ushort)MBREG.Auto_Output_Return_Step_3_Count, 1, buf);
            }
        }

        /// <summary>
        /// �Զ�����ǰ��⵽��������ʱ��
        /// </summary>
        public ushort Detection_Current_Before_Return_Time
        {
            get
            {
                ushort tmp = _cache_pulse_value.Buf[MBREG.Detection_Current_Before_Return_Time - MBREG.Address_Pulse_Value_Start];
                tmp /= 10;
                return tmp;
            }
            set
            {
                ushort[] buf = new ushort[] { (ushort)(value * 10) };
                pSetRegisterAsync((ushort)MBREG.Detection_Current_Before_Return_Time, 1, buf);
            }
        }
        #endregion

        #region ���캯��
        public PulseValues()
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
            if (Log.IsDebugEnabled) { Log.Debug("�첽��ȡ���в���"); }

            if (GetRegisterAsync != null)
            {
                GetRegisterAsync((ushort)MBREG.Address_Pulse_Value_Start, (ushort)_cache_pulse_value.Buf.Length,
                            _cache_pulse_value.Buf, timeout, GetCallBack, this);
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
                GetRegister((ushort)MBREG.Address_Pulse_Value_Start, (ushort)_cache_pulse_value.Buf.Length,
                            _cache_pulse_value.Buf, timeout);
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
        private enum MBREG : ushort
        {
            Address_Pulse_Value_Start = 0xC8,

            Manual_Output_Frequency = 0xC8,
            Manual_Output_Count_L= 0xC9,
            Manual_Output_Count_H = 0xCA,
            Manual_Output_Time = 0xCB,
            Manual_Output_Direction = 0xCC,
            Manual_Point_Press_Pulse = 0xCD,
            Auto_Output_Forward_Step_1_Frequency = 0xCE,
            Auto_Output_Forward_Step_1_Count = 0xCF,
            Auto_Output_Forward_Step_2_Frequency = 0xD0,
            Auto_Output_Forward_Step_2_Count = 0xD1,
            Auto_Output_Forward_Step_3_Frequency = 0xD2,
            Auto_Output_Forward_Step_3_Count = 0xD3,
            Auto_Output_Return_Frequency = 0xD4,
            Auto_Output_Return_Step_3_Count = 0xD5,
            Detection_Current_Before_Return_Time = 0xD6,

            Address_Pulse_Value_End = 0xD6,
        }
        #endregion
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(RunValue));

        /// <summary>
        /// ��������
        /// </summary>
        private DeviceCache _cache_pulse_value
            = new DeviceCache(MBREG.Address_Pulse_Value_End - MBREG.Address_Pulse_Value_Start + 1);


        #endregion

    }
}
