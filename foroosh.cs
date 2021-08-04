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
    public partial class foroosh : Form
    {
        public foroosh()
        {
            InitializeComponent();
        }

        private void foroosh_Load(object sender, EventArgs e)
        {
            DataManagement.DT = DataManagement.Search("select distinct kalaID[کد],name[نام کالا],vahed[واحد],ghimat[قیمت],vazn[مقدار] from kala order by kalaID");
            dataGridView2.DataSource = DataManagement.DT;

            txtdate.Text = Data.Pdate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount == 0)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Focus();
            }
            else if (dataGridView3.Rows[dataGridView3.RowCount - 1].Cells[0].Value.ToString() == "") return;
            else
            {

                dataGridView3.Rows.Add();
                dataGridView3.Focus();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("مشکل در حذف فیلد", "خطا");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DisplaySum()
        {
            try
            {
                decimal cheks = 0;
                if (txtnaghdi.Text.Trim() == string.Empty) txtnaghdi.Text = "0";
                for (int i = 0; i < dataGridView3.Rows.Count; i++) cheks += Convert.ToDecimal(dataGridView3.Rows[i].Cells["mablaghch"].Value);
                lbljamchek.Text = cheks.ToString();
                lbljamkol.Text = (Convert.ToDecimal(txtnaghdi.Text) + cheks).ToString();
                lblMande.Text = (double.Parse(lblKol.Text) - (double.Parse(lbljamkol.Text))).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnaghdi_TextChanged(object sender, EventArgs e)
        {
            DisplaySum();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            typekala k = new typekala();
            k.ShowDialog(this);
            DataManagement.DT = DataManagement.Search("select distinct kalaID[کد],name[نام کالا],vahed[واحد],ghimat[قیمت],vazn[مقدار] from kala order by kalaID");
            dataGridView2.DataSource = DataManagement.DT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcodemosh.Text == "" && txtnamemosh.Text == "")
            {
                MessageBox.Show("مشتری را انتخاب کنید");
                return;
            }
            if (dataGridView1.RowCount == 0) return;

            if (dataGridView3.RowCount != 0)
            {
                double jam = 0;
                try
                {
                    for (int i = 0; i < dataGridView3.RowCount; i++)
                        jam += double.Parse(dataGridView3.Rows[i].Cells[4].Value.ToString());
                }
                catch { };
                lbljamchek.Text = jam.ToString();
                lbljamkol.Text = (jam + double.Parse(txtnaghdi.Text)).ToString();
                lblMande.Text = (double.Parse(lblKol.Text) - double.Parse(lbljamkol.Text)).ToString();
            }

            if (MessageBox.Show(this, "برای ثبت اطلاعات مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            string sql = "INSERT INTO factorforoosh (idmoshtari, mablaghkol, naghdi, mcheck, date, typefactor) VALUES (" + txtcodemosh.Text + ", N'" + lblKol.Text + "', N'" + txtnaghdi.Text + "', N'" + lbljamchek.Text + "', N'" + txtdate.Text + "', N'f')";
            DataManagement.I_U_D("SELECT idfactor FROM factorforoosh", sql);
            DataManagement.DT = DataManagement.Search("SELECT  TOP (1) idfactor FROM factorforoosh ORDER BY idfactor DESC");
            idFactor = DataManagement.DT.Rows[0][0].ToString();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null) break;
                sql = "INSERT INTO kalaTmp (IDfactor, name, vahed, ghimat, vazn, ghimatekol) VALUES (" + idFactor + ", N'" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "', N'" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "', N'" +
                    dataGridView1.Rows[i].Cells[3].Value.ToString() + "', N'" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "', N'" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "')";
                DataManagement.DT = DataManagement.I_U_D("SELECT * FROM kala", sql);
                double vazn = double.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                vazn = vazn - double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                sql = "UPDATE kala SET vazn = N'" + vazn + "' WHERE (kalaID = " + dataGridView1.Rows[i].Cells[0].Value.ToString() + ")";
                DataManagement.DT = DataManagement.I_U_D("SELECT * FROM kala", sql);
            }

            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                if (dataGridView3.Rows[i].Cells[0].Value.ToString() == "") break;
                sql = "INSERT INTO [check] (chID, idfactor, bank, shobe, tarikh, mablagh) VALUES (N'" + dataGridView3.Rows[i].Cells[0].Value.ToString() + "', " + idFactor + ", N'" + ((dataGridView3.Rows[i].Cells[1].Value == null) ? "0" : dataGridView3.Rows[i].Cells[1].Value.ToString()) + "', N'" +
                    ((dataGridView3.Rows[i].Cells[2].Value == null) ? "0" : dataGridView3.Rows[i].Cells[2].Value.ToString()) + "', N'" + ((dataGridView3.Rows[i].Cells[3].Value == null) ? "0" : dataGridView3.Rows[i].Cells[3].Value.ToString()) + "', N'" + ((dataGridView3.Rows[i].Cells[4].Value == null) ? "0" : dataGridView3.Rows[i].Cells[4].Value.ToString()) + "')";
                DataManagement.DT = DataManagement.I_U_D("SELECT * FROM [check]", sql);
            }

            double mande1 = double.Parse(lblMande.Text);
            double mande2 = double.Parse(label16.Text);
            if (mande1 != 0)
            {
                sql = "UPDATE Properties SET Address_1 = N'" + lblMande.Text + "' WHERE (Id = " + txtcodemosh.Text + ")";
                DataManagement.DT = DataManagement.I_U_D("SELECT * FROM [check]", sql);
            }

            MessageBox.Show("اطلاعات با موفقیت ثبت شد");

            if (MessageBox.Show(this, "آیا فاکتور چاپ شود؟", "سوال", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    printFactor();
                }
                catch { MessageBox.Show("مشکل در چاپ اطلاعات"); }
            }
            btnSabt.Enabled = false;

        }

        string idFactor = "";
        private void printFactor()
        {
            DataManagement.DT = DataManagement.Search("SELECT idfactor[codefactor], idmoshtari[codemoshtari], naghdi, mcheck, date, mablaghkol[mablaghekol] FROM factorforoosh ORDER BY codefactor  DESC");
            DataManagement.DT.Columns.Add("numberofcheck");
            if (DataManagement.DT.Rows.Count != 0)
            {
                DataManagement.DT.Rows[0]["numberofcheck"] = dataGridView3.RowCount.ToString();
            }
            Stimulsoft.Report.StiReport stikol = new Stimulsoft.Report.StiReport();
            stikol.Load("RptForosh.mrt");
            stikol.RegData("DS2", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;
            DataManagement.DT = DataManagement.Search("select distinct kalaID[codekala],name[namekala],vahed,ghimat[gheymatvahed],vazn[meghdar],ghimatekol[mablaghkol] from kalaTmp WHERE (IDfactor = '" + idFactor + "') order by kalaID");
            stikol.Load("RptForosh.mrt");
            stikol.RegData("factor", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;
            stikol.Show();
        }

        private void txtcodemosh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtcodemosh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                DataManagement.DT = DataManagement.Search("select distinct kalaID[کد],name[نام کالا],vahed[واحد],ghimat[قیمت],vazn[مقدار] from kala order by kalaID");
                dataGridView2.DataSource = DataManagement.DT;
            }
            else
            {
                DataManagement.DT = DataManagement.Search("select distinct kalaID[کد],name[نام کالا],vahed[واحد],ghimat[قیمت],vazn[مقدار] from kala where (name LIKE N'" + txtSearch.Text + "%')");
                dataGridView2.DataSource = DataManagement.DT;
            }
        }

        private void lblKol_TextChanged(object sender, EventArgs e)
        {
            lblMande.Text = (double.Parse(lblKol.Text) - (double.Parse(txtnaghdi.Text) + double.Parse(lbljamchek.Text))).ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataManagement.DT = DataManagement.Search("SELECT Job FROM Properties WHERE (Id = " + txtcodemosh.Text + ")");
            if (DataManagement.DT.Rows.Count == 0) return;
            label16.Text = DataManagement.DT.Rows[0][0].ToString();
            double sum = double.Parse(lblMande.Text) + double.Parse(label16.Text);
        }


    }
}