namespace Apple_Software
{
    partial class saat
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdastkol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtkols = new System.Windows.Forms.TextBox();
            this.txtdast = new System.Windows.Forms.TextBox();
            this.txtEnter = new System.Windows.Forms.MaskedTextBox();
            this.txtExit = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtshift = new System.Windows.Forms.ComboBox();
            this.txtdate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSabt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(236, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "ثبت ورود و خروج پرسنل";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfamily);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات پرسنلی";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "چاپ صورت حساب";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "لیست کارکرد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(239, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "نام";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(153, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(106, 22);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(376, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام خانوادگی";
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(265, 46);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(180, 22);
            this.txtfamily.TabIndex = 1;
            this.txtfamily.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtfamily.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(482, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "کد پرسنلی";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(451, 46);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(92, 22);
            this.txtcode.TabIndex = 0;
            this.txtcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcode_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtdastkol);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtkols);
            this.groupBox2.Controls.Add(this.txtdast);
            this.groupBox2.Controls.Add(this.txtEnter);
            this.groupBox2.Controls.Add(this.txtExit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtshift);
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تعیین ساعت و شیفت کاری روز ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(141, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 14);
            this.label11.TabIndex = 14;
            this.label11.Text = "کل دسمزد";
            // 
            // txtdastkol
            // 
            this.txtdastkol.Enabled = false;
            this.txtdastkol.Location = new System.Drawing.Point(6, 77);
            this.txtdastkol.Name = "txtdastkol";
            this.txtdastkol.Size = new System.Drawing.Size(129, 22);
            this.txtdastkol.TabIndex = 13;
            this.txtdastkol.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(481, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "کل ساعات";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(309, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "دستمزد هر ساعت";
            // 
            // txtkols
            // 
            this.txtkols.Enabled = false;
            this.txtkols.Location = new System.Drawing.Point(431, 77);
            this.txtkols.Name = "txtkols";
            this.txtkols.Size = new System.Drawing.Size(38, 22);
            this.txtkols.TabIndex = 10;
            this.txtkols.Text = "0";
            // 
            // txtdast
            // 
            this.txtdast.Enabled = false;
            this.txtdast.Location = new System.Drawing.Point(209, 77);
            this.txtdast.Name = "txtdast";
            this.txtdast.Size = new System.Drawing.Size(94, 22);
            this.txtdast.TabIndex = 4;
            this.txtdast.Text = "0";
            this.txtdast.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtEnter
            // 
            this.txtEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnter.Enabled = false;
            this.txtEnter.Location = new System.Drawing.Point(431, 49);
            this.txtEnter.Mask = "00";
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnter.Size = new System.Drawing.Size(38, 22);
            this.txtEnter.TabIndex = 2;
            this.txtEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnter.EnabledChanged += new System.EventHandler(this.txtEnter_EnabledChanged);
            this.txtEnter.Leave += new System.EventHandler(this.txtEnter_Leave);
            // 
            // txtExit
            // 
            this.txtExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExit.Enabled = false;
            this.txtExit.Location = new System.Drawing.Point(269, 49);
            this.txtExit.Mask = "00";
            this.txtExit.Name = "txtExit";
            this.txtExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExit.Size = new System.Drawing.Size(34, 22);
            this.txtExit.TabIndex = 3;
            this.txtExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExit.Leave += new System.EventHandler(this.txtExit_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(309, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "ساعت خروج";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(481, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "ساعت ورود";
            // 
            // txtshift
            // 
            this.txtshift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtshift.Enabled = false;
            this.txtshift.FormattingEnabled = true;
            this.txtshift.Items.AddRange(new object[] {
            "صبح",
            "عصر",
            "شب"});
            this.txtshift.Location = new System.Drawing.Point(209, 21);
            this.txtshift.Name = "txtshift";
            this.txtshift.Size = new System.Drawing.Size(94, 22);
            this.txtshift.TabIndex = 1;
            this.txtshift.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtshift_KeyDown);
            this.txtshift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtshift_KeyPress);
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.Enabled = false;
            this.txtdate.Location = new System.Drawing.Point(383, 21);
            this.txtdate.Mask = "0000/00/00";
            this.txtdate.Name = "txtdate";
            this.txtdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdate.Size = new System.Drawing.Size(86, 22);
            this.txtdate.TabIndex = 0;
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdate.EnabledChanged += new System.EventHandler(this.txtdate_EnabledChanged);
            this.txtdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdate_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(309, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "شیفت کاری";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(481, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "تاریخ";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(145, 437);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(123, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "حذف";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(274, 437);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSabt
            // 
            this.btnSabt.Location = new System.Drawing.Point(411, 437);
            this.btnSabt.Name = "btnSabt";
            this.btnSabt.Size = new System.Drawing.Size(150, 23);
            this.btnSabt.TabIndex = 5;
            this.btnSabt.Text = "جدید";
            this.btnSabt.UseVisualStyleBackColor = true;
            this.btnSabt.Click += new System.EventHandler(this.btnSabt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 178);
            this.groupBox3.TabIndex = 294;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "کارکرد ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 157);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(165, 114);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(390, 104);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            this.dataGridView2.Leave += new System.EventHandler(this.dataGridView2_Leave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 295;
            this.button3.Text = "پرداخت دستی";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apple_Software.Properties.Resources.Background_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 500);
            this.ControlBox = false;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSabt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "saat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.saat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtshift;
        private System.Windows.Forms.MaskedTextBox txtdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSabt;
        private System.Windows.Forms.MaskedTextBox txtExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtEnter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtkols;
        private System.Windows.Forms.TextBox txtdast;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdastkol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}