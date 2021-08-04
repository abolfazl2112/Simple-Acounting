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
    public partial class chap : Form
    {
        public chap()
        {
            InitializeComponent();
        }

        private void chap_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "") return;
            printFactor();
        }

        private string getMon(int mah)
        {
            switch (mah)
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

        private void printFactor()
        {
            double jamekol = 0;
            string sql1 = "SELECT factorforoosh.date,kalaTmp.name'nameKala', kalaTmp.vahed, kalaTmp.ghimat'ghimatvahed', kalaTmp.vazn'meghdar', kalaTmp.ghimatekol'mablagh' FROM kalaTmp INNER JOIN" +
                " factorforoosh ON kalaTmp.IDfactor = factorforoosh.idfactor WHERE (factorforoosh.typefactor = N'"+(radioButton1.Checked?"kh":"f")+"')";
            DataManagement.DT = DataManagement.Search(sql1);
            string sal1 ="" , mah1 = "";
            for (int i = 0; i < DataManagement.DT.Rows.Count; i++)
            {
                sal1= DataManagement.DT.Rows[i][0].ToString().Substring(0, 4);
                mah1 = getMon( int.Parse(DataManagement.DT.Rows[i][0].ToString().Substring(5, 2)));
                if (sal1 == comboBox2.Text && mah1  == comboBox1.Text)
                {
                    jamekol += double.Parse(DataManagement.DT.Rows[i]["mablagh"].ToString());   
                    continue;
                }
                else
                {
                    DataManagement.DT.Rows.RemoveAt(i--);
                }
            }
            Stimulsoft.Report.StiReport stikol = new Stimulsoft.Report.StiReport();
            stikol.Load("mahianeKala.mrt");
            stikol.RegData("data", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;


            DataManagement.DT = DataManagement.Search("select name from kala");
            //DataManagement.DT.Columns.Remove("name");
            DataManagement.DT.Columns.Add("type");
            DataManagement.DT.Columns.Add("sal");
            DataManagement.DT.Columns.Add("mah");
            DataManagement.DT.Columns.Add("jamekol");
            
            DataManagement.DT.Rows[0]["type"] = type;
            DataManagement.DT.Rows[0]["sal"] = comboBox2.Text;
            DataManagement.DT.Rows[0]["mah"] = comboBox1.Text;
            DataManagement.DT.Rows[0]["jamekol"] = jamekol;

            stikol.Load("mahianeKala.mrt");
            stikol.RegData("variable", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;
            stikol.Show();
        }

        string type = "خرید";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                type = "خرید";
            else
                type = "فروش";
        }
    }

}
