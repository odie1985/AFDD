using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Threading;
using Common;
using Lines.Com;
using log4net;
using LinesDevicesManager;
using Devices.AFDD;


namespace KARO_AFDD
{
    public partial class frmAndArcManual : Form
    {
        public frmAndArcManual()
        {
            InitializeComponent();
        }

        private void frmAndArcManual_Load(object sender, EventArgs e)
        {
            ComHelper.InitComLinesandDevices();
            //ComLine cl = ComHelper.GetComLines()[0];
            //AFDD ck = (AFDD)cl.Devices[0];
            //cl.AddTimer(ComHelper.GetComConfig()[0].RefreshPeriod, true, ck.FactoryRefresh);
            form_init();
        }

        private void form_init()
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];

            txtManualFreq.Text = ck.PulseValues.Manual_Output_Frequency.ToString();
            txtManualCount.Text = ck.PulseValues.Manual_Output_Count.ToString();
            txtManualTime.Text = ck.PulseValues.Manual_Output_Time.ToString();
            if (ck.PulseValues.Manual_Output_Direction == 0)
            {
                cbxManualDirection.Text = "正向";
            }
            else
            {
                cbxManualDirection.Text = "反向";
            }
            txtManualPointPress.Text = ck.PulseValues.Manual_Point_Press_Pulse.ToString();
            txtAutoForwardStep1Freq.Text = ck.PulseValues.Auto_Output_Forward_Step_1_Frequency.ToString();
            txtAutoForwardStep1Count.Text = ck.PulseValues.Auto_Output_Forward_Step_1_Count.ToString();
            txtAutoForwardStep2Freq.Text = ck.PulseValues.Auto_Output_Forward_Step_2_Frequency.ToString();
            txtAutoForwardStep2Count.Text = ck.PulseValues.Auto_Output_Forward_Step_2_Count.ToString();
            txtAutoForwardStep3Freq.Text = ck.PulseValues.Auto_Output_Forward_Step_3_Frequency.ToString();
            txtAutoForwardStep3Count.Text = ck.PulseValues.Auto_Output_Forward_Step_3_Count.ToString();
            txtAutoReturnFreq.Text = ck.PulseValues.Auto_Output_Return_Frequency.ToString();
            txtAutoReturnStep3Count.Text = ck.PulseValues.Auto_Output_Return_Step_3_Count.ToString();
            txtAutoCurrentBeforeReturn.Text = ck.PulseValues.Detection_Current_Before_Return_Time.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           ComLine cl = ComHelper.GetComLines()[0];
           AFDD ck = (AFDD)cl.Devices[0];
           if (MessageBox.Show("启动运行？", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
           {
               AsyncCallback callback = new AsyncCallback(ControlSet_SetCallBack);
               ck.ControlSets.Output(callback);
           }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            AsyncCallback callback = new AsyncCallback(ControlSet_SetCallBack);
            ck.ControlSets.Stop(callback);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            AsyncCallback callback = new AsyncCallback(ControlSet_SetCallBack);
            ck.ControlSets.Forward(callback);
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            AsyncCallback callback = new AsyncCallback(ControlSet_SetCallBack);
            ck.ControlSets.Backward(callback);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            AsyncCallback callback = new AsyncCallback(ControlSet_SetCallBack);
            ck.ControlSets.Auto(callback);
        }

        void ControlSet_SetCallBack(IAsyncResult ar)
        {
            ControlSet cs = (ControlSet)ar.AsyncState;
            cs.SetCallBack -= new AsyncCallback(ControlSet_SetCallBack);
        }

        private void btnManualFreq_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Manual_Output_Frequency = ushort.Parse(txtManualFreq.Text);
        }

        private void btnManualCount_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Manual_Output_Count = ushort.Parse(txtManualCount.Text);
        }

        private void btnManualTime_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Manual_Output_Time = ushort.Parse(txtManualTime.Text);
        }

        private void btnManualDirection_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            if (cbxManualDirection.Text == "正向")
            {
                ck.PulseValues.Manual_Output_Direction = 0;
            }
            else
            {
                ck.PulseValues.Manual_Output_Direction = 1;
            }
        }

        private void btnManualPointPress_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Manual_Point_Press_Pulse = ushort.Parse(txtManualPointPress.Text);
        }

        private void btnAutoReturnFreq_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Auto_Output_Return_Frequency = ushort.Parse(txtAutoReturnFreq.Text);
        }

        private void btnAutoReturnStep3Count_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Auto_Output_Return_Step_3_Count = ushort.Parse(txtAutoReturnStep3Count.Text);
        }

        private void btnAutoCurrentBeforeReturn_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Detection_Current_Before_Return_Time = ushort.Parse(txtAutoCurrentBeforeReturn.Text);
        }

        private void btnAutoForwardStep1Freq_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Auto_Output_Forward_Step_1_Frequency = ushort.Parse(txtAutoForwardStep1Freq.Text);
        }

        private void btnAutoForwardStep1Count_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Auto_Output_Forward_Step_1_Count = ushort.Parse(txtAutoForwardStep1Count.Text);
        }

        private void btnAutoForwardStep2Freq_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Auto_Output_Forward_Step_2_Frequency = ushort.Parse(txtAutoForwardStep2Freq.Text);
        }

        private void btnAutoForwardStep2Count_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Auto_Output_Forward_Step_2_Count = ushort.Parse(txtAutoForwardStep2Count.Text);
        }

        private void btnAutoForwardStep3Freq_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Auto_Output_Forward_Step_3_Frequency = ushort.Parse(txtAutoForwardStep3Freq.Text);
        }

        private void btnAutoForwardStep3Count_Click(object sender, EventArgs e)
        {
            ComLine cl = ComHelper.GetComLines()[0];
            AFDD ck = (AFDD)cl.Devices[0];
            ck.PulseValues.Auto_Output_Forward_Step_3_Count = ushort.Parse(txtAutoForwardStep3Count.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            form_init();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is frmAFD63223)
                {
                    frmAFD63223 AFD63223 = (frmAFD63223)form;
                    AFD63223.Activate();
                    AFD63223.Show();
                }
            }
        }
    }
}
