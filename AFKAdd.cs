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
    public partial class AFKAdd : Form
    {
        public AFKAdd()
        {
            InitializeComponent();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox3, e);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13") button3.Focus();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(TPassword, e);
        }

        private void TPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox6, e);
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox7, e);
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox8, e);
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox9, e);
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox10, e);
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox11, e);
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox12, e);
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox14, e);
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13") button1.Focus();
        }

        private void AFKAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "114")
                button3_Click(sender, e);
            if (e.KeyValue.ToString() == "113")
                button1_Click(sender, e);
        }

        public static string Tid = ""; 
        private void AFKAdd_Load(object sender, EventArgs e)
        {
            try
            {
                Tid = "";
                DataManagement.DT = DataManagement.Search("select Tid from properties where left(Tid,1)='U'");
                Tid = "U" + (DataManagement.DT.Rows.Count + 1).ToString();

                DataManagement.DT = DataManagement.Search("select Id from properties");
                textBox1.Text = (DataManagement.DT.Rows.Count + 1).ToString();
            }
            catch { }

            this.Height = 448;
            this.Width = 445;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close.Form(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                DialogResult resualt;
                resualt = MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a = 0;
                for (int i = 0; i < textBox7.Text.Length; i++)
                    if (!char.IsNumber(Convert.ToChar(textBox7.Text.Substring(i, 1))))
                        a = 1;
                for (int i = 0; i < textBox8.Text.Length; i++)
                    if (!char.IsNumber(Convert.ToChar(textBox8.Text.Substring(i, 1))))
                        a = 1;
                for (int i = 0; i < textBox9.Text.Length; i++)
                    if (!char.IsNumber(Convert.ToChar(textBox9.Text.Substring(i, 1))))
                        a = 1;
                for (int i = 0; i < textBox10.Text.Length; i++)
                    if (!char.IsNumber(Convert.ToChar(textBox10.Text.Substring(i, 1))))
                        a = 1;

                if (a == 1)
                {
                    MessageBox.Show("!لطفا در فیلد های تلفن یا موبایل عدد وارد کنید", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        DataManagement.DT = DataManagement.I_U_D("select * from Users", "Insert Into Users(Id,Aname,Password) Values(" + Convert.ToInt32(textBox1.Text.ToString()) + ",'" + textBox4.Text.ToString() + "','" + TPassword.Text.ToString() + "')");
                        DataManagement.DT = DataManagement.I_U_D("select * from Properties", "Insert Into Properties(Id,Tid,Name,Family,Job,Tell_1,Tell_2,Mobile_1,Mobile_2,Address_1,Address_2,Picture,Dis) Values(" + Convert.ToInt32(textBox1.Text.ToString()) + ",'" + Tid + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "','" + textBox9.Text.ToString() + "','" + textBox10.Text.ToString() + "','" + textBox11.Text.ToString() + "','" + textBox12.Text.ToString() + "','" + PictureLocation + "','" + textBox14.Text.ToString() + "')");
                        MessageBox.Show(". مشخصات کاربر جدید ثبت شد", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch { }
                }
            }
        }

        public static string PictureLocation = "";
        private void button3_Click(object sender, EventArgs e)
        {
            int a = Picture.Pic(this);
            pictureBox2.ImageLocation = Picture.Location;
            PictureLocation = Picture.Location;
            textBox4.Focus();
        }

    }
}
