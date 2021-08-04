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
    public partial class print : Form
    {
        string sql1, sql2;
        public int type = 1;
        public print()
        {
            InitializeComponent();
            sql1 = sql2 = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;

            string nameFactor = SetSql();
            filterdata();
            printFactor(nameFactor);
            this.UseWaitCursor = false;
        }

        private string SetSql()
        {
            string sql01 ,sql3 = "";
            string nameFactor = "";
            if (type == 1)
            {
                sql1 = "SELECT Properties.Name + ' ' + Properties.Family[sharh], factorforoosh.mablaghkol[mablagh],factorforoosh.date FROM factorforoosh INNER JOIN " +
                       " Properties ON factorforoosh.idmoshtari = Properties.Id WHERE (factorforoosh.typefactor = N'kh')";

                sql2 = "SELECT Properties.Name + ' ' + Properties.Family[sharh], karkerd.mablagh, karkerd.date FROM Properties INNER JOIN karkerd ON Properties.Id = karkerd.IDperson";

                sql01 = "SELECT name[sharh],mablagh[mablagh]  ,date FROM pardakhti";

                sql3 = "";

                sql1 = "select * from (" + sql1 + " union " + sql2 + " union " + sql01 + ") AS derivedtbl_1";
                
                nameFactor = "hazine.mrt";

                DataManagement.DT = DataManagement.Search(sql1);
            }
            else
            {
                sql1 = "SELECT Properties.Name + ' ' + Properties.Family[sharh], factorforoosh.mablaghkol[mablagh],factorforoosh.date FROM factorforoosh INNER JOIN " +
                       " Properties ON factorforoosh.idmoshtari = Properties.Id WHERE (factorforoosh.typefactor = N'f')";
                nameFactor = "daramad.mrt";
                DataManagement.DT = DataManagement.Search(sql1);
            }
            filterdata();
            return nameFactor;
        }

        private void filterdata()
        {
            if (txtYear.Text == "") return;
            int year = 0;
            int month = 0;
            for (int i = 0; i < DataManagement.DT.Rows.Count; )
            {
                year = int.Parse(DataManagement.DT.Rows[i][2].ToString().Substring(0, 4));
                month = int.Parse(DataManagement.DT.Rows[i][2].ToString().Substring(5, 2));
                if (txtYear.Text == "") return;
                if (year != int.Parse(txtYear.Text))
                    DataManagement.DT.Rows.RemoveAt(i);
                else
                {
                    if(month != selectedMonth)
                        DataManagement.DT.Rows.RemoveAt(i);
                    else
                        i++;
                }
            }
        }




        private void printFactor(string nameFactor)
        {

            Stimulsoft.Report.StiReport stikol = new Stimulsoft.Report.StiReport();

            stikol.Load(nameFactor);
            stikol.RegData("ds1", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;

            double ld = mohasebe();
            

            DataManagement.DT = DataManagement.Search("SELECT TOP (1) idfactor FROM factorforoosh");
            DataManagement.DT.Columns.Add("jamhazine");
            DataManagement.DT.Rows[0]["jamhazine"] = ld.ToString();
            stikol.Load(nameFactor);
            stikol.RegData("var", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;

            stikol.Show();
        }

        

        private void txtdate_Leave(object sender, EventArgs e)
        {

        }

        private void print_Load(object sender, EventArgs e)
        {
            if (type == 1)
                btnPrint.Text = "چاپ هزینه ها";
            else
                btnPrint.Text = "چاپ درآمدها";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == "") return;
            this.UseWaitCursor = true;
            int oldtype = type;



            type = 1;
            SetSql();
            double hazine = mohasebe();
            lblhazine.Text = hazine.ToString();
            type = 2;
            SetSql();
            double daramad = mohasebe();
            lblDaramad.Text = daramad.ToString();


            double sood = daramad - hazine;
            lblSood.Text = sood.ToString();

            type = oldtype;
            this.UseWaitCursor = false;
        }

        private double mohasebe()
        {

            double ld = 0;
            for (int i = 0; i < DataManagement.DT.Rows.Count; i++)
            {
                try
                {
                    ld += double.Parse(DataManagement.DT.Rows[i][1].ToString());
                }
                catch { }
            }
            return ld;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int selectedMonth = -1;
        private void txtMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMonth = txtMonth.SelectedIndex+1;
        }
    }
}
