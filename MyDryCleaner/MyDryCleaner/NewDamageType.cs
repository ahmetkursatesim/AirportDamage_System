using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql;


namespace AirportDamage_S
{
    public partial class NewDamageType : Form
    {
        public MySqlConnection cnn;
        static String txtSunucu = "localhost";
        static String txtUserName = "root";
        static String txtPassword = "1234";
        public List<String> UrunValues = new List<string>();

        public NewDamageType()
        {
            InitializeComponent();
            String conString = String.Format("server={0};database=airportd; user id={1};password={2}", txtSunucu, txtUserName, txtPassword);//Bağlantı bilgilerimiz
            cnn = new MySqlConnection(conString);//Bağlantı komutumuz
            //cnn.Open();
            //cnn.ChangeDatabase("drycleaner");
        }

        private void YeniUrun_Load(object sender, EventArgs e)
        {
            UrunValues.Clear();
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_transactions_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    lstVwUrunler.Items.Add(read["transactions_type_description"].ToString()+" - "+read["transactions_time"].ToString()+" gün");
                    UrunValues.Add(read["transactions_type_code"].ToString());
                    
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
                if (txtAciklama.Text != "" && txtIslemSuresi.Text != "")
                {
                    cnn.Open();
                    MySqlCommand cmdCustomer = new MySqlCommand("select count(*) as cnt from ref_transactions_types where transactions_type_description='"+txtAciklama.Text+"'", cnn);
                    MySqlDataReader readerCustomer = cmdCustomer.ExecuteReader();
                    readerCustomer.Read();
                    int count = int.Parse(readerCustomer["cnt"].ToString());
                    readerCustomer.Close();
                    cnn.Close();
                    if (count == 0)
                    {
                        cnn.Open();
                        MySqlCommand command = new MySqlCommand("INSERT INTO airportd.ref_transactions_types  (transactions_type_description, transactions_time) VALUES ('" + txtAciklama.Text + "','" + txtIslemSuresi.Text.ToString() + "')", cnn);
                        //MySqlCommand command = new MySqlCommand("INSERT INTO drycleaner.ref_garment_types  (garment_type_description, days_to_clean) VALUES ('ayak','3')", cnn);

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
            UrunValues.Clear();
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_transactions_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    lstVwUrunler.Items.Add(read["transactions_type_description"].ToString() + " - " + read["transactions_time"].ToString() + " gün");
                    UrunValues.Add(read["transactions_type_code"].ToString());

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
                MySqlCommand command = new MySqlCommand("DELETE FROM airportd.ref_transactions_types WHERE airportd.ref_transactions_types.transactions_type_code=" + UrunValues[lstVwUrunler.SelectedItems[0].Index].ToString(), cnn);
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
            UrunValues.Clear();
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_transactions_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    lstVwUrunler.Items.Add(read["transactions_type_description"].ToString() + " - " + read["transactions_time"].ToString() + " gün");
                    UrunValues.Add(read["transactions_type_code"].ToString());

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

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
