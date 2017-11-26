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
    public partial class UpdateRecord : Form
    {
        public String transactId;
        public MySqlConnection con;
        public UpdateRecord()
        {
            InitializeComponent();
        }
        public UpdateRecord(String id)
        {
            InitializeComponent();
            transactId = id;
            con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
        }
        private void KayitDuzenle_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter
                ("select damageabout_id,cost,brought_in_date,actual_return_date,pickup_date,other_details from damageabout where damageabout.damageabout_id = '"+transactId+"'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["damageabout_id"].HeaderText = "DamageId";
        
            dataGridView1.Columns["cost"].HeaderText = "Tutar";
            dataGridView1.Columns["brought_in_date"].HeaderText = "BroughtDate";
            dataGridView1.Columns["actual_return_date"].HeaderText = "Return Date";
            dataGridView1.Columns["pickup_date"].HeaderText = "Transaction completion time";
            dataGridView1.Columns["other_details"].HeaderText = "Other Details";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            String cost = dataGridView1[1,0].Value.ToString();
            String brgDate = dataGridView1[2, 0].Value.ToString();
          //  String expDate = dataGridView1[3, 0].Value.ToString();
            String actDate = dataGridView1[3, 0].Value.ToString();
            String pickDate = dataGridView1[4, 0].Value.ToString();
            String others = dataGridView1[5, 0].Value.ToString();
            MySqlCommand cmd = new MySqlCommand("UPDATE damageabout set cost='"+cost+"',brought_in_date='"+brgDate+"',actual_return_date='"+actDate+"',pickup_date='"+pickDate+"',other_details='"+others+"' where damageabout.damageabout_id = '"+transactId+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
