using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WMS
{
    public partial class Home : Form
    {
        private string connectionString1 = "Data Source=192.168.0.16;Database=LineTracer;User ID=root;Password=1234";
        private string connectionString2 = "Data Source=192.168.0.16;Database=SmartFactory;User ID=root;Password=1234";

        public Home(String UserID)
        {
            InitializeComponent();
            User.Text = UserID;
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            btn_page1_Click(sender, e);
        }

        private void btn_page1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            inventory.SelectTab(0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_today.Text = DateTime.Now.ToString();

            int today_year = DateTime.Now.Year;
            int today_month = DateTime.Now.Month;
            int today_day = DateTime.Now.Day;

            int good_num = GetNum("select count(*) from Product where 품질=\"양호\"");
            int notgood_num = GetNum("select count(*) from Product where 품질=\"불량\"");
            lbl_good_num.Text = good_num.ToString();
            lbl_notgood_num.Text = notgood_num.ToString();

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString1);
            mySqlConnection.Open();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM Inventory", mySqlConnection);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            int today_good_num = GetNum("select count(*) from Product " +
                "where 품질=\"양호\" and (생산시간>=\"" + today_year.ToString() + "-" + today_month.ToString() + "-"
                + today_day.ToString() + " 00:00:00\" and 생산시간<=\"" + today_year.ToString() + "-"
                + today_month.ToString() + "-" + today_day.ToString() + " 23:59:59\")");
            int today_notgood_num = GetNum("select count(*) from Product " +
                "where 품질=\"불량\" and (생산시간>=\"" + today_year.ToString() + "-" + today_month.ToString() + "-"
                + today_day.ToString() + " 00:00:00\" and 생산시간<=\"" + today_year.ToString() + "-"
                + today_month.ToString() + "-" + today_day.ToString() + " 23:59:59\")");
            lbl_today_good.Text = good_num.ToString();
            lbl_today_notgood.Text = notgood_num.ToString();

            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM Stat", mySqlConnection);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            lbl_tracer1_stat.Text = dt2.Rows[0][0].ToString();
            lbl_tracer2_stat.Text = dt2.Rows[0][1].ToString();
            int tracer1_stat = CharToInt(dt2.Rows[0][0].ToString()[0]) % 5;
            int tracer2_stat = CharToInt(dt2.Rows[0][1].ToString()[0]) % 3;

            if (tracer1_stat == 1)
                lbl_tracer1_stat.Text = "공장 -> 창고1";
            else if (tracer1_stat == 2)
                lbl_tracer1_stat.Text = "창고1 -> 공장";
            else if (tracer1_stat == 3)
                lbl_tracer1_stat.Text = "공장 -> 창고2";
            else if (tracer1_stat == 4)
                lbl_tracer1_stat.Text = "창고2 -> 공장";
            else
                lbl_tracer1_stat.Text = "대기중";

            if(tracer2_stat == 1)
                lbl_tracer2_stat.Text = "공장 -> 불량창고";
            else if (tracer2_stat == 2)
                lbl_tracer2_stat.Text = "불량창고 -> 공장";
            else
                lbl_tracer2_stat.Text = "대기중";

            pictureBox1.Image = imageList1.Images[(((tracer1_stat) * 3) + (tracer2_stat))];

            mySqlConnection.Close();
        }

        private void btn_page2_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            tracer_stat.SelectTab(0);
        }

        public int CharToInt(char ch)
        {
            int i = (int)ch - 48;
            
            return i;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;

            int record_good = GetNum("select count(*) from Product " +
                "where 품질=\"양호\" and (생산시간>=\"" + year.ToString() + "-" + month.ToString() + "-"
                + day.ToString() + " 00:00:00\" and 생산시간<=\"" + year.ToString() + "-"
                + month.ToString() + "-" + day.ToString() + " 23:59:59\")");
            int record_notgood = GetNum("select count(*) from Product " +
                "where 품질=\"불량\" and (생산시간>=\"" + year.ToString() + "-" + month.ToString() + "-"
                + day.ToString() + " 00:00:00\" and 생산시간<=\"" + year.ToString() + "-"
                + month.ToString() + "-" + day.ToString() + " 23:59:59\")");
            lbl_record_good.Text = record_good.ToString();
            lbl_record_notgood.Text = record_notgood.ToString();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int GetNum(string str)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString2);
            mySqlConnection.Open();
            MySqlCommand count = new MySqlCommand(str, mySqlConnection);
            int myCount = Convert.ToInt32(count.ExecuteScalar());
            mySqlConnection.Close();

            return myCount;
        }

        private void button_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
