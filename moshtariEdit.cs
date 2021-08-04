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
    public partial class moshtariEdit : Form
    {
        public moshtariEdit()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox4.Text.ToString()) > 0 || Convert.ToInt32(textBox5.Text.ToString()) > 0)
                {
                    MessageBox.Show("مشتری مورد نظر دارای گردش مالی می باشد شما قادر به حذف آن نیستید", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    DialogResult resualt = MessageBox.Show("؟آیا می خواهید عملیات حذف را ادامه دهید", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resualt == DialogResult.Yes)
                    {
                        DataManagement.DT = DataManagement.I_U_D("select * from Properties", "delete from Properties where Properties.id=" + textBox1.Text.ToString() + "");
                        DataManagement.DT = DataManagement.I_U_D("select * from Hesab", "delete from Hesab where Id=" + textBox1.Text.ToString() + "");
                        this.Close();
                    }
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close.Form(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    }
                    catch { };
                    button1.Enabled = false;
                }
            }
        }

        public static string PictureLocation = "";
        private void button3_Click(object sender, EventArgs e)
        {
            int a = Picture.Pic(this);
            PictureLocation = Picture.Location.ToString();
            pictureBox2.ImageLocation = PictureLocation.ToString();
            button1.Enabled = true;
            textBox6.Focus();
        }

        private void moshtariEdit_Load(object sender, EventArgs e)
        {
            try
            {
                DataManagement.DT = DataManagement.Search("SELECT Id, Tid, Name, Family, Job, Tell_1, Tell_2, Mobile_1, Mobile_2, Address_1, Address_2, Picture, Dis FROM Properties WHERE (Id =" + DetectForm.Cod.ToString() + ")");
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
                DataManagement.DT = DataManagement.Search("SELECT TOP 1 * FROM Hesab WHERE (Id = " + DetectForm.Cod.ToString() + ") order by SHS desc");
                textBox4.Text = DataManagement.DT.Rows[0][5].ToString();
                textBox5.Text = DataManagement.DT.Rows[0][4].ToString();
            }
            catch { };

            this.Height = 442;
            this.Width = 448;
        }

        private void moshtariEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "114")
                button3_Click(sender, e);
            if (e.KeyValue.ToString() == "113")
                button1_Click(sender, e);
            if (e.KeyValue.ToString() == "115")
                button4_Click(sender, e);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13") button1.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            Control.Focus(textBox3, e);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13") button3.Focus();
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
    }
}
