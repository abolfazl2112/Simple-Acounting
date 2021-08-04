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
    public partial class kharid : Form
    {
        public kharid()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            typekala k = new typekala();
            k.ShowDialog(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = 0;
                dataGridView1.Focus();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Selected = true;

            }
            else if (dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value == null)
            {
                return;
            }
            else
            {
                try
                {
                    double g, m;
                    m = double.Parse(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value.ToString());
                    g = double.Parse(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value.ToString());
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = g * m;
                    double maj = 0;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        maj += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                    lblKol.Text = maj.ToString();
                }
                catch { }
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = 0;
                dataGridView1.Focus();
            }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount == 0)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Focus();
            }
            else if (dataGridView3.Rows[dataGridView3.RowCount-1].Cells[0].Value.ToString() == "") return;
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lblKol.Text = (double.Parse(lblKol.Text) - double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString())).ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("مشکل در حذف فیلد", "خطا");
            }
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
            string sql = "INSERT INTO factorforoosh (idmoshtari, mablaghkol, naghdi, mcheck, date, typefactor) VALUES (" + txtcodemosh.Text + ", N'" + lblKol.Text + "', N'" + txtnaghdi.Text + "', N'" + lbljamchek.Text + "', N'" + txtdate.Text + "', N'kh')";
            DataManagement.I_U_D("SELECT  TOP (1) idfactor FROM factorforoosh ORDER BY idfactor DESC", sql);
            DataManagement.DT = DataManagement.Search("SELECT  TOP (1) idfactor FROM factorforoosh ORDER BY idfactor DESC");
            idFactor = DataManagement.DT.Rows[0][0].ToString();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "") continue;
                
                sql = "INSERT INTO kalaTmp (IDfactor, name, vahed, ghimat, vazn, ghimatekol) VALUES (" + idFactor + ", N'" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "', N'" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "', N'" +
                        dataGridView1.Rows[i].Cells[2].Value.ToString() + "', N'" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "', N'" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "')";
                DataManagement.DT = DataManagement.I_U_D("SELECT * FROM kala", sql);
                
                double p = isKala(dataGridView1.Rows[i].Cells[0].Value.ToString());
                if (p != -1)
                {
                    p += double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    sql = "UPDATE kala SET vazn = N'" + p + "' WHERE (name = N'" + p + "')";
                }
                else
                    sql = "INSERT INTO kala (name, vahed, ghimat, vazn) VALUES (N'" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "', N'" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "', N'" +
                        dataGridView1.Rows[i].Cells[2].Value.ToString() + "', N'" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "')";

                DataManagement.DT = DataManagement.I_U_D("SELECT * FROM kala", sql);


            }
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                if (dataGridView3.Rows[i].Cells[0].Value == null) break;
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
                printFactor();
            }
            button1.Enabled = false;
            
        }

        private double isKala(string p)
        {
            DataManagement.DT = DataManagement.Search("select name,vazn from kala");
            for (int i = 0; i < DataManagement.DT.Rows.Count; i++)
                if (DataManagement.DT.Rows[i][0].ToString() == p) return double.Parse(DataManagement.DT.Rows[i][1].ToString());
            return -1;
        }

        string idFactor = "";
        private void printFactor()
        {
            DataManagement.DT = DataManagement.Search("SELECT idfactor[codefactor], idmoshtari[codemoshtari], naghdi, mcheck, date, mablaghkol[mablaghekol] FROM factorforoosh  ORDER BY codefactor  DESC");
            DataManagement.DT.Columns.Add("numberofcheck");
            DataManagement.DT.Rows[0]["numberofcheck"] = dataGridView3.RowCount.ToString();
            Stimulsoft.Report.StiReport stikol = new Stimulsoft.Report.StiReport();
            stikol.Load("Rptkharid.mrt");
            stikol.RegData("DS2", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;

            DataManagement.DT = DataManagement.Search("select distinct kalaID[codekala],name[namekala],vahed,ghimat[gheymatvahed],vazn[meghdar],ghimatekol[mablaghkol] from kalaTmp WHERE (IDfactor = " + idFactor + ") order by kalaID");
            stikol.Load("Rptkharid.mrt");
            stikol.RegData("factor", DataManagement.DT);
            stikol.Dictionary.DataSources.Items[0].DataTable = DataManagement.DT;
            stikol.Show();
        }

        private void kharid_Load(object sender, EventArgs e)
        {
            txtdate.Text = Data.Pdate(); 

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

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    double g, m;
                    m = double.Parse(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value.ToString());
                    g = double.Parse(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value.ToString());
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = g * m;
                    double maj = 0;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        maj += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                    lblKol.Text = maj.ToString();
                }
                catch {
                
                }
            }
        }

        private void txtcodemosh_Leave(object sender, EventArgs e)
        {
            DataManagement.DT = DataManagement.Search("select Name + ' ' + Family AS tmp from moshtari where id = " + txtcodemosh.Text + "");
            txtnamemosh.Text = DataManagement.DT.Rows[0][0].ToString();
        }

        private void txtcodemosh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lblKol_TextChanged(object sender, EventArgs e)
        {
            lblMande.Text = (double.Parse(lblKol.Text) - (double.Parse(txtnaghdi.Text) + double.Parse(lbljamchek.Text))).ToString();
        }

        private void txtnaghdi_TextChanged(object sender, EventArgs e)
        {
            DisplaySum();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataManagement.DT = DataManagement.Search("SELECT Job FROM Properties WHERE (Id = " + txtcodemosh.Text + ")");
            if (DataManagement.DT.Rows.Count == 0) return;
            label16.Text = DataManagement.DT.Rows[0][0].ToString();
            double sum = double.Parse(lblMande.Text) + double.Parse(label16.Text);
        }
    }
}
