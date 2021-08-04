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
    public partial class printHesab : Form
    {
        DataGridView dg = null;
        public printHesab(DataGridView dgv)
        {
            InitializeComponent();
            dg = dgv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMah.Text == "" || txtYear.Text == "")
                return;
            double jam = 0;
            int year = 0, mah = 0;
            int i = 0;
            int selectMah = txtMah.SelectedIndex + 1;
            for (; i < dg.Rows.Count;)
            {
                year = int.Parse(dg.Rows[i].Cells[1].Value.ToString().Substring(0, 4));
                mah = int.Parse(dg.Rows[i].Cells[1].Value.ToString().Substring(5, 2));

                if (year != int.Parse(txtYear.Text))
                    dg.Rows.RemoveAt(i);
                else if (mah != selectMah)
                    dg.Rows.RemoveAt(i);
                else
                {
                    jam += double.Parse(dg.Rows[i++].Cells[7].Value.ToString());
                }
            }
            Jam = jam.ToString();

            if (dg.RowCount == 0) { MessageBox.Show("اطلاعاتی یافت نشد"); return; }
            print();
        }

        public string Name = "", Jam = "0";
        private void print()
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

            printer.Title = "فاکتور کارکرد آقای " + Name;
            printer.TitleAlignment = StringAlignment.Center;
            printer.TitleColor = Color.Blue;
            printer.TitleFont = new Font("Tahoma", 14);
            printer.TitleFormatFlags = StringFormatFlags.DirectionRightToLeft;

            printer.SubTitle = "مجموع کارکرد :" + Jam;
            printer.SubTitleAlignment = StringAlignment.Center;
            printer.SubTitleColor = Color.Blue;
            printer.SubTitleFont = new Font("Tahoma", 14);
            printer.SubTitleFormatFlags = StringFormatFlags.DirectionRightToLeft;

            printer.Footer = "کاگاه تولیدی لولای آریا";
            printer.FooterAlignment = StringAlignment.Center;
            printer.FooterColor = Color.Blue;
            printer.FooterFont = new Font("Tahoma", 14);
            printer.FooterFormatFlags = StringFormatFlags.DirectionRightToLeft;
            printer.FooterSpacing = 10;

            printer.PrintPreviewDataGridView(dg);

            this.Cursor = Cursors.Default;
        }
    }
}
