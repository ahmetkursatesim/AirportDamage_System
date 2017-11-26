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
    public partial class AirportRunAway : Form
    {
        public AirportRunAway()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AirportRunAway_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select Damage_Name,AirportRunAway_Name,DamageCategory from damageinfo  ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;
           
            dataGridView1.Columns["Damage_Name"].HeaderText = "DamageName";
            dataGridView1.Columns["AirportRunAway_Name"].HeaderText = "Airport Track";
            dataGridView1.Columns["DamageCategory"].HeaderText = "Damage Category";
            // dataGridView1.DataBindings=
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select Damage_Name,AirportRunAway_Name,DamageCategory from damageinfo  ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlCommand adapter = new MySqlCommand("select count(*) as cnt from damageinfo where AirportRunAway_Name=" + trackname.Text.ToString(), con);
          
            MySqlDataReader readerC = adapter.ExecuteReader();
          
            readerC.Read();
           
            int count = int.Parse(readerC["cnt"].ToString());
           
            readerC.Close();

            MySqlCommand adapt = new MySqlCommand("select  max(DamageCategory) as cn from damageinfo where AirportRunAway_Name=" + trackname.Text.ToString(), con);
            MySqlDataReader reader = adapt.ExecuteReader();
            reader.Read();
            int co = int.Parse(reader["cn"].ToString());
            reader.Close();
            if (co<=2 && count<=4)
            {

                MessageBox.Show("Airfield is open");


            }
            else
            {

                MessageBox.Show("Airfield is close");

            }


        }

        private void trackname_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlCommand adapter = new MySqlCommand("select count(*) as 1_Airfield from damageinfo where AirportRunAway_Name=1" , con);

            MySqlDataReader readerC = adapter.ExecuteReader();

            readerC.Read();

            int count1 = int.Parse(readerC["1_Airfield"].ToString());

            readerC.Close();
            /////////////////////////////////////////////////////
            MySqlCommand adap = new MySqlCommand("select count(*) as 2_Airfield from damageinfo where AirportRunAway_Name=2", con);

            MySqlDataReader read = adap.ExecuteReader();

            read.Read();

            int count2 = int.Parse(read["2_Airfield"].ToString());

            read.Close();

            //////////////////////////////////////////////////////
            MySqlCommand ada = new MySqlCommand("select count(*) as 3_Airfield from damageinfo where AirportRunAway_Name=3", con);

            MySqlDataReader rea = ada.ExecuteReader();

            rea.Read();

            int count3 = int.Parse(rea["3_Airfield"].ToString());

            rea.Close();


            //////////////////////////
            MySqlCommand ad = new MySqlCommand("select brought_in_date as date from damageabout", con);

            MySqlDataReader re = ad.ExecuteReader();

            re.Read();

            string adate = re["date"].ToString();

            re.Close();

            /////////////////////////////////////////////////////////////
            this.chart1.Series["1.AirField"].Points.AddXY(adate,count1);
            this.chart1.Series["2.AirField"].Points.AddXY(adate,count2);
            this.chart1.Series["3.AirField"].Points.AddXY(adate,count3);
        }
    }
}
