using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Common;
using Modbus_v2;
using Lines.Com;
using log4net;

namespace Devices.AFDD
{
    /// <summary>
    /// ��д�Ĵ�������ί������
    /// </summary>
    public delegate void GetSetRegisterAsyncHandler(ushort start_ad, ushort nums, ushort[] buf, int timeout, AsyncCallback callback, object @object);
    public delegate void GetSetRegisterHandler(ushort start_ad, ushort nums, ushort[] buf, int timeout);

    /// <summary>
    /// �豸�������ȴ����߿��еĳ�ʱʱ��
    /// </summary>
    public enum Timeout
    {
        Never = -1,
        Short = 2000,
        Middle = 5000,
        Long = 10000,
    }

    public class AFDD:Common.BaseDevice
    {
        #region �����ֶ�

        #endregion

        #region �¼�����
        /// <summary>
        /// ��д�Ĵ����ص��¼�
        /// </summary>
        //public event AsyncCallback SetCallBack;
        //public event AsyncCallback GetCallBack;

        /// <summary>
        /// �豸ͨѶ�¼�
        /// </summary> 
        public event DeviceEventHandler Online;
        public event DeviceEventHandler Offline;

        /// <summary>
        /// ��UIʹ�ã����Set�������
        /// ����Get������Ϊ�ڲ��������ʲ��ṩ��UIʹ��
        /// </summary>
        public event DeviceEventHandler SetResult;
        #endregion

        #region ����
        /// <summary>
        /// ��������
        /// </summary>
        public RunValue RunValues
        {
            get
            {
                return _RunValues;
            }
        }

        /// <summary>
        /// ���Ӳ���
        /// </summary>
        public MonitorValue MonitorValues
        {
            get
            {
                return _MonitorValues;
            }
        }

        /// <summary>
        /// ���Ʋ���
        /// </summary>
        public ControlSet ControlSets
        {
            get
            {
                return _ControlSets;
            }
        }

