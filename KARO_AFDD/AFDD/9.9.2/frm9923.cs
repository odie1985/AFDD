using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Automation.BDaq;
using System.Threading;

namespace KARO_AFDD
{
    public partial class frm9923 : Form
    {
        #region fields
        private int[] m_portHex = new int[ConstVal.PortCountShow] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int[] m_portNum = new int[ConstVal.PortCountShow] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        SimpleGraph m_simpleGraph_I;
        SimpleGraph m_simpleGraph_V;
        double[] m_dataScaled;
        double[] m_dataCalibration;
        double[] m_dataScaled_I;
        double[] m_dataScaled_V;

        TimeUnit m_timeUnit;

        string device1742 = "PCI-1742U,BID#0";
        string device1758DO = "PCI-1758UDO,BID#0";
        string device1758DI = "PCI-1758UDI,BID#0";
        int startChannel = 1;
        int channelCount = 4;
        int sampleCount = 3000; 
        int convertClkRatePerChan = 1000;

        delegate void UpdateUIDelegate();

        #endregion

        public frm9923()
        {
            InitializeComponent();
        }
		
        private void frm9923_Load(object sender, EventArgs e)
        {
            instantDoCtrl1.SelectedDevice = new DeviceInformation(device1758DO);
            instantDiCtrl1.SelectedDevice = new DeviceInformation(device1758DI);
            bufferedAiCtrl1.SelectedDevice = new DeviceInformation(device1742);

            Control.CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(MainProgram);
            thread.IsBackground = true;
            thread.Start();
        }

        private void MainProgram()
        {

            if (!bufferedAiCtrl1.Initialized)
            {
                MessageBox.Show("No device be selected or device open failed!", "AsynchronousOneBufferedAI");
                this.Close();
                return;
            }

            bufferedAiCtrl1.Streaming = false; // specify the running mode: one-buffered.

            //initialize a graph with a picture box control to draw Ai data. 
            m_simpleGraph_I = new SimpleGraph(pictureBox_I.Size, pictureBox_I);
            m_simpleGraph_V = new SimpleGraph(pictureBox_V.Size, pictureBox_V);

            this.Text = "Asynchronous One Buffered AI(" + bufferedAiCtrl1.SelectedDevice.Description + ")";
            trackBar_div_I.Enabled = false;
            trackBar_shift_I.Enabled = false;
            textBox_div_I.ReadOnly = true;
            textBox_shift_I.ReadOnly = true;

            trackBar_div_V.Enabled = false;
            trackBar_shift_V.Enabled = false;
            textBox_div_V.ReadOnly = true;
            textBox_shift_V.ReadOnly = true;

            sampleCount = (int)bufferedAiCtrl1.ConvertClock.Rate;
            convertClkRatePerChan = bufferedAiCtrl1.ScanChannel.Samples;
            txtClockRate.Text = convertClkRatePerChan.ToString();
            txtSamples.Text = sampleCount.ToString();

            ConfigureGraph();
            InitializePortState();
        }

        private void InitializePortState()
        {
            byte portData = 0;
             
            int startPort = int.Parse(cbxChannelCount.Text);
            ErrorCode err = ErrorCode.Success;
            byte[] mask = instantDoCtrl1.Features.DataMask;
            for (int i = 0; (i + ConstVal.StartPort) < instantDoCtrl1.Features.PortCount && i < ConstVal.PortCountShow; ++i)
            {
                err = instantDoCtrl1.Write(i + ConstVal.StartPort, (byte)m_portHex[i]);
                if (err != ErrorCode.Success)
                {
                    HandleError(err);
                    return;
                }

                m_portNum[i] = i + ConstVal.StartPort;
                m_portHex[i] = portData;

                //if (instantDoCtrl1.PortDirection != null)
                //{
                //    portDir = (byte)instantDoCtrl1.PortDirection[i + ConstVal.StartPort].Direction;
                //}
            }
        }

