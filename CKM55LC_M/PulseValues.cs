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
        #region 公有字段

        #endregion

        #region 事件定义
        /// <summary>
        /// 读寄存器回调事件
        /// </summary>
        public event AsyncCallback GetCallBack;
        public event AsyncCallback SetCallBack;

        /// <summary>
        /// 读取寄存器事件
        /// </summary>
        public event GetSetRegisterAsyncHandler GetRegisterAsync;
        public event GetSetRegisterAsyncHandler SetRegisterAsync;
        public event GetSetRegisterHandler GetRegister;
        public event GetSetRegisterHandler SetRegister;
        #endregion

        #region 属性
        /// <summary>
        /// 手动输出频率（Hz）
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
        /// 手动输出个数
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
        /// 手动输出时间（s）
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
        /// 手动输出方向
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
        /// 手动每次按下脉冲个数（点动）
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
        /// 自动输出前进阶段一频率（Hz）
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
        /// 自动输出前进阶段一个数
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
        /// 自动输出前进阶段二频率（Hz）
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
        /// 自动输出前进阶段二个数
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
        /// 自动输出前进阶段三频率（Hz）
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
        /// 自动输出前进阶段三个数
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
        /// 自动输出返回阶段频率
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
        /// 自动输出返回阶段三个数
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
        /// 自动返回前检测到电流持续时间
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

        #region 构造函数
        public PulseValues()
        {
            SetCallBack += new AsyncCallback(pSetCallBack);
        }
        #endregion

        #region 公有方法
        /// <summary>
        /// 从设备读取参数
        /// </summary>
        public void GetRegistersAsync(int timeout)
        {
            if (Log.IsDebugEnabled) { Log.Debug("异步读取运行参数"); }

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
            if (Log.IsDebugEnabled) { Log.Debug("同步读取运行参数"); }

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

        #region 保护方法
        /// <summary>
        /// 写寄存器（异步）
        /// </summary>
        private void pSetRegisterAsync(ushort start_ad, ushort nums, ushort[] buf)
        {
            if (Log.IsDebugEnabled) { Log.DebugFormat("异步写入保护参数({0})=[{1}]", start_ad, buf[0]); }

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
        /// 设置寄存器回调函数，用于读回寄存器值
        /// </summary>
        private void pSetCallBack(IAsyncResult ar)
        {
            GetRegisters((int)Timeout.Never);
        }
        #endregion

        #region 保护字段

        #region modbus 寄存器定义
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
        /// 日志
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(RunValue));

        /// <summary>
        /// 测量参数
        /// </summary>
        private DeviceCache _cache_pulse_value
            = new DeviceCache(MBREG.Address_Pulse_Value_End - MBREG.Address_Pulse_Value_Start + 1);


        #endregion

    }
}
