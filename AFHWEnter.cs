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
    public partial class AFHWEnter : Form
    {
        string sqlAll = "SELECT code'کد', name'نام پیمانکار', noe'نوع عملیات', tedad'تعداد/مقدار', ghimat'قیمت واحد', mablagh'جمع' FROM peyman";
        public AFHWEnter()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || comboBox1.Text == "" || comboBox2.Text =="") return;
            AFDHWEnter af = new AFDHWEnter();
            af.Name = txtname.Text;
            af.sal = comboBox2.Text;
            af.mah = comboBox1.Text;
            af.code = codeID;
            af.type = "پیمانکار";
            
            af.ShowDialog(this);
            dataGridView3.DataSource = DataManagement.Search(sqlAll);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount == 0) return;
            if (MessageBox.Show("آیا برای حذف مطمئن هستید؟", "", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            string sql = "DELETE FROM peyman WHERE (code = " + dataGridView3.CurrentRow.Cells[0].Value.ToString() + ")";
            DataManagement.I_U_D("select * from check", sql);
            MessageBox.Show("اطلاعات با موفقیت حذف شد");
            dataGridView3.DataSource = DataManagement.Search(sqlAll);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void AFHWEnter_Load(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();
            comboBox1.Text = (getMon());
            comboBox2.Text = pc.GetYear(DateTime.Now).ToString();
            DataManagement.DT = DataManagement.Search("SELECT Name + ' ' + Family AS name,Id FROM Properties where (left(Properties.Tid,1)='P')");
            for (int i = 0; i < DataManagement.DT.Rows.Count; i++)
            {
                txtname.Items.Add(DataManagement.DT.Rows[i][0].ToString());
                listBox1.Items.Add(DataManagement.DT.Rows[i][1].ToString());
            }
            dataGridView3.DataSource = DataManagement.Search(sqlAll);
        }

        private string getMon()
        {
            PersianCalendar pc=new PersianCalendar();
            switch(pc.GetMonth(DateTime.Now))
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                    case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
                default:
                    return "";
            }
        }

        string codeID = "";
        private void txtname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtname.SelectedIndex == -1) return;
            codeID = listBox1.Items[txtname.SelectedIndex].ToString();
            dataGridView3.DataSource = DataManagement.Search(sqlAll + "  where (code = N'"+codeID+"')AND(name = N'" + txtname.Text + "') AND (mah = N'"+comboBox1.Text+"') AND (sal = N'"+comboBox2.Text+"')");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || comboBox1.Text == "" || comboBox2.Text == "") return;
            printFactor();
        }

        private void printFactor()
        {
            DataManagement.DT = DataManagement.Search("SELECT noe AS amaliat, tedad AS meghdar, ghimat AS ghimatvahed, mablagh "+
 "FROM            peyman  where (name = N'" + txtname.Text + "') AND (mah = N'"+comboBox1.Text+"') AND (sal = N'"+comboBox2.Text+"')");
            
            Stimulsoft.Report.StiReport stikol = new Stimulsoft.Report.StiReport();
            stikol.Load("mahianePeiman.mrt");
            stikol.RegData("data", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;

            DataManagement.DT = DataManagement.Search("SELECT name FROM peyman");
            DataManagement.DT.Columns.Add("mah");
            DataManagement.DT.Columns.Add("sal");
            DataManagement.DT.Columns.Add("jamekol");
            double jamekol = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
                jamekol += double.Parse(dataGridView3.Rows[i].Cells[5].Value.ToString());
            DataManagement.DT.Rows.Add();

            DataManagement.DT.Rows[0]["name"] = txtname.Text;
            DataManagement.DT.Rows[0]["mah"] = comboBox1.Text;
            DataManagement.DT.Rows[0]["sal"] = comboBox2.Text;
            DataManagement.DT.Rows[0]["jamekol"] = jamekol;
            
            stikol.Load("mahianePeiman.mrt");
            stikol.RegData("variable", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;
            stikol.Show();
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
