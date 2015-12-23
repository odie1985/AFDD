using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Devices.MCCB
{
    public class FactorySet
    {
        #region �����ֶ�
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
                //GetRegisterAsync((ushort)MBREG.Address_Run_Value_Start, (ushort)_cache_run_value.Buf.Length,
                //            _cache_run_value.Buf, timeout, GetCallBack, this);
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
                //GetRegister((ushort)MBREG.Address_Run_Value_Start, (ushort)_cache_run_value.Buf.Length,
                //            _cache_run_value.Buf, timeout);
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

        }
        #endregion
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(RunValue));

        /// <summary>
        /// ��������
        /// </summary>
        //private DeviceCache _cache_run_value
        //    = new DeviceCache(MBREG.Address_Run_Value_End - MBREG.Address_Run_Value_Start + 1);


        #endregion

    }
}
