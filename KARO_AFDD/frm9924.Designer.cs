namespace KARO_AFDD
{
    partial class frm9924
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm9922));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCurrentChoose = new System.Windows.Forms.ComboBox();
            this.cbxArcGear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtPowerFactor = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.txtBreakTime = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar_shift = new System.Windows.Forms.TrackBar();
            this.label_shift = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_divide = new System.Windows.Forms.Label();
            this.label_XCoordinateMax = new System.Windows.Forms.Label();
            this.label_XCoordinateMin = new System.Windows.Forms.Label();
            this.textBox_shift = new System.Windows.Forms.TextBox();
            this.label_YCoordinateMax = new System.Windows.Forms.Label();
            this.label_YCoordinateMiddle = new System.Windows.Forms.Label();
            this.label_YCoordinateMin = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBar_div = new System.Windows.Forms.TrackBar();
            this.textBox_div = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picSchematic = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbxValueRange = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnExhaustFan = new System.Windows.Forms.Button();
            this.btnFan = new System.Windows.Forms.Button();
            this.cbxChannelCount = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtSamples = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button_getData = new System.Windows.Forms.Button();
            this.txtSampleTime = new System.Windows.Forms.TextBox();
            this.txtClockRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.instantDoCtrl1 = new Automation.BDaq.InstantDoCtrl(this.components);
            this.bufferedAiCtrl1 = new Automation.BDaq.BufferedAiCtrl(this.components);
            this.instantDiCtrl1 = new Automation.BDaq.InstantDiCtrl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_shift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_div)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchematic)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(577, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 84);
            this.label1.TabIndex = 12;
            this.label1.Text = "验证电路中突然出现\r\n串联电弧故障时的正确动作";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxCurrentChoose);
            this.panel1.Controls.Add(this.cbxArcGear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 58);
            this.panel1.TabIndex = 13;
            // 
            // cbxCurrentChoose
            // 
            this.cbxCurrentChoose.FormattingEnabled = true;
            this.cbxCurrentChoose.Items.AddRange(new object[] {
            "3A",
            "6A",
            "13A",
            "20A",
            "40A",
            "63A"});
            this.cbxCurrentChoose.Location = new System.Drawing.Point(472, 9);
            this.cbxCurrentChoose.Name = "cbxCurrentChoose";
            this.cbxCurrentChoose.Size = new System.Drawing.Size(121, 35);
            this.cbxCurrentChoose.TabIndex = 3;
            this.cbxCurrentChoose.Text = "3A";
            // 
            // cbxArcGear
            // 
            this.cbxArcGear.FormattingEnabled = true;
            this.cbxArcGear.Items.AddRange(new object[] {
            "电弧发生器",
            "碳化电缆试品"});
            this.cbxArcGear.Location = new System.Drawing.Point(127, 9);
            this.cbxArcGear.Name = "cbxArcGear";
            this.cbxArcGear.Size = new System.Drawing.Size(121, 35);
            this.cbxArcGear.TabIndex = 2;
            this.cbxArcGear.Text = "电弧发生器";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "电流选择";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "试验电流";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFolderBrowser);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtFilePath);
            this.panel2.Controls.Add(this.txtPowerFactor);
            this.panel2.Controls.Add(this.txtPower);
            this.panel2.Controls.Add(this.txtBreakTime);
            this.panel2.Controls.Add(this.txtCurrent);
            this.panel2.Controls.Add(this.txtVoltage);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(661, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 137);
            this.panel2.TabIndex = 14;
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Location = new System.Drawing.Point(537, 94);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(37, 34);
            this.btnFolderBrowser.TabIndex = 24;
            this.btnFolderBrowser.Text = "...";
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(467, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 27);
            this.label14.TabIndex = 23;
            this.label14.Text = "w";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 27);
            this.label13.TabIndex = 23;
            this.label13.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 27);
            this.label12.TabIndex = 22;
            this.label12.Text = "V";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(361, 94);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(170, 34);
            this.txtFilePath.TabIndex = 21;
            // 
            // txtPowerFactor
            // 
            this.txtPowerFactor.Location = new System.Drawing.Point(361, 50);
            this.txtPowerFactor.Name = "txtPowerFactor";
            this.txtPowerFactor.Size = new System.Drawing.Size(100, 34);
            this.txtPowerFactor.TabIndex = 20;
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(361, 9);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(100, 34);
            this.txtPower.TabIndex = 19;
            // 
            // txtBreakTime
            // 
            this.txtBreakTime.Location = new System.Drawing.Point(116, 94);
            this.txtBreakTime.Name = "txtBreakTime";
            this.txtBreakTime.Size = new System.Drawing.Size(100, 34);
            this.txtBreakTime.TabIndex = 18;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(76, 50);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(100, 34);
            this.txtCurrent.TabIndex = 17;
            // 
            // txtVoltage
            // 
            this.txtVoltage.Location = new System.Drawing.Point(76, 9);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(100, 34);
            this.txtVoltage.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 27);
            this.label10.TabIndex = 15;
            this.label10.Text = "分断时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "保存目录";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "功率因数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "功率";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "电流";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "电压";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trackBar_shift);
            this.panel3.Controls.Add(this.label_shift);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label_divide);
            this.panel3.Controls.Add(this.label_XCoordinateMax);
            this.panel3.Controls.Add(this.label_XCoordinateMin);
            this.panel3.Controls.Add(this.textBox_shift);
            this.panel3.Controls.Add(this.label_YCoordinateMax);
            this.panel3.Controls.Add(this.label_YCoordinateMiddle);
            this.panel3.Controls.Add(this.label_YCoordinateMin);
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Controls.Add(this.trackBar_div);
            this.panel3.Controls.Add(this.textBox_div);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(661, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 226);
            this.panel3.TabIndex = 15;
            // 
            // trackBar_shift
            // 
            this.trackBar_shift.AutoSize = false;
            this.trackBar_shift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.trackBar_shift.Location = new System.Drawing.Point(222, 194);
            this.trackBar_shift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar_shift.Maximum = 1000;
            this.trackBar_shift.Name = "trackBar_shift";
            this.trackBar_shift.Size = new System.Drawing.Size(96, 25);
            this.trackBar_shift.TabIndex = 58;
            this.trackBar_shift.TickFrequency = 100;
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.label_shift.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_shift.Location = new System.Drawing.Point(200, 197);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(25, 17);
            this.label_shift.TabIndex = 60;
            this.label_shift.Text = "ms";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(110, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 17);
            this.label16.TabIndex = 54;
            this.label16.Text = "Shift:";
            // 
            // label_divide
            // 
            this.label_divide.AutoSize = true;
            this.label_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.label_divide.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_divide.Location = new System.Drawing.Point(402, 197);
            this.label_divide.Name = "label_divide";
            this.label_divide.Size = new System.Drawing.Size(25, 17);
            this.label_divide.TabIndex = 61;
            this.label_divide.Text = "ms";
            // 
            // label_XCoordinateMax
            // 
            this.label_XCoordinateMax.AutoSize = true;
            this.label_XCoordinateMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.label_XCoordinateMax.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_XCoordinateMax.Location = new System.Drawing.Point(537, 195);
            this.label_XCoordinateMax.Name = "label_XCoordinateMax";
            this.label_XCoordinateMax.Size = new System.Drawing.Size(46, 17);
            this.label_XCoordinateMax.TabIndex = 63;
            this.label_XCoordinateMax.Text = "10 Sec";
            // 
            // label_XCoordinateMin
            // 
            this.label_XCoordinateMin.AutoSize = true;
            this.label_XCoordinateMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.label_XCoordinateMin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_XCoordinateMin.Location = new System.Drawing.Point(42, 195);
            this.label_XCoordinateMin.Name = "label_XCoordinateMin";
            this.label_XCoordinateMin.Size = new System.Drawing.Size(39, 17);
            this.label_XCoordinateMin.TabIndex = 62;
            this.label_XCoordinateMin.Text = "0 Sec";
            // 
            // textBox_shift
            // 
            this.textBox_shift.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_shift.Location = new System.Drawing.Point(152, 195);
            this.textBox_shift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_shift.Name = "textBox_shift";
            this.textBox_shift.Size = new System.Drawing.Size(45, 23);
            this.textBox_shift.TabIndex = 55;
            this.textBox_shift.Text = "10";
            this.textBox_shift.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_YCoordinateMax
            // 
            this.label_YCoordinateMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.label_YCoordinateMax.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_YCoordinateMax.Location = new System.Drawing.Point(3, 5);
            this.label_YCoordinateMax.Name = "label_YCoordinateMax";
            this.label_YCoordinateMax.Size = new System.Drawing.Size(31, 23);
            this.label_YCoordinateMax.TabIndex = 59;
            this.label_YCoordinateMax.Text = "5V";
            this.label_YCoordinateMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_YCoordinateMiddle
            // 
            this.label_YCoordinateMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.label_YCoordinateMiddle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_YCoordinateMiddle.Location = new System.Drawing.Point(4, 89);
            this.label_YCoordinateMiddle.Name = "label_YCoordinateMiddle";
            this.label_YCoordinateMiddle.Size = new System.Drawing.Size(30, 23);
            this.label_YCoordinateMiddle.TabIndex = 60;
            this.label_YCoordinateMiddle.Text = "0V";
            this.label_YCoordinateMiddle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_YCoordinateMin
            // 
            this.label_YCoordinateMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.label_YCoordinateMin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_YCoordinateMin.Location = new System.Drawing.Point(4, 175);
            this.label_YCoordinateMin.Name = "label_YCoordinateMin";
            this.label_YCoordinateMin.Size = new System.Drawing.Size(30, 23);
            this.label_YCoordinateMin.TabIndex = 61;
            this.label_YCoordinateMin.Text = "0V";
            this.label_YCoordinateMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox.Location = new System.Drawing.Point(34, 4);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(550, 180);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 44;
            this.pictureBox.TabStop = false;
            // 
            // trackBar_div
            // 
            this.trackBar_div.AutoSize = false;
            this.trackBar_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.trackBar_div.Location = new System.Drawing.Point(427, 195);
            this.trackBar_div.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar_div.Maximum = 1000;
            this.trackBar_div.Minimum = 10;
            this.trackBar_div.Name = "trackBar_div";
            this.trackBar_div.Size = new System.Drawing.Size(96, 23);
            this.trackBar_div.TabIndex = 59;
            this.trackBar_div.TickFrequency = 100;
            this.trackBar_div.Value = 100;
            // 
            // textBox_div
            // 
            this.textBox_div.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_div.Location = new System.Drawing.Point(359, 196);
            this.textBox_div.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_div.Name = "textBox_div";
            this.textBox_div.Size = new System.Drawing.Size(41, 23);
            this.textBox_div.TabIndex = 57;
            this.textBox_div.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(327, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 17);
            this.label15.TabIndex = 56;
            this.label15.Text = "Div:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.picSchematic);
            this.panel4.Location = new System.Drawing.Point(12, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(643, 305);
            this.panel4.TabIndex = 16;
            // 
            // picSchematic
            // 
            this.picSchematic.Location = new System.Drawing.Point(23, 11);
            this.picSchematic.Name = "picSchematic";
            this.picSchematic.Size = new System.Drawing.Size(600, 280);
            this.picSchematic.TabIndex = 0;
            this.picSchematic.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbxValueRange);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.btnExhaustFan);
            this.panel5.Controls.Add(this.btnFan);
            this.panel5.Controls.Add(this.cbxChannelCount);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.btnQuit);
            this.panel5.Controls.Add(this.btnPause);
            this.panel5.Controls.Add(this.btnStart);
            this.panel5.Controls.Add(this.txtSamples);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.button_getData);
            this.panel5.Controls.Add(this.txtSampleTime);
            this.panel5.Controls.Add(this.txtClockRate);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(12, 488);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(643, 236);
            this.panel5.TabIndex = 16;
            // 
            // cbxValueRange
            // 
            this.cbxValueRange.FormattingEnabled = true;
            this.cbxValueRange.Items.AddRange(new object[] {
            "+/- 5A",
            "+/- 10A",
            "+/- 50A",
            "+/- 200A"});
            this.cbxValueRange.Location = new System.Drawing.Point(524, 13);
            this.cbxValueRange.Name = "cbxValueRange";
            this.cbxValueRange.Size = new System.Drawing.Size(100, 35);
            this.cbxValueRange.TabIndex = 66;
            this.cbxValueRange.Text = "+/- 10V";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(426, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 27);
            this.label19.TabIndex = 65;
            this.label19.Text = "电流范围";
            // 
            // btnExhaustFan
            // 
            this.btnExhaustFan.Location = new System.Drawing.Point(14, 139);
            this.btnExhaustFan.Name = "btnExhaustFan";
            this.btnExhaustFan.Size = new System.Drawing.Size(111, 36);
            this.btnExhaustFan.TabIndex = 64;
            this.btnExhaustFan.Text = "排气扇";
            this.btnExhaustFan.UseVisualStyleBackColor = true;
            // 
            // btnFan
            // 
            this.btnFan.Location = new System.Drawing.Point(179, 139);
            this.btnFan.Name = "btnFan";
            this.btnFan.Size = new System.Drawing.Size(111, 36);
            this.btnFan.TabIndex = 63;
            this.btnFan.Text = "风扇";
            this.btnFan.UseVisualStyleBackColor = true;
            // 
            // cbxChannelCount
            // 
            this.cbxChannelCount.FormattingEnabled = true;
            this.cbxChannelCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxChannelCount.Location = new System.Drawing.Point(116, 61);
            this.cbxChannelCount.Name = "cbxChannelCount";
            this.cbxChannelCount.Size = new System.Drawing.Size(100, 35);
            this.cbxChannelCount.TabIndex = 60;
            this.cbxChannelCount.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 27);
            this.label18.TabIndex = 59;
            this.label18.Text = "采样通道";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(341, 181);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(111, 36);
            this.btnQuit.TabIndex = 58;
            this.btnQuit.Text = "退出试验";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(179, 181);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(111, 36);
            this.btnPause.TabIndex = 57;
            this.btnPause.Text = "停止试验";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 181);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 36);
            this.btnStart.TabIndex = 56;
            this.btnStart.Text = "开始试验";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // txtSamples
            // 
            this.txtSamples.Location = new System.Drawing.Point(320, 13);
            this.txtSamples.Name = "txtSamples";
            this.txtSamples.Size = new System.Drawing.Size(100, 34);
            this.txtSamples.TabIndex = 55;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(222, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 27);
            this.label17.TabIndex = 54;
            this.label17.Text = "采样个数";
            // 
            // button_getData
            // 
            this.button_getData.CausesValidation = false;
            this.button_getData.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_getData.Location = new System.Drawing.Point(553, 200);
            this.button_getData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_getData.Name = "button_getData";
            this.button_getData.Size = new System.Drawing.Size(87, 32);
            this.button_getData.TabIndex = 53;
            this.button_getData.Text = "Get Data";
            this.button_getData.UseVisualStyleBackColor = true;
            // 
            // txtSampleTime
            // 
            this.txtSampleTime.Location = new System.Drawing.Point(320, 61);
            this.txtSampleTime.Name = "txtSampleTime";
            this.txtSampleTime.Size = new System.Drawing.Size(100, 34);
            this.txtSampleTime.TabIndex = 4;
            // 
            // txtClockRate
            // 
            this.txtClockRate.Location = new System.Drawing.Point(116, 13);
            this.txtClockRate.Name = "txtClockRate";
            this.txtClockRate.Size = new System.Drawing.Size(100, 34);
            this.txtClockRate.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 27);
            this.label11.TabIndex = 2;
            this.label11.Text = "采样计时";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "采样频率";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listView);
            this.panel6.Location = new System.Drawing.Point(661, 488);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(587, 236);
            this.panel6.TabIndex = 17;
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(23, 13);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(121, 97);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.Visible = false;
            // 
            // instantDoCtrl1
            // 
            this.instantDoCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDoCtrl1._StateStream")));
            // 
            // bufferedAiCtrl1
            // 
            this.bufferedAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("bufferedAiCtrl1._StateStream")));
            // 
            // instantDiCtrl1
            // 
            this.instantDiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDiCtrl1._StateStream")));
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 31);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(351, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(220, 75);
            this.label20.TabIndex = 18;
            this.label20.Text = "9.9.2.2";
            // 
            // frm9922
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1260, 736);
            this.ControlBox = false;
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1260, 736);
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "frm9924";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm9924";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_shift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_div)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSchematic)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbxCurrentChoose;
        private System.Windows.Forms.ComboBox cbxArcGear;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtPowerFactor;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.TextBox txtBreakTime;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.TextBox txtSampleTime;
        private System.Windows.Forms.TextBox txtClockRate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label_YCoordinateMax;
        private System.Windows.Forms.Label label_YCoordinateMiddle;
        private System.Windows.Forms.Label label_YCoordinateMin;
        public System.Windows.Forms.Label label_XCoordinateMax;
        private System.Windows.Forms.Label label_XCoordinateMin;
        private Automation.BDaq.InstantDoCtrl instantDoCtrl1;
        private Automation.BDaq.BufferedAiCtrl bufferedAiCtrl1;
        private System.Windows.Forms.TrackBar trackBar_shift;
        public System.Windows.Forms.Label label_shift;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_divide;
        private System.Windows.Forms.TextBox textBox_shift;
        private System.Windows.Forms.TrackBar trackBar_div;
        private System.Windows.Forms.TextBox textBox_div;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_getData;
        private System.Windows.Forms.TextBox txtSamples;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private Automation.BDaq.InstantDiCtrl instantDiCtrl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picSchematic;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxChannelCount;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnExhaustFan;
        private System.Windows.Forms.Button btnFan;
        private System.Windows.Forms.ComboBox cbxValueRange;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
    }
}