        /// <summary>
        /// ��ϲ���
        /// </summary>
        public DiagnosisValue DiagnosisValues
        {
            get
            {
                return _DiagnosisValues;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public ProtectSet ProtectSets
        {
            get
            {
                return _ProtectSets;
            }
        }

        /// <summary>
        /// �غ�բ����
        /// </summary>
        public ReclosingSet ReclosingSets
        {
            get
            {
                return _ReclosingSets;
            }
        }

        /// <summary>��
        /// ϵͳ����
        /// </summary>
        public SystemSet SystemSets
        {
            get
            {
                return _SystemSets;
            }
        }
        
        /// <summary>
        /// ʶ�����
        /// </summary>
        public IdentityValue IdentityValues
        {
            get
            {
                return _IdentityValues;
            }
        }

        /// <summary>
        /// ������������
        /// </summary>
        public CalibrationValue CalibrationValues
        {
            get
            {
                return _CalibrationValues;
            }
        }

        /// <summary>
        /// �������
        /// </summary>
        public PulseValues PulseValues
        {
            get
            {
                return _PulseValues;
            }
        }
        #endregion

        #region ���캯��
        public AFDD(byte index, BaseLine line)
            : base(index, "CKM55LC_M")
        {
            Line = line;
            _lock = new object();

            string str = Line.GetType().ToString();

            if (str == "Lines.Com.ComLine")
            {
                ComLine cl = (ComLine)line;

                _modbus = new Modbus(index);
                _modbus.InterFrameGap = cl.InterFrameGap;
                _modbus.CaptureLineArgs += new CaptureLineArgsEventHandler(cl.CaptureLine);
                _modbus.ReleaseLineArgs += new ReleaseLineArgsEventHandler(cl.ReleaseLine);
                _modbus.DiscardSendBuffer += new CommonEventHandler(cl.DiscardSendBuffer);
                _modbus.DiscardReceiveBuffer += new CommonEventHandler(cl.DiscardReceiveBuffer);
                _modbus.Send += new IOEventHandler(cl.Send);
                _modbus.Receive += new IOEventHandler(cl.Receive);

                if (Log.IsDebugEnabled) { Log.DebugFormat("��ʼ��CKM55LC_M[{0}]��ComLine[{1}]", index, cl.Name); }
            }
            else if (str == "Lines.Ethernet.NetLine")
            {
            }
            else
            {
                Log.Error("unsupported Line type:" + str);
                throw new Exception("unsupported Line type:" + str);
            }

            //�첽����Handler�����ʼ��
            _SetRegisterHandle = new GetSetRegisterHandler(SetRegister);
            _GetRegisterHandle = new GetSetRegisterHandler(GetRegister);

            //����Ĵ��������ʼ��
            _RunValues = new RunValue();
            _RunValues.GetRegister += new GetSetRegisterHandler(GetRegister);
            _RunValues.GetRegisterAsync += new GetSetRegisterAsyncHandler(GetRegisterAsync);

            _MonitorValues = new MonitorValue();
            _MonitorValues.GetRegister += new GetSetRegisterHandler(GetRegister);
            _MonitorValues.GetRegisterAsync += new GetSetRegisterAsyncHandler(GetRegisterAsync);

            _ControlSets = new ControlSet();
            _ControlSets.SetRegisterAsync += new GetSetRegisterAsyncHandler(SetRegisterAsync);

            _DiagnosisValues = new DiagnosisValue();
            _DiagnosisValues.GetRegister += new GetSetRegisterHandler(GetRegister);
            _DiagnosisValues.GetRegisterAsync += new GetSetRegisterAsyncHandler(GetRegisterAsync);

            _ProtectSets = new ProtectSet();
            _ProtectSets.GetRegister += new GetSetRegisterHandler(GetRegister);
            _ProtectSets.GetRegisterAsync += new GetSetRegisterAsyncHandler(GetRegisterAsync);
            _ProtectSets.SetRegisterAsync += new GetSetRegisterAsyncHandler(SetRegisterAsync);

            _ReclosingSets = new ReclosingSet();
            _ReclosingSets.GetRegister += new GetSetRegisterHandler(GetRegister);
            _ReclosingSets.GetRegisterAsync += new GetSetRegisterAsyncHandler(GetRegisterAsync);
            _ReclosingSets.SetRegisterAsync += new GetSetRegisterAsyncHandler(SetRegisterAsync);

            _SystemSets = new SystemSet();
            _SystemSets.GetRegister += new GetSetRegisterHandler(GetRegister);
            _SystemSets.GetRegisterAsync += new GetSetRegisterAsyncHandler(GetRegisterAsync);
            _SystemSets.SetRegisterAsync += new GetSetRegisterAsyncHandler(SetRegisterAsync);

            _IdentityValues = new IdentityValue();
            _IdentityValues.GetRegister += new GetSetRegisterHandler(GetRegister);
            _IdentityValues.GetRegisterAsync += new GetSetRegisterAsyncHandler(GetRegisterAsync);
            _IdentityValues.SetRegister += new GetSetRegisterHandler(SetRegister);

            _CalibrationValues = new CalibrationValue();
            _CalibrationValues.GetRegister += new GetSetRegisterHandler(GetRegister);
            _CalibrationValues.GetRegisterAsync += new GetSetRegisterAsyncHandler(GetRegisterAsync);
            _CalibrationValues.SetRegisterAsync += new GetSetRegisterAsyncHandler(SetRegisterAsync);
            _CalibrationValues.SetRegister += new GetSetRegisterHandler(SetRegister);

            _PulseValues = new PulseValues();
            _PulseValues.GetRegister += new GetSetRegisterHandler(GetRegister);
            _PulseValues.GetRegisterAsync += new GetSetRegisterAsyncHandler(GetRegisterAsync);
            _PulseValues.SetRegisterAsync += new GetSetRegisterAsyncHandler(SetRegisterAsync);

            GetAllRegistersAsync();
        }
        #endregion

        #region ���з���
        /// <summary>
        /// �첽��ȡ���мĴ���
        /// Ĭ���޵ȴ����߳�ʱʱ��
        /// </summary>
        public void GetAllRegistersAsync()
        {
            GetAllRegistersAsync((int)Timeout.Never);
        }

        /// <summary>
        /// �첽��ȡ���мĴ���
        /// </summary>
        /// <param name="timeout">�ȴ����߳�ʱʱ�䣨ms��</param>
        public void GetAllRegistersAsync(Timeout timeout)
        {
            GetAllRegistersAsync((int)timeout);
        }

        /// <summary>
        /// ͬ����ȡ���мĴ���
        /// Ĭ���޵ȴ����߳�ʱʱ��
        /// </summary>
        public void GetAllRegisters()
        {
            GetAllRegisters((int)Timeout.Never);
        }

        /// <summary>
        /// ͬ����ȡ���мĴ���
        /// </summary>
        /// <param name="timeout">�ȴ����߳�ʱʱ�䣨ms��</param>
        public void GetAllRegisters(Timeout timeout)
        {
            GetAllRegisters((int)timeout);
        }

        /// <summary>
        /// �ṩ����·��ʱˢ�µĴ�����
        /// </summary>
        public void PeriodRefresh(object sender, ElapsedEventArgs e)
        {
            // ֻʵʱˢ�����в����ͼ��Ӳ���
            _RunValues.GetRegistersAsync((int)Timeout.Short);
            _MonitorValues.GetRegistersAsync((int)Timeout.Short);
            //_DiagnosisValues.GetCounterRegistersAsync((int)Timeout.Short);
            // ���Ӳ���Ӧ���лص���������¼�**********************************************

        }

        /// <summary>
        /// �ṩ����·��ʱˢ�µĴ�����
        /// </summary>
        public void FactoryRefresh(object sender, ElapsedEventArgs e)
        {
            _RunValues.GetRegistersAsync((int)Timeout.Short);
            _MonitorValues.GetRegistersAsync((int)Timeout.Short);
            _IdentityValues.GetRegistersAsync((int)Timeout.Short);
            _CalibrationValues.GetRegistersAsync((int)Timeout.Short);
            _ProtectSets.GetRegistersAsync((int)Timeout.Short);
            _ReclosingSets.GetRegistersAsync((int)Timeout.Short);
            _DiagnosisValues.GetCounterRegistersAsync((int)Timeout.Short);
            //_PulseValues.GetRegistersAsync((int)Timeout.Short);
        }
        #endregion

        #region ��������
        /// <summary>
        /// �첽��ȡ���мĴ���
        /// </summary>
        private void GetAllRegistersAsync(int timeout)
        {
            if (Log.IsDebugEnabled) { Log.DebugFormat("�첽��ȡ[{0}]���мĴ���,Timeout[{1}]", this.Index, timeout); }

            // ��ȡ���мĴ������첽������
            _RunValues.GetRegistersAsync(timeout);
            _MonitorValues.GetRegistersAsync(timeout);
            _DiagnosisValues.GetRegistersAsync(timeout);
            _ProtectSets.GetRegistersAsync(timeout);
            _ReclosingSets.GetRegistersAsync(timeout);
            _SystemSets.GetRegistersAsync(timeout);
            _IdentityValues.GetRegistersAsync(timeout);
            _CalibrationValues.GetRegistersAsync(timeout);
            _PulseValues.GetRegisters(timeout);
        }

        /// <summary>
        /// ͬ����ȡ���мĴ���
        /// </summary>
        private void GetAllRegisters(int timeout)
        {
            if (Log.IsDebugEnabled) { Log.DebugFormat("ͬ����ȡ[{0}]���мĴ���,Timeout[{1}]", this.Index, timeout); }

            // ��ȡ���мĴ�����ͬ��������
            _RunValues.GetRegisters(timeout);
            _MonitorValues.GetRegisters(timeout);
            _DiagnosisValues.GetRegisters(timeout);
            _ProtectSets.GetRegisters(timeout);
            _ReclosingSets.GetRegisters(timeout);
            _SystemSets.GetRegisters(timeout);
            _IdentityValues.GetRegisters(timeout);
            _CalibrationValues.GetRegisters(timeout);
            _PulseValues.GetRegisters(timeout);
        }

        #region ��д�Ĵ����첽����
        /// <summary>
        /// ���üĴ���
        /// </summary>
        private void SetRegisterAsync(ushort start_ad, ushort nums, ushort[] buf, int timeout, AsyncCallback callback, object @object)
        {
            _SetRegisterHandle.BeginInvoke(start_ad, nums, buf, timeout, callback, @object);
        }

        /// <summary>
        /// ���üĴ���
        /// </summary>
        private void GetRegisterAsync(ushort start_ad, ushort nums, ushort[] buf, int timeout, AsyncCallback callback, object @object)
        {
            _GetRegisterHandle.BeginInvoke(start_ad, nums, buf, timeout, callback, @object);
        }
        #endregion

        #region ��д�Ĵ���ͬ������
        /// <summary>
        /// ���üĴ���
        /// </summary>
        private void SetRegister(ushort start_ad, ushort nums, ushort[] buf, int timeout)
        {
            lock (_lock)
            {
                _modbus.StartAddress = start_ad;
                _modbus.Numbers = nums;
                _modbus.Values = buf;

                CountTotalSet++;

                try
                {
                    if (IsOffline == true)
                    {
                        // ����0��
                        _modbus.WriteRegs(0, timeout);

                        if (IsOffline == true)
                        {
                            IsOffline = false;

                            Status = "SetRegister successful";
                            IsSetSuccess = true;

                            string str = string.Format("Device:[{0}][Online]" + Status, this.Index);

                            Log.Warn(str);

                            if (Online != null)
                            {
                                Online(this, str);
                            }
                        }
                    }
                    else
                    {
                        // ����0��
                        _modbus.WriteRegs(0, timeout);
                        Status = "SetRegister successful";
                        IsSetSuccess = true;
                    }

                    if (SetResult != null)
                    {
                        SetResult(this, "�Ĵ������óɹ�");
                    }
                }
                catch (System.Exception ex)
                {
                    Status = "SetRegister unsuccessful";
                    IsSetSuccess = false;
                    CountErrorSet++;
                    TimeErrorSet = DateTime.Now;

                    if (SetResult != null)
                    {
                        SetResult(this, "�Ĵ�������ʧ��");
                    }

                    if (Log.IsDebugEnabled) { Log.DebugFormat("Device:[{0}]" + Status + " - " + ex.Message, this.Index); }

                    if (IsOffline == false)
                    {
                        IsOffline = true;
                        TimeOffline = DateTime.Now;

                        string str = string.Format("Device:[{0}][Offline]" + Status + " - " + ex.Message, this.Index);

                        Log.Warn(str);

                        if (Offline != null)
                        {
                            Offline(this, str);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// ��ȡ�Ĵ���
        /// </summary>
        private void GetRegister(ushort start_ad, ushort nums, ushort[] buf, int timeout)
        {
            lock (_lock)
            {
                _modbus.StartAddress = start_ad;
                _modbus.Numbers = nums;
                _modbus.Values = buf;

                CountTotalGet++;

                try
                {
                    if (IsOffline == true)
                    {
                        // ����0��
                        _modbus.ReadRegs(0, timeout);

                        if (IsOffline == true)
                        {
                            IsOffline = false;

                            Status = "GetRegister successful";
                            IsGetSuccess = true;

                            string str = string.Format("Device:[{0}][Online]" + Status, this.Index);

                            Log.Warn(str);

                            if (Online != null)
                            {
                                Online(this, str);
                            }
                        }
                    }
                    else
                    {
                        // ����0��
                        _modbus.ReadRegs(0, timeout);
                        Status = "GetRegister successful";
                        IsGetSuccess = true;
                    }
                }
                catch (System.Exception ex)
                {
                    Status = "GetRegister unsuccessful";
                    IsGetSuccess = false;
                    CountErrorGet++;
                    TimeErrorGet = DateTime.Now;

                    if (Log.IsDebugEnabled) { Log.DebugFormat("Device:[{0}]" + Status + " - " + ex.Message, this.Index); }

                    if (IsOffline == false)
                    {
                        IsOffline = true;
                        TimeOffline = DateTime.Now;

                        string str = string.Format("Device:[{0}][Offline]" + Status + " - " + ex.Message, this.Index);

                        Log.Warn(str);

                        if (Offline != null)
                        {
                            Offline(this, str);
                        }
                    }
                }
            }
        }
        #endregion

        #endregion

        #region �����ֶ�
        /// <summary>
        /// ��־
        /// </summary>
        static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(AFDD));

        /// <summary>
        /// ��д�Ĵ�������ί��
        /// </summary>
        private GetSetRegisterHandler _SetRegisterHandle;
        private GetSetRegisterHandler _GetRegisterHandle;

        /// <summary>
        /// modbus����
        /// </summary>
        private Modbus _modbus;

        /// <summary>
        /// ��������
        /// </summary>
        private RunValue _RunValues;

        /// <summary>
        /// ���Ӳ���
        /// </summary>
        private MonitorValue _MonitorValues;

        /// <summary>
        /// ���Ʋ���
        /// </summary>
        private ControlSet _ControlSets;

        /// <summary>
        /// ��ϲ���
        /// </summary>
        private DiagnosisValue _DiagnosisValues;

        /// <summary>
        /// ��������
        /// </summary>
        private ProtectSet _ProtectSets;

        /// <summary>
        /// �غ�բ����
        /// </summary>
        private ReclosingSet _ReclosingSets;
        
        /// <summary>
        /// ϵͳ����
        /// </summary>
        private SystemSet _SystemSets;

        /// <summary>
        /// ʶ����Ϣ
        /// </summary>
        private IdentityValue _IdentityValues;

        /// <summary>
        /// ������������
        /// </summary>
        private CalibrationValue _CalibrationValues;

        /// <summary>
        /// �������
        /// </summary>
        private PulseValues _PulseValues;

        /// <summary>
        /// ������
        /// </summary>
        private object _lock;
        #endregion
    }
}
