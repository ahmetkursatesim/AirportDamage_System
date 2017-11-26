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
    public partial class LogIn : Form
    {
        string id = "";
        string name = "";
        string username = "";
        string password= "";


        MySqlConnection con;
        public LogIn()
        {
            InitializeComponent();
            con = new MySqlConnection("datasource= localhost; database=airportd; userid= root; password='1234';");
            con.Open();


        }
        private void GirisYap(int admin)
        {
            MySqlCommand cmd;
            try
            {
                if (admin == 1)
                {
                    cmd = new MySqlCommand("select staff_id, staff_details, password from staff where is_admin= true and user_name='"
                        + txt_username.Text.ToString() + "'", con);
                   
                }
                else
                {
                     cmd = new MySqlCommand("select staff_id, staff_details, password from staff where is_admin= false and user_name='"
                       + txt_username.Text.ToString() + "'", con);
                   
                }

                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader["staff_id"].ToString();
                    name = reader["staff_details"].ToString();
                    password = reader["password"].ToString();

                }
                reader.Close();

                if (txt_password.Text.ToString() == password)
                {
                    int _id = int.Parse(id);

                    Form x = new  Home(_id, name, admin, this);
                  //  Form x = new Form();
                    
                    x.Show();
                    //this.Dispose();

                }

            }
            catch
            {

            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            GirisYap(1);
 
        }
        ~LogIn()
        {
            con.Close();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            GirisYap(0);
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
           
           
         
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Form x = new ForgottenPassword();
           
          

            x.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
