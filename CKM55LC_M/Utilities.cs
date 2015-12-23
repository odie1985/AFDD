using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devices.AFDD
{
    public class Utilities
    {
        #region �Ĵ���ֵת������
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

        #region �ַ���
        // �����ַ�������˳��Ҫ��
        /// <summary>
        /// ��λָʾ
        /// </summary>
        public static readonly string[] Str_PhasePhase_Indicator = new string[]
        {
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "N��",
            "C��",
            "B��",
            "A��",
        };

        /// <summary>
        /// ��������
        /// </summary>
        public static readonly string[] Str_Fault = new string[]
        {
            "�޼�¼",
            "˲ʱ����",
            "����ʱ����",
            "����ʱ����",
            "ʣ���������",
            "��ƽ���������",
            "ȱ�����",
            "�������",
            "����ѹ����",
            "Ƿ��ѹ����",
            "��е����",
            "©����Ȧ����",
        };
										
        /// <summary>
        /// SOE����
        /// </summary>
        public static readonly string[] Str_SOE = new string[]
        {											
            "�޼�¼",
            "��բ",
            "��բ",
            "��λ",
            "����",
            "��������",
            "�����޸�",
			"Ԥ��", 
			"ȡ��Ԥ��", 
			"�ϵ��Զ���բ",
			"©�籣���غ�բ",
			"��ѹ�����غ�բ",
			"Ƿѹ�����غ�բ",
        };

        public static readonly string[] Str_LOG = new string[] 
        { 
            "�޼�¼",
        };
										
        public static readonly string[] Str_Protect_Enable = new string[]
        {
            "��·����",
            "��������",
            "���ع���",
            "ʣ���������",
            "��ƽ���������",
            "�������",
            "%��%",
            "��ѹ����",
            "Ƿѹ����",
            "��е����",
            "��Ȧ����",
            "%��%",
            "%��%",
            "%��%",
            "��״̬Ԥ��",
            "���ؾ���",
        };

        public static readonly string[] Str_Protect_Mode_List = new string[]
        {
            "˲ʱ����",
            "����ʱ����",
            "����ʱ����",
            "ʣ���������",
            "��ƽ���������",
            "�������",
            "�������",
            "��ѹ����",
            "Ƿѹ����",
        };

        public static readonly string[] Str_Protect_Mode = new string[]
        {
            "����",
            "�ѿ�",
            "����+�ѿ�",
        };

        public static readonly string[] Str_Reclosing_Enable = new string[]
        {
            "%��%",
            "%��%",
            "%��%",
            "ʣ���������",
            "%��%",
            "%��%",
            "%��%",
            "��ѹ����",
            "Ƿѹ����",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "�ϵ�",
        };

        public static readonly string[] Str_Display_Parameter = new string[]
        {
            "A�����",
            "B�����",
            "C�����",
            "ʣ�����",
            "��ƽ�����",
            "A���ѹ",
            "B���ѹ",
            "C���ѹ",
            "����",
            "�¶�",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
            "%��%",
        };
        #endregion
    }
}
