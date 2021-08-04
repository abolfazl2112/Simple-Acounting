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
    public partial class AFLoad : Form
    {
        public AFLoad()
        {
            InitializeComponent();
        }
        
        public static int a = 0;
        private void AFLTimer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                this.Opacity += 0.01;
            }
            Application.DoEvents();
            AFLTimer1.Enabled = false;
            AFLTimer.Enabled = true; 
        }

        private void AFLTimer_Tick(object sender, EventArgs e)
        {
            if (a > 99)
            {
                AFLTimer.Enabled = false;
                Form AFEnter = new AFEnter();
                this.Hide();
                AFEnter.ShowDialog();
            }
            else
            {
                a += 1;
                AFLProgressBar.Value = AFLProgressBar.Value + 1;
            }
        }

        private void AFLoad_Load(object sender, EventArgs e)
        {
        }

    }
}
