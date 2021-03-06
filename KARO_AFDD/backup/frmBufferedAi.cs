﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Automation.BDaq;
using System.Runtime.InteropServices;

namespace KARO_AFDD
{
    public partial class frmBufferedAi : Form
    {
        #region fields
        SimpleGraph m_simpleGraph;
        double[] m_dataScaled;
        double[] m_dataCalibration;

        TimeUnit m_timeUnit;

        delegate void UpdateUIDelegate();
        #endregion
        
        public frmBufferedAi()
        {
            InitializeComponent();
        }

        public frmBufferedAi(int deviceNumber)
       {
           InitializeComponent();
           bufferedAiCtrl1.SelectedDevice = new DeviceInformation(deviceNumber);
       }

        private void frmBufferedAi_Load(object sender, EventArgs e)
        {
            //The default device of project is demo device, users can choose other devices according to their needs. 

            if (!bufferedAiCtrl1.Initialized)
            {
                MessageBox.Show("No device be selected or device open failed!", "AsynchronousOneBufferedAI");
                this.Close();
                return;
            }

            bufferedAiCtrl1.Streaming = false; // specify the running mode: one-buffered.

            //initialize a graph with a picture box control to draw Ai data. 
            m_simpleGraph = new SimpleGraph(pictureBox.Size, pictureBox);

            m_dataScaled = new double[bufferedAiCtrl1.BufferCapacity];

            this.Text = "Asynchronous One Buffered AI(" + bufferedAiCtrl1.SelectedDevice.Description + ")";
            trackBar_div.Enabled = false;
            trackBar_shift.Enabled = false;
            textBox_div.ReadOnly = true;
            textBox_shift.ReadOnly = true;

            ConfigureGraph();
            InitListView();
        }

        private void ConfigureGraph()
        {
            trackBar_shift.Maximum = (int)Math.Floor((1000.0 * (bufferedAiCtrl1.ScanChannel.Samples) / (bufferedAiCtrl1.ConvertClock.Rate))); //ms
            trackBar_shift.Minimum = 0;
            trackBar_shift.Value = 0;
            textBox_shift.Text = trackBar_shift.Value.ToString();

            m_timeUnit = TimeUnit.Millisecond;
            label_divide.Text = "ms";
            label_shift.Text = "ms";

            trackBar_div.Maximum = 1000000;
            trackBar_div.Minimum = 0;
            //1 pixel to 1 data point. How much time plotting pictureBox.Size.Width / 10(panelLineCount) data points requires in ms. 
            trackBar_div.Value = (int)Math.Floor(((100.0 * pictureBox.Size.Width) / bufferedAiCtrl1.ConvertClock.Rate));
            if (bufferedAiCtrl1.ConvertClock.Rate >= 10 * 1000)
            {
                trackBar_div.Value = (int)Math.Floor(((100.0 * 1000 * pictureBox.Size.Width) / bufferedAiCtrl1.ConvertClock.Rate));
                m_timeUnit = TimeUnit.Microsecond;
                trackBar_shift.Maximum = (int)Math.Floor(1000 * 1000.0 * bufferedAiCtrl1.ScanChannel.Samples / bufferedAiCtrl1.ConvertClock.Rate); //us
                trackBar_shift.Minimum = 0;
                label_divide.Text = "us";
                label_shift.Text = "us";
            }

            textBox_div.Text = trackBar_div.Value.ToString();
            trackBar_div.Maximum = 4 * trackBar_div.Value; // 1 pixel to 4 data points
            trackBar_div.Minimum = (int)Math.Ceiling(1.0 * trackBar_div.Value / 10);

            SetXCord();
            MathInterval rangeY = new MathInterval();
            ValueUnit unit = (ValueUnit)(-1); // Don't show unit in the label.
            rangeY.Max = 10;
            rangeY.Min = -10;

            string[] Y_CordLables = new string[3];
            Helpers.GetYCordRangeLabels(Y_CordLables, rangeY.Max, rangeY.Min, unit);
            label_YCoordinateMax.Text = Y_CordLables[0];
            label_YCoordinateMin.Text = Y_CordLables[1];
            label_YCoordinateMiddle.Text = Y_CordLables[2];

            if (ValueUnit.Millivolt == unit)
            {
                rangeY.Max /= 1000;
                rangeY.Min /= 1000;
            }
            m_simpleGraph.YCordRangeMax = rangeY.Max;
            m_simpleGraph.YCordRangeMin = rangeY.Min;
            m_simpleGraph.Clear();
        }

        private void SetXCord()
        {
            m_simpleGraph.XCordTimeDiv = trackBar_div.Value;
            m_simpleGraph.XCordTimeOffset = trackBar_shift.Value;
            double rangeMax = m_simpleGraph.XCordTimeDiv * 10 + trackBar_shift.Value;
            string[] X_rangeLabels = new string[2];
            Helpers.GetXCordRangeLabels(X_rangeLabels, rangeMax, trackBar_shift.Value, m_timeUnit);
            label_XCoordinateMax.Text = X_rangeLabels[0];
            label_XCoordinateMin.Text = X_rangeLabels[1];
        }

