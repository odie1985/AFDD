namespace KARO_AFDD
{
    partial class frmAndArc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAndArc));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbxManualDirection = new System.Windows.Forms.ComboBox();
            this.btnAutoForwardStep3Count = new System.Windows.Forms.Button();
            this.btnAutoForwardStep3Freq = new System.Windows.Forms.Button();
            this.btnAutoForwardStep2Count = new System.Windows.Forms.Button();
            this.btnAutoForwardStep2Freq = new System.Windows.Forms.Button();
            this.btnAutoForwardStep1Count = new System.Windows.Forms.Button();
            this.btnAutoForwardStep1Freq = new System.Windows.Forms.Button();
            this.btnAutoCurrentBeforeReturn = new System.Windows.Forms.Button();
            this.btnAutoReturnStep3Count = new System.Windows.Forms.Button();
            this.btnAutoReturnFreq = new System.Windows.Forms.Button();
            this.btnManualPointPress = new System.Windows.Forms.Button();
            this.btnManualDirection = new System.Windows.Forms.Button();
            this.btnManualTime = new System.Windows.Forms.Button();
            this.btnManualCount = new System.Windows.Forms.Button();
            this.btnManualFreq = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAutoForwardStep3Count = new System.Windows.Forms.TextBox();
            this.txtAutoForwardStep3Freq = new System.Windows.Forms.TextBox();
            this.txtAutoForwardStep2Count = new System.Windows.Forms.TextBox();
            this.txtAutoForwardStep2Freq = new System.Windows.Forms.TextBox();
            this.txtAutoForwardStep1Count = new System.Windows.Forms.TextBox();
            this.txtAutoForwardStep1Freq = new System.Windows.Forms.TextBox();
            this.txtAutoCurrentBeforeReturn = new System.Windows.Forms.TextBox();
            this.txtAutoReturnStep3Count = new System.Windows.Forms.TextBox();
            this.txtAutoReturnFreq = new System.Windows.Forms.TextBox();
            this.txtManualPointPress = new System.Windows.Forms.TextBox();
            this.txtManualTime = new System.Windows.Forms.TextBox();
            this.txtManualCount = new System.Windows.Forms.TextBox();
            this.txtManualFreq = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(150, 651);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "手动输出";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(307, 651);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(149, 50);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止输出";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "手动输出频率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "手动输出个数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "手动输出时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "手动输出方向";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "手动每次按下脉冲个数(点动)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "自动输出前进阶段一频率";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(1031, 531);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 34);
            this.btnRefresh.TabIndex = 53;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbxManualDirection
            // 
            this.cbxManualDirection.FormattingEnabled = true;
            this.cbxManualDirection.Items.AddRange(new object[] {
            "正向",
            "反向"});
            this.cbxManualDirection.Location = new System.Drawing.Point(454, 331);
            this.cbxManualDirection.Name = "cbxManualDirection";
            this.cbxManualDirection.Size = new System.Drawing.Size(100, 35);
            this.cbxManualDirection.TabIndex = 52;
            // 
            // btnAutoForwardStep3Count
            // 
            this.btnAutoForwardStep3Count.Location = new System.Drawing.Point(1081, 446);
            this.btnAutoForwardStep3Count.Name = "btnAutoForwardStep3Count";
            this.btnAutoForwardStep3Count.Size = new System.Drawing.Size(34, 34);
            this.btnAutoForwardStep3Count.TabIndex = 51;
            this.btnAutoForwardStep3Count.Text = "写";
            this.btnAutoForwardStep3Count.UseVisualStyleBackColor = true;
            this.btnAutoForwardStep3Count.Click += new System.EventHandler(this.btnAutoForwardStep3Count_Click);
            // 
            // btnAutoForwardStep3Freq
            // 
            this.btnAutoForwardStep3Freq.Location = new System.Drawing.Point(1081, 388);
            this.btnAutoForwardStep3Freq.Name = "btnAutoForwardStep3Freq";
            this.btnAutoForwardStep3Freq.Size = new System.Drawing.Size(34, 34);
            this.btnAutoForwardStep3Freq.TabIndex = 50;
            this.btnAutoForwardStep3Freq.Text = "写";
            this.btnAutoForwardStep3Freq.UseVisualStyleBackColor = true;
            this.btnAutoForwardStep3Freq.Click += new System.EventHandler(this.btnAutoForwardStep3Freq_Click);
            // 
            // btnAutoForwardStep2Count
            // 
            this.btnAutoForwardStep2Count.Location = new System.Drawing.Point(1081, 331);
            this.btnAutoForwardStep2Count.Name = "btnAutoForwardStep2Count";
            this.btnAutoForwardStep2Count.Size = new System.Drawing.Size(34, 34);
            this.btnAutoForwardStep2Count.TabIndex = 49;
            this.btnAutoForwardStep2Count.Text = "写";
            this.btnAutoForwardStep2Count.UseVisualStyleBackColor = true;
            this.btnAutoForwardStep2Count.Click += new System.EventHandler(this.btnAutoForwardStep2Count_Click);
            // 
            // btnAutoForwardStep2Freq
            // 
            this.btnAutoForwardStep2Freq.Location = new System.Drawing.Point(1081, 274);
            this.btnAutoForwardStep2Freq.Name = "btnAutoForwardStep2Freq";
            this.btnAutoForwardStep2Freq.Size = new System.Drawing.Size(34, 34);
            this.btnAutoForwardStep2Freq.TabIndex = 48;
            this.btnAutoForwardStep2Freq.Text = "写";
            this.btnAutoForwardStep2Freq.UseVisualStyleBackColor = true;
            this.btnAutoForwardStep2Freq.Click += new System.EventHandler(this.btnAutoForwardStep2Freq_Click);
            // 
            // btnAutoForwardStep1Count
            // 
            this.btnAutoForwardStep1Count.Location = new System.Drawing.Point(1081, 217);
            this.btnAutoForwardStep1Count.Name = "btnAutoForwardStep1Count";
            this.btnAutoForwardStep1Count.Size = new System.Drawing.Size(34, 34);
            this.btnAutoForwardStep1Count.TabIndex = 47;
            this.btnAutoForwardStep1Count.Text = "写";
            this.btnAutoForwardStep1Count.UseVisualStyleBackColor = true;
            this.btnAutoForwardStep1Count.Click += new System.EventHandler(this.btnAutoForwardStep1Count_Click);
            // 
            // btnAutoForwardStep1Freq
            // 
            this.btnAutoForwardStep1Freq.Location = new System.Drawing.Point(1081, 160);
            this.btnAutoForwardStep1Freq.Name = "btnAutoForwardStep1Freq";
            this.btnAutoForwardStep1Freq.Size = new System.Drawing.Size(34, 34);
            this.btnAutoForwardStep1Freq.TabIndex = 46;
            this.btnAutoForwardStep1Freq.Text = "写";
            this.btnAutoForwardStep1Freq.UseVisualStyleBackColor = true;
            this.btnAutoForwardStep1Freq.Click += new System.EventHandler(this.btnAutoForwardStep1Freq_Click);
            // 
            // btnAutoCurrentBeforeReturn
            // 
            this.btnAutoCurrentBeforeReturn.Location = new System.Drawing.Point(598, 559);
            this.btnAutoCurrentBeforeReturn.Name = "btnAutoCurrentBeforeReturn";
            this.btnAutoCurrentBeforeReturn.Size = new System.Drawing.Size(34, 34);
            this.btnAutoCurrentBeforeReturn.TabIndex = 45;
            this.btnAutoCurrentBeforeReturn.Text = "写";
            this.btnAutoCurrentBeforeReturn.UseVisualStyleBackColor = true;
            this.btnAutoCurrentBeforeReturn.Click += new System.EventHandler(this.btnAutoCurrentBeforeReturn_Click);
            // 
            // btnAutoReturnStep3Count
            // 
            this.btnAutoReturnStep3Count.Location = new System.Drawing.Point(599, 502);
            this.btnAutoReturnStep3Count.Name = "btnAutoReturnStep3Count";
            this.btnAutoReturnStep3Count.Size = new System.Drawing.Size(34, 34);
            this.btnAutoReturnStep3Count.TabIndex = 44;
            this.btnAutoReturnStep3Count.Text = "写";
            this.btnAutoReturnStep3Count.UseVisualStyleBackColor = true;
            this.btnAutoReturnStep3Count.Click += new System.EventHandler(this.btnAutoReturnStep3Count_Click);
            // 
            // btnAutoReturnFreq
            // 
            this.btnAutoReturnFreq.Location = new System.Drawing.Point(598, 445);
            this.btnAutoReturnFreq.Name = "btnAutoReturnFreq";
            this.btnAutoReturnFreq.Size = new System.Drawing.Size(34, 34);
            this.btnAutoReturnFreq.TabIndex = 43;
            this.btnAutoReturnFreq.Text = "写";
            this.btnAutoReturnFreq.UseVisualStyleBackColor = true;
            this.btnAutoReturnFreq.Click += new System.EventHandler(this.btnAutoReturnFreq_Click);
            // 
            // btnManualPointPress
            // 
            this.btnManualPointPress.Location = new System.Drawing.Point(598, 388);
            this.btnManualPointPress.Name = "btnManualPointPress";
            this.btnManualPointPress.Size = new System.Drawing.Size(34, 34);
            this.btnManualPointPress.TabIndex = 42;
            this.btnManualPointPress.Text = "写";
            this.btnManualPointPress.UseVisualStyleBackColor = true;
            this.btnManualPointPress.Click += new System.EventHandler(this.btnManualPointPress_Click);
            // 
            // btnManualDirection
            // 
            this.btnManualDirection.Location = new System.Drawing.Point(599, 331);
            this.btnManualDirection.Name = "btnManualDirection";
            this.btnManualDirection.Size = new System.Drawing.Size(34, 34);
            this.btnManualDirection.TabIndex = 41;
            this.btnManualDirection.Text = "写";
            this.btnManualDirection.UseVisualStyleBackColor = true;
            this.btnManualDirection.Click += new System.EventHandler(this.btnManualDirection_Click);
            // 
            // btnManualTime
            // 
            this.btnManualTime.Location = new System.Drawing.Point(599, 274);
            this.btnManualTime.Name = "btnManualTime";
            this.btnManualTime.Size = new System.Drawing.Size(34, 34);
            this.btnManualTime.TabIndex = 40;
            this.btnManualTime.Text = "写";
            this.btnManualTime.UseVisualStyleBackColor = true;
            this.btnManualTime.Click += new System.EventHandler(this.btnManualTime_Click);
            // 
            // btnManualCount
            // 
            this.btnManualCount.Location = new System.Drawing.Point(599, 217);
            this.btnManualCount.Name = "btnManualCount";
            this.btnManualCount.Size = new System.Drawing.Size(34, 34);
            this.btnManualCount.TabIndex = 39;
            this.btnManualCount.Text = "写";
            this.btnManualCount.UseVisualStyleBackColor = true;
            this.btnManualCount.Click += new System.EventHandler(this.btnManualCount_Click);
            // 
            // btnManualFreq
            // 
            this.btnManualFreq.Location = new System.Drawing.Point(599, 160);
            this.btnManualFreq.Name = "btnManualFreq";
            this.btnManualFreq.Size = new System.Drawing.Size(34, 34);
            this.btnManualFreq.TabIndex = 38;
            this.btnManualFreq.Text = "写";
            this.btnManualFreq.UseVisualStyleBackColor = true;
            this.btnManualFreq.Click += new System.EventHandler(this.btnManualFreq_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(560, 562);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 27);
            this.label21.TabIndex = 37;
            this.label21.Text = "s";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(560, 277);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 27);
            this.label20.TabIndex = 36;
            this.label20.Text = "s";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1040, 391);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 27);
            this.label19.TabIndex = 35;
            this.label19.Text = "Hz";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1040, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 27);
            this.label18.TabIndex = 34;
            this.label18.Text = "Hz";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1040, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 27);
            this.label17.TabIndex = 33;
            this.label17.Text = "Hz";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(559, 448);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 27);
            this.label16.TabIndex = 32;
            this.label16.Text = "Hz";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(560, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 27);
            this.label15.TabIndex = 31;
            this.label15.Text = "Hz";
            // 
            // txtAutoForwardStep3Count
            // 
            this.txtAutoForwardStep3Count.Location = new System.Drawing.Point(934, 446);
            this.txtAutoForwardStep3Count.Name = "txtAutoForwardStep3Count";
            this.txtAutoForwardStep3Count.Size = new System.Drawing.Size(100, 34);
            this.txtAutoForwardStep3Count.TabIndex = 30;
            // 
            // txtAutoForwardStep3Freq
            // 
            this.txtAutoForwardStep3Freq.Location = new System.Drawing.Point(934, 388);
            this.txtAutoForwardStep3Freq.Name = "txtAutoForwardStep3Freq";
            this.txtAutoForwardStep3Freq.Size = new System.Drawing.Size(100, 34);
            this.txtAutoForwardStep3Freq.TabIndex = 29;
            // 
            // txtAutoForwardStep2Count
            // 
            this.txtAutoForwardStep2Count.Location = new System.Drawing.Point(934, 331);
            this.txtAutoForwardStep2Count.Name = "txtAutoForwardStep2Count";
            this.txtAutoForwardStep2Count.Size = new System.Drawing.Size(100, 34);
            this.txtAutoForwardStep2Count.TabIndex = 28;
            // 
            // txtAutoForwardStep2Freq
            // 
            this.txtAutoForwardStep2Freq.Location = new System.Drawing.Point(934, 274);
            this.txtAutoForwardStep2Freq.Name = "txtAutoForwardStep2Freq";
            this.txtAutoForwardStep2Freq.Size = new System.Drawing.Size(100, 34);
            this.txtAutoForwardStep2Freq.TabIndex = 27;
            // 
            // txtAutoForwardStep1Count
            // 
            this.txtAutoForwardStep1Count.Location = new System.Drawing.Point(934, 217);
            this.txtAutoForwardStep1Count.Name = "txtAutoForwardStep1Count";
            this.txtAutoForwardStep1Count.Size = new System.Drawing.Size(100, 34);
            this.txtAutoForwardStep1Count.TabIndex = 26;
            // 
            // txtAutoForwardStep1Freq
            // 
            this.txtAutoForwardStep1Freq.Location = new System.Drawing.Point(934, 160);
            this.txtAutoForwardStep1Freq.Name = "txtAutoForwardStep1Freq";
            this.txtAutoForwardStep1Freq.Size = new System.Drawing.Size(100, 34);
            this.txtAutoForwardStep1Freq.TabIndex = 25;
            // 
            // txtAutoCurrentBeforeReturn
            // 
            this.txtAutoCurrentBeforeReturn.Location = new System.Drawing.Point(454, 559);
            this.txtAutoCurrentBeforeReturn.Name = "txtAutoCurrentBeforeReturn";
            this.txtAutoCurrentBeforeReturn.Size = new System.Drawing.Size(100, 34);
            this.txtAutoCurrentBeforeReturn.TabIndex = 24;
            // 
            // txtAutoReturnStep3Count
            // 
            this.txtAutoReturnStep3Count.Location = new System.Drawing.Point(454, 502);
            this.txtAutoReturnStep3Count.Name = "txtAutoReturnStep3Count";
            this.txtAutoReturnStep3Count.Size = new System.Drawing.Size(100, 34);
            this.txtAutoReturnStep3Count.TabIndex = 23;
            // 
            // txtAutoReturnFreq
            // 
            this.txtAutoReturnFreq.Location = new System.Drawing.Point(453, 445);
            this.txtAutoReturnFreq.Name = "txtAutoReturnFreq";
            this.txtAutoReturnFreq.Size = new System.Drawing.Size(100, 34);
            this.txtAutoReturnFreq.TabIndex = 22;
            // 
            // txtManualPointPress
            // 
            this.txtManualPointPress.Location = new System.Drawing.Point(453, 388);
            this.txtManualPointPress.Name = "txtManualPointPress";
            this.txtManualPointPress.Size = new System.Drawing.Size(100, 34);
            this.txtManualPointPress.TabIndex = 21;
            // 
            // txtManualTime
            // 
            this.txtManualTime.Location = new System.Drawing.Point(454, 274);
            this.txtManualTime.Name = "txtManualTime";
            this.txtManualTime.Size = new System.Drawing.Size(100, 34);
            this.txtManualTime.TabIndex = 19;
            // 
            // txtManualCount
            // 
            this.txtManualCount.Location = new System.Drawing.Point(454, 217);
            this.txtManualCount.Name = "txtManualCount";
            this.txtManualCount.Size = new System.Drawing.Size(100, 34);
            this.txtManualCount.TabIndex = 18;
            // 
            // txtManualFreq
            // 
            this.txtManualFreq.Location = new System.Drawing.Point(454, 160);
            this.txtManualFreq.Name = "txtManualFreq";
            this.txtManualFreq.Size = new System.Drawing.Size(100, 34);
            this.txtManualFreq.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(145, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(292, 27);
            this.label14.TabIndex = 16;
            this.label14.Text = "自动返回前检测到电流持续时间";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(232, 27);
            this.label13.TabIndex = 15;
            this.label13.Text = "自动输出返回阶段三个数";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 27);
            this.label12.TabIndex = 14;
            this.label12.Text = "自动输出返回阶段频率";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(671, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 27);
            this.label11.TabIndex = 13;
            this.label11.Text = "自动输出前进阶段三个数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(671, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 27);
            this.label10.TabIndex = 12;
            this.label10.Text = "自动输出前进阶段二个数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(671, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "自动输出前进阶段一个数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "自动输出前进阶段三频率";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "自动输出前进阶段二频率";
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForward.Location = new System.Drawing.Point(464, 651);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(149, 50);
            this.btnForward.TabIndex = 10;
            this.btnForward.Text = "前进点动";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackward.Location = new System.Drawing.Point(621, 651);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(149, 50);
            this.btnBackward.TabIndex = 11;
            this.btnBackward.Text = "后退点动";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAuto.Location = new System.Drawing.Point(778, 651);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(149, 50);
            this.btnAuto.TabIndex = 12;
            this.btnAuto.Text = "自动程序";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.Location = new System.Drawing.Point(1107, 683);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(141, 41);
            this.btnReturnMain.TabIndex = 54;
            this.btnReturnMain.Text = "返回主菜单";
            this.btnReturnMain.UseVisualStyleBackColor = true;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(369, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(480, 75);
            this.label22.TabIndex = 55;
            this.label22.Text = "并弧试验参数设置";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 31);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // frmAndArc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1260, 736);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnAutoCurrentBeforeReturn);
            this.Controls.Add(this.cbxManualDirection);
            this.Controls.Add(this.btnAutoReturnStep3Count);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAutoReturnFreq);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnManualPointPress);
            this.Controls.Add(this.btnAutoForwardStep3Count);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnAutoForwardStep3Freq);
            this.Controls.Add(this.txtAutoCurrentBeforeReturn);
            this.Controls.Add(this.btnManualDirection);
            this.Controls.Add(this.txtAutoReturnStep3Count);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.txtAutoReturnFreq);
            this.Controls.Add(this.btnManualTime);
            this.Controls.Add(this.txtManualPointPress);
            this.Controls.Add(this.btnAutoForwardStep2Count);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnManualCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnManualFreq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAutoForwardStep2Freq);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnAutoForwardStep1Count);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAutoForwardStep1Freq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtManualTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtManualCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtManualFreq);
            this.Controls.Add(this.txtAutoForwardStep1Freq);
            this.Controls.Add(this.txtAutoForwardStep1Count);
            this.Controls.Add(this.txtAutoForwardStep2Freq);
            this.Controls.Add(this.txtAutoForwardStep2Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutoForwardStep3Freq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtAutoForwardStep3Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1260, 736);
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "frmAndArc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "并弧试验";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAutoForwardStep3Count;
        private System.Windows.Forms.TextBox txtAutoForwardStep3Freq;
        private System.Windows.Forms.TextBox txtAutoForwardStep2Count;
        private System.Windows.Forms.TextBox txtAutoForwardStep2Freq;
        private System.Windows.Forms.TextBox txtAutoForwardStep1Count;
        private System.Windows.Forms.TextBox txtAutoForwardStep1Freq;
        private System.Windows.Forms.TextBox txtAutoCurrentBeforeReturn;
        private System.Windows.Forms.TextBox txtAutoReturnStep3Count;
        private System.Windows.Forms.TextBox txtAutoReturnFreq;
        private System.Windows.Forms.TextBox txtManualPointPress;
        private System.Windows.Forms.TextBox txtManualTime;
        private System.Windows.Forms.TextBox txtManualCount;
        private System.Windows.Forms.TextBox txtManualFreq;
        private System.Windows.Forms.Button btnAutoForwardStep3Count;
        private System.Windows.Forms.Button btnAutoForwardStep3Freq;
        private System.Windows.Forms.Button btnAutoForwardStep2Count;
        private System.Windows.Forms.Button btnAutoForwardStep2Freq;
        private System.Windows.Forms.Button btnAutoForwardStep1Count;
        private System.Windows.Forms.Button btnAutoForwardStep1Freq;
        private System.Windows.Forms.Button btnAutoCurrentBeforeReturn;
        private System.Windows.Forms.Button btnAutoReturnStep3Count;
        private System.Windows.Forms.Button btnAutoReturnFreq;
        private System.Windows.Forms.Button btnManualPointPress;
        private System.Windows.Forms.Button btnManualDirection;
        private System.Windows.Forms.Button btnManualTime;
        private System.Windows.Forms.Button btnManualCount;
        private System.Windows.Forms.Button btnManualFreq;
        private System.Windows.Forms.ComboBox cbxManualDirection;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}