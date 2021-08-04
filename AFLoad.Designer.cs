namespace Apple_Software
{
    partial class AFLoad
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
            this.AFLProgressBar = new System.Windows.Forms.ProgressBar();
            this.AFLTimer1 = new System.Windows.Forms.Timer(this.components);
            this.AFLTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AFLProgressBar
            // 
            this.AFLProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AFLProgressBar.Location = new System.Drawing.Point(0, 264);
            this.AFLProgressBar.Name = "AFLProgressBar";
            this.AFLProgressBar.Size = new System.Drawing.Size(510, 24);
            this.AFLProgressBar.TabIndex = 6;
            // 
            // AFLTimer1
            // 
            this.AFLTimer1.Enabled = true;
            this.AFLTimer1.Interval = 1;
            this.AFLTimer1.Tick += new System.EventHandler(this.AFLTimer1_Tick);
            // 
            // AFLTimer
            // 
            this.AFLTimer.Interval = 20;
            this.AFLTimer.Tick += new System.EventHandler(this.AFLTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Apple_Software.Properties.Resources.Logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // AFLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 288);
            this.Controls.Add(this.AFLProgressBar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "AFLoad";
            this.Opacity = 0D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AFLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar AFLProgressBar;
        private System.Windows.Forms.Timer AFLTimer1;
        private System.Windows.Forms.Timer AFLTimer;
    }
}

