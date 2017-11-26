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
    public partial class NewComplaint : Form
    {
        public MySqlConnection cnn;
        static String txthost = "localhost";
        static String txtUserName = "root";
        static String txtPassword = "1234";
        public List<String> damageValues = new List<string>();
        public NewComplaint()
        {
            InitializeComponent();
            String conString = String.Format("server={0}; user id={1};password={2};database=airportd;", txthost, txtUserName, txtPassword);//Bağlantı bilgilerimiz
            cnn = new MySqlConnection(conString);//Bağlantı komutumuz
        }

        private void YeniSikayet_Load(object sender, EventArgs e)
        {
            damageValues.Clear();
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_complaint_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    lstVwUrunler.Items.Add(read["complaint_type_description"].ToString());
                    damageValues.Add(read["complaint_type_code"].ToString());

                }
                read.Close();

                cnn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAciklama.Text != "")
                {
                    cnn.Open();
                    MySqlCommand cmdCustomer = new MySqlCommand("select count(*) as cnt from ref_complaint_types where complaint_type_description='" + txtAciklama.Text + "'", cnn);
                    MySqlDataReader readerCustomer = cmdCustomer.ExecuteReader();
                    readerCustomer.Read();
                    int count = int.Parse(readerCustomer["cnt"].ToString());
                    readerCustomer.Close();
                    cnn.Close();
                    if (count == 0)
                    {
                        cnn.Open();
                        MySqlCommand command = new MySqlCommand("INSERT INTO airportd.ref_complaint_types  (complaint_type_description) VALUES ('" + txtAciklama.Text + "')", cnn);
                       

                        command.ExecuteNonQuery();
                        cnn.Close();
                    }
                    else
                        MessageBox.Show("Böyle Bir Kayıt Mevcut.");

                }
                else
                    MessageBox.Show("Bütün alanları doldurun.");


               

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            //refresh list
            lstVwUrunler.Clear();
            damageValues.Clear();
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_complaint_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    lstVwUrunler.Items.Add(read["complaint_type_description"].ToString());
                    damageValues.Add(read["complaint_type_code"].ToString());

                }
                read.Close();

                cnn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM airportd.ref_complaint_types WHERE airportd.ref_complaint_types.complaint_type_code=" + damageValues[lstVwUrunler.SelectedItems[0].Index].ToString(), cnn);
                command.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Bu ürüne ait kayıt mevcut olduğu için silinemez");
                cnn.Close();
            }
            //refresh list
            lstVwUrunler.Clear();
            damageValues.Clear();
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_complaint_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    lstVwUrunler.Items.Add(read["complaint_type_description"].ToString());
                    damageValues.Add(read["complaint_type_code"].ToString());

                }
                read.Close();

                cnn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void lstVwUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
