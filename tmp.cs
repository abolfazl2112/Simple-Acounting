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
    public partial class tmp : Form
    {
        public tmp()
        {
            InitializeComponent();
        }

        public string num = "0";
        private void tmp_Load(object sender, EventArgs e)
        {
            label2.Text = num;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.Parse(textBox1.Text) > float.Parse(label2.Text))
            {
                MessageBox.Show("تعداد انتخابی از تعداد موجودی بیشتر است");
                return;
            }
            num = textBox1.Text;
            this.Close();
        }
    }
}
