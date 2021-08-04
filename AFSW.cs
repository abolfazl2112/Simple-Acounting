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
    public partial class AFSW : Form
    {
        public AFSW()
        {
            InitializeComponent();
        }

        private void AFSW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "114")
                button1_Click(sender, e);
            if (e.KeyValue.ToString() == "113")
                button5_Click(sender, e);
            if (e.KeyValue.ToString() == "115")
                button4_Click(sender, e);
        }

        public static string DId = "";
        public static string TId = "";
        public static string Id = "";
        public static string Cod = "";
        public static string TData = "";
        public static string TPrice = "";
        public static string Dis = "";
        public static string Time = "";
        public static string Temp = "";
        private void AFSW_Load(object sender, EventArgs e)
        {
            this.Height = 318;
            this.Width = 506;
            if (DetectForm.F == 9)
            {
                button5.Enabled = false;
                Cod = DetectForm.Cod.ToString();
                DataManagement.DT = DataManagement.Search("Select Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis,Properties.Name,Properties.Family,Properties.Picture,Time.Id,Time.Time,Time.Price From Hesab,Properties,Time where Hesab.Id=Properties.Id and Hesab.SHS=Time.Id and Hesab.SHS='" + DetectForm.Cod.ToString() + "' and Hesab.Temp Like 'W%'");
                DId = TId = Id = DataManagement.DT.Rows[0][0].ToString();
                textBox1.Text = DataManagement.DT.Rows[0][1].ToString();
                textBox2.Text = DataManagement.DT.Rows[0][7].ToString();
                textBox3.Text = DataManagement.DT.Rows[0][8].ToString();
                textBox4.Text = TData = DataManagement.DT.Rows[0][2].ToString();
                numericUpDown1.Value = Convert.ToInt32(DataManagement.DT.Rows[0][11]);
                Time = DataManagement.DT.Rows[0][11].ToString();
                textBox6.Text = TPrice = DataManagement.DT.Rows[0][12].ToString();
                textBox7.Text = Dis = DataManagement.DT.Rows[0][6].ToString();
                pictureBox2.ImageLocation = DataManagement.DT.Rows[0][9].ToString();
                textBox5.Text = (Convert.ToInt64(textBox6.Text) / Convert.ToInt64(numericUpDown1.Value)).ToString();
            }
            if (DetectForm.F == 10)
            {
                button1.Enabled = false;
                button4.Enabled = false;
                DataManagement.DT = DataManagement.Search("Select Properties.id,Properties.name,Properties.family,Properties.Picture from Properties where Properties.id='" + DetectForm.Cod.ToString() + "'");
                Id = DataManagement.DT.Rows[0][0].ToString();
                textBox2.Text = DataManagement.DT.Rows[0][1].ToString();
                textBox3.Text = DataManagement.DT.Rows[0][2].ToString();
                pictureBox2.ImageLocation = DataManagement.DT.Rows[0][3].ToString();

                textBox1.Text = Cod;
                textBox4.Text = TData;
                numericUpDown1.Value = Convert.ToInt32(Time);
                textBox6.Text = TPrice;
                textBox5.Text = (Convert.ToInt64(textBox6.Text) / Convert.ToInt64(numericUpDown1.Value)).ToString();
                textBox7.Text = Dis;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 10;
            this.Close();
            AFPKW.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = 0;

                if (textBox5.Text.ToString().Length >= 1)
                {
                    for (int i = 0; i < textBox5.Text.Length; i++)
                    {
                        if (!char.IsNumber(Convert.ToChar(textBox5.Text.Substring(i, 1))))
                            a = 1;
                    }
                    if (a == 1)
                    {
                        MessageBox.Show("!لطفا عدد وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox5.Select(0, textBox5.Text.Length);
                        textBox5.Focus();
                    }
                    else
                    {
                        if (radioButton2.Checked == true)
                        {
                            textBox6.Text = textBox5.Text.ToString();
                            textBox7.Text = ".مبلغ  " + textBox6.Text.ToString() + " ریال بابت " + numericUpDown1.Text.ToString() + " ساعت کار روزانه واریز شد ";
                        }
                        else
                        {
                            textBox6.Text = (Convert.ToInt64(numericUpDown1.Text) * Convert.ToInt64(textBox5.Text)).ToString();
                            textBox7.Text = ".مبلغ  " + textBox6.Text.ToString() + " ریال بابت " + numericUpDown1.Text.ToString() + " ساعت کار روزانه واریز شد ";
                        }
                    }
                }
            }
            catch { };
        }

        public static string SHS = "";
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                decimal Bed = 0;
                decimal Bes = 0;
                DialogResult DR = new DialogResult();
                DR = MessageBox.Show("آیا می خواهید سند موجود به نام کاربر مورد نظر شما وارد شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    DataManagement.DT = DataManagement.Search("select top 1 * from Hesab Order by SHS desc");
                    if (DataManagement.DT.Rows.Count > 0)
                        SHS = (Convert.ToInt32(DataManagement.DT.Rows[0][1].ToString()) + 1).ToString();
                    else
                        SHS = "1";

                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                    {
                        DialogResult resualt;
                        resualt = MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataManagement.DT = DataManagement.Search("select * from Hesab where Id=" + Id + "");
                        if (Convert.ToInt32(DataManagement.DT.Rows.Count.ToString()) > 0)
                        {
                            DataManagement.DT = DataManagement.Search("select top 1 * from Hesab where Id=" + Id + " order by SHS desc");

                            Bed = Convert.ToInt64(DataManagement.DT.Rows[0][4]);
                            Bes = Convert.ToInt64(DataManagement.DT.Rows[0][5]);

                            if (Bed != 0)
                            {
                                Bed = Bed - Convert.ToInt64(textBox6.Text);
                                if (Bed == 0)
                                {
                                    Bed = 0;
                                    Bes = 0;
                                }
                                else if (Bed < 0)
                                {
                                    Bes = -(Bed);
                                    Bed = 0;
                                }
                                else Bes = 0;
                            }
                            else
                            {
                                Bed = 0;
                                Bes = Bes + Convert.ToInt64(textBox6.Text);
                            }
                            DataManagement.DT = DataManagement.I_U_D("select * from Hesab where Id=" + Id + "", "Insert Into Hesab(Id,SHS,Data,Temp,Bed,Bes,Dis) Values(" + Id + "," + SHS + ",'" + textBox4.Text.ToString() + "','" + "WT" + textBox6.Text.ToString() + "'," + Bed + "," + Bes + ",'" + textBox7.Text.ToString() + "')");
                            DataManagement.DT = DataManagement.I_U_D("select * From Time", "Insert Into Time(Id,Time,Price) Values(" + SHS + "," + numericUpDown1.Value.ToString() + "," + textBox6.Text.ToString() + ")");
                        }
                        else
                        {
                            DataManagement.DT = DataManagement.I_U_D("select * from Hesab where Id=" + Id + "", "Insert Into Hesab(Id,SHS,Data,Temp,Bed,Bes,Dis) Values(" + Id + "," + SHS + ",'" + textBox4.Text.ToString() + "','" + "WT" + textBox6.Text.ToString() + "',0," + textBox6.Text.ToString() + ",'" + textBox7.Text.ToString() + "')");
                            DataManagement.DT = DataManagement.I_U_D("select * From Time", "Insert Into Time(Id,Time,Price) Values(" + SHS + "," + numericUpDown1.Value.ToString() + "," + textBox6.Text.ToString() + ")");
                        }
                    }
                    MessageBox.Show(".ساعت کاری جدید با شماره سند " + SHS + " ثبت شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DR = MessageBox.Show("آیا می خواهید سند قبلی حذف شود ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes) button4_Click(sender, e);

                DetectForm.F = 0;
                DetectForm.Cod = "";
                this.Close();
            }
            catch { };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal Bed = 0;
                decimal Bes = 0;
                int Cuont = 0;
                if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    DialogResult resualt;
                    resualt = MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", "Error To Insert Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataManagement.DT = DataManagement.Search("Select * from Hesab where Hesab.Id='" + TId + "' order by Hesab.SHS ASC");
                    if (DataManagement.DT.Rows[0][1].ToString() == textBox1.Text.ToString())
                    {
                        Temp = "WT" + textBox6.Text.ToString();
                        DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + TId + ",Hesab.SHS=" + textBox1.Text.ToString() + ",Hesab.Data='" + textBox4.Text.ToString() + "',Hesab.Temp='" + Temp + "',Bed=0,Bes=" + textBox6.Text.ToString() + ",Dis='" + textBox7.Text.ToString() + "' where Hesab.SHS=" + textBox1.Text.ToString() + "");
                        DataManagement.DT = DataManagement.I_U_D("Select * from Time", "Update Time Set Time.Id=" + textBox1.Text.ToString() + ",Time.Time=" + numericUpDown1.Value.ToString() + ",Time.Price=" + textBox6.Text.ToString() + " where Time.Id=" + textBox1.Text.ToString() + "");
                    }
                    else
                    {
                        DataManagement.DT = DataManagement.Search("SELECT top 1 Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + TId + "' and Hesab.SHS < '" + textBox1.Text.ToString() + "' order by Hesab.SHS DESC");

                        Bed = Convert.ToInt64(DataManagement.DT.Rows[0][4]);
                        Bes = Convert.ToInt64(DataManagement.DT.Rows[0][5]);

                        if (Bed != 0)
                        {
                            Bed = Bed - Convert.ToInt64(textBox6.Text);
                            if (Bed == 0)
                            {
                                Bed = 0;
                                Bes = 0;
                            }
                            else if (Bed < 0)
                            {
                                Bes = -(Bed);
                                Bed = 0;
                            }
                            else Bes = 0;

                            Temp = "WT" + textBox6.Text.ToString();
                            DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + TId + ",Hesab.SHS=" + textBox1.Text.ToString() + ",Hesab.Data='" + textBox4.Text.ToString() + "',Hesab.Temp='" + Temp + "',Bed=" + Bed + ",Bes=" + Bes + ",Dis='" + textBox7.Text.ToString() + "' where Hesab.SHS=" + textBox1.Text.ToString() + "");
                            DataManagement.DT = DataManagement.I_U_D("Select * from Time", "Update Time Set Time.Id=" + textBox1.Text.ToString() + ",Time.Time=" + numericUpDown1.Value.ToString() + ",Time.Price=" + textBox6.Text.ToString() + " where Time.Id=" + textBox1.Text.ToString() + "");
                        }
                        else if (Bes != 0)
                        {
                            Temp = "WT" + textBox6.Text.ToString();
                            DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + TId + ",Hesab.SHS=" + textBox1.Text.ToString() + ",Hesab.Data='" + textBox4.Text.ToString() + "',Hesab.Temp='" + Temp + "',Bed=0,Bes=" + (Convert.ToInt64(textBox6.Text) + Bes).ToString() + ",Dis='" + textBox7.Text.ToString() + "' where Hesab.SHS=" + textBox1.Text.ToString() + "");
                            DataManagement.DT = DataManagement.I_U_D("Select * from Time", "Update Time Set Time.Id=" + textBox1.Text.ToString() + ",Time.Time=" + numericUpDown1.Value.ToString() + ",Time.Price=" + textBox6.Text.ToString() + " where Time.Id=" + textBox1.Text.ToString() + "");
                        }
                        else
                        {
                            Temp = "WT" + textBox6.Text.ToString();
                            DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + TId + ",Hesab.SHS=" + textBox1.Text.ToString() + ",Hesab.Data='" + textBox4.Text.ToString() + "',Hesab.Temp='" + Temp + "',Bed=0,Bes=" + textBox6.Text.ToString() + ",Dis='" + textBox7.Text.ToString() + "' where Hesab.SHS=" + textBox1.Text.ToString() + "");
                            DataManagement.DT = DataManagement.I_U_D("Select * from Time", "Update Time Set Time.Id=" + textBox1.Text.ToString() + ",Time.Time=" + numericUpDown1.Value.ToString() + ",Time.Price=" + textBox6.Text.ToString() + " where Time.Id=" + textBox1.Text.ToString() + "");
                        }
                    }
                    DataManagement.DT = DataManagement.Search("SELECT Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + TId + "' and Hesab.SHS >= '" + textBox1.Text.ToString() + "' order by Hesab.SHS ASC");
                    Cuont = Convert.ToInt32(DataManagement.DT.Rows.Count.ToString());
                    if (Cuont > 1)
                    {
                        for (int i = 1; i < (Cuont); i++)
                        {
                            if (DataManagement.DT.Rows[i][3].ToString().Substring(0, 1) == "W")
                            {
                                Bed = Convert.ToInt64(DataManagement.DT.Rows[i - 1][4]);
                                Bes = Convert.ToInt64(DataManagement.DT.Rows[i - 1][5]);
                                if (Bed != 0)
                                {
                                    Bed = Bed - Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                    if (Bed < 0)
                                    {
                                        Bes = -(Bed);
                                        Bed = 0;
                                    }
                                    else if (Bed == 0)
                                    {
                                        Bed = 0;
                                        Bes = 0;
                                    }
                                    else Bes = 0;
                                }
                                else
                                {
                                    Bed = 0;
                                    Bes = Bes + Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                }
                                DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DataManagement.DT.Rows[i][0].ToString() + ",Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[i][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[i][3].ToString() + "',Hesab.Bed=" + Bed + ",Hesab.Bes=" + Bes + ",Hesab.Dis='" + DataManagement.DT.Rows[i][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + "");
                                DataManagement.DT = DataManagement.Search("SELECT Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + TId + "' and Hesab.SHS >= '" + textBox1.Text.ToString() + "' order by Hesab.SHS ASC");
                            }
                            if (DataManagement.DT.Rows[i][3].ToString().Substring(0, 1) == "H")
                            {
                                if (DataManagement.DT.Rows[i][3].ToString().Substring(1, 1) == "T")
                                {
                                    Bed = Convert.ToInt64(DataManagement.DT.Rows[i - 1][4]);
                                    Bes = Convert.ToInt64(DataManagement.DT.Rows[i - 1][5]);
                                    if (Bed != 0)
                                    {
                                        Bed = Bed - Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                        if (Bed < 0)
                                        {
                                            Bes = -(Bed);
                                            Bed = 0;
                                        }
                                        else if (Bed == 0)
                                        {
                                            Bed = 0;
                                            Bes = 0;
                                        }
                                        else Bes = 0;
                                    }
                                    else
                                    {
                                        Bed = 0;
                                        Bes = Bes + Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                    }
                                    DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DataManagement.DT.Rows[i][0].ToString() + ",Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[i][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[i][3].ToString() + "',Hesab.Bed=" + Bed + ",Hesab.Bes=" + Bes + ",Hesab.Dis='" + DataManagement.DT.Rows[i][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + "");
                                    DataManagement.DT = DataManagement.Search("SELECT Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + TId + "' and Hesab.SHS >= '" + textBox1.Text.ToString() + "' order by Hesab.SHS ASC");
                                }
                                if (DataManagement.DT.Rows[i][3].ToString().Substring(1, 1) == "B")
                                {
                                    Bed = Convert.ToInt64(DataManagement.DT.Rows[i - 1][4]);
                                    Bes = Convert.ToInt64(DataManagement.DT.Rows[i - 1][5]);
                                    if (Bes != 0)
                                    {
                                        Bes = Bes - Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                        if (Bes < 0)
                                        {
                                            Bed = -(Bes);
                                            Bes = 0;
                                        }
                                        else if (Bes == 0)
                                        {
                                            Bed = 0;
                                            Bes = 0;
                                        }
                                        else Bed = 0;
                                    }
                                    else
                                    {
                                        Bes = 0;
                                        Bed = Bed + Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                    }
                                    DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DataManagement.DT.Rows[i][0].ToString() + ",Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[i][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[i][3].ToString() + "',Hesab.Bed=" + Bed + ",Hesab.Bes=" + Bes + ",Hesab.Dis='" + DataManagement.DT.Rows[i][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + "");
                                    DataManagement.DT = DataManagement.Search("SELECT Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + TId + "' and Hesab.SHS >= '" + textBox1.Text.ToString() + "' order by Hesab.SHS ASC");
                                }
                            }
                        }
                    }
                    MessageBox.Show(" سند با شماره" + DetectForm.Cod.ToString() + " تغییر یافت", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch { };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal Bed = 0;
            decimal Bes = 0;
            int Cuont = 0;

            try
            {
                DataManagement.DT = DataManagement.Search("Select top 1 * from Hesab where Hesab.Id='" + DId + "' order by Hesab.SHS DESC");
                if (DataManagement.DT.Rows[0][1].ToString() != textBox1.Text.ToString())
                {
                    DataManagement.DT = DataManagement.Search("Select * from Hesab where Hesab.Id='" + DId + "' order by Hesab.SHS ASC");
                    if (DataManagement.DT.Rows[0][1].ToString() == textBox1.Text.ToString() && Convert.ToInt64(DataManagement.DT.Rows.Count) > 1)
                    {
                        if (DataManagement.DT.Rows[1][3].ToString().Substring(1, 1) == "B")
                        {
                            DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DId + ",Hesab.SHS=" + DataManagement.DT.Rows[1][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[1][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[1][3].ToString() + "',Bed=" + DataManagement.DT.Rows[1][3].ToString().Substring(2, DataManagement.DT.Rows[1][3].ToString().Length - 2) + ",Bes=0,Dis='" + DataManagement.DT.Rows[1][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[1][1].ToString() + "");
                        }
                        else if (DataManagement.DT.Rows[1][3].ToString().Substring(1, 1) == "T")
                        {
                            DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DId + ",Hesab.SHS=" + DataManagement.DT.Rows[1][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[1][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[1][3].ToString() + "',Bed=0,Bes=" + DataManagement.DT.Rows[1][3].ToString().Substring(2, DataManagement.DT.Rows[1][3].ToString().Length - 2) + ",Dis='" + DataManagement.DT.Rows[1][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[1][1].ToString() + "");
                        }
                    }
                    else
                    {
                        DataManagement.DT = DataManagement.Search("SELECT top 1 Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + DId + "' and Hesab.SHS < '" + textBox1.Text.ToString() + "' order by Hesab.SHS DESC");

                        Bed = Convert.ToInt64(DataManagement.DT.Rows[0][4]);
                        Bes = Convert.ToInt64(DataManagement.DT.Rows[0][5]);

                        DataManagement.DT = DataManagement.Search("SELECT top 1 Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + DId + "' and Hesab.SHS > '" + textBox1.Text.ToString() + "' order by Hesab.SHS ASC");
                        Temp = DataManagement.DT.Rows[0][3].ToString();

                        if (Temp.Substring(0, 1) == "W")
                        {
                            if (Bed != 0)
                            {
                                Bed = Bed - Convert.ToInt64(Temp.Substring(2, Temp.Length - 2));
                                if (Bed < 0)
                                {
                                    Bes = -(Bed);
                                    Bed = 0;
                                }
                                else if (Bed == 0)
                                {
                                    Bed = 0;
                                    Bes = 0;
                                }
                                else Bes = 0;
                            }
                            else
                            {
                                Bed = 0;
                                Bes = Bes + Convert.ToInt64(Temp.Substring(2, Temp.Length - 2));
                            }
                            DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DataManagement.DT.Rows[0][0].ToString() + ",Hesab.SHS=" + DataManagement.DT.Rows[0][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[0][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[0][3].ToString() + "',Hesab.Bed=" + Bed + ",Hesab.Bes=" + Bes + ",Hesab.Dis='" + DataManagement.DT.Rows[0][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[0][1].ToString() + "");
                            DataManagement.DT = DataManagement.Search("SELECT * from Hesab");
                        }

                        if (Temp.Substring(0, 1) == "H")
                        {
                            if (Temp.Substring(1, 1) == "T")
                            {
                                if (Bed != 0)
                                {
                                    Bed = Bed - Convert.ToInt64(Temp.Substring(2, Temp.Length - 2));
                                    if (Bed < 0)
                                    {
                                        Bes = -(Bed);
                                        Bed = 0;
                                    }
                                    else if (Bed == 0)
                                    {
                                        Bed = 0;
                                        Bes = 0;
                                    }
                                    else Bes = 0;
                                }
                                else
                                {
                                    Bed = 0;
                                    Bes = Bes + Convert.ToInt64(Temp.Substring(2, Temp.Length - 2));
                                }
                                DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DataManagement.DT.Rows[0][0].ToString() + ",Hesab.SHS=" + DataManagement.DT.Rows[0][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[0][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[0][3].ToString() + "',Hesab.Bed=" + Bed + ",Hesab.Bes=" + Bes + ",Hesab.Dis='" + DataManagement.DT.Rows[0][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[0][1].ToString() + "");
                                DataManagement.DT = DataManagement.Search("SELECT * from Hesab");
                            }
                            if (Temp.Substring(1, 1) == "B")
                            {
                                if (Bes != 0)
                                {
                                    Bes = Bes - Convert.ToInt64(Temp.Substring(2, Temp.Length - 2));
                                    if (Bes < 0)
                                    {
                                        Bed = -(Bes);
                                        Bes = 0;
                                    }
                                    else if (Bes == 0)
                                    {
                                        Bed = 0;
                                        Bes = 0;
                                    }
                                    else Bed = 0;
                                }
                                else
                                {
                                    Bes = 0;
                                    Bed = Bed + Convert.ToInt64(Temp.Substring(2, Temp.Length - 2));
                                }
                                DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DataManagement.DT.Rows[0][0].ToString() + ",Hesab.SHS=" + DataManagement.DT.Rows[0][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[0][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[0][3].ToString() + "',Hesab.Bed=" + Bed + ",Hesab.Bes=" + Bes + ",Hesab.Dis='" + DataManagement.DT.Rows[0][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[0][1].ToString() + "");
                                DataManagement.DT = DataManagement.Search("SELECT * from Hesab");
                            }
                        }
                    }

                    DataManagement.DT = DataManagement.Search("SELECT Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + DId + "' and Hesab.SHS > '" + textBox1.Text.ToString() + "' order by Hesab.SHS ASC");
                    Cuont = Convert.ToInt32(DataManagement.DT.Rows.Count.ToString());

                    if (Cuont > 1)
                    {
                        for (int i = 1; i < (Cuont); i++)
                        {
                            if (DataManagement.DT.Rows[i][3].ToString().Substring(0, 1) == "W")
                            {
                                Bed = Convert.ToInt64(DataManagement.DT.Rows[i - 1][4]);
                                Bes = Convert.ToInt64(DataManagement.DT.Rows[i - 1][5]);
                                if (Bed != 0)
                                {
                                    Bed = Bed - Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                    if (Bed < 0)
                                    {
                                        Bes = -(Bed);
                                        Bed = 0;
                                    }
                                    else if (Bed == 0)
                                    {
                                        Bed = 0;
                                        Bes = 0;
                                    }
                                    else Bes = 0;
                                }
                                else
                                {
                                    Bed = 0;
                                    Bes = Bes + Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                }
                                DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DataManagement.DT.Rows[i][0].ToString() + ",Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[i][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[i][3].ToString() + "',Hesab.Bed=" + Bed + ",Hesab.Bes=" + Bes + ",Hesab.Dis='" + DataManagement.DT.Rows[i][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + "");
                                DataManagement.DT = DataManagement.Search("SELECT Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + DId + "' and Hesab.SHS > '" + textBox1.Text.ToString() + "' order by Hesab.SHS ASC");
                            }
                            if (DataManagement.DT.Rows[i][3].ToString().Substring(0, 1) == "H")
                            {
                                if (DataManagement.DT.Rows[i][3].ToString().Substring(1, 1) == "T")
                                {
                                    Bed = Convert.ToInt64(DataManagement.DT.Rows[i - 1][4]);
                                    Bes = Convert.ToInt64(DataManagement.DT.Rows[i - 1][5]);
                                    if (Bed != 0)
                                    {
                                        Bed = Bed - Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                        if (Bed < 0)
                                        {
                                            Bes = -(Bed);
                                            Bed = 0;
                                        }
                                        else if (Bed == 0)
                                        {
                                            Bed = 0;
                                            Bes = 0;
                                        }
                                        else Bes = 0;
                                    }
                                    else
                                    {
                                        Bed = 0;
                                        Bes = Bes + Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                    }
                                    DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DataManagement.DT.Rows[i][0].ToString() + ",Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[i][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[i][3].ToString() + "',Hesab.Bed=" + Bed + ",Hesab.Bes=" + Bes + ",Hesab.Dis='" + DataManagement.DT.Rows[i][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + "");
                                    DataManagement.DT = DataManagement.Search("SELECT Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + DId + "' and Hesab.SHS > '" + textBox1.Text.ToString() + "' order by Hesab.SHS ASC");
                                }
                                if (DataManagement.DT.Rows[i][3].ToString().Substring(1, 1) == "B")
                                {
                                    Bed = Convert.ToInt64(DataManagement.DT.Rows[i - 1][4]);
                                    Bes = Convert.ToInt64(DataManagement.DT.Rows[i - 1][5]);
                                    if (Bes != 0)
                                    {
                                        Bes = Bes - Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                        if (Bes < 0)
                                        {
                                            Bed = -(Bes);
                                            Bes = 0;
                                        }
                                        else if (Bes == 0)
                                        {
                                            Bed = 0;
                                            Bes = 0;
                                        }
                                        else Bed = 0;
                                    }
                                    else
                                    {
                                        Bes = 0;
                                        Bed = Bed + Convert.ToInt64(DataManagement.DT.Rows[i][3].ToString().Substring(2, DataManagement.DT.Rows[i][3].ToString().Length - 2));
                                    }
                                    DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Update Hesab Set Hesab.id=" + DataManagement.DT.Rows[i][0].ToString() + ",Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + ",Hesab.Data='" + DataManagement.DT.Rows[i][2].ToString() + "',Hesab.Temp='" + DataManagement.DT.Rows[i][3].ToString() + "',Hesab.Bed=" + Bed + ",Hesab.Bes=" + Bes + ",Hesab.Dis='" + DataManagement.DT.Rows[i][6].ToString() + "' where Hesab.SHS=" + DataManagement.DT.Rows[i][1].ToString() + "");
                                    DataManagement.DT = DataManagement.Search("SELECT Hesab.Id,Hesab.SHS,Hesab.Data,Hesab.Temp,Hesab.Bed,Hesab.Bes,Hesab.Dis FROM Hesab WHERE Hesab.id='" + DId + "' and Hesab.SHS > '" + textBox1.Text.ToString() + "' order by Hesab.SHS ASC");
                                }
                            }
                        }
                    }
                }
            }
            catch { };
            DataManagement.DT = DataManagement.I_U_D("Select * from Hesab", "Delete Hesab where Hesab.SHS = " + textBox1.Text.ToString() + "");
            DataManagement.DT = DataManagement.I_U_D("Select * from Time", "Delete Time Where Time.id=" + textBox1.Text.ToString() + "");
            MessageBox.Show(" سند با شماره" + textBox1.Text.ToString() + " حذف شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetectForm.F = 0;
            this.Close();
        }
    }
}
