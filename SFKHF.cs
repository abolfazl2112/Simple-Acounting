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
    public partial class SFKHF : Form
    {
        public SFKHF()
        {
            InitializeComponent();
        }

        public string typ = "";
        private void SFKHF_Load(object sender, EventArgs e)
        {
            string sql = "";
            if (typ == "f")
            {
                sql = "SELECT idfactor'کد فاکتور', idmoshtari'کد مشتری', mablaghkol'مبلغ کل', naghdi'نقدی', mcheck'چک', date'تاریخ' FROM factorforoosh WHERE (typefactor = N'f')";
            }
            else
            {
                sql = "SELECT idfactor'کد فاکتور', idmoshtari'کد مشتری', mablaghkol'مبلغ کل', naghdi'نقدی', mcheck'چک', date'تاریخ' FROM factorforoosh WHERE (typefactor = N'kh')";
            }
            DataManagement.DT = DataManagement.Search(sql);
            dataGridView1.DataSource = DataManagement.DT;
        }

        private void txtFactor_TextChanged(object sender, EventArgs e)
        {
            string sql = "", FileName = "";
            if (txtFactor.Text == "" && txtMoshtari.Text == "")
            {
                if (typ == "f")
                {
                    sql = "SELECT idfactor'کد فاکتور', idmoshtari'کد مشتری', mablaghkol'مبلغ کل', naghdi'نقدی', mcheck'چک', date'تاریخ' FROM factorforoosh WHERE (typefactor = N'f')";
                }
                else
                {
                    sql = "SELECT idfactor'کد فاکتور', idmoshtari'کد مشتری', mablaghkol'مبلغ کل', naghdi'نقدی', mcheck'چک', date'تاریخ' FROM factorforoosh WHERE (typefactor = N'kh')";
                }
            }
            else
            {
                if (typ == "f")
                {
                    sql = "SELECT idfactor'کد فاکتور', idmoshtari'کد مشتری', mablaghkol'مبلغ کل', naghdi'نقدی', mcheck'چک', date'تاریخ' FROM factorforoosh WHERE (typefactor = N'f')AND(idfactor LIKE '" + txtFactor.Text + "%')AND(idmoshtari LIKE '" + txtMoshtari.Text + "%')";
                }
                else
                {
                    sql = "SELECT idfactor'کد فاکتور', idmoshtari'کد مشتری', mablaghkol'مبلغ کل', naghdi'نقدی', mcheck'چک', date'تاریخ' FROM factorforoosh WHERE (typefactor = N'kh')AND(idfactor LIKE '" + txtFactor.Text + "%')AND(idmoshtari LIKE '" + txtMoshtari.Text + "%')";
                }
            }
            DataManagement.DT = DataManagement.Search(sql);
            dataGridView1.DataSource = DataManagement.DT;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string FileName = "";
            if(typ == "f")
                FileName = "RptForosh.mrt";
            else
                FileName = "Rptkharid.mrt";

            printFactor(FileName);

        }

        private void printFactor(string FileName)
        {
            DataManagement.DT = DataManagement.Search("SELECT idfactor[codefactor], idmoshtari[codemoshtari], naghdi, mcheck, date, mablaghkol[mablaghekol] FROM factorforoosh where (typefactor = N'" + typ + "')AND(idfactor = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")AND(idmoshtari = " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + ")");
            Stimulsoft.Report.StiReport stikol = new Stimulsoft.Report.StiReport();
            stikol.Load(FileName);
            stikol.RegData("DS2", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;

            DataManagement.DT = DataManagement.Search("select distinct kalaID[codekala],name[namekala],vahed,ghimat[gheymatvahed],vazn[meghdar],ghimatekol[mablaghkol] from kalaTmp WHERE (IDfactor = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ") order by kalaID");
            stikol.Load(FileName);
            stikol.RegData("factor", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;
            stikol.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount == 0)return;
            if (MessageBox.Show("آیا برای حذف مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            DataManagement.I_U_D("select * from kala", "DELETE FROM factorforoosh WHERE (typefactor = N'" + typ + "') AND (idfactor = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")");
            SFKHF_Load(null, null);
        }
    }
}
