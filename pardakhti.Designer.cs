namespace Apple_Software
{
    partial class pardakhti
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMablagh = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.MaskedTextBox();
            this.lblDel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.ComboBox();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtMablagh);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.lblDel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(118, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 107);
            this.groupBox1.TabIndex = 328;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پرداختی";
            // 
            // txtMablagh
            // 
            this.txtMablagh.Location = new System.Drawing.Point(134, 75);
            this.txtMablagh.Name = "txtMablagh";
            this.txtMablagh.Size = new System.Drawing.Size(117, 21);
            this.txtMablagh.TabIndex = 324;
            this.txtMablagh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(6, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(245, 21);
            this.txtname.TabIndex = 323;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(171, 48);
            this.txtdate.Mask = "0000/00/00";
            this.txtdate.Name = "txtdate";
            this.txtdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdate.Size = new System.Drawing.Size(80, 21);
            this.txtdate.TabIndex = 322;
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtdate_MaskInputRejected);
            // 
            // lblDel
            // 
            this.lblDel.BackColor = System.Drawing.Color.Transparent;
            this.lblDel.Image = global::Apple_Software.Properties.Resources.error;
            this.lblDel.Location = new System.Drawing.Point(6, 66);
            this.lblDel.Name = "lblDel";
            this.lblDel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDel.Size = new System.Drawing.Size(43, 39);
            this.lblDel.TabIndex = 326;
            this.lblDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(257, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 314;
            this.label2.Text = "نام و نام خانوادگی";
            // 
            // lblAdd
            // 
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Image = global::Apple_Software.Properties.Resources.add;
            this.lblAdd.Location = new System.Drawing.Point(45, 65);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAdd.Size = new System.Drawing.Size(43, 39);
            this.lblAdd.TabIndex = 325;
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAdd.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(257, 79);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 319;
            this.label3.Text = "مبلغ پرداختی";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(104, 79);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 319;
            this.label7.Text = "ریال";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(257, 51);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 319;
            this.label6.Text = "تاریخ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(6, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 38);
            this.btnPrint.TabIndex = 327;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 61);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 40);
            this.btnExit.TabIndex = 323;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 17);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(461, 144);
            this.dataGridView3.TabIndex = 322;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(205, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 14);
            this.label18.TabIndex = 324;
            this.label18.Text = "پرداختی به کارگر";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(16, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 164);
            this.groupBox2.TabIndex = 329;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست پرداختی ها";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Location = new System.Drawing.Point(14, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(98, 107);
            this.groupBox3.TabIndex = 330;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtDay);
            this.groupBox4.Controls.Add(this.txtMonth);
            this.groupBox4.Controls.Add(this.txtYear);
            this.groupBox4.Location = new System.Drawing.Point(16, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 52);
            this.groupBox4.TabIndex = 331;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "جستجو";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 23);
            this.btnSearch.TabIndex = 321;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(206, 23);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 320;
            this.label9.Text = "روز";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(332, 23);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 320;
            this.label8.Text = "ماه";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(433, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 320;
            this.label1.Text = "سال";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDay
            // 
            this.txtDay.FormattingEnabled = true;
            this.txtDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.txtDay.Location = new System.Drawing.Point(147, 20);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(53, 21);
            this.txtDay.TabIndex = 0;
            this.txtDay.SelectedIndexChanged += new System.EventHandler(this.txtDay_SelectedIndexChanged);
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // txtMonth
            // 
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.txtMonth.Location = new System.Drawing.Point(236, 20);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(90, 21);
            this.txtMonth.TabIndex = 0;
            this.txtMonth.SelectedIndexChanged += new System.EventHandler(this.txtMonth_SelectedIndexChanged);
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.FormattingEnabled = true;
            this.txtYear.Items.AddRange(new object[] {
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400"});
            this.txtYear.Location = new System.Drawing.Point(359, 20);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(68, 21);
            this.txtYear.TabIndex = 0;
            this.txtYear.SelectedIndexChanged += new System.EventHandler(this.txtYear_SelectedIndexChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // pardakhti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apple_Software.Properties.Resources.Background_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 404);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label18);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pardakhti";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.pardakhti_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtdate;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtMablagh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtMonth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtDay;
    }
}