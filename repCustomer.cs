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
    public partial class repCustomer : Form
    {
        public repCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (txtcode.Text == "")
                    return;
                dataGridView1.DataSource = DataManagement.Search(sqlkol + " where (id = '"+txtcode.Text+"')");

            }
            if (radioButton2.Checked)
            {
                if (txtMonth.Text == "" || txtYear.Text == "")
                    return;
                dataGridView1.DataSource = DataManagement.Search(sqlkol + " where (date = '" + txtYear.Text + "')");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 11;
            AFPKW.flagDarj = true;
            AFPKW.ShowDialog(this);
            if (AFPKW.code == "") return;
            txtcode.Text = AFPKW.code;
            txtname.Text = AFPKW.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
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

            printer.Title = "کارگا تولیدی لولای آریا";
            printer.TitleAlignment = StringAlignment.Center;
            printer.TitleColor = Color.Blue;
            printer.TitleFont = new Font("Arial", 14);
            printer.TitleFormatFlags = StringFormatFlags.DirectionRightToLeft;

            printer.SubTitle = "گزارش کارکرد آقای / خانم:" + txtname.Text; 
            printer.SubTitleAlignment = StringAlignment.Center;
            printer.SubTitleColor = Color.Blue;
            printer.SubTitleFont = new Font("Arial", 14);
            printer.SubTitleFormatFlags = StringFormatFlags.DirectionRightToLeft;

            printer.Footer = "سال:" + txtYear.Text + "      ماه:" + txtMonth.Text;
            printer.FooterAlignment = StringAlignment.Center;
            printer.FooterColor = Color.Blue;
            printer.FooterFont = new Font("Arial", 14);
            printer.FooterFormatFlags = StringFormatFlags.DirectionRightToLeft;
            printer.FooterSpacing = 10;

            printer.PrintPreviewDataGridView(dataGridView1);

            this.Cursor = Cursors.Default;
        }

        string sqlkol = "";
        private void repCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataManagement.Search(sqlkol);
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) radioButton1.Checked = false;
        }
    }
}
