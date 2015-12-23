using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using log4net;

namespace Devices.AFDD
{
    /// <summary>
    /// ���Ʋ�����
    /// </summary>
    public class ControlSet
    {
        #region �����ֶ�

        #endregion

        #region �¼�����
        /// <summary>
        /// ���Ĵ����ص��¼�
        /// </summary>
        public event AsyncCallback SetCallBack;

        /// <summary>
        /// ���Ĵ����¼�
        /// </summary>
        public event GetSetRegisterAsyncHandler SetRegisterAsync;
        #endregion

        #region ����

        #endregion

        #region ���캯��

        #endregion

        #region ���з���
        #region �����Ʋ���(����)
        /// <summary>
        /// ��բ
        /// </summary>
        public void Open(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x01 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }

        /// <summary>
        /// ��բ
        /// </summary>
        public void Close(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x02 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }

        /// <summary>
        /// ��λ
        /// </summary>
        public void Reset(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x04 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }

        /// <summary>
        /// ����
        /// </summary>
        public void Test(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x08 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }

        /// <summary>
        /// �������
        /// </summary>
        public void ResetQ(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x10 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }

        /// <summary>
        /// �ֶ����
        /// </summary>
        public void Output(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x20 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }

        /// <summary>
        /// ֹͣ���
        /// </summary>
        public void Stop(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x40 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }

        /// <summary>
        /// ǰ���㶯
        /// </summary>
        public void Forward(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x80 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }

        /// <summary>
        /// ���˵㶯
        /// </summary>
        public void Backward(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x100 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }

        /// <summary>
        /// �Զ�����
        /// </summary>
        public void Auto(AsyncCallback callback)
        {
            ushort[] buf = new ushort[] { 0x200 };
            pSetRegisterAsync((ushort)MBREG.Control_Run, 1, buf,
                callback, this);
        }
        #endregion

        #endregion

        #region ��������
        /// <summary>
        /// д�Ĵ������첽��
        /// </summary>
        private void pSetRegisterAsync(ushort start_ad, ushort nums, ushort[] buf, AsyncCallback callback, object @object)
        {
            if (Log.IsDebugEnabled) { Log.DebugFormat("�첽д����Ʋ���({0})=[{1}]", start_ad, buf[0]); }

            if (SetRegisterAsync != null)
            {
                SetRegisterAsync(start_ad, nums, buf, -1, callback, @object);
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
        /// <summary>
        /// modbus �Ĵ�������
        /// </summary>
        private enum MBREG : ushort
        {
            Address_Control_Value_Start = 0x20,

            Control_Run = 0x20,

            Address_Control_Value_End = 0x20,
        }
        #endregion
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(ControlSet));

        /// <summary>
        /// ���Ʋ���
        /// </summary>
        private DeviceCache _cache_control_value
            = new DeviceCache(MBREG.Address_Control_Value_End - MBREG.Address_Control_Value_Start + 1);


        #endregion

    }
}