        /// <summary>
        /// 创建图像
        /// </summary>
        private void ConfigureGraph()
        {
            trackBar_shift_I.Maximum = trackBar_shift_V.Maximum = (int)Math.Floor((1000.0 * (sampleCount) / (convertClkRatePerChan))); //ms
            trackBar_shift_I.Minimum = trackBar_shift_V.Minimum = 0;
            trackBar_shift_I.Value = trackBar_shift_V.Value = 0;
            textBox_shift_I.Text = trackBar_shift_I.Value.ToString();
            textBox_shift_V.Text = trackBar_shift_V.Value.ToString();

            m_timeUnit = TimeUnit.Millisecond;
            label_divide_I.Text = label_divide_V.Text = "ms";
            label_shift_I.Text = label_shift_V.Text = "ms";

            trackBar_div_I.Maximum = trackBar_div_V.Maximum = 1000000;
            trackBar_div_I.Minimum = trackBar_div_V.Minimum  = 0;
            //1 pixel to 1 data point. How much time plotting pictureBox.Size.Width / 10(panelLineCount) data points requires in ms. 
            trackBar_div_I.Value = (int)Math.Floor(((100.0 * pictureBox_I.Size.Width) / convertClkRatePerChan));
            trackBar_div_V.Value = (int)Math.Floor(((100.0 * pictureBox_V.Size.Width) / convertClkRatePerChan));
            if (convertClkRatePerChan >= 10 * 1000)
            {
                trackBar_div_I.Value = (int)Math.Floor(((100.0 * 1000 * pictureBox_I.Size.Width) / convertClkRatePerChan));
                trackBar_div_V.Value = (int)Math.Floor(((100.0 * 1000 * pictureBox_V.Size.Width) / convertClkRatePerChan));
                m_timeUnit = TimeUnit.Microsecond;
                trackBar_shift_I.Maximum = trackBar_shift_V.Maximum = (int)Math.Floor(1000 * 1000.0 * sampleCount / convertClkRatePerChan); //us
                trackBar_shift_I.Minimum = trackBar_shift_V.Minimum  = 0;
                label_divide_I.Text = label_divide_V.Text = "us";
                label_shift_I.Text = label_shift_V.Text = "us";
            }

            textBox_div_I.Text = trackBar_div_I.Value.ToString();
            textBox_div_V.Text = trackBar_div_V.Value.ToString();

            trackBar_div_I.Maximum = 4 * trackBar_div_I.Value; // 1 pixel to 4 data points
            trackBar_div_I.Minimum = (int)Math.Ceiling(1.0 * trackBar_div_I.Value / 10);
            trackBar_div_V.Maximum = 4 * trackBar_div_V.Value; 
            trackBar_div_V.Minimum = (int)Math.Ceiling(1.0 * trackBar_div_V.Value / 10);

            SetXCord_I(); 
            SetXCord_V();

            MathInterval rangeY_I = new MathInterval();
            MathInterval rangeY_V = new MathInterval();
            ValueUnit unit_I = (ValueUnit)(-1); // Don't show unit in the label.
            ValueUnit unit_V = (ValueUnit)(-1); 

            rangeY_V.Max = 693;
            rangeY_V.Min = -693;

            if (cbxValueRange.Text == "+/- 10A")
            {
                rangeY_I.Max = 10;
                rangeY_I.Min = -10;
            }
            else if (cbxValueRange.Text == "+/- 5A")
            {
                rangeY_I.Max = 5;
                rangeY_I.Min = -5;
            }
            else if (cbxValueRange.Text == "+/- 50A")
            {
                rangeY_I.Max = 50;
                rangeY_I.Min = -50;
            }
            else if (cbxValueRange.Text == "+/- 200A")
            {
                rangeY_I.Max = 200;
                rangeY_I.Min = -200;
            }

            string[] Y_CordLables_I = new string[3];
            string[] Y_CordLables_V = new string[3];
            Helpers.GetYCordRangeLabels(Y_CordLables_I, rangeY_I.Max, rangeY_I.Min, unit_I);
            Helpers.GetYCordRangeLabels(Y_CordLables_V, rangeY_V.Max, rangeY_V.Min, unit_V);

            label_YCoordinateMax_I.Text = Y_CordLables_I[0] + "A";
            label_YCoordinateMin_I.Text = Y_CordLables_I[1] + "A";
            label_YCoordinateMiddle_I.Text = Y_CordLables_I[2] + "A";

            label_YCoordinateMax_V.Text = Y_CordLables_V[0] + "V";
            label_YCoordinateMin_V.Text = Y_CordLables_V[1] + "V";
            label_YCoordinateMiddle_V.Text = Y_CordLables_V[2] + "V";

            if (ValueUnit.Milliampere == unit_I)
            {
                rangeY_I.Max /= 1000;
                rangeY_I.Min /= 1000;
            }

            if (ValueUnit.Millivolt == unit_V)
            {
                rangeY_V.Max /= 1000;
                rangeY_V.Min /= 1000;
            }
            m_simpleGraph_I.YCordRangeMax = rangeY_I.Max;
            m_simpleGraph_I.YCordRangeMin = rangeY_I.Min;
            m_simpleGraph_I.Clear();

            m_simpleGraph_V.YCordRangeMax = rangeY_V.Max;
            m_simpleGraph_V.YCordRangeMin = rangeY_V.Min;
            m_simpleGraph_V.Clear();
        }

