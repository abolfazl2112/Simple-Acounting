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
    public partial class AFPP : Form
    {
        public AFPP()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
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
            Control.Focus(textBox5, e);
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resualt;
                if (DetectForm.F != 4)
                    resualt = MessageBox.Show("?آیا می خواهید پیمانکار مورد نظر را حذف کنید", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                else
                    resualt = MessageBox.Show("?آیا می خواهید کاربر مورد نظر را حذف کنید", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resualt == DialogResult.Yes)
                {
                    DataManagement.DT = DataManagement.I_U_D("select * from Properties where Properties.id=" + textBox1.Text.ToString() + "", "delete from Properties where Properties.id=" + textBox1.Text.ToString() + "");
                    DataManagement.DT = DataManagement.I_U_D("select * from Users where Users.id=" + textBox1.Text.ToString() + "", "delete from Users where Users.Id=" + textBox1.Text.ToString() + "");
                    MessageBox.Show("عملیات حذف انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                    DetectForm.F = 0;
                }
            }
            catch { };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" )
            {
                DialogResult resualt;
                resualt = MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("!لطفا در فیلد های تلفن یا موبایل عدد وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        DataManagement.DT = DataManagement.I_U_D("select * from Properties where Properties.id=" + textBox1.Text.ToString() + "", "Update Properties set Name='" + textBox2.Text.ToString() + "',Family='" + textBox3.Text.ToString() + "',job='" + textBox6.Text.ToString() + "',Tell_1='" + textBox7.Text.ToString() + "',Tell_2='" + textBox8.Text.ToString() + "',Mobile_1='" + textBox9.Text.ToString() + "',Mobile_2='" + textBox10.Text.ToString() + "',Address_1='" + textBox11.Text.ToString() + "',Address_2='" + textBox12.Text.ToString() + "',Picture='" + PictureLocation.ToString() + "',Dis='" + textBox14.Text.ToString() + "' where Properties.id=" + textBox1.Text.ToString() + "");
                        DataManagement.DT = DataManagement.I_U_D("select * from Users where Users.id=" + textBox1.Text.ToString() + "", "Update Users set Aname='" + textBox4.Text.ToString() + "',Password='" + textBox5.Text.ToString() + "' where Users.id=" + textBox1.Text.ToString() + "");

                    }
                    catch { };
                    MessageBox.Show("تغییرات انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    button1.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close.Form(this);
            DetectForm.F = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        public static string PictureLocation = "";
        private void AFPP_Load(object sender, EventArgs e)
        {

            if (DetectForm.F == 4)
                label18.Text = "مشخصات کاربر";
            button1.Enabled = false;
            try
            {
                DataManagement.DT = DataManagement.Search("SELECT Id, Tid, Name, Family, Job, Tell_1, Tell_2, Mobile_1, Mobile_2, Address_1, Address_2, Picture, Dis FROM Properties WHERE (Id = " + DetectForm.Cod.ToString() + ")");
                textBox1.Text = DetectForm.Cod.ToString();
                textBox2.Text = DataManagement.DT.Rows[0][2].ToString();
                textBox3.Text = DataManagement.DT.Rows[0][3].ToString();
                textBox6.Text = DataManagement.DT.Rows[0][4].ToString();
                textBox7.Text = DataManagement.DT.Rows[0][5].ToString();
                textBox8.Text = DataManagement.DT.Rows[0][6].ToString();
                textBox9.Text = DataManagement.DT.Rows[0][7].ToString();
                textBox10.Text = DataManagement.DT.Rows[0][8].ToString();
                textBox11.Text = DataManagement.DT.Rows[0][9].ToString();
                textBox12.Text = DataManagement.DT.Rows[0][10].ToString();
                PictureLocation = DataManagement.DT.Rows[0][11].ToString();
                textBox14.Text = DataManagement.DT.Rows[0][12].ToString();
                pictureBox2.ImageLocation = PictureLocation;
                DataManagement.DT = DataManagement.Search("SELECT Id, AName, Password FROM Users WHERE (Id = " + DetectForm.Cod.ToString() + ")");
                textBox4.Text = DataManagement.DT.Rows[0][1].ToString();
                textBox5.Text = DataManagement.DT.Rows[0][2].ToString();
            }
            catch { };
            this.Height = 442;
            this.Width = 445;
        }

        private void AFPP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "114")
                button3_Click(sender, e);
            if (e.KeyValue.ToString() == "113")
                button1_Click(sender, e);
            if (e.KeyValue.ToString() == "115")
                button4_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Picture.Pic(this);
            PictureLocation = Picture.Location.ToString();
            pictureBox2.ImageLocation = PictureLocation.ToString();
            button1.Enabled = true;
            textBox4.Focus();
        }
    }
}
