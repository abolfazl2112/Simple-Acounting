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
    public partial class AFEnter : Form
    {
        public AFEnter()
        {
            InitializeComponent();
        }

        private void AFEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "113")
                button1_Click(sender, e);
        }

        private void CUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
                TPassword.Focus();
        }

        public static int t = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (t == 2)
            {
                MessageBox.Show("!خروج به دلیل مسائل امنیتی", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                for (int i = 0; i < 100; i++)
                {
                    this.Opacity -= 0.01;
                }
                Application.DoEvents();
                Application.Exit();
            }
            else
            {
                if (Password == TPassword.Text)
                {
                    MFApple MFApple = new MFApple();
                    for (int i = 0; i < 100; i++)
                        this.Opacity -= 0.01;
                    Application.DoEvents();
                    this.Hide();
                    MFApple.ShowDialog();
                }
                else
                {
                    MessageBox.Show("!رمز ورودی اشتباه می باشد لطفا دوباره امتحان کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TPassword.Focus();
                    TPassword.SelectAll();
                    t += 1;
                }
            }         
        }

        private void TPassword_TextChanged(object sender, EventArgs e)
        {
            if (TPassword.Text == Password)
                label5.Show();
            else
                label5.Hide();
        }

        public static string Password = "";
        public static string User = "";
        private void CUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataManagement.DT = DataManagement.Search("select AName,Password from Users where AName like '" + CUsers.Text.ToString() + "%'");
                Password = DataManagement.DT.Rows[0][1].ToString();
                TPassword.Focus();
                TPassword.Text = "";
                User = CUsers.Text.ToString();
            }
            catch { };
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
                button1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void AFEnter_Load(object sender, EventArgs e)
        {
            Languge_Keybord.Persian();
            try
            {
                DataManagement.DT = DataManagement.Search("select AName,Password from Users");
                for (int i = 0; i < DataManagement.DT.Rows.Count; i++)
                    CUsers.Items.Add(DataManagement.DT.Rows[i][0].ToString());
                CUsers.Text = DataManagement.DT.Rows[0][0].ToString();
                Password = DataManagement.DT.Rows[0][1].ToString();
            }
            catch { };

            this.Height = 180;
            this.Width = 358;
        }

        private void M1_Click(object sender, EventArgs e)
        {
            TPassword.Copy();
            M3.Enabled = true;
        }

        private void M2_Click(object sender, EventArgs e)
        {
            TPassword.Cut();
            M3.Enabled = true;
        }

        private void M3_Click(object sender, EventArgs e)
        {
            TPassword.Paste();
            M3.Enabled = false;
        }

        private void M4_1_Click(object sender, EventArgs e)
        {
            M4_1.Checked = true;
            M4_2.Checked = false;
            Languge_Keybord.Persian();
        }

        private void M4_2_Click(object sender, EventArgs e)
        {
            M4_1.Checked = false;
            M4_2.Checked = true;
            Languge_Keybord.English();
        }

        private void M5_1_Click(object sender, EventArgs e)
        {
            M5_1.Checked = true;
            M5_2.Checked = false;
            TPassword.PasswordChar = '\0';
        }

        private void M5_2_Click(object sender, EventArgs e)
        {
            M5_1.Checked = false;
            M5_2.Checked = true;
            TPassword.PasswordChar = 'o';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resualt;
            resualt = MessageBox.Show("آیا می خواهید از برنامه خارج شوید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resualt == DialogResult.Yes)
            {
                for (int i = 0; i < 100; i++)
                {
                    this.Opacity -= 0.01;
                }
                Application.Exit();
            }
        }

        private void TPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
                button1.Focus();
        }        
    }
}
