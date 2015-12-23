namespace KARO_AFDD
{
    partial class frmCarbidePath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarbidePath));
            this.btn12kV = new System.Windows.Forms.Button();
            this.btn2kV = new System.Windows.Forms.Button();
            this.btnLamp = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExhaustFan = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.instantDoCtrl1 = new Automation.BDaq.InstantDoCtrl(this.components);
            this.instantDiCtrl1 = new Automation.BDaq.InstantDiCtrl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn12kV
            // 
            this.btn12kV.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn12kV.Location = new System.Drawing.Point(111, 204);
            this.btn12kV.Margin = new System.Windows.Forms.Padding(4);
            this.btn12kV.Name = "btn12kV";
            this.btn12kV.Size = new System.Drawing.Size(198, 85);
            this.btn12kV.TabIndex = 0;
            this.btn12kV.Text = "12kV通电";
            this.btn12kV.UseVisualStyleBackColor = true;
            this.btn12kV.Click += new System.EventHandler(this.btn12kV_Click);
            // 
            // btn2kV
            // 
            this.btn2kV.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2kV.Location = new System.Drawing.Point(111, 332);
            this.btn2kV.Margin = new System.Windows.Forms.Padding(4);
            this.btn2kV.Name = "btn2kV";
            this.btn2kV.Size = new System.Drawing.Size(198, 85);
            this.btn2kV.TabIndex = 1;
            this.btn2kV.Text = "2kV通电";
            this.btn2kV.UseVisualStyleBackColor = true;
            this.btn2kV.Click += new System.EventHandler(this.btn2kV_Click);
            // 
            // btnLamp
            // 
            this.btnLamp.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLamp.Location = new System.Drawing.Point(111, 460);
            this.btnLamp.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamp.Name = "btnLamp";
            this.btnLamp.Size = new System.Drawing.Size(198, 85);
            this.btnLamp.TabIndex = 2;
            this.btnLamp.Text = "白炽灯测试";
            this.btnLamp.UseVisualStyleBackColor = true;
            this.btnLamp.Click += new System.EventHandler(this.btnLamp_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.Location = new System.Drawing.Point(1107, 683);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(141, 41);
            this.btnReturnMain.TabIndex = 3;
            this.btnReturnMain.Text = "返回主菜单";
            this.btnReturnMain.UseVisualStyleBackColor = true;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(446, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "碳化路径试验";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 31);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnExhaustFan
            // 
            this.btnExhaustFan.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExhaustFan.Location = new System.Drawing.Point(374, 460);
            this.btnExhaustFan.Name = "btnExhaustFan";
            this.btnExhaustFan.Size = new System.Drawing.Size(198, 85);
            this.btnExhaustFan.TabIndex = 67;
            this.btnExhaustFan.Text = "排气扇";
            this.btnExhaustFan.UseVisualStyleBackColor = true;
            this.btnExhaustFan.Click += new System.EventHandler(this.btnExhaustFan_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(643, 588);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(198, 85);
            this.btnQuit.TabIndex = 66;
            this.btnQuit.Text = "退出试验";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPause.Location = new System.Drawing.Point(374, 588);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(198, 85);
            this.btnPause.TabIndex = 65;
            this.btnPause.Text = "停止试验";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(111, 588);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 85);
            this.btnStart.TabIndex = 64;
            this.btnStart.Text = "开始试验";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(368, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 68;
            this.label2.Text = "设置时间t1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(368, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 69;
            this.label3.Text = "设置时间t2";
            // 
            // txtT1
            // 
            this.txtT1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtT1.Location = new System.Drawing.Point(557, 255);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(155, 39);
            this.txtT1.TabIndex = 70;
            this.txtT1.Text = "1";
            this.txtT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtT2
            // 
            this.txtT2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtT2.Location = new System.Drawing.Point(557, 329);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(155, 39);
            this.txtT2.TabIndex = 71;
            this.txtT2.Text = "2";
            this.txtT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(730, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 31);
            this.label4.TabIndex = 72;
            this.label4.Text = "s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(730, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 73;
            this.label5.Text = "s";
            // 
            // instantDoCtrl1
            // 
            this.instantDoCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDoCtrl1._StateStream")));
            // 
            // instantDiCtrl1
            // 
            this.instantDiCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDiCtrl1._StateStream")));
            // 
            // frmCarbidePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1260, 736);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtT2);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExhaustFan);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnLamp);
            this.Controls.Add(this.btn2kV);
            this.Controls.Add(this.btn12kV);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1260, 736);
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "frmCarbidePath";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDefault";
            this.Load += new System.EventHandler(this.frmCarbidePath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn12kV;
        private System.Windows.Forms.Button btn2kV;
        private System.Windows.Forms.Button btnLamp;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExhaustFan;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Automation.BDaq.InstantDoCtrl instantDoCtrl1;
        private Automation.BDaq.InstantDiCtrl instantDiCtrl1;
    }
}