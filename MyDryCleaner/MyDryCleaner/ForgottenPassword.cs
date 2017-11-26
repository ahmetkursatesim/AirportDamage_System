using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
namespace AirportDamage_S
{
    public partial class ForgottenPassword : Form
    {
        MySqlCommand cmdF;
        String pass;
        public ForgottenPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SendPassword_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();


            cmdF = new MySqlCommand("select  password from staff where user_name='"
                  + UserName.Text.ToString() + "'", con);
            MySqlDataReader reader = cmdF.ExecuteReader();
            while (reader.Read())
            {
              
                pass = reader["password"].ToString();

            }
            MailMessage mes = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("AirportDamageSystem@outlook.com", "krstahmet1235");
            smtp.Port = 587;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;
            mes.To.Add(MailS.Text);
            mes.From = new MailAddress("AirportDamageSystem@outlook.com", "krstahmet1235");
            mes.Subject = "Forgotten Paswword";
            mes.Body =pass ;
            smtp.Send(mes);
            MessageBox.Show("Mail was sent");

        }

        private void ForgottenPassword_Load(object sender, EventArgs e)
        {
           

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
