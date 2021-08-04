using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using AnalogClockControl;

namespace Apple_Software
{
    public partial class MFApple : Form
    {
        public MFApple()
        {
            InitializeComponent();
        }

        public static int si = 0;
        private void MFTime_Tick(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            PersianCalendar ps = new PersianCalendar();
            LTime.Text = string.Format("|  {2} : {1} : {0}  | ", ps.GetHour(Time), ps.GetMinute(Time), ps.GetSecond(Time));
        }

        private void MFName_Tick(object sender, EventArgs e)
        {
            try
            {
                string Lstr = "نرم افزار حسابداری کارگاه تولیدی لولای آریا....";
                if (this.Text.ToString().Length < Lstr.Length)
                {
                    this.Text = Lstr.Substring(0, si) + "_";
                    si += 1;
                }
                else
                {
                    this.Text = "";
                    si = 0;
                }
            }
            catch { }
        }

        private void MFApple_Load(object sender, EventArgs e)
        {
            LData.Text = Data.Persian() + " |";
            LData1.Text = Data.English() + " |";
            User.Text = "کاربر فعال : " + AFEnter.User.ToString() + " |";

            getdate();
            
            AnalogClock Clock = new AnalogClock();
            Clock.Start();
        }

        private void getdate()
        {
            string date = "";
            PersianCalendar pc = new PersianCalendar();
            int d = pc.GetDayOfMonth(DateTime.Now);
            int m = pc.GetMonth(DateTime.Now);
            int y = pc.GetYear(DateTime.Now);
            date = y.ToString() + "/" + ((m < 10) ? "0" + m.ToString() : m.ToString()) + "/" + ((d < 10) ? "0" + d.ToString() : d.ToString());

            dataGridView1.DataSource = DataManagement.Search("SELECT [check].bank'نام بانک', shobe'شعبه', tarikh'تاریخ', mablagh'مبلغ' FROM [check] INNER JOIN factorforoosh ON [check].idfactor = factorforoosh.idfactor WHERE ([check].tarikh = N'" + date + "') AND (factorforoosh.typefactor = N'kh')");
            dataGridView2.DataSource = DataManagement.Search("SELECT [check].bank'نام بانک', shobe'شعبه', tarikh'تاریخ', mablagh'مبلغ' FROM [check] INNER JOIN factorforoosh ON [check].idfactor = factorforoosh.idfactor WHERE ([check].tarikh = N'" + date + "') AND (factorforoosh.typefactor = N'f')");
        }

        private void MFApple_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void M1_Click(object sender, EventArgs e)
        {
            AFPAdd AFPAdd = new AFPAdd();
            AFPAdd.ShowDialog();
        }

        private void M2_Click(object sender, EventArgs e)
        {
            AFKAdd AFKAdd = new AFKAdd();
            AFKAdd.ShowDialog();
        }

        private void M3_Click(object sender, EventArgs e)
        {
            AFWAdd AFWAdd = new AFWAdd();
            AFWAdd.ShowDialog();
        }

        private void M4_Click(object sender, EventArgs e)
        {
            AFEnter AFEnter = new AFEnter();
            AFEnter.ShowDialog();
            this.Hide();
        }

        private void M5_Click(object sender, EventArgs e)
        {
            close.Form(this);
        }

        private void N1_Click(object sender, EventArgs e)
        {
            if (MfSS.Visible == true)
                MfSS.Visible = false;
            else
                MfSS.Visible = true;
        }

        private void N2_Click(object sender, EventArgs e)
        {
            if (LData.Visible == true)
                LData.Visible = false;
            else
                LData.Visible = true;
        }

        private void N3_Click(object sender, EventArgs e)
        {
            if (LData1.Visible == true)
                LData1.Visible = false;
            else
                LData1.Visible = true;
        }

        private void N4_Click(object sender, EventArgs e)
        {
            if (User.Visible == true)
                User.Visible = false;
            else
                User.Visible = true;
        }

        private void N7_Click(object sender, EventArgs e)
        {
            if (LTime.Visible == true)
                LTime.Visible = false;
            else
                LTime.Visible = true;
        }

        private void N5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void N6_1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ODI = new OpenFileDialog();
            ODI.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            ODI.Filter = "Picture As jpg|*.jpg|Picture As jpeg|*.jpeg*|Picture As bmp|*.bmp|Picture As gif|*.gif|Picture As wmf|*.wmf|Picture As png|*.png";

            if (ODI.ShowDialog(this) == DialogResult.OK)
            {
                BackgroundImage = Image.FromFile(ODI.FileName);

            }
        }

        private void N6_2_Click(object sender, EventArgs e)
        {
            N6_2.Checked = true;
            N6_3.Checked = false;
            N6_4.Checked = false;
        }

