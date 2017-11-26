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
    public partial class DeleteAttendant : Form
    {
        MySqlConnection con;
        List<String> cmbStaffId = new List<string>();
        public DeleteAttendant()
        {
            InitializeComponent();
            con = new MySqlConnection("datasource= localhost; database=airportd; userid=root; password=1234;");
            con.Open(); 
        }

        private void DeleteAttendant_Load(object sender, EventArgs e)
        {

            comboadd();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            MySqlCommand cmd = new MySqlCommand("delete from staff where staff_details='"+comboBox1.SelectedItem.ToString()+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted info");
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboadd();
        }
        private void comboadd()
        {
                        MySqlCommand cmd = new MySqlCommand("select* from staff", con);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["staff_details"].ToString());
                
                cmbStaffId.Add(reader["staff_id"].ToString());
            }
            reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("update  staff set user_name='"+textBox1.Text+ "',password='"+ textBox2.Text+ "' where staff_details='" + comboBox1.SelectedItem.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update info");
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboadd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select user_name,password from staff where staff_details='" + comboBox1.SelectedItem.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               
                textBox1.Text = reader["user_name"].ToString();
                textBox2.Text = reader["password"].ToString();
               
            }
            reader.Close();
        }
    }
}
