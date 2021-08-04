using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Apple_Software
{
    public partial class AFDHWEnter : Form
    {
        public AFDHWEnter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string code="", Name = "",sal = "", mah="",type="پیمانکار";
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO peyman (code,name, noe, tedad, ghimat, mablagh,mah,sal,type) VALUES (N'" + code + "',N'" + textBox5.Text + "', N'" + textBox1.Text + "', N'" + textBox2.Text + "', N'" + textBox3.Text + "', N'" + textBox4.Text + "',N'" + mah + "',N'" + sal + "',N'" + type + "')";
            DataManagement.I_U_D("select * from [check]", sql);
            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            this.Close();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = (double.Parse(textBox2.Text) * double.Parse(textBox3.Text)).ToString();
            }
            catch { }
        }

        
        private void AFDHWEnter_Load(object sender, EventArgs e)
        {
            textBox5.Text = Name;
        }
    }
}
