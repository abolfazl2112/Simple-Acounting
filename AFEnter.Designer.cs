namespace Apple_Software
{
    partial class AFEnter
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.MPassword = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.M1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.M2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.M3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.M4 = new System.Windows.Forms.ToolStripMenuItem();
            this.M4_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.M4_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.M5 = new System.Windows.Forms.ToolStripMenuItem();
            this.M5_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.M5_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CUsers = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(3, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 47);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(166, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "ESC   خروج";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(252, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "F2   ورود";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TPassword);
            this.groupBox1.Controls.Add(this.CUsers);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // TPassword
            // 
            this.TPassword.ContextMenuStrip = this.MPassword;
            this.TPassword.ForeColor = System.Drawing.Color.DarkViolet;
            this.TPassword.Location = new System.Drawing.Point(48, 59);
            this.TPassword.Name = "TPassword";
            this.TPassword.PasswordChar = 'o';
            this.TPassword.Size = new System.Drawing.Size(204, 21);
            this.TPassword.TabIndex = 237;
            this.TPassword.Text = "09155211257";
            this.TPassword.TextChanged += new System.EventHandler(this.TPassword_TextChanged);
            this.TPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TPassword_KeyDown);
            // 
            // MPassword
            // 
            this.MPassword.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M1,
            this.toolStripSeparator1,
            this.M2,
            this.toolStripSeparator2,
            this.M3,
            this.toolStripSeparator3,
            this.M4,
            this.toolStripSeparator4,
            this.M5});
            this.MPassword.Name = "MPassword";
            this.MPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MPassword.Size = new System.Drawing.Size(148, 138);
            // 
            // M1
            // 
            this.M1.Name = "M1";
            this.M1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.M1.Size = new System.Drawing.Size(147, 22);
            this.M1.Text = "کپی";
            this.M1.Click += new System.EventHandler(this.M1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // M2
            // 
            this.M2.Name = "M2";
            this.M2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.M2.Size = new System.Drawing.Size(147, 22);
            this.M2.Text = "انتقال";
            this.M2.Click += new System.EventHandler(this.M2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
            // 
            // M3
            // 
            this.M3.Name = "M3";
            this.M3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.M3.Size = new System.Drawing.Size(147, 22);
            this.M3.Text = "جایگزین";
            this.M3.Click += new System.EventHandler(this.M3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(144, 6);
            // 
            // M4
            // 
            this.M4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M4_1,
            this.toolStripSeparator5,
            this.M4_2});
            this.M4.Name = "M4";
            this.M4.Size = new System.Drawing.Size(147, 22);
            this.M4.Text = "زبان صفحه کلید";
            // 
            // M4_1
            // 
            this.M4_1.Checked = true;
            this.M4_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.M4_1.Name = "M4_1";
            this.M4_1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.M4_1.Size = new System.Drawing.Size(153, 22);
            this.M4_1.Text = "فارسی";
            this.M4_1.Click += new System.EventHandler(this.M4_1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(150, 6);
            // 
            // M4_2
            // 
            this.M4_2.Name = "M4_2";
            this.M4_2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.M4_2.Size = new System.Drawing.Size(153, 22);
            this.M4_2.Text = "انگلیسی";
            this.M4_2.Click += new System.EventHandler(this.M4_2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(144, 6);
            // 
            // M5
            // 
            this.M5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M5_1,
            this.toolStripSeparator6,
            this.M5_2});
            this.M5.Name = "M5";
            this.M5.Size = new System.Drawing.Size(147, 22);
            this.M5.Text = "حالت رمز ورودی";
            // 
            // M5_1
            // 
            this.M5_1.Name = "M5_1";
            this.M5_1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.M5_1.Size = new System.Drawing.Size(163, 22);
            this.M5_1.Text = "نمایش";
            this.M5_1.Click += new System.EventHandler(this.M5_1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(160, 6);
            // 
            // M5_2
            // 
            this.M5_2.Checked = true;
            this.M5_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.M5_2.Name = "M5_2";
            this.M5_2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.M5_2.Size = new System.Drawing.Size(163, 22);
            this.M5_2.Text = "عدم نمایش";
            this.M5_2.Click += new System.EventHandler(this.M5_2_Click);
            // 
            // CUsers
            // 
            this.CUsers.FormattingEnabled = true;
            this.CUsers.Location = new System.Drawing.Point(48, 32);
            this.CUsers.Name = "CUsers";
            this.CUsers.Size = new System.Drawing.Size(204, 21);
            this.CUsers.TabIndex = 236;
            this.CUsers.SelectedIndexChanged += new System.EventHandler(this.CUsers_SelectedIndexChanged);
            this.CUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CUsers_KeyDown);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Wingdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button6.ForeColor = System.Drawing.Color.BlueViolet;
            this.button6.Location = new System.Drawing.Point(10, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 22);
            this.button6.TabIndex = 235;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Webdings", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(10, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 24);
            this.label5.TabIndex = 234;
            this.label5.Text = "a";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(259, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = ": کلمه عبور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(258, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = ": نام کاربری";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apple_Software.Properties.Resources.Users;
            this.pictureBox1.Location = new System.Drawing.Point(307, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(220, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "شناسایی کاربر";
            // 
            // AFEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AFEnter";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AFEnter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AFEnter_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CUsers;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.ContextMenuStrip MPassword;
        private System.Windows.Forms.ToolStripMenuItem M1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem M2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem M3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem M4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem M5;
        private System.Windows.Forms.ToolStripMenuItem M4_1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem M4_2;
        private System.Windows.Forms.ToolStripMenuItem M5_1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem M5_2;
    }
}