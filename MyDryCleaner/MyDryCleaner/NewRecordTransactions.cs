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
    public partial class NewRecordTransactions : Form
    {
        public MySqlConnection cnn;
        static String txtSunucu = "localhost";
        static String txtUserName = "root";
        static String txtPassword = "1234";
        public List<String> UrunValues = new List<string>();

        public NewRecordTransactions()
        {
            InitializeComponent();
            String conString = String.Format("server={0}; user id={1};password={2};database=airportd;", txtSunucu, txtUserName, txtPassword);//Bağlantı bilgilerimiz
            cnn = new MySqlConnection(conString);//Bağlantı komutumuz
        }

        private void YeniTamirat_Load(object sender, EventArgs e)
        {
            UrunValues.Clear();
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_repair_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    lstVwUrunler.Items.Add(read["repair_type_description"].ToString() + " - " + read["standard_price"].ToString() + " lira");
                    UrunValues.Add(read["repair_type_code"].ToString());

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
                    MySqlCommand cmdCustomer = new MySqlCommand("select count(*) as cnt from ref_repair_types where repair_type_description='" + txtAciklama.Text + "'", cnn);
                    MySqlDataReader readerCustomer = cmdCustomer.ExecuteReader();
                    readerCustomer.Read();
                    int count = int.Parse(readerCustomer["cnt"].ToString());
                    readerCustomer.Close();
                    cnn.Close();
                    if (count == 0)
                    {
                        cnn.Open();
                        MySqlCommand command = new MySqlCommand("INSERT INTO airportd.ref_repair_types  (repair_type_description, standard_price) VALUES ('" + txtAciklama.Text + "','" + txtIslemSuresi.Text.ToString() + "')", cnn);
                      

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
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_repair_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    lstVwUrunler.Items.Add(read["repair_type_description"].ToString() + " - " + read["standard_price"].ToString() + " lira");
                    UrunValues.Add(read["repair_type_code"].ToString());

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
                MySqlCommand command = new MySqlCommand("DELETE FROM airportd.ref_repair_types WHERE airportd.ref_repair_types.repair_type_code=" + UrunValues[lstVwUrunler.SelectedItems[0].Index].ToString(), cnn);
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_repair_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    lstVwUrunler.Items.Add(read["repair_type_description"].ToString() + " - " + read["standard_price"].ToString() + " lira");
                    UrunValues.Add(read["repair_type_code"].ToString());

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
    }
}
