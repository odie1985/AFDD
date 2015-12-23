namespace KARO_AFDD
{
    partial class frm992
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm992));
            this.btn9923 = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn9922 = new System.Windows.Forms.Button();
            this.btn9924 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn9923
            // 
            this.btn9923.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9923.Location = new System.Drawing.Point(468, 334);
            this.btn9923.Margin = new System.Windows.Forms.Padding(4);
            this.btn9923.Name = "btn9923";
            this.btn9923.Size = new System.Drawing.Size(325, 114);
            this.btn9923.TabIndex = 0;
            this.btn9923.Text = "9.9.2.3\r\n验证接入带串联电弧故障\r\n负载的正确动作 ";
            this.btn9923.UseVisualStyleBackColor = true;
            this.btn9923.Click += new System.EventHandler(this.btn9923_Click);
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
            this.label1.Location = new System.Drawing.Point(313, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "9.9.2 串联电弧故障试验";
            // 
            // btn9922
            // 
            this.btn9922.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9922.Location = new System.Drawing.Point(109, 334);
            this.btn9922.Margin = new System.Windows.Forms.Padding(4);
            this.btn9922.Name = "btn9922";
            this.btn9922.Size = new System.Drawing.Size(325, 114);
            this.btn9922.TabIndex = 5;
            this.btn9922.Text = "9.9.2.2 \r\n验证电路中突然出现\r\n串联电弧故障时的正确动作";
            this.btn9922.UseVisualStyleBackColor = true;
            this.btn9922.Click += new System.EventHandler(this.btn9922_Click);
            // 
            // btn9924
            // 
            this.btn9924.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9924.Location = new System.Drawing.Point(827, 334);
            this.btn9924.Margin = new System.Windows.Forms.Padding(4);
            this.btn9924.Name = "btn9924";
            this.btn9924.Size = new System.Drawing.Size(325, 114);
            this.btn9924.TabIndex = 6;
            this.btn9924.Text = "9.9.2.4\r\n闭合串联电弧故障时\r\n的正确动作";
            this.btn9924.UseVisualStyleBackColor = true;
            this.btn9924.Click += new System.EventHandler(this.btn9924_Click);
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
            // frm992
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1260, 736);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn9924);
            this.Controls.Add(this.btn9922);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btn9923);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1260, 736);
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "frm992";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm992";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn9923;
        private System.Windows.Forms.Button btnAFDD;
        private System.Windows.Forms.Button btnAFD;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn9922;
        private System.Windows.Forms.Button btn9924;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}