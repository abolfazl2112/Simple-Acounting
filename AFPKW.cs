using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Apple_Software
{
    public partial class AFPKW : Form
    {
        public AFPKW()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DetectForm.F == 1 || DetectForm.F == 2 || DetectForm.F == 5 || DetectForm.F == 6 || DetectForm.F == 8 || DetectForm.F == 10)
                    DataManagement.DT = DataManagement.Search("select distinct Properties.id as [کد],Properties.Name as [نام],Properties.Family as [نام خانوادگی] from Properties where left(Properties.Tid,1)='W' and Properties.name like '" + textBox1.Text.ToString() + "%' and Properties.Family like '" + textBox2.Text.ToString() + "%' order by properties.Id");
                if (DetectForm.F == 3)
                    DataManagement.DT = DataManagement.Search("select distinct Properties.id as [کد],Properties.Name as [نام],Properties.Family as [نام خانوادگی] from Properties where left(Properties.Tid,1)='P' and Properties.name like '" + textBox1.Text.ToString() + "%' and Properties.Family like '" + textBox2.Text.ToString() + "%' order by properties.Id");
                if (DetectForm.F == 4)
                    DataManagement.DT = DataManagement.Search("select distinct Properties.id as [کد],Properties.Name as [نام],Properties.Family as [نام خانوادگی] from Properties where left(Properties.Tid,1)='U' and Properties.name like '" + textBox1.Text.ToString() + "%' and Properties.Family like '" + textBox2.Text.ToString() + "%' order by properties.Id");
                if (DetectForm.F == 7)
                    DataManagement.DT = DataManagement.Search("select Hesab.SHS as [شماره سند],Hesab.id as [کدکارگر],Hesab.Data as [تاریخ] from Hesab where Hesab.id like '" + textBox1.Text.ToString() + "%' and Hesab.SHS like '" + textBox2.Text.ToString() + "%' and Left(Hesab.Temp,1)='H' order by Hesab.Id");
                if (DetectForm.F == 9)
                    DataManagement.DT = DataManagement.Search("select Hesab.SHS as [شماره سند],Hesab.id as [کدکارگر],Hesab.Data as [تاریخ] from Hesab where Hesab.id like '" + textBox1.Text.ToString() + "%' and Hesab.SHS like '" + textBox2.Text.ToString() + "%' and Left(Hesab.Temp,1)='W' order by Hesab.Id");
                if (DetectForm.F == 11)
                    DataManagement.DT = DataManagement.Search("select distinct Properties.id as [کد],Properties.Name as [نام],Properties.Family as [نام خانوادگی] from Properties where left(Properties.Tid,1)='M' and Properties.name like '" + textBox1.Text.ToString() + "%' and Properties.Family like '" + textBox2.Text.ToString() + "%' order by properties.Id");

                dataGridView1.DataSource = DataManagement.DT;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DetectForm.Cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch { }
            if (DetectForm.Cod == "")
                MessageBox.Show(".لطفا شخص مورد نظر را انتخاب کنید", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (DetectForm.F == 1)
                {
                    AFHWEnter AFHWEnter = new AFHWEnter();
                    AFHWEnter.ShowDialog();
                    DetectForm.F = 0;
                    this.Close();
                }
                if (DetectForm.F == 2)
                {
                    AFDHWEnter AFDHWEnter = new AFDHWEnter();
                    AFDHWEnter.ShowDialog();
                    DetectForm.F = 0;
                    this.Close();
                }
                if (DetectForm.F == 3 || DetectForm.F == 4)
                {
                    AFPP AFPP = new AFPP();
                    AFPP.ShowDialog();
                    DetectForm.F = 0;
                    this.Close();
                }
                if (DetectForm.F == 5)
                {
                    AFPW AFPW = new AFPW();
                    AFPW.ShowDialog();
                    DetectForm.F = 0;
                    this.Close();
                }
                if (DetectForm.F == 6)
                {
                  //  AFCWH AFCWH = new AFCWH();
                    DetectForm.F = 0;
                    this.Close();
                  //  AFCWH.ShowDialog();
                }
                if (DetectForm.F == 7 || DetectForm.F == 8)
                {
                    AFS AFS = new AFS();
                    this.Close();
                    AFS.ShowDialog();
                }
                if (DetectForm.F == 9 || DetectForm.F == 10)
                {
                    AFSW AFSW = new AFSW();
                    this.Close();
                    AFSW.ShowDialog();
                }
                if (DetectForm.F == 11)
                {
                    moshtariEdit me = new moshtariEdit();
                    this.Close();
                    me.ShowDialog();
                }
            }
        }

        private void AFPKW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                button1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DetectForm.F == 1)
            {
                AFHWEnter AFHWEnter = new AFHWEnter();
                AFHWEnter.ShowDialog();
                DetectForm.F = 0;
                this.Close();
            }
            if (DetectForm.F == 2)
            {
                AFDHWEnter AFDHWEnter = new AFDHWEnter();
                AFDHWEnter.ShowDialog();
                DetectForm.F = 0;
                this.Close();
            }
            this.Close();                              
        }

        public static AFHWEnter AFHWEnter = new AFHWEnter();
        public bool flagDarj = false;
        private void AFPKW_Load(object sender, EventArgs e)
        {
            if (DetectForm.F == 7)
            {
                label1.Text = ": کد کارگر";
                label2.Text = ": شماره سند";
                textBox1.Width -= 20;
                label1.Left -= 20;
            }

            textBox1_TextChanged(sender, e);
            textBox1.Focus();

            this.Height = 358;
            this.Width = 344;

            if (flagDarj) darj.Visible = true;
        }

        public string code = "", name = "";
        private void darj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }
    }
}
