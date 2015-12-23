namespace KARO_AFDD
{
    partial class frmBufferedAi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBufferedAi));
            this.listView = new System.Windows.Forms.ListView();
            this.label_YCoordinateMin = new System.Windows.Forms.Label();
            this.label_YCoordinateMiddle = new System.Windows.Forms.Label();
            this.label_YCoordinateMax = new System.Windows.Forms.Label();
            this.label_XCoordinateMax = new System.Windows.Forms.Label();
            this.label_XCoordinateMin = new System.Windows.Forms.Label();
            this.label_divide = new System.Windows.Forms.Label();
            this.button_getData = new System.Windows.Forms.Button();
            this.label_shift = new System.Windows.Forms.Label();
            this.trackBar_div = new System.Windows.Forms.TrackBar();
            this.trackBar_shift = new System.Windows.Forms.TrackBar();
            this.textBox_div = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_shift = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bufferedAiCtrl1 = new Automation.BDaq.BufferedAiCtrl(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_shift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(197, 388);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(524, 38);
            this.listView.TabIndex = 59;
            this.listView.TabStop = false;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // label_YCoordinateMin
            // 
            this.label_YCoordinateMin.BackColor = System.Drawing.SystemColors.Control;
            this.label_YCoordinateMin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_YCoordinateMin.Location = new System.Drawing.Point(5, 336);
            this.label_YCoordinateMin.Name = "label_YCoordinateMin";
            this.label_YCoordinateMin.Size = new System.Drawing.Size(53, 23);
            this.label_YCoordinateMin.TabIndex = 58;
            this.label_YCoordinateMin.Text = "0V";
            this.label_YCoordinateMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_YCoordinateMiddle
            // 
            this.label_YCoordinateMiddle.BackColor = System.Drawing.SystemColors.Control;
            this.label_YCoordinateMiddle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_YCoordinateMiddle.Location = new System.Drawing.Point(7, 181);
            this.label_YCoordinateMiddle.Name = "label_YCoordinateMiddle";
            this.label_YCoordinateMiddle.Size = new System.Drawing.Size(53, 23);
            this.label_YCoordinateMiddle.TabIndex = 57;
            this.label_YCoordinateMiddle.Text = "0V";
            this.label_YCoordinateMiddle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_YCoordinateMax
            // 
            this.label_YCoordinateMax.BackColor = System.Drawing.SystemColors.Control;
            this.label_YCoordinateMax.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_YCoordinateMax.Location = new System.Drawing.Point(6, 13);
            this.label_YCoordinateMax.Name = "label_YCoordinateMax";
            this.label_YCoordinateMax.Size = new System.Drawing.Size(53, 23);
            this.label_YCoordinateMax.TabIndex = 56;
            this.label_YCoordinateMax.Text = "5V";
            this.label_YCoordinateMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_XCoordinateMax
            // 
            this.label_XCoordinateMax.AutoSize = true;
            this.label_XCoordinateMax.BackColor = System.Drawing.SystemColors.Control;
            this.label_XCoordinateMax.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_XCoordinateMax.Location = new System.Drawing.Point(669, 358);
            this.label_XCoordinateMax.Name = "label_XCoordinateMax";
            this.label_XCoordinateMax.Size = new System.Drawing.Size(52, 20);
            this.label_XCoordinateMax.TabIndex = 55;
            this.label_XCoordinateMax.Text = "10 Sec";
            // 
            // label_XCoordinateMin
            // 
            this.label_XCoordinateMin.AutoSize = true;
            this.label_XCoordinateMin.BackColor = System.Drawing.SystemColors.Control;
            this.label_XCoordinateMin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_XCoordinateMin.Location = new System.Drawing.Point(61, 358);
            this.label_XCoordinateMin.Name = "label_XCoordinateMin";
            this.label_XCoordinateMin.Size = new System.Drawing.Size(44, 20);
            this.label_XCoordinateMin.TabIndex = 54;
            this.label_XCoordinateMin.Text = "0 Sec";
            // 
            // label_divide
            // 
            this.label_divide.AutoSize = true;
            this.label_divide.BackColor = System.Drawing.SystemColors.Control;
            this.label_divide.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_divide.Location = new System.Drawing.Point(520, 447);
            this.label_divide.Name = "label_divide";
            this.label_divide.Size = new System.Drawing.Size(28, 20);
            this.label_divide.TabIndex = 53;
            this.label_divide.Text = "ms";
            // 
            // button_getData
            // 
            this.button_getData.CausesValidation = false;
            this.button_getData.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_getData.Location = new System.Drawing.Point(634, 484);
            this.button_getData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_getData.Name = "button_getData";
            this.button_getData.Size = new System.Drawing.Size(87, 32);
            this.button_getData.TabIndex = 52;
            this.button_getData.Text = "Get Data";
            this.button_getData.UseVisualStyleBackColor = true;
            this.button_getData.Click += new System.EventHandler(this.button_getData_Click);
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.BackColor = System.Drawing.SystemColors.Control;
            this.label_shift.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_shift.Location = new System.Drawing.Point(180, 447);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(28, 20);
            this.label_shift.TabIndex = 51;
            this.label_shift.Text = "ms";
            // 
            // trackBar_div
            // 
            this.trackBar_div.AutoSize = false;
            this.trackBar_div.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_div.Location = new System.Drawing.Point(554, 445);
            this.trackBar_div.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar_div.Maximum = 1000;
            this.trackBar_div.Minimum = 10;
            this.trackBar_div.Name = "trackBar_div";
            this.trackBar_div.Size = new System.Drawing.Size(173, 23);
            this.trackBar_div.TabIndex = 50;
            this.trackBar_div.TickFrequency = 100;
            this.trackBar_div.Value = 100;
            this.trackBar_div.Scroll += new System.EventHandler(this.trackBar_div_Scroll);
            // 
            // trackBar_shift
            // 
            this.trackBar_shift.AutoSize = false;
            this.trackBar_shift.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_shift.Location = new System.Drawing.Point(214, 446);
            this.trackBar_shift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar_shift.Maximum = 1000;
            this.trackBar_shift.Name = "trackBar_shift";
            this.trackBar_shift.Size = new System.Drawing.Size(149, 25);
            this.trackBar_shift.TabIndex = 49;
            this.trackBar_shift.TickFrequency = 100;
            this.trackBar_shift.Scroll += new System.EventHandler(this.trackBar_shift_Scroll);
            // 
            // textBox_div
            // 
            this.textBox_div.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_div.Location = new System.Drawing.Point(437, 446);
            this.textBox_div.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_div.Name = "textBox_div";
            this.textBox_div.Size = new System.Drawing.Size(81, 26);
            this.textBox_div.TabIndex = 48;
            this.textBox_div.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(397, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Div:";
            // 
            // textBox_shift
            // 
            this.textBox_shift.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_shift.Location = new System.Drawing.Point(98, 445);
            this.textBox_shift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_shift.Name = "textBox_shift";
            this.textBox_shift.Size = new System.Drawing.Size(81, 26);
            this.textBox_shift.TabIndex = 46;
            this.textBox_shift.Text = "10";
            this.textBox_shift.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(49, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Shift:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Color of channels:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox.Location = new System.Drawing.Point(61, 13);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(660, 340);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 43;
            this.pictureBox.TabStop = false;
            // 
            // bufferedAiCtrl1
            // 
            this.bufferedAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("bufferedAiCtrl1._StateStream")));
            this.bufferedAiCtrl1.Stopped += new System.EventHandler<Automation.BDaq.BfdAiEventArgs>(this.bufferedAiCtrl1_Stopped);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(98, 484);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 26);
            this.textBox1.TabIndex = 60;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmBufferedAi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 529);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label_YCoordinateMin);
            this.Controls.Add(this.label_YCoordinateMiddle);
            this.Controls.Add(this.label_YCoordinateMax);
            this.Controls.Add(this.label_XCoordinateMax);
            this.Controls.Add(this.label_XCoordinateMin);
            this.Controls.Add(this.label_divide);
            this.Controls.Add(this.button_getData);
            this.Controls.Add(this.label_shift);
            this.Controls.Add(this.trackBar_div);
            this.Controls.Add(this.trackBar_shift);
            this.Controls.Add(this.textBox_div);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_shift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBufferedAi";
            this.Text = "Asynchronous One Buffered AI";
            this.Load += new System.EventHandler(this.frmBufferedAi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_shift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label_YCoordinateMin;
        private System.Windows.Forms.Label label_YCoordinateMiddle;
        private System.Windows.Forms.Label label_YCoordinateMax;
        public System.Windows.Forms.Label label_XCoordinateMax;
        private System.Windows.Forms.Label label_XCoordinateMin;
        private System.Windows.Forms.Label label_divide;
        private System.Windows.Forms.Button button_getData;
        public System.Windows.Forms.Label label_shift;
        private System.Windows.Forms.TrackBar trackBar_div;
        private System.Windows.Forms.TrackBar trackBar_shift;
        private System.Windows.Forms.TextBox textBox_div;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_shift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private Automation.BDaq.BufferedAiCtrl bufferedAiCtrl1;
        private System.Windows.Forms.TextBox textBox1;
    }
}