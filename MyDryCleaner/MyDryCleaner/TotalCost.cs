using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AirportDamage_S
{
    public partial class TotalCost : Form
    {
        public TotalCost()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetTotalCost_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT SUM(cost) as TotalCost FROM damageabout where brought_in_date='" + dateTimePicker1.Value.ToShortDateString() + "'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void TotalCost_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT SUM(cost) as TotalCost FROM damageabout ", con);
            DataTable dt = new DataTable();
          adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["TotalCost"].HeaderText = "Total Cost";
         
            // dataGridView1.DataBindings=
            timer1.Start();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();

            MySqlCommand a = new MySqlCommand("SELECT cost,Sum(cost) as Totalcost FROM damageabout ", con);

            MySqlDataReader r = a.ExecuteReader();

            r.Read();

            int Totalcost = int.Parse(r["cost"].ToString());
            int Tcost = int.Parse(r["TotalCost"].ToString());



            r.Close();

            

            /////////////////////////////////////////////////////////////
           this.chart1.Series["Total Cost"].Points.AddXY(Tcost,Totalcost);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listcost_Click(object sender, EventArgs e)
        {


            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT cost,brought_in_date  FROM damageabout ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Cost"].HeaderText = "Cost";
            dataGridView1.Columns["brought_in_date"].HeaderText = "Date";

            // dataGridView1.DataBindings=
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT sum(cost) as TotalCost FROM damageabout ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["TotalCost"].HeaderText = "TotalCost";
           

            // dataGridView1.DataBindings=
            timer1.Start();
        }
    }
}
