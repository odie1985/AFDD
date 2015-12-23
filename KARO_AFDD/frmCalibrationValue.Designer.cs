namespace KARO_AFDD
{
    partial class frmCalibrationValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalibrationValue));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtKB = new System.Windows.Forms.TextBox();
            this.txtSmp2 = new System.Windows.Forms.TextBox();
            this.txtSmp1 = new System.Windows.Forms.TextBox();
            this.btnStep5 = new System.Windows.Forms.Button();
            this.lblbStep5 = new System.Windows.Forms.Label();
            this.btnStep4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStep3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStep2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStep1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.instantAiCtrl1 = new Automation.BDaq.InstantAiCtrl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 31);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(502, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 75);
            this.label1.TabIndex = 11;
            this.label1.Text = "试验校准";
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Checked = true;
            this.chkC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkC.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkC.Location = new System.Drawing.Point(284, 265);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(83, 31);
            this.chkC.TabIndex = 45;
            this.chkC.Text = "3通道";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Checked = true;
            this.chkB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkB.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkB.Location = new System.Drawing.Point(194, 265);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(83, 31);
            this.chkB.TabIndex = 44;
            this.chkB.Text = "2通道";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Checked = true;
            this.chkA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkA.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkA.Location = new System.Drawing.Point(103, 265);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(83, 31);
            this.chkA.TabIndex = 43;
            this.chkA.Text = "1通道";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(98, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 27);
            this.label7.TabIndex = 42;
            this.label7.Text = "请选择要校准的通道：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(768, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 27);
            this.label6.TabIndex = 41;
            this.label6.Text = "安培";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(168, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 40;
            this.label5.Text = "安培";
            // 
            // txtY2
            // 
            this.txtY2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtY2.Location = new System.Drawing.Point(703, 262);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(62, 34);
            this.txtY2.TabIndex = 30;
            // 
            // txtY1
            // 
            this.txtY1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtY1.Location = new System.Drawing.Point(103, 372);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(62, 34);
            this.txtY1.TabIndex = 25;
            this.txtY1.Text = "0";
            // 
            // txtKB
            // 
            this.txtKB.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKB.Location = new System.Drawing.Point(703, 502);
            this.txtKB.Name = "txtKB";
            this.txtKB.ReadOnly = true;
            this.txtKB.Size = new System.Drawing.Size(367, 34);
            this.txtKB.TabIndex = 39;
            this.txtKB.TabStop = false;
            // 
            // txtSmp2
            // 
            this.txtSmp2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSmp2.Location = new System.Drawing.Point(703, 368);
            this.txtSmp2.Name = "txtSmp2";
            this.txtSmp2.ReadOnly = true;
            this.txtSmp2.Size = new System.Drawing.Size(367, 34);
            this.txtSmp2.TabIndex = 38;
            this.txtSmp2.TabStop = false;
            // 
            // txtSmp1
            // 
            this.txtSmp1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSmp1.Location = new System.Drawing.Point(103, 502);
            this.txtSmp1.Name = "txtSmp1";
            this.txtSmp1.ReadOnly = true;
            this.txtSmp1.Size = new System.Drawing.Size(367, 34);
            this.txtSmp1.TabIndex = 37;
            this.txtSmp1.TabStop = false;
            // 
            // btnStep5
            // 
            this.btnStep5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStep5.Location = new System.Drawing.Point(1076, 499);
            this.btnStep5.Name = "btnStep5";
            this.btnStep5.Size = new System.Drawing.Size(87, 37);
            this.btnStep5.TabIndex = 34;
            this.btnStep5.Text = "关闭";
            this.btnStep5.UseVisualStyleBackColor = true;
            this.btnStep5.Click += new System.EventHandler(this.btnStep5_Click);
            // 
            // lblbStep5
            // 
            this.lblbStep5.AutoSize = true;
            this.lblbStep5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblbStep5.Location = new System.Drawing.Point(698, 442);
            this.lblbStep5.Name = "lblbStep5";
            this.lblbStep5.Size = new System.Drawing.Size(114, 27);
            this.lblbStep5.TabIndex = 36;
            this.lblbStep5.Text = "5.校准完成.";
            // 
            // btnStep4
            // 
            this.btnStep4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStep4.Location = new System.Drawing.Point(1076, 365);
            this.btnStep4.Name = "btnStep4";
            this.btnStep4.Size = new System.Drawing.Size(87, 35);
            this.btnStep4.TabIndex = 33;
            this.btnStep4.Text = "下一步";
            this.btnStep4.UseVisualStyleBackColor = true;
            this.btnStep4.Click += new System.EventHandler(this.btnStep4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(698, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "4.已记录RMS采样值,请按\"下一步\"";
            // 
            // btnStep3
            // 
            this.btnStep3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStep3.Location = new System.Drawing.Point(826, 263);
            this.btnStep3.Name = "btnStep3";
            this.btnStep3.Size = new System.Drawing.Size(87, 33);
            this.btnStep3.TabIndex = 32;
            this.btnStep3.Text = "下一步";
            this.btnStep3.UseVisualStyleBackColor = true;
            this.btnStep3.Click += new System.EventHandler(this.btnStep3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(698, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "3.请发电流，并设置，完成请按“下一步”";
            // 
            // btnStep2
            // 
            this.btnStep2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStep2.Location = new System.Drawing.Point(476, 502);
            this.btnStep2.Name = "btnStep2";
            this.btnStep2.Size = new System.Drawing.Size(87, 34);
            this.btnStep2.TabIndex = 28;
            this.btnStep2.Text = "下一步";
            this.btnStep2.UseVisualStyleBackColor = true;
            this.btnStep2.Click += new System.EventHandler(this.btnStep2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(98, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "2.已记录RMS采样值,请按\"下一步\"";
            // 
            // btnStep1
            // 
            this.btnStep1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStep1.Location = new System.Drawing.Point(231, 369);
            this.btnStep1.Name = "btnStep1";
            this.btnStep1.Size = new System.Drawing.Size(87, 37);
            this.btnStep1.TabIndex = 27;
            this.btnStep1.Text = "下一步";
            this.btnStep1.UseVisualStyleBackColor = true;
            this.btnStep1.Click += new System.EventHandler(this.btnStep1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(98, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 27);
            this.label8.TabIndex = 26;
            this.label8.Text = "1.请发电流，并设置，完成请按“下一步”";
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Checked = true;
            this.chkD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkD.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkD.Location = new System.Drawing.Point(374, 265);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(83, 31);
            this.chkD.TabIndex = 46;
            this.chkD.Text = "4通道";
            this.chkD.UseVisualStyleBackColor = true;
            // 
            // instantAiCtrl1
            // 
            this.instantAiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantAiCtrl1._StateStream")));
            // 
            // frmCalibrationValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1260, 736);
            this.ControlBox = false;
            this.Controls.Add(this.chkD);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.chkB);
            this.Controls.Add(this.chkA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtKB);
            this.Controls.Add(this.txtSmp2);
            this.Controls.Add(this.txtSmp1);
            this.Controls.Add(this.btnStep5);
            this.Controls.Add(this.lblbStep5);
            this.Controls.Add(this.btnStep4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStep3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStep2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStep1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1260, 736);
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "frmCalibrationValue";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCalibrationValue";
            this.Load += new System.EventHandler(this.frmCalibrationValue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtKB;
        private System.Windows.Forms.TextBox txtSmp2;
        private System.Windows.Forms.TextBox txtSmp1;
        private System.Windows.Forms.Button btnStep5;
        private System.Windows.Forms.Label lblbStep5;
        private System.Windows.Forms.Button btnStep4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStep3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStep2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStep1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkD;
        private Automation.BDaq.InstantAiCtrl instantAiCtrl1;
    }
}