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
    public partial class newDamageAdd : Form
    {
        public string map;
        MySqlConnection con;
        List<String> cbTypeId = new List<string>();
        List<String> cmbComId = new List<string>();
        List<String> cmbComtId = new List<string>();
        List<String> cmbCompListId = new List<string>();
        private int staffId;
        private string staffName = "";

        public newDamageAdd(int staffId, string staffName)
        {
            this.staffId = staffId;
            this.staffName = staffName;
            InitializeComponent();
            con = new MySqlConnection("datasource= localhost; database=airportd; userid=root; password=1234;");
            con.Open(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
       
          string temp = txtName.Text.ToString();
            string temp2=txtLongtitude.Text.ToString();
            string temp3 = Latitude.Text.ToString();
            string temp4 = Runaway.Text.ToString();
            string temp5 = DamageCategory.Text.ToString();
            MySqlCommand cmdd = new MySqlCommand("insert into damageinfo(Damage_Name,Longtitude,Latitude,AirportRunAway_Name,DamageCategory) value ('" + temp + "','" + temp2 + "','" + temp3 + "','" + temp4 + "','" + temp5 + "')", con);
          cmdd.ExecuteNonQuery();
       
          MySqlCommand cmdCustomer = new MySqlCommand("select max(Damage_id) as cusId from damageinfo",con);
          MySqlDataReader readerCustomer = cmdCustomer.ExecuteReader();
          readerCustomer.Read();
          String DamageId = readerCustomer["cusId"].ToString();
          readerCustomer.Close();

          String transactionId = cbTypeId[cbType.SelectedIndex];
       

           MySqlCommand command = new MySqlCommand("insert into damageabout (transactions_type_code,staff_id,cost,brought_in_date,expected_return_date,Damage_id,pickup_date,actual_return_date) values ("+transactionId+","+ staffId+",'"+
           txtCost.Text.ToString() + "','" + time1.Value.ToShortDateString() + "','" + time1.Value.ToShortDateString() + "', "+DamageId+",'','')", con);
           command.ExecuteNonQuery();


            cmdCustomer = new MySqlCommand("select max(damageabout_id) as tarId from damageabout", con);
            readerCustomer = cmdCustomer.ExecuteReader();
           readerCustomer.Read();
           String transactionsId = readerCustomer["tarId"].ToString();
           readerCustomer.Close();


           for (int i = 0; i < Complaint.Items.Count; i++)
			{
                cmdd = new MySqlCommand("insert into complaints(complaint_type_code,Damage_id,damageabout_id,complaint_details) values ('" + cmbCompListId[i].ToString() + "','"+DamageId+"','"+transactionsId+"','')", con);
                cmdd.ExecuteNonQuery();
			}


           MessageBox.Show("Kayıt " + transactionsId + "  Numarasıyla Eklendi");
    
        }

        private void YeniKayitEkle_Load(object sender, EventArgs e)
        {

           

            lblStaffName.Text = staffName;
            MySqlCommand cmd = new MySqlCommand ("select * from  ref_transactions_types", con);
            MySqlDataReader reader= cmd.ExecuteReader();
            while(reader.Read())
            {
                cbType.Items.Add(reader["transactions_type_description"].ToString());
                cbTypeId.Add(reader["transactions_type_code"].ToString());
            }
           
            reader.Close();


            cmd = new MySqlCommand("select * from  ref_complaint_types", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbComplaint.Items.Add(reader["complaint_type_description"].ToString());
                cmbComtId.Add(reader["complaint_type_code"].ToString());
            }
            reader.Close();
          
        }

       private void cmbStaffId_SelectedIndexChanged(object sender, EventArgs e)
       {
        //    txtStaffName.Clear();
        //    MySqlCommand cmd = new MySqlCommand("select * from  staff where staff_id ="+ cmbStaffId.SelectedValue+"", con);
        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        txtStaffName.Text = reader["staff_details"].ToString();
        //    }
        //     reader.Close();
            
            
       }
        ~newDamageAdd()
        {
            con.Close();
        }

        private void cmbComplaint_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Complaint.Items.Add(cmbComplaint.Text);
            cmbCompListId.Add(cmbComtId[cmbComplaint.SelectedIndex]);
         

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLongtitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void Latitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void Complaint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gmap a = new Gmap();
            a.Show();
      
         

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            Latitude.Text = Gmap.lat;
            txtLongtitude.Text = Gmap.longt;

        }

        private void Runaway_TextChanged(object sender, EventArgs e)
        {

        }

        private void DamageCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void time1_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void gMapControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
