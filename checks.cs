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
    public partial class checks : Form
    {
        string sql = "SELECT [check].chID'شماره چک', [check].idfactor'شماره فاکتور', [check].bank'بانک', [check].shobe'شعبه', [check].tarikh'تاریخ', [check].mablagh'مبلغ'  FROM [check] INNER JOIN factorforoosh ON [check].idfactor = factorforoosh.idfactor ";
        
        public checks()
        {
            InitializeComponent();
        }

        private void checks_Load(object sender, EventArgs e)
        {
            string date = "";
            PersianCalendar pc = new PersianCalendar();
            int d = pc.GetDayOfMonth(DateTime.Now);
            int m = pc.GetMonth(DateTime.Now);
            int y = pc.GetYear(DateTime.Now);
            date = y.ToString() + "/" + ((m < 10) ? "0" + m.ToString() : m.ToString()) + "/" + ((d < 10) ? "0" + d.ToString() : d.ToString());

            dataGridView3.DataSource = DataManagement.Search(sql);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (txtCheck.SelectedIndex)
            {
                case 0:
                    dataGridView3.DataSource = DataManagement.Search(sql);
                    break;
                case 1:
                    dataGridView3.DataSource = DataManagement.Search(sql + "WHERE(factorforoosh.typefactor = N'f') " + (txtDate.Text == "  /  /" ? " " : "AND ([check].tarikh = N'" + txtDate.Text + "')"));
                    break;
                case 2:
                    dataGridView3.DataSource = DataManagement.Search(sql + "WHERE(factorforoosh.typefactor = N'kh') " + (txtDate.Text == "  /  /" ? " " : "AND ([check].tarikh = N'" + txtDate.Text + "')"));
                    break;
            }

        }

        private void btnSabt_Click(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(null, null);
        }
    }
}
