namespace Apple_Software
{
    partial class pish
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
            this.btnSabt = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblKol = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnamemosh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodemosh = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnNewKala = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kalaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaVahed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalameghdar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalajam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSabt
            // 
            this.btnSabt.Location = new System.Drawing.Point(98, 393);
            this.btnSabt.Name = "btnSabt";
            this.btnSabt.Size = new System.Drawing.Size(80, 23);
            this.btnSabt.TabIndex = 310;
            this.btnSabt.Text = "چاپ";
            this.btnSabt.UseVisualStyleBackColor = true;
            this.btnSabt.Click += new System.EventHandler(this.btnSabt_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(513, 357);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 318;
            this.label15.Text = "تاریخ:";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(413, 351);
            this.txtdate.Mask = "0000/00/00";
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(94, 21);
            this.txtdate.TabIndex = 317;
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(15, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 14);
            this.label12.TabIndex = 316;
            this.label12.Text = "ریال";
            // 
            // lblKol
            // 
            this.lblKol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKol.BackColor = System.Drawing.Color.Transparent;
            this.lblKol.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKol.Location = new System.Drawing.Point(49, 349);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(157, 28);
            this.lblKol.TabIndex = 315;
            this.lblKol.Text = "0";
            this.lblKol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(215, 357);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 314;
            this.label14.Text = "مبلغ قابل پرداخت:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Apple_Software.Properties.Resources.error;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(275, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 112);
            this.button5.TabIndex = 311;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Image = global::Apple_Software.Properties.Resources.add;
            this.button4.Location = new System.Drawing.Point(275, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 109);
            this.button4.TabIndex = 309;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(272, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 14);
            this.label18.TabIndex = 313;
            this.label18.Text = "پیش فاکتور";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 312;
            this.btnExit.Text = "ESC   خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtnamemosh);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtcodemosh);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(107, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 38);
            this.groupBox3.TabIndex = 308;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(142, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 296;
            this.label2.Text = "نام مشتری";
            // 
            // txtnamemosh
            // 
            this.txtnamemosh.Enabled = false;
            this.txtnamemosh.Location = new System.Drawing.Point(6, 11);
            this.txtnamemosh.Name = "txtnamemosh";
            this.txtnamemosh.Size = new System.Drawing.Size(130, 21);
            this.txtnamemosh.TabIndex = 295;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(404, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 294;
            this.label1.Text = "کد مشتری";
            // 
            // txtcodemosh
            // 
            this.txtcodemosh.Location = new System.Drawing.Point(306, 11);
            this.txtcodemosh.Name = "txtcodemosh";
            this.txtcodemosh.Size = new System.Drawing.Size(93, 21);
            this.txtcodemosh.TabIndex = 288;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(270, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 23);
            this.button6.TabIndex = 287;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 247);
            this.groupBox2.TabIndex = 307;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست کالاهای موجد در انبار";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(200, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 14);
            this.label16.TabIndex = 295;
            this.label16.Text = "نام کالا";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 21);
            this.txtSearch.TabIndex = 289;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 41);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(254, 203);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnNewKala
            // 
            this.btnNewKala.Location = new System.Drawing.Point(21, 58);
            this.btnNewKala.Name = "btnNewKala";
            this.btnNewKala.Size = new System.Drawing.Size(80, 23);
            this.btnNewKala.TabIndex = 306;
            this.btnNewKala.Text = "کالای جدید";
            this.btnNewKala.UseVisualStyleBackColor = true;
            this.btnNewKala.Click += new System.EventHandler(this.btnNewKala_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(312, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 247);
            this.groupBox1.TabIndex = 305;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست کالاهای انتخابی";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kalaID,
            this.kalaName,
            this.kalaVahed,
            this.kalaprice,
            this.kalameghdar,
            this.kalajam});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(265, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // kalaID
            // 
            this.kalaID.HeaderText = "کد کالا";
            this.kalaID.Name = "kalaID";
            this.kalaID.Width = 65;
            // 
            // kalaName
            // 
            this.kalaName.HeaderText = "نام کالا";
            this.kalaName.Name = "kalaName";
            // 
            // kalaVahed
            // 
            this.kalaVahed.HeaderText = "واحد";
            this.kalaVahed.Name = "kalaVahed";
            // 
            // kalaprice
            // 
            this.kalaprice.HeaderText = "قیمت واحد";
            this.kalaprice.Name = "kalaprice";
            // 
            // kalameghdar
            // 
            this.kalameghdar.HeaderText = "مقدار";
            this.kalameghdar.Name = "kalameghdar";
            // 
            // kalajam
            // 
            this.kalajam.HeaderText = "جمع کل";
            this.kalajam.Name = "kalajam";
            // 
            // pish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apple_Software.Properties.Resources.Background_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 425);
            this.Controls.Add(this.btnSabt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblKol);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNewKala);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximizeBox = false;
            this.Name = "pish";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.pish_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSabt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblKol;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnamemosh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodemosh;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnNewKala;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaVahed;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalaprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalameghdar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalajam;


    }
}