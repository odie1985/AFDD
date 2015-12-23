namespace KARO_AFDD
{
    partial class frmAFD633
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAFD633));
            this.label1 = new System.Windows.Forms.Label();
            this.btn6331 = new System.Windows.Forms.Button();
            this.btn6332 = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(397, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 75);
            this.label1.TabIndex = 5;
            this.label1.Text = "6.3.3 误报警试验";
            // 
            // btn6331
            // 
            this.btn6331.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6331.Location = new System.Drawing.Point(302, 326);
            this.btn6331.Margin = new System.Windows.Forms.Padding(4);
            this.btn6331.Name = "btn6331";
            this.btn6331.Size = new System.Drawing.Size(265, 85);
            this.btn6331.TabIndex = 8;
            this.btn6331.Text = "6.3.3.1\r\n各种负载误报警试验";
            this.btn6331.UseVisualStyleBackColor = true;
            this.btn6331.Click += new System.EventHandler(this.btn6331_Click);
            // 
            // btn6332
            // 
            this.btn6332.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6332.Location = new System.Drawing.Point(694, 326);
            this.btn6332.Margin = new System.Windows.Forms.Padding(4);
            this.btn6332.Name = "btn6332";
            this.btn6332.Size = new System.Drawing.Size(265, 85);
            this.btn6332.TabIndex = 11;
            this.btn6332.Text = "6.3.3.2\r\n并联抗扰动试验";
            this.btn6332.UseVisualStyleBackColor = true;
            this.btn6332.Click += new System.EventHandler(this.btn6332_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.Location = new System.Drawing.Point(1107, 683);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(141, 41);
            this.btnReturnMain.TabIndex = 18;
            this.btnReturnMain.Text = "返回主菜单";
            this.btnReturnMain.UseVisualStyleBackColor = true;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 31);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmAFD633
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1260, 736);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btn6332);
            this.Controls.Add(this.btn6331);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1260, 736);
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "frmAFD633";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "4.2.2 误报警试验";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn6331;
        private System.Windows.Forms.Button btn6332;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}