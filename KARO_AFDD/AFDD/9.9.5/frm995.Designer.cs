namespace KARO_AFDD
{
    partial class frm995
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm995));
            this.btn9954 = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn9952 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn9954
            // 
            this.btn9954.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9954.Location = new System.Drawing.Point(663, 334);
            this.btn9954.Margin = new System.Windows.Forms.Padding(4);
            this.btn9954.Name = "btn9954";
            this.btn9954.Size = new System.Drawing.Size(325, 114);
            this.btn9954.TabIndex = 0;
            this.btn9954.Text = "9.9.5.4\r\n带各种干扰负载的试验";
            this.btn9954.UseVisualStyleBackColor = true;
            this.btn9954.Click += new System.EventHandler(this.btn9954_Click);
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
            this.label1.Location = new System.Drawing.Point(257, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "9.9.5 带各种干扰负载的试验";
            // 
            // btn9952
            // 
            this.btn9952.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9952.Location = new System.Drawing.Point(272, 334);
            this.btn9952.Margin = new System.Windows.Forms.Padding(4);
            this.btn9952.Name = "btn9952";
            this.btn9952.Size = new System.Drawing.Size(325, 114);
            this.btn9952.TabIndex = 5;
            this.btn9952.Text = "9.9.5.2\r\n串扰测试";
            this.btn9952.UseVisualStyleBackColor = true;
            this.btn9952.Click += new System.EventHandler(this.btn9952_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 31);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frm995
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1260, 736);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn9952);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btn9954);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1260, 736);
            this.MinimumSize = new System.Drawing.Size(1260, 736);
            this.Name = "frm995";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm995";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn9954;
        private System.Windows.Forms.Button btnAFDD;
        private System.Windows.Forms.Button btnAFD;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn9952;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}