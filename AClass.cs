using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Apple_Software
{
    class DataManagement
    {
       // public static SqlConnection SCO = new SqlConnection("server=(local);database=appledb;Integrated Security=True");
        public static SqlConnection SCO = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\AppleDatabase.mdf;Integrated Security=True;User Instance=True");
        public static SqlCommand SCM = new SqlCommand();
        public static SqlDataAdapter SDA = new SqlDataAdapter();
        public static SqlCommandBuilder SCB = new SqlCommandBuilder();
        public static DataTable DT = new DataTable();

        public static DataTable Search(string CTS)
        {
            if (SCO.State != ConnectionState.Open) SCO.Open();
            DT = new DataTable();
            SCM = new SqlCommand(CTS, SCO);
            SDA = new SqlDataAdapter(SCM);
            SCB = new SqlCommandBuilder(SDA);
            SDA.Fill(DT);
            return (DT);
        }

        public static DataTable I_U_D(string CTS, string CTSIDU)
        {
            if (SCO.State != ConnectionState.Open) SCO.Open();
            DT = new DataTable();
            SCM = new SqlCommand(CTS, SCO);
            SDA = new SqlDataAdapter(SCM);
            SCB = new SqlCommandBuilder(SDA);
            SDA.Fill(DT);
            SCM.CommandText = CTSIDU;
            SCM.ExecuteNonQuery();
            return (DT);
        }
    }
    class Data
    {
        public static String Persian()
        {
            string D, S;
            DateTime Mdate = DateTime.Now;
            PersianCalendar PD = new PersianCalendar();
            D = string.Format("{2} / {1} / {0}", PD.GetDayOfMonth(Mdate),
            PD.GetMonth(Mdate), PD.GetYear(Mdate));
            S = PD.GetDayOfWeek(Mdate).ToString();
            switch (S)
            {
                case "Saturday": return (D + " " + " :   شنبه");
                case "Sunday": return (D + " " + " :  یک شنبه");
                case "Monday": return (D + " " + " :  دو شنبه");
                case "Tuesday": return (D + " " + " :  سه شنبه");
                case "Wednesday": return (D + " " + " : چهار شنبه");
                case "Thursday": return (D + " " + " : پنج شنبه");
                case "Friday": return (D + " " + " :  جمعه");
            }
            return "Persian Data";
        }

        public static string Pdate()
        {
            string st = "";
            PersianCalendar pc = new PersianCalendar();
            int day, m, y;
            y = pc.GetYear(DateTime.Now);
            m = pc.GetMonth(DateTime.Now);
            day = pc.GetDayOfMonth(DateTime.Now);
            st = y.ToString() + ((m < 10) ? "0" + m.ToString() : m.ToString()) + ((day < 10) ? "0" + day.ToString() : day.ToString());
            return st;
        }

        public static string English()
        {
            string S;
            DateTime Mdate = DateTime.Now;
            S = Mdate.Day.ToString() + " / " + Mdate.Month.ToString() + " / " + Mdate.Year.ToString() + " : " + Mdate.DayOfWeek;
            return (S);
        }
    }
    class Languge_Keybord
    {
        public static void Persian()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("fa-ir"));
        }
        public static void English()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-us"));
        }
    }

    class Control
    {
        public static void Focus(TextBox TextBox, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13") TextBox.Focus();

        }
    }

    class Picture
    {
        public static string Location = "";
        public static int Pic(Form form)
        {
            OpenFileDialog ODI = new OpenFileDialog();
            ODI.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            ODI.Filter = "Picture As jpg|*.jpg|Picture As jpeg|*.jpeg*|Picture As bmp|*.bmp|Picture As gif|*.gif|Picture As wmf|*.wmf|Picture As png|*.png";
            if (ODI.ShowDialog(form) == DialogResult.OK)
                Location = ODI.FileName.ToString();
            return (0);
        }
    }

    class close
    {
        public static void Form(Form form)
        {
            DialogResult resualt;
            resualt = MessageBox.Show("آیا می خواهید از فرم خارج شوید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resualt == DialogResult.Yes) form.Close();
        }
    }

    class DetectForm
    {
        public static int F = 0;
        public static string Cod = "";
        public static string Key = "";
    }        
}
