using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devices.AFDD
{
    public class Utilities
    {
        #region 寄存器值转换方法
        public static string BitCodeToString(string[] str, uint code)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (((code >> i) & 0x1) == 1)
                {
                    return str[i];
                }
            }
            return "";
        }

        public static List<MonitorValue.GENSTATUS> BitCodeToEnumGen(ushort code)
        {
            List<MonitorValue.GENSTATUS> gen = new List<MonitorValue.GENSTATUS>();

            for (int i = 0; i < 16; i++)
            {
                if (((code >> i) & 0x1) == 1)
                {
                    gen.Add((MonitorValue.GENSTATUS)i);
                }
            }
            return gen;
        }

        public static List<MonitorValue.FAULTSTATUS> BitCodeToEnumFault(ushort code)
        {
            List<MonitorValue.FAULTSTATUS> fau = new List<MonitorValue.FAULTSTATUS>();

            for (int i = 0; i < 16; i++)
            {
                if (((code >> i) & 0x1) == 1)
                {
                    fau.Add((MonitorValue.FAULTSTATUS)i);
                }
            }
            return fau;
        }

        public static List<MonitorValue.PHASEINDIC> BitCodeToEnumPhase(ushort code)
        {
            List<MonitorValue.PHASEINDIC> ph = new List<MonitorValue.PHASEINDIC>();

            for (int i = 0; i < 16; i++)
            {
                if (((code >> i) & 0x1) == 1)
                {
                    ph.Add((MonitorValue.PHASEINDIC)i);
                }
            }
            return ph;
        }

        public static DateTime BitCodeToDateTime(ushort y_m, ushort d_h, ushort m_s)
        {
            int year = ((y_m >> 8) & 0x00FF) + 2000;
            int month = y_m & 0x00FF;
            int day = (d_h >> 8) & 0x00FF;
            int hour = d_h & 0x00FF;
            int minute = (m_s >> 8) & 0x00FF;
            int second = m_s & 0x00FF;

            DateTime dt = new DateTime(year, month, day, hour, minute, second);
            return dt;
        }

        public static List<string> BitCodeToStringList(string[] str, uint code)
        {
            List<string> ls = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                if (((code >> i) & 0x1) == 1)
                {
                    ls.Add(str[i]);
                }
            }
            return ls;
        }


        public static List<string> BitCodeToStringList_ProtectMode(string[] str, uint code)
        {
            List<string> ls = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                uint tmp_code = (code >> (i * 2)) & 0x3;

                ls.Add(BitCodeToString_ProtectMode(tmp_code));
            }
            return ls;
        }


        public static ushort[] StringListToBitCode(string[] str, List<string> ls)
        {
            uint bitcode = 0;

            if (ls.Count > 0)
            {
                foreach (string s in ls)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (s == str[i])
                        {
                            bitcode |= (uint)(0x1 << i);
                            break;
                        }
                    }
                }
            }

            ushort[] bc = new ushort[2];
            bc[0] = (ushort)(bitcode & 0xFFFF);
            bc[1] = (ushort)((bitcode >> 16) & 0xFFFF);
            return bc;
        }

        public static ushort[] StringListToBitCode_ProtectMode( List<string> ls)
        {
            uint bitcode = 0;

            for (int i = 0; i < ls.Count; i++)
            {
                if (i != 0)
                {
                    if (ls[i] == Str_Protect_Mode[0])
                    {
                        bitcode = (bitcode << 2) | 0x1;
                    }
                    else if (ls[i] == Str_Protect_Mode[1])
                    {
                        bitcode = (bitcode << 2) | 0x2;
                    }
                    else if (ls[i] == Str_Protect_Mode[2])
                    {
                        bitcode = (bitcode << 2) | 0x3;
                    }
                }
                else
                {
                    if (ls[i] == Str_Protect_Mode[0])
                    {
                        bitcode |= 0x1;
                    }
                    else if (ls[i] == Str_Protect_Mode[1])
                    {
                        bitcode |= 0x2;
                    }
                    else if (ls[i] == Str_Protect_Mode[2])
                    {
                        bitcode |= 0x3;
                    }
                }

            }

            ushort[] bc = new ushort[2];
            bc[0] = (ushort)(bitcode & 0xFFFF);
            bc[1] = (ushort)((bitcode >> 16) & 0xFFFF);
            return bc;
        }

        public static string BitCodeToString_ProtectMode(uint code)
        {
            string str = "";
            if (code == 1)
            {
                str = Str_Protect_Mode[0];
            }
            else if (code == 2)
            {
                str = Str_Protect_Mode[1];
            }
            else if(code==3)
            {
                str = Str_Protect_Mode[2];
            }

            return str;
        }

        #endregion

        #region 字符串
        // 以下字符串都有顺序要求
        /// <summary>
        /// 相位指示
        /// </summary>
        public static readonly string[] Str_PhasePhase_Indicator = new string[]
        {
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "N相",
            "C相",
            "B相",
            "A相",
        };

        /// <summary>
        /// 故障类型
        /// </summary>
        public static readonly string[] Str_Fault = new string[]
        {
            "无记录",
            "瞬时故障",
            "短延时故障",
            "长延时故障",
            "剩余电流故障",
            "不平衡电流故障",
            "缺相故障",
            "断零故障",
            "过电压故障",
            "欠电压故障",
            "机械故障",
            "漏电线圈故障",
        };
										
        /// <summary>
        /// SOE类型
        /// </summary>
        public static readonly string[] Str_SOE = new string[]
        {											
            "无记录",
            "合闸",
            "分闸",
            "复位",
            "试验",
            "清零热容",
            "参数修改",
			"预警", 
			"取消预警", 
			"上电自动合闸",
			"漏电保护重合闸",
			"过压保护重合闸",
			"欠压保护重合闸",
        };

        public static readonly string[] Str_LOG = new string[] 
        { 
            "无记录",
        };
										
        public static readonly string[] Str_Protect_Enable = new string[]
        {
            "短路故障",
            "过流故障",
            "过载故障",
            "剩余电流故障",
            "不平衡电流故障",
            "断相故障",
            "%？%",
            "过压故障",
            "欠压故障",
            "机械故障",
            "线圈故障",
            "%？%",
            "%？%",
            "%？%",
            "打开状态预警",
            "过载警告",
        };

        public static readonly string[] Str_Protect_Mode_List = new string[]
        {
            "瞬时故障",
            "短延时故障",
            "长延时故障",
            "剩余电流故障",
            "不平衡电流故障",
            "断相故障",
            "断零故障",
            "过压故障",
            "欠压故障",
        };

        public static readonly string[] Str_Protect_Mode = new string[]
        {
            "报警",
            "脱扣",
            "报警+脱扣",
        };

        public static readonly string[] Str_Reclosing_Enable = new string[]
        {
            "%？%",
            "%？%",
            "%？%",
            "剩余电流故障",
            "%？%",
            "%？%",
            "%？%",
            "过压故障",
            "欠压故障",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "上电",
        };

        public static readonly string[] Str_Display_Parameter = new string[]
        {
            "A相电流",
            "B相电流",
            "C相电流",
            "剩余电流",
            "不平衡电流",
            "A相电压",
            "B相电压",
            "C相电压",
            "热容",
            "温度",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
            "%？%",
        };
        #endregion
    }
}