        private void N6_3_Click(object sender, EventArgs e)
        {
            N6_2.Checked = false;
            N6_3.Checked = true;
            N6_4.Checked = false;
        }

        private void N6_4_Click(object sender, EventArgs e)
        {
            N6_2.Checked = false;
            N6_3.Checked = false;
            N6_4.Checked = true;
        }

        private void O1_Click(object sender, EventArgs e)
        {
            AFHWEnter AFHWEnter = new AFHWEnter();
            AFHWEnter.ShowDialog();
        }

        private void O2_Click(object sender, EventArgs e)
        {
            AFDHWEnter AFDHWEnter = new AFDHWEnter();
            AFDHWEnter.ShowDialog();
        }

        private void O3_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 9;
            AFPKW.ShowDialog();
        }

        private void O4_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 7;
            AFPKW.ShowDialog();
        }

        private void P1_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 3;
            AFPKW.ShowDialog();
        }

        private void P2_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 4;
            AFPKW.ShowDialog();
        }

        private void P3_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 5;
            AFPKW.ShowDialog();
        }

        private void Q1_Click(object sender, EventArgs e)
        {
            print p = new print();
            p.type = 1;
            p.ShowDialog(this);
        }

        

        private void Q2_Click(object sender, EventArgs e)
        {
            print p = new print();
            p.type = 2;
            p.ShowDialog(this);
        }

        private void U1_Click(object sender, EventArgs e)
        {
            AFHWEnter AFHWEnter = new AFHWEnter();
            AFHWEnter.ShowDialog();
        }

        private void U2_Click(object sender, EventArgs e)
        {
            AFDHWEnter AFDHWEnter = new AFDHWEnter();
            AFDHWEnter.ShowDialog();
        }

        private void U3_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 9;
            AFPKW.ShowDialog();
        }

        private void U4_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 7;
            AFPKW.ShowDialog();
        }

        private void U5_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 6;
            AFPKW.ShowDialog();
        }

        private void U6_Click(object sender, EventArgs e)
        {
            AFEnter AFEnter = new AFEnter();
            AFEnter.ShowDialog();
            this.Hide();
        }

        private void U8_Click(object sender, EventArgs e)
        {
            close.Form(this);
        }

        private void U7_1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ODI = new OpenFileDialog();
            ODI.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            ODI.Filter = "Picture As jpg|*.jpg|Picture As jpeg|*.jpeg*|Picture As bmp|*.bmp|Picture As gif|*.gif|Picture As wmf|*.wmf|Picture As png|*.png";

            if (ODI.ShowDialog(this) == DialogResult.OK)
            {
                BackgroundImage = Image.FromFile(ODI.FileName);
            }
        }

        private void U7_2_Click(object sender, EventArgs e)
        {
            N6_2.Checked = true;
            N6_3.Checked = false;
            N6_4.Checked = false;
        }

        private void U7_3_Click(object sender, EventArgs e)
        {
            N6_2.Checked = false;
            N6_3.Checked = true;
            N6_4.Checked = false;
        }

        private void U7_4_Click(object sender, EventArgs e)
        {
            N6_2.Checked = false;
            N6_3.Checked = false;
            N6_4.Checked = true;
        }

        private void MFApple_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "27")
                M4_Click(sender, e);
        }

        private void خریدکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kharid kh = new kharid();
            kh.ShowDialog(this);
        }

        private void فروشکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foroosh f = new foroosh();
            f.ShowDialog(this);
        }

        private void ورودمشخصاتکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moshtari m = new moshtari();
            m.ShowDialog(this);
        }

        private void جستجویمششتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 11;
            AFPKW.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ورودکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typekala k = new typekala();
            k.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saat s = new saat();
            s.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            close.Form(this);
        }

        private void جستجویفاکتورخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFKHF s = new SFKHF();
            s.typ = "kh";
            s.ShowDialog(this);
        }

        private void جستجویفاکتورفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFKHF s = new SFKHF();
            s.typ = "f";
            s.ShowDialog(this);
        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new about().ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AFHWEnter af = new AFHWEnter();
            af.ShowDialog(this);
        }

        private void گزارشماهیانهفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chap c = new chap();
            c.ShowDialog(this);
        }

        private void پیشفاکتورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new pish().ShowDialog(this); 
        }

        private void چکهایدریافتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new checks().ShowDialog(this);
        }

        private void M_DropDownOpened(object sender, EventArgs e)
        {
        }

        private void گزارشمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new repCustomer().ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new pardakhti().ShowDialog(this);
        }

        private void پرداختیبهکارگرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new pardakhti().ShowDialog(this);

        }

        private void پرداختیبهپیمانکار4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AFHWEnter af = new AFHWEnter();
            af.ShowDialog(this);
        }      
    }
}
