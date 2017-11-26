using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace AirportDamage_S
{
    
    public partial class AddRepair : Form
    {
        public MySqlConnection cnn;
        static String txtSunucu="localhost";
        static String txtUserName = "root";
        static String txtPassword = "1234";
        public List<String> DamageValues = new List<string>();
        public List<string> TransValues = new List<string>();
        public List<string> TransListValues = new List<string>();



        public AddRepair()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TransactionsB_Load(object sender, EventArgs e)
        {
            String conString = String.Format("server={0}; user id={1};password={2}", txtSunucu, txtUserName, txtPassword);//Bağlantı bilgilerimiz
            cnn = new MySqlConnection(conString);//Bağlantı komutumuz
            try
            {
                cnn.Open();//Bağlantımı açıyoruz
                cnn.ChangeDatabase("airportd");
                getTran(cnn);
                getTransactions(cnn);

                cnn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        void getTran(MySqlConnection cnn)//database alanını dolduruyoruz
        {
            cmbBxDamageA.Items.Clear();//Öncelikle dropdown menümüzü temizliyoruz

             DamageValues.Clear();
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT damageabout_id,Damage_Name,Longtitude,Latitude,transactions_type_description FROM airportd.damageabout,airportd.ref_transactions_types,airportd.damageinfo where airportd.damageinfo.Damage_id=airportd.damageabout.Damage_id and airportd.ref_transactions_types.transactions_type_code=airportd.damageabout.transactions_type_code", cnn);
                    MySqlDataReader read = command.ExecuteReader();

                    while (read.Read())
                    {
                        cmbBxDamageA.Items.Add(read["Damage_Name"].ToString() + " - " + read["transactions_type_description"].ToString());
                        DamageValues.Add(read["damageabout_id"].ToString());
                    }
                    read.Close();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

           
        }
        void getTransactions(MySqlConnection cnn)//database alanını dolduruyoruz
        {
            TransactionsA.Items.Clear();//Öncelikle dropdown menümüzü temizliyoruz

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_repair_types", cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    TransactionsA.Items.Add(read["repair_type_description"].ToString());
                    TransValues.Add(read["repair_type_code"].ToString());
                }
                read.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbBxDamageA_SelectedIndexChanged(object sender, EventArgs e)
        {
            TasksA.Items.Clear();
            ActionA.Items.Clear();
            TransListValues.Clear();
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_repair_types,airportd.repairs where airportd.repairs.repair_type_code=airportd.ref_repair_types.repair_type_code and airportd.repairs.damageabout_id=" + DamageValues[cmbBxDamageA.SelectedIndex].ToString(), cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    TasksA.Items.Add(read["repair_type_description"].ToString());
                    TransListValues.Add(read["repair_id"].ToString());
                }
                read.Close();
                command = new MySqlCommand("SELECT * FROM airportd.ref_complaint_types,airportd.complaints,airportd.damageabout where airportd.ref_complaint_types.complaint_type_code=airportd.complaints.complaint_type_code and airportd.complaints.damageabout_id=airportd.damageabout.damageabout_id and   airportd.complaints.damageabout_id=" + DamageValues[cmbBxDamageA.SelectedIndex].ToString(), cnn);
                 read = command.ExecuteReader();
                while (read.Read())
                {
                    ActionA.Items.Add(read["complaint_type_description"].ToString());
                    TransListValues.Add(read["complaint_id"].ToString());
                }
                read.Close();
                cnn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAddTransactions_Click(object sender, EventArgs e)
        {

            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO airportd.repairs  (damageabout_id, repair_type_code, repair_cost) VALUES ("+DamageValues[cmbBxDamageA.SelectedIndex].ToString()+","+TransValues[TransactionsA.SelectedIndex].ToString()+", 10)", cnn);
                command.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
          
            TasksA.Items.Clear();

            TransListValues.Clear();

            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_repair_types,airportd.repairs where airportd.repairs.repair_type_code=airportd.ref_repair_types.repair_type_code and airportd.repairs.damageabout_id=" + DamageValues[cmbBxDamageA.SelectedIndex].ToString(), cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    TasksA.Items.Add(read["repair_type_description"].ToString());
                    TransListValues.Add(read["repair_id"].ToString());
                }
                read.Close();
                cnn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DeleteTrans_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM airportd.repairs WHERE airportd.repairs.repair_id="+TransListValues[TasksA.SelectedItems[0].Index].ToString(), cnn);
                command.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                cnn.Close();
            }

            TasksA.Items.Clear();
            TransListValues.Clear();
            try
            {
                cnn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM airportd.ref_repair_types,airportd.repairs where airportd.repairs.repair_type_code=airportd.ref_repair_types.repair_type_code and airportd.repairs.damageabout_id=" + DamageValues[cmbBxDamageA.SelectedIndex].ToString(), cnn);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    TasksA.Items.Add(read["repair_type_description"].ToString());
                    TransListValues.Add(read["repair_id"].ToString());
                }
                read.Close();
                cnn.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void TasksA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                
                cnn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE airportd.damageabout set actual_return_date='" + DateTime.Now.ToShortDateString() + "' where damageabout_id=" + DamageValues[cmbBxDamageA.SelectedIndex].ToString(), cnn);
                command.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("completed");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void TransactionsA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ActionA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
