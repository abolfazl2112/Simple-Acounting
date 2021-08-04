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
    public partial class saat : Form
    {
        public saat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtshift_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void saat_Load(object sender, EventArgs e)
        {
            txtdate.Text = Data.Pdate();
            DataManagement.DT = DataManagement.Search("SELECT IDperson[کد پرسنلی], date[تاریخ], shift[شیفت کاری], enter[س.ورود], exite[س.خروج],kolsaat[جمع ساعات],dastmozd[دستمزدهر.س],mablagh[کل دستمرد] FROM karkerd");
            dataGridView1.DataSource = DataManagement.DT;

        }
        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcode.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtname.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtfamily.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                dataGridView2.Visible = false;
                button1.Focus();

            }
            if (e.KeyCode == Keys.Escape) dataGridView2.Visible = false;

            
        }

        int flag = 0;
        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            DataManagement.DT = DataManagement.Search("SELECT IDperson[کد پرسنلی], date[تاریخ], shift[شیفت کاری], enter[س.ورود], exite[س.خروج],kolsaat[جمع ساعات],dastmozd[دستمزدهر.س],mablagh[کل دستمرد] FROM karkerd where (IDperson = '" + txtcode.Text + "')");
            dataGridView1.DataSource = DataManagement.DT;
            if (DataManagement.DT.Rows.Count == 0)
                return;
            button2.Enabled = true;
        }

        private void btnSabt_Click(object sender, EventArgs e)
        {
            if (btnSabt.Text == "جدید")
            {
                btnDel.Enabled = btnEdit.Enabled = false;
                btnExit.Text = "انصراف";
                btnSabt.Text = "ثبت";
                txtdate.Enabled = txtEnter.Enabled = txtExit.Enabled = txtshift.Enabled = txtdast.Enabled = txtdate.Enabled = true;
                txtdate.Focus();
            }
            else
            {
                if (txtcode.Text == "")
                {MessageBox.Show("کد پرسنلی انتخاب نشده است"); return; }

                if (txtdate.Text == "" && txtshift.Text == "") 
                {MessageBox.Show("اطلاعات را بصورت کامل وارد کنید"); return; }

                DataManagement.DT = DataManagement.I_U_D("SELECT IDperson[کد پرسنلی], date[تاریخ], shift[شیفت کاری], enter[س.ورود], exite[س.خروج],kolsaat[جمع ساعات],dastmozd[دستمزدهر.س],mablagh[کل دستمزد] FROM karkerd",
                    "INSERT INTO karkerd (IDperson, date, shift, enter, exite,kolsaat,dastmozd,mablagh) VALUES (" +
                    txtcode.Text + ", N'" + txtdate.Text + "', N'" + txtshift.Text + "', N'" + txtEnter.Text + "', N'" + txtExit.Text + "', N'" + txtkols.Text + "', N'" + txtdast.Text + "', N'" + txtdastkol.Text + "')");
                dataGridView1.DataSource = DataManagement.DT;

                txtdate.Enabled = txtEnter.Enabled = txtExit.Enabled = txtshift.Enabled = txtdast.Enabled = false;
                txtdast.Text = txtkols.Text = txtdastkol.Text = txtdate.Text = txtEnter.Text = txtExit.Text = txtshift.Text = "";
                txtdate.Text = Data.Pdate();
                btnDel.Enabled = btnEdit.Enabled = true;
                btnExit.Text = "خروج";
                btnSabt.Text = "جدید";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "خروج")
                this.Close();
            else
            {
                txtdate.Enabled = txtEnter.Enabled = txtExit.Enabled = txtshift.Enabled = txtdast.Enabled = false;
                txtdate.Text = txtEnter.Text = txtExit.Text = txtshift.Text = txtdast.Text = txtkols.Text = txtdastkol.Text = "";
                txtdate.Text = Data.Pdate();
                btnDel.Enabled = btnEdit.Enabled = btnSabt.Enabled = true;
                btnExit.Text = "خروج";
                btnEdit.Text = "ویرایش";
                btnSabt.Text = "جدید";
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "ویرایش")
            {
                if (dataGridView1.RowCount == 0) return;
                btnExit.Text = "انصراف";
                btnEdit.Text = "ثبت";
                txtEnter.Enabled = txtExit.Enabled = txtdast.Enabled = true;

                txtdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtshift.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEnter.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtExit.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtkols.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtdast.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtdastkol.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                btnDel.Enabled = btnSabt.Enabled = false;

                txtEnter.Focus();
            }
            else
            {
                if (txtcode.Text == "")
                {
                    MessageBox.Show("کد پرسنلی انتخاب نشده است"); return; ;
                }
                DataManagement.DT = DataManagement.I_U_D("SELECT IDperson[کد پرسنلی], date[تاریخ], shift[شیفت کاری], enter[س.ورود], exite[س.خروج],kolsaat[جمع ساعات],dastmozd[دستمزدهر.س],mablagh[کل دستمزد] FROM karkerd",
                    "UPDATE karkerd SET enter = N'" + txtEnter.Text + "', exite = N'" + txtExit.Text + "',kolsaat= N'" + txtkols.Text + "',dastmozd= N'" + txtdast.Text + "',mablagh= N'" + 
                    txtdastkol.Text + "'  WHERE (IDperson = " + txtcode.Text + ") AND (date = N'" + txtdate.Text + "') AND (shift = N'" + txtshift.Text + "')");
                    
                dataGridView1.DataSource = DataManagement.DT;

                txtdast.Enabled = txtEnter.Enabled = txtExit.Enabled = false;
                txtdate.Text = txtEnter.Text = txtExit.Text = txtshift.Text = "";
                txtdate.Text = Data.Pdate();
                btnDel.Enabled = btnSabt.Enabled = true;
                btnExit.Text = "خروج";
                btnEdit.Text = "ویرایش";
            }
        }

        private void dataGridView2_Leave(object sender, EventArgs e)
        {
            flag = 0;
            dataGridView2.DataSource = null;
            dataGridView2.Visible = false;
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                button2.Enabled = false;
                if (txtname.Text == "" && txtfamily.Text == "" && txtcode.Text == "")
                {
                    dataGridView2.Visible = true;
                    DataManagement.DT = DataManagement.Search("SELECT Id'کد پرسنلی', Name'نام', Family'نام خانوادگی' FROM Properties where left(Properties.Tid,1)<>'M'");
                    dataGridView2.DataSource = DataManagement.DT;
                }
                else
                {
                    dataGridView2.Visible = true;
                    DataManagement.DT = DataManagement.Search("SELECT Id'کد پرسنلی', Name'نام', Family'نام خانوادگی' FROM Properties WHERE (left(Properties.Tid,1)<>'M') AND (Id LIKE '" + txtcode.Text + "%') AND (Name LIKE N'" + txtname.Text + "%') AND (Family LIKE N'" + txtfamily.Text + "%')");
                    dataGridView2.DataSource = DataManagement.DT;
                }
                dataGridView2.Focus();
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcode.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtfamily.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            dataGridView2.Visible = false;
            button1.Focus();
        }

        private void txtdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtshift.Focus();
        }

        private void txtshift_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtEnter.Focus();

        }

        private void txtEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtExit.Focus();

        }

        private void txtEnter_EnabledChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = !txtEnter.Enabled;
        }

        private void txtExit_Leave(object sender, EventArgs e)
        {
            if (txtExit.Text == "") return;
            if (int.Parse(txtExit.Text) > 24)
            {
                MessageBox.Show(""); txtExit.Text = "24";
                return;
            }

            int exitS = int.Parse(txtExit.Text), enterS = int.Parse(txtEnter.Text); 
            if ( exitS < enterS)
            {
                exitS += 24;
            }
            enterS = exitS - enterS;
            txtkols.Text = enterS.ToString();
            if (txtdast.Text != "")
                txtdastkol.Text = (double.Parse(txtdast.Text) * enterS).ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (txtdast.Text == "") txtdast.Text = "0";
            double kol = 0;
            try
            {
                 kol = double.Parse(txtkols.Text) * double.Parse(txtdast.Text);
            }
            catch { kol = 0; }

            txtdastkol.Text = kol.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtfamily.Text == "" || txtcode.Text == "")
            { MessageBox.Show("اطلاعات پرسنلی را کامل وارد کنید"); return; }
            printHesab ph = new printHesab(dataGridView1);
            ph.Name = txtname.Text + " " + txtfamily.Text;
            ph.ShowDialog(this);
        }

        private void txtEnter_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txtEnter.Text) > 24)
            {
                MessageBox.Show(""); txtEnter.Text = "24";
                return;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            string sql = "DELETE FROM karkerd  WHERE (IDperson = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ") AND (date = N'" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "') AND (shift = N'" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "')";
            DataManagement.DT = DataManagement.I_U_D("select * from  [check]", sql);
            dataGridView1.DataSource = DataManagement.Search("SELECT IDperson[کد پرسنلی], date[تاریخ], shift[شیفت کاری], enter[س.ورود], exite[س.خروج],kolsaat[جمع ساعات],dastmozd[دستمزدهر.س],mablagh[کل دستمزد] FROM karkerd");
        }

        private void txtdate_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtfamily.Text == "" && txtname.Text == "") return;
            pardakhti par = new pardakhti(txtcode.Text, txtname.Text + " " + txtfamily.Text);
            par.ShowDialog(this);
        }
    }
}
