namespace KARO_AFDD
{
    partial class frmAFD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAFD));
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArcFalse = new System.Windows.Forms.Button();
            this.btnFalseAlarm = new System.Windows.Forms.Button();
            this.btnLoadInhibitory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(500, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "AFD试验";
            // 
            // btnArcFalse
            // 
            this.btnArcFalse.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnArcFalse.Location = new System.Drawing.Point(228, 326);
            this.btnArcFalse.Margin = new System.Windows.Forms.Padding(4);
            this.btnArcFalse.Name = "btnArcFalse";
            this.btnArcFalse.Size = new System.Drawing.Size(226, 85);
            this.btnArcFalse.TabIndex = 6;
            this.btnArcFalse.Text = "6.3.2\r\n故障电弧试验";
            this.btnArcFalse.UseVisualStyleBackColor = true;
            this.btnArcFalse.Click += new System.EventHandler(this.btnArcFalse_Click);
            // 
            // btnFalseAlarm
            // 
            this.btnFalseAlarm.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFalseAlarm.Location = new System.Drawing.Point(517, 326);
            this.btnFalseAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.btnFalseAlarm.Name = "btnFalseAlarm";
            this.btnFalseAlarm.Size = new System.Drawing.Size(226, 85);
            this.btnFalseAlarm.TabIndex = 7;
            this.btnFalseAlarm.Text = "6.3.3\r\n误报警试验";
            this.btnFalseAlarm.UseVisualStyleBackColor = true;
            this.btnFalseAlarm.Click += new System.EventHandler(this.btnFalseAlarm_Click);
            // 
            // btnLoadInhibitory
            // 
            this.btnLoadInhibitory.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadInhibitory.Location = new System.Drawing.Point(806, 326);
            this.btnLoadInhibitory.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadInhibitory.Name = "btnLoadInhibitory";
            this.btnLoadInhibitory.Size = new System.Drawing.Size(226, 85);
            this.btnLoadInhibitory.TabIndex = 8;
            this.btnLoadInhibitory.Text = "6.3.4\r\n负载抑制性试验";
            this.btnLoadInhibitory.UseVisualStyleBackColor = true;
            this.btnLoadInhibitory.Click += new System.EventHandler(this.btnLoadInhibitory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 31);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmAFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1260, 736);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadInhibitory);
            this.Controls.Add(this.btnFalseAlarm);
            this.Controls.Add(this.btnArcFalse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnMain);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1260, 736);
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "frmAFD";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAFD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn12kV;
        private System.Windows.Forms.Button btnAFDD;
        private System.Windows.Forms.Button btnAFD;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArcFalse;
        private System.Windows.Forms.Button btnFalseAlarm;
        private System.Windows.Forms.Button btnLoadInhibitory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}