        /// <summary>
        /// 设置X坐标轴
        /// </summary>
        private void SetXCord_I()
        {
            m_simpleGraph_I.XCordTimeDiv = trackBar_div_I.Value;
            m_simpleGraph_I.XCordTimeOffset = trackBar_shift_I.Value;
            double rangeMax_I = m_simpleGraph_I.XCordTimeDiv * 10 + trackBar_shift_I.Value;

            string[] X_rangeLabels_I = new string[2];
            Helpers.GetXCordRangeLabels(X_rangeLabels_I, rangeMax_I, trackBar_shift_I.Value, m_timeUnit);
            label_XCoordinateMax_I.Text = X_rangeLabels_I[0];
            label_XCoordinateMin_I.Text = X_rangeLabels_I[1];
        }

        private void SetXCord_V()
        {
            m_simpleGraph_V.XCordTimeDiv = trackBar_div_V.Value;
            m_simpleGraph_V.XCordTimeOffset = trackBar_shift_V.Value;
            double rangeMax_V = m_simpleGraph_V.XCordTimeDiv * 10 + trackBar_shift_V.Value;

            string[] X_rangeLabels_V = new string[2];
            Helpers.GetXCordRangeLabels(X_rangeLabels_V, rangeMax_V, trackBar_shift_V.Value, m_timeUnit);
            label_XCoordinateMax_V.Text = X_rangeLabels_V[0];
            label_XCoordinateMin_V.Text = X_rangeLabels_V[1];
        }

        private void trackBar_shift_Scroll_I(object sender, EventArgs e)
        {
            SetXCord_I();
            textBox_shift_I.Text = trackBar_shift_I.Value.ToString();
            m_simpleGraph_I.Shift(trackBar_shift_I.Value);
        }

        private void trackBar_div_Scroll_I(object sender, EventArgs e)
        {
            m_simpleGraph_I.Div(trackBar_div_I.Value);
            SetXCord_I();
            textBox_div_I.Text = trackBar_div_I.Value.ToString();
        }

        private void trackBar_shift_Scroll_V(object sender, EventArgs e)
        {
            SetXCord_V();
            textBox_shift_V.Text = trackBar_shift_V.Value.ToString();
            m_simpleGraph_V.Shift(trackBar_shift_V.Value);
        }

        private void trackBar_div_Scroll_V(object sender, EventArgs e)
        {
            m_simpleGraph_V.Div(trackBar_div_V.Value);
            SetXCord_V();
            textBox_div_V.Text = trackBar_div_V.Value.ToString();
        }

        private void DO_btnStart_Click(object sender, EventArgs e)
        {
            if (DI_Check(2) == 1)
            {
                if (cbxCurrentChoose.Text == "3A")
                {
                    do
                    {
                        DO_Click(4, 7);    //S317 S318 S319
                    } while ((int)DI_Check(4) == 7);
                }
                else if (cbxCurrentChoose.Text == "6A")
                {
                    do
                    {
                        DO_Click(3, 64);    //S315
                    } while ((int)DI_Check(3) == 64);

                    do
                    {
                        DO_Click(4, 4);    //S319
                    } while ((int)DI_Check(4) == 4);
                }
                else if (cbxCurrentChoose.Text == "13A")
                {
                    do
                    {
                        DO_Click(3, 160);    //S314 S316
                    } while ((int)DI_Check(3) == 160);
                }
                else if (cbxCurrentChoose.Text == "20A")
                {
                    do
                    {
                        DO_Click(3, 16);    //S313
                    } while ((int)DI_Check(3) == 16);
                }
                else if (cbxCurrentChoose.Text == "40A")
                {
                    do
                    {
                        DO_Click(3, 8);    //S312
                    } while ((int)DI_Check(3) == 8);
                }
                else if (cbxCurrentChoose.Text == "63A")
                {
                    do
                    {
                        DO_Click(3, 4);    //S311
                    } while ((int)DI_Check(3) == 4);
                }
                else
                {
                    return;
                }

                CarbonationTest();
            }
        }

