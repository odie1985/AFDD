using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using log4net;

namespace Devices.AFDD
{
    /// <summary>
    /// 监视参数类
    /// </summary>
    public class MonitorValue
    {
        #region 公有字段
        /// <summary>
        /// 综合状态
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
        /// 故障状态
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
        /// 相位指示
        /// </summary>
        public enum PHASEINDIC
        {
            PhaseN = 12,
            PhaseC = 13,
            PhaseB = 14,
            PhaseA = 15,
        }
        #endregion

        #region 事件定义
        /// <summary>
        /// 读寄存器回调事件
        /// </summary>
        public event AsyncCallback GetCallBack;

        /// <summary>
        /// 读寄存器事件
        /// </summary>
        public event GetSetRegisterAsyncHandler GetRegisterAsync;
        public event GetSetRegisterHandler GetRegister;
        #endregion

        #region 属性
        /// <summary>
        /// 主触头状态
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
        /// DO状态
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
        /// 综合状态
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
        /// 故障状态
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
        /// 相位指示
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

        #region 构造函数

        #endregion

        #region 公有方法
        /// <summary>
        /// 从设备读取参数
        /// </summary>
        public void GetRegistersAsync(int timeout)
        {
            if (Log.IsDebugEnabled) { Log.Debug("异步读取监视参数"); }

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
            if (Log.IsDebugEnabled) { Log.Debug("同步读取监视参数"); }

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

        #region 保护方法

        #endregion

        #region 保护字段

        #region modbus 寄存器定义
        /// <summary>
        /// modbus 寄存器定义
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
        /// 日志
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(MonitorValue));

        /// <summary>
        /// 监视参数
        /// </summary>
        private DeviceCache _cache_monitor_value
                            = new DeviceCache(MBREG.Address_Monitor_Value_End - MBREG.Address_Monitor_Value_Start + 1);


        #endregion

    }
}
