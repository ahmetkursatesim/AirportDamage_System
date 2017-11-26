using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GMap.NET;

namespace AirportDamage_S
{
    public partial class ListDamageRecord : Form
    {
        public string lat;
        public string longt;
        public ListDamageRecord()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //Binding
        }

        private void ListDamageRecord_Load(object sender, EventArgs e)
        {
         
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select damageabout_id,cost,brought_in_date,actual_return_date,Damage_Name,Longtitude,Latitude,pickup_date,staff_details from damageabout, damageinfo, staff where damageabout.Damage_id = damageinfo.Damage_id and damageabout.staff_id= staff.staff_id order by damageabout_id", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["damageabout_id"].HeaderText = "Damageİd";
            dataGridView1.Columns["staff_details"].HeaderText = "Receiver";
            dataGridView1.Columns["cost"].HeaderText = "Cost";
            dataGridView1.Columns["brought_in_date"].HeaderText = "Date of entry";
            dataGridView1.Columns["actual_return_date"].HeaderText = "End Date";
            dataGridView1.Columns["pickup_date"].HeaderText = "Transaction completion time";
            dataGridView1.Columns["Damage_Name"].HeaderText = "DamageName";
            dataGridView1.Columns["Longtitude"].HeaderText = "Longtitude";
            dataGridView1.Columns["Latitude"].HeaderText = "Latitude";
           // dataGridView1.DataBindings=
            timer1.Start();
            gMapControl1.MapProvider = GMap.NET.MapProviders.YandexSatelliteMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(40.125563,32.995088 );
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                double lng = double.Parse(dt.Rows[i][5].ToString());
                double lati = double.Parse(dt.Rows[i][6].ToString());
                GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
                GMap.NET.WindowsForms.GMapMarker marker =
                    new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        new GMap.NET.PointLatLng(lati, lng),
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
                markers.Markers.Add(marker);
                gMapControl1.Overlays.Add(markers);
                marker.ToolTipText = "hello\nout there";


                 GMap.NET.WindowsForms.GMapOverlay polyOverlay = new GMap.NET.WindowsForms.GMapOverlay("polygons");
                List<GMap.NET.PointLatLng> points = new List<GMap.NET.PointLatLng>();
                points.Add(new PointLatLng(lati, lng));
                points.Add(new PointLatLng(lati - 0.0000000000200, lng + 0.0000980000000));
                points.Add(new PointLatLng(lati - 0.0003942299427, lng + 0.0001120000000));
                points.Add(new PointLatLng(lati - 0.0003942298427, lng + 0.0000030000000));
                GMap.NET.WindowsForms.GMapPolygon polygon = new GMap.NET.WindowsForms.GMapPolygon(points, "mypolygon");
                polygon.Fill = new SolidBrush(Color.FromArgb(100, Color.Red));
                polygon.Stroke = new Pen(Color.Red, 1);
                polyOverlay.Polygons.Add(polygon);
                gMapControl1.Overlays.Add(polyOverlay);


            }
          





        
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           double id1 = double.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            double id2= double.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());


       
            gMapControl1.Position = new GMap.NET.PointLatLng(id2,id1);




            String id = "";
            try
            {
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                UpdateRecord kd = new UpdateRecord(id);
                kd.Show();
            }
            catch
            {
            }
            dataGridView1.Columns.Clear();

          
        

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select damageabout_id,cost,brought_in_date,actual_return_date,Damage_Name,Longtitude,Latitude,pickup_date,staff_details from damageabout, damageinfo, staff where damageabout.Damage_id = damageinfo.Damage_id and damageabout.staff_id= staff.staff_id order by damageabout_id", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            dataGridView1.DataSource = dt;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
