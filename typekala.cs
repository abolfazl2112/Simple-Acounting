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
    public partial class typekala : Form
    {
        public typekala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtCode.Enabled)
                DataManagement.DT = DataManagement.I_U_D("SELECT kala.* FROM kala", "INSERT INTO kala (name, vahed, ghimat, vazn) VALUES (N'" + txtName.Text + "', N'" + txtVahed.Text + "', N'" + txtPrice.Text + "', N'" + txtMeghdar.Text + "')");
            else
                DataManagement.DT = DataManagement.I_U_D("SELECT kala.* FROM kala", "UPDATE kala SET name = N'" + txtName.Text + "', vahed = N'" + txtVahed.Text + "', ghimat = N'" + txtPrice.Text + "', vazn = N'" + txtMeghdar.Text + "' WHERE (kalaID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")");

            dataGridView1.DataSource = DataManagement.DT;
            dataGridView1.Refresh();

            groupBox1.Enabled = false;
            txtCode.Text = txtMeghdar.Text = txtName.Text = txtPrice.Text = txtVahed.Text = "";
            if (!txtCode.Enabled) txtCode.Enabled = true;
            btnNew.Focus();
            typekala_Load(null, null);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtCode.Enabled = false;
            txtName.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            groupBox1.Enabled = true;
            txtCode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtVahed.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMeghdar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCode.Focus();

        }

        private void typekala_Load(object sender, EventArgs e)
        {
            DataManagement.DT = DataManagement.Search("SELECT kalaID[کد کالا], name[نام کالا], vahed[واحد], ghimat[قیمت], vazn[مقدار] FROM kala");
            dataGridView1.DataSource = DataManagement.DT;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            txtCode.Text = txtMeghdar.Text = txtName.Text = txtPrice.Text = txtVahed.Text = "";
            if (!txtCode.Enabled) txtCode.Enabled = true;
            btnNew.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"آیا برای حذف مطمئن هستید؟","اخطار",MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            if (dataGridView1.RowCount == 0) return;
            DataManagement.DT = DataManagement.I_U_D("SELECT kalaID[کد کالا], name[نام کالا], vahed[واحد], ghimat[قیمت], vazn[مقدار] FROM kala", "DELETE FROM kala WHERE (kalaID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ")");
            dataGridView1.DataSource = DataManagement.DT;
            typekala_Load(null, null);
            
        }

        private void btnKey_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
