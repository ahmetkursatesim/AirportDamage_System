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
    public partial class Delivery : Form
    {
        MySqlConnection con;
        
        public Delivery()
        {
            InitializeComponent();
        }

        private void Teslimat_Load(object sender, EventArgs e)
        {
            btnduty.Hide();
           con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
           con.Open();
           pictureBox1.ImageLocation = "7.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
          
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");

            MySqlDataAdapter adapter = new MySqlDataAdapter("select damageabout.damageabout_id, pickup_date, repair_cost, repair_type_description from airportd.damageabout, airportd.repairs, airportd.ref_repair_types where  repairs.damageabout_id = damageabout.damageabout_id  and ref_repair_types.repair_type_code = repairs.repair_type_code and damageabout.damageabout_id="+textBox1.Text.ToString() , con);
            DataSet ds = new DataSet();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["damageabout_id"].HeaderText="Damage ID";
            dataGridView1.Columns["pickup_date"].HeaderText = "Transaction completion time";
          
            dataGridView1.Columns["repair_type_description"].HeaderText = "Repairt";
            dataGridView1.Columns["repair_cost"].HeaderText = "Repair";

            btnduty.Show();
            
        }

        private void btnDuty_Click(object sender, EventArgs e)
        {

            
            if (dataGridView1[1, 0].Value.ToString() =="" )
            {
                if (dataGridView1[1, 0].Value.ToString() != "")
                {
                  
                    MySqlCommand adp = new MySqlCommand("update damageabout set pickup_date='" +
                    DateTime.Now.ToShortDateString() + "' where damageabout_id = " + dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString(), con);
                    adp.ExecuteNonQuery();
                    dataGridView1.Columns.Clear();

                    btnGet_Click(this, e);
                    MessageBox.Show(" completed");
                }
                else
                    MessageBox.Show("Not Completed"); 
            }
            else
                MessageBox.Show("ready for use");
       
        }
        ~Delivery()
        {
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mail open = new Mail();
            open.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