        private void trackBar_shift_Scroll(object sender, EventArgs e)
        {
            SetXCord();
            textBox_shift.Text = trackBar_shift.Value.ToString();
            m_simpleGraph.Shift(trackBar_shift.Value);
        }

        private void trackBar_div_Scroll(object sender, EventArgs e)
        {
            m_simpleGraph.Div(trackBar_div.Value);
            SetXCord();
            textBox_div.Text = trackBar_div.Value.ToString();
        }

        private void button_getData_Click(object sender, EventArgs e)
        {
            ErrorCode err = ErrorCode.Success;
            m_simpleGraph.Clear();
            err = bufferedAiCtrl1.Prepare();
            //maybe bufferedAiCtrl1.ConvertClock.Rate is modifed in driver
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

            trackBar_div.Enabled = true;
            trackBar_shift.Enabled = true;
            button_getData.Enabled = false;
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

                Calibration(m_dataScaled);
                double max = effectiveValue(m_dataScaled);
                double maxValue = max / Math.Sqrt(2);
                textBox1.Text = maxValue.ToString();

                m_simpleGraph.Chart(m_dataCalibration,
                                 bufferedAiCtrl1.ScanChannel.ChannelCount,
                                 bufferedAiCtrl1.ScanChannel.Samples,
                                 1.0 / bufferedAiCtrl1.ConvertClock.Rate);
                this.Invoke((UpdateUIDelegate)delegate()
                {
                    button_getData.Enabled = true;
                });
            }
            catch (System.Exception) { }
        }

        private void InitListView()
        {
            //control list view ,one grid indicates a channel which specials with color.
            listView.Clear();
            listView.FullRowSelect = false;
            listView.Width = 512;
            listView.Height = 43;
            listView.View = View.Details;// Set the view to show details.
            listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.GridLines = true;
            listView.AllowDrop = false;
            listView.Capture = false;
            // there are 8 columns for every item.
            for (int i = 0; i < 8; i++)
            {
                listView.Columns.Add("", 63);
            }

            // modify the grid's height with image Indirectly.
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 16);//width and height.
            listView.SmallImageList = imgList; //use imgList to modify the height of listView grids.

            // create two ListViewItem objects,so there are 16 grids for listView.
            ListViewItem firstItem;
            ListViewItem secondItem;

            firstItem = new ListViewItem();
            firstItem.SubItems.Clear();
            firstItem.UseItemStyleForSubItems = false;
            firstItem.Font = new Font("SimSun", 10);

            secondItem = new ListViewItem();
            secondItem.SubItems.Clear();
            secondItem.UseItemStyleForSubItems = false;
            secondItem.Font = new Font("SimSun", 10);

            // format every grid for output.
            firstItem.SubItems[0].Text = "";
            firstItem.SubItems[0].BackColor = m_simpleGraph.Pens[0].Color;
            for (int i = 1; i < 8; i++)
            {
                if (i < bufferedAiCtrl1.ScanChannel.ChannelCount)
                {
                    firstItem.SubItems.Add((""), Color.Black, Color.Honeydew, new Font("SimSun", 10));
                    firstItem.SubItems[i].BackColor = m_simpleGraph.Pens[i].Color;
                }
                else
                {
                    firstItem.SubItems.Add("");
                    firstItem.SubItems[i].BackColor = Color.White;
                }
            }

            if (8 < bufferedAiCtrl1.ScanChannel.ChannelCount)
            {
                secondItem.SubItems[0].Text = "";
                secondItem.SubItems[0].BackColor = m_simpleGraph.Pens[8].Color;
            }
            else
            {
                secondItem.SubItems[0].Text = "";
                secondItem.SubItems[0].BackColor = Color.White;
            }
            for (int i = 9; i < 16; i++)
            {
                if (i < bufferedAiCtrl1.ScanChannel.ChannelCount)
                {
                    secondItem.SubItems.Add((""), Color.Black, Color.Honeydew, new Font("SimSun", 10));
                    secondItem.SubItems[i - 8].BackColor = m_simpleGraph.Pens[i].Color;
                }
                else
                {
                    secondItem.SubItems.Add("");
                    secondItem.SubItems[i - 8].BackColor = Color.White;
                }
            }

            ListViewItem[] list = new ListViewItem[] { firstItem, secondItem };
            listView.Items.AddRange(list);
            listView.SendToBack();
        }

        private void Calibration(double[] m_data)
        {
            for (int i = 0; i < m_dataScaled.Length; i++)
            {
                m_dataCalibration[i] = m_dataScaled[i] - 2.5;
            }
                       
        }

        private void HandleError(ErrorCode err)
        {
            if (err != ErrorCode.Success)
            {
                MessageBox.Show("Sorry ! There are some errors happened, the error code is: " + err.ToString(), "AsynchronousOneBufferedAI");
            }
        }

        private double effectiveValue(double[] m_data)
        {
            double max = 0;

            for (int i = 0; i < m_dataScaled.Length; i++)
            {
                if (m_dataScaled[i] > max)
                {
                    max = m_dataScaled[i];
                }
            }

            return max;
        }
    }
}
