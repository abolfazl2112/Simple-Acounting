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
    public partial class pish : Form
    {
        public pish()
        {
            InitializeComponent();
        }

        private void btnNewKala_Click(object sender, EventArgs e)
        {
            typekala k = new typekala();
            k.ShowDialog(this);
            DataManagement.DT = DataManagement.Search("select distinct kalaID[کد],name[نام کالا],vahed[واحد],ghimat[قیمت],vazn[مقدار] from kala order by kalaID");
            dataGridView2.DataSource = DataManagement.DT;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AFPKW AFPKW = new AFPKW();
            DetectForm.F = 11;
            AFPKW.flagDarj = true;
            AFPKW.ShowDialog(this);
            if (AFPKW.code == "") return;
            txtcodemosh.Text = AFPKW.code;
            txtnamemosh.Text = AFPKW.name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount == 0) return;
            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView2.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show(this, "کالای انتخابی تکراری است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = dataGridView2.CurrentRow.Cells[0].Value;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = dataGridView2.CurrentRow.Cells[1].Value;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = dataGridView2.CurrentRow.Cells[2].Value;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value = dataGridView2.CurrentRow.Cells[3].Value;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = "0";
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[5].Value = "0";
            tmp t = new tmp();
            t.num = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            t.ShowDialog(this);
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = t.num;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[5].Value = double.Parse(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value.ToString()) * double.Parse(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value.ToString());
            double jam = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
                jam += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            lblKol.Text = jam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                if (dataGridView1.RowCount == 0) return;
                double jam = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    jam += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                lblKol.Text = jam.ToString();
            }
            catch
            {
                MessageBox.Show("مشکل در حذف فیلد", "خطا");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printFactor()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("codekala");
            dt.Columns.Add("namekala");
            dt.Columns.Add("vahed");
            dt.Columns.Add("gheymatvahed");
            dt.Columns.Add("meghdar");
            dt.Columns.Add("mablaghkol");

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dt.Rows.Add(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("codemoshtari");
            dt2.Columns.Add("date");
            dt2.Columns.Add("naghdi");
            dt2.Columns.Add("mablaghekol");

            dt2.Rows.Add(txtcodemosh.Text,txtdate.Text,"0",lblKol.Text);

            Stimulsoft.Report.StiReport stikol = new Stimulsoft.Report.StiReport();
            stikol.Load("pish.mrt");
            stikol.RegData("DS2", dt2);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;
            stikol.Load("pish.mrt");
            stikol.RegData("factor", dt);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;
            stikol.Show();
        }

        private void btnSabt_Click(object sender, EventArgs e)
        {
            printFactor();
        }

        string sqlkol = "SELECT kalaID'کد', name'نام کالا', vahed'واحد', ghimat'قیمت واحد', vazn'مقدار', ghimatekol'مبلغ کل' FROM kala";
        private void pish_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DataManagement.Search(sqlkol);
        }
    }
}
