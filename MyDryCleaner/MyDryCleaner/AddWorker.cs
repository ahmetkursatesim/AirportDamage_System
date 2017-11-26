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
    public partial class AddWorker : Form
    {
        MySqlConnection con;
        public AddWorker()
        {
            InitializeComponent();
            con = new MySqlConnection("datasource= localhost; database= airportd; userid= root; password=1234");
            con.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtStaff.Text == "" || txtPassword.Text=="" || txtUserName.Text=="")
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            else
            {
                
                MySqlCommand cmd = new MySqlCommand("insert into staff(staff_details,user_name,password,is_admin) value('"+txtStaff.Text.ToString()+"','"+txtUserName.Text+"','"+txtPassword.Text+"',"+chckAdmin.Checked+")",con);
                int c=cmd.ExecuteNonQuery();
                MessageBox.Show(c.ToString());
                

            }
        }
        ~AddWorker()
        {
            con.Close();
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {

        }

        private void txtStaff_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chckAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
