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
    public partial class pardakhti : Form
    {
        string code = "", name;
        string sqlAll = "SELECT code'کد', name'نام و نام خانوادگی', date'تاریخ', mablagh'مبلغ پرداختی' FROM pardakhti";
        
        public pardakhti()
        {
            InitializeComponent();
        }

        public pardakhti(string code, string name)
        {
            InitializeComponent();

            this.code = code;
            this.name = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8) ? false : true;
        }

        private void pardakhti_Load(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar pc = new PersianCalendar();
            dataGridView3.DataSource = DataManagement.Search(sqlAll + " WHERE (code = N'" + code + "')");
            txtname.Text = name;
            string day = (pc.GetDayOfMonth(DateTime.Now) < 10) ? ("0" + pc.GetDayOfMonth(DateTime.Now).ToString()) : (pc.GetDayOfMonth(DateTime.Now).ToString());
            string mo = (pc.GetMonth(DateTime.Now) < 10) ? "0" + pc.GetMonth(DateTime.Now).ToString() : pc.GetMonth(DateTime.Now).ToString();
            txtdate.Text = pc.GetYear(DateTime.Now).ToString() + mo + day;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (txtMablagh.Text == "") return;
            string sql = "INSERT INTO pardakhti (code, name, date, mablagh) VALUES (N'" + code + "', N'" + name + "', N'" + txtdate.Text + "', N'" + txtMablagh.Text + "')";
            DataManagement.I_U_D(sqlAll, sql);
            pardakhti_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataGridViewPrinter.DGVPrinter printer = new DataGridViewPrinter.DGVPrinter();
            printer.CellAlignment = StringAlignment.Center;
            printer.CellFormatFlags = StringFormatFlags.DirectionRightToLeft;

            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.HeaderCellFormatFlags = StringFormatFlags.DirectionRightToLeft;
            printer.PageNumberAlignment = StringAlignment.Near;
            printer.PageNumberInHeader = true;
            printer.PageNumberOnSeparateLine = true;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;

            printer.Title = "لیست پرداختی ها";
            printer.TitleAlignment = StringAlignment.Center;
            printer.TitleColor = Color.Blue;
            printer.TitleFont = new Font("Arial", 14);
            printer.TitleFormatFlags = StringFormatFlags.DirectionRightToLeft;

            printer.SubTitle = "سال : " + txtYear.Text + "ماه : " + txtMonth.Text + "روز : " + txtDay.Text;
            printer.SubTitleAlignment = StringAlignment.Center;
            printer.SubTitleColor = Color.Blue;
            printer.SubTitleFont = new Font("Arial", 14);
            printer.SubTitleFormatFlags = StringFormatFlags.DirectionRightToLeft;

            //printer.Footer = "Footer";
            //printer.FooterAlignment = StringAlignment.Center;
            //printer.FooterColor = Color.Blue;
            //printer.FooterFont = new Font("Arial", 14);
            //printer.FooterFormatFlags = StringFormatFlags.DirectionRightToLeft;
            //printer.FooterSpacing = 10;

            printer.PrintPreviewDataGridView(dataGridView3);

            this.Cursor = Cursors.Default;
        }

        private void txtdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount == 0) return;
            string sql = "DELETE FROM pardakhti WHERE (code = N'" + code + "') AND (date = N'" + dataGridView3.CurrentRow.Cells[2].Value.ToString() + "') AND (mablagh = N'" + dataGridView3.CurrentRow.Cells[3].Value.ToString() + "')";
            DataManagement.I_U_D(sqlAll, sql);
            pardakhti_Load(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = DataManagement.Search(sqlAll + " where(code = " + code + ")");
            for (int i = 0;i<dataGridView3.RowCount ; i++)
            {
                string[] str = dataGridView3.Rows[i].Cells[2].Value.ToString().Split('/');
                if (ky != "")
                {
                    if (str[0] != ky)
                    {
                        dataGridView3.Rows.RemoveAt(i--);
                        continue;
                    }
                }
                else
                    continue;
                if (km != "")
                {
                    if (km != str[1])
                    {
                        dataGridView3.Rows.RemoveAt(i--);
                        continue;
                    }
                }
                else continue;
                if (kd != "")
                    if (kd != str[2])
                        dataGridView3.Rows.RemoveAt(i--);
            }
        }

        string ky = "", km = "", kd = "";
        private void txtYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ky = txtYear.Text;
        }

        private void txtMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            km = (txtMonth.SelectedIndex + 1).ToString();
        }

        private void txtDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            kd = txtDay.Text;
        }
    }
}