        private void bufferedAiCtrl1_Stopped(object sender, BfdAiEventArgs args)
        {
            ErrorCode err;

            try
            {
                //The BufferedAiCtrl has been disposed.
                if (bufferedAiCtrl1.State == ControlState.Idle)
                {
                    return;
                }

                err = bufferedAiCtrl1.GetData(args.Count, m_dataScaled);
                if (err != ErrorCode.Success)
                {
                    HandleError(err);
                    return;
                }

                System.Diagnostics.Debug.WriteLine("stopped!");

                Samples_Calibration(m_dataScaled);
                Current_Calculate(m_dataCalibration);
                Voltage_Calculate(m_dataScaled_V);

                m_simpleGraph_I.Chart(m_dataScaled_I,
                                 1,
                                 bufferedAiCtrl1.ScanChannel.Samples,
                                 1.0 / bufferedAiCtrl1.ConvertClock.Rate);

                m_simpleGraph_V.Chart(m_dataScaled_V,
                                 1,
                                 bufferedAiCtrl1.ScanChannel.Samples,
                                 1.0 / bufferedAiCtrl1.ConvertClock.Rate);

                double effectValue_I = effectiveValue(m_dataScaled_I);
                double effectValue_V = effectiveValue(m_dataScaled_V);
                txtCurrent.Text = effectValue_I.ToString("#0.00");  //保留两位小数
                txtVoltage.Text = effectValue_V.ToString("#0.00");

                this.Invoke((UpdateUIDelegate)delegate()
                {
                    
                });

                System.Threading.Thread.Sleep(2000);

                InitializePortState();
            }
            catch (System.Exception) { }
        }

        /// <summary>
        /// 采样值校准
        /// </summary>
        private void Samples_Calibration(double[] m_data)
        {
            for (int i = 0; i < m_dataCalibration.Length; i++)
            {
                if (cbxChannelCount.Text == "1")
                {
                    m_dataCalibration[i] = m_data[((i + 1) * 4) - 4] - 2.48;
                }
                else if (cbxChannelCount.Text == "2")
                {
                    m_dataCalibration[i] = m_data[((i + 1) * 4) - 3] - 2.5;
                }
                else if (cbxChannelCount.Text == "3")
                {
                    m_dataCalibration[i] = m_data[((i + 1) * 4) - 2] - 2.48;
                }

                m_dataScaled_V[i] = m_data[((i + 1) * 4) - 1];
            }
        }

        /// <summary>
        /// 电流值计算
        /// </summary>
        private void Current_Calculate(double[] m_data)
        {
            for (int i = 0; i < m_data.Length; i++)
            {
                if (cbxChannelCount.Text == "1")
                {
                    m_dataScaled_I[i] = m_data[i] * 6.18 - 0.32;
                }
                else if (cbxChannelCount.Text == "2")
                {
                    m_dataScaled_I[i] = m_data[i] * 31 - 1.788;
                }
                else if (cbxChannelCount.Text == "3")
                {
                    m_dataScaled_I[i] = m_data[i] * 100;
                }
            }
        }

        /// <summary>
        /// 电压值计算
        /// </summary>
        private void Voltage_Calculate(double[] m_data)
        {
            for (int i = 0; i < m_data.Length; i++)
            {
                m_dataScaled_V[i] = m_data[i] * 49;
            }
        }

        /// <summary>
        /// 有效值计算
        /// </summary>
        private double effectiveValue(double[] m_data)
        {
            double sumValue = 0;
            double tmp = 0;
            double effectiveValue = 0;

            for (int i = 0; i < m_data.Length; i++)
            {
                sumValue += Math.Pow(m_data[i], 2);
            }

            tmp = sumValue / m_data.Length;
            effectiveValue = Math.Sqrt(tmp);

            return effectiveValue;
        }

        private void savingTotxt()
        {
            string nowHour = DateTime.Now.Hour.ToString();
            string nowMin = DateTime.Now.Minute.ToString();
            string nowSec = DateTime.Now.Second.ToString();
            string testName = "9923";
            string fileName = nowHour + nowMin + nowSec + "_" + testName;

            StreamWriter sw = new StreamWriter("E:\\" + fileName + ".txt", true);
        }

        #region Button Operate

        /// <summary>
        /// DO开关控制
        /// </summary>
        private void DO_Click(int port, int data)
        {
            ErrorCode err = ErrorCode.Success;

            err = instantDoCtrl1.Write(port, (byte)data);
            if (err != ErrorCode.Success)
            {
                HandleError(err);
                return;
            }
        }

        /// <summary>
        /// DI状态检测
        /// </summary>
        private byte DI_Check(int port)
        {
            byte data = 0;
            ErrorCode err = ErrorCode.Success;

            err = instantDiCtrl1.Read(port, out data);

            return data;
        }

        private void CarbonationTest()
        {
            do
            {
                DO_Click(2, 76);    //S303 S304 S307
            } while ((int)DI_Check(2) == 76);

            do
            {
                DO_Click(0, 16);     //S105
            } while ((int)DI_Check(0) == 16);

            DO_Click(3, DI_Check(3) + 1);   //S309

            Sampling();
        }

        /// <summary>
        /// 试验采样
        /// </summary>
        private void Sampling()
        {
            System.Threading.Thread.Sleep(1000);

            DO_Click(2, DI_Check(2) + 2);

            System.Threading.Thread.Sleep(1000);
            do
            {
                DO_Click(1, 2);     //S110
            } while ((int)DI_Check(1) == 2);

            Sampling_getdata();
        }

        private void Sampling_getdata()
        {
            ErrorCode err = ErrorCode.Success;
            m_simpleGraph_I.Clear();
            m_simpleGraph_V.Clear();

            sampleCount = int.Parse(txtSamples.Text);
            convertClkRatePerChan = int.Parse(txtClockRate.Text);

            m_dataScaled = new double[sampleCount * 4];
            m_dataCalibration = new double[sampleCount];
            m_dataScaled_I = new double[sampleCount];
            m_dataScaled_V = new double[sampleCount];

            ScanChannel scanChannel = bufferedAiCtrl1.ScanChannel;
            scanChannel.ChannelStart = startChannel;
            scanChannel.ChannelCount = channelCount;
            scanChannel.Samples = sampleCount;
            bufferedAiCtrl1.ConvertClock.Rate = convertClkRatePerChan;

            err = bufferedAiCtrl1.Prepare();

            ConfigureGraph();
            if (err == ErrorCode.Success)
            {
                err = bufferedAiCtrl1.Start();
            }

            if (err != ErrorCode.Success)
            {
                HandleError(err);
                return;
            }

            trackBar_div_I.Enabled = true;
            trackBar_shift_I.Enabled = true;
            trackBar_div_V.Enabled = true;
            trackBar_shift_V.Enabled = true;
        }


        #endregion

        private void HandleError(ErrorCode err)
        {
            if (err != ErrorCode.Success)
            {
                MessageBox.Show("Sorry ! There are some errors happened, the error code is: " + err.ToString(), "AsynchronousOneBufferedAI");
            }
        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = fd.SelectedPath;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            InitializePortState();
        }

        private void btnExhaustFan_Click(object sender, EventArgs e)
        {
 			byte tmp = DI_Check(1);
            int checkDI = (int)tmp & 4;
            if (checkDI == 1)
            {
                DO_Click(1, DI_Check(1) + 4);
            }
            else
            {
                DO_Click(1, DI_Check(1) - 4);
            }
        }

        private void btnFan_Click(object sender, EventArgs e)
        {
			byte tmp = DI_Check(4);
            int checkDI = (int)tmp & 32;
            if (checkDI == 1)
            {
                DO_Click(4, DI_Check(4) + 32);
            }
            else
            {
                DO_Click(4, DI_Check(4) - 32);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            instantDiCtrl1.Dispose();
            instantDoCtrl1.Dispose();
            bufferedAiCtrl1.Dispose();
            this.Hide();
        }
    }
}
