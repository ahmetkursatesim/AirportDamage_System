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
    public partial class Gmap : Form
    {
        public Gmap()
        {
            InitializeComponent();
        }
        public static string lat;
        public static string longt;
        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void Gmap_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.YandexSatelliteMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(40.1246901, 32.9904012);

            
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT Longtitude,Latitude  FROM damageinfo ", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Longtitude"].HeaderText = "Longtitude";
            dataGridView1.Columns["Latitude"].HeaderText = "Latitude";
            // dataGridView1.DataBindings=
            timer1.Start();
            MySqlDataAdapter da = new MySqlDataAdapter("Select Longtitude,Latitude from damageinfo", con);
            MySqlCommandBuilder cBuilder = new MySqlCommandBuilder(da);

            for (int i = dt.Rows.Count-1; i >= 0; i--)
            {
                double lng = double.Parse(dt.Rows[i][0].ToString());
                double lati = double.Parse(dt.Rows[i][1].ToString());
                GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
                GMap.NET.WindowsForms.GMapMarker marker =
                    new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        new GMap.NET.PointLatLng(lati, lng),
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
                markers.Markers.Add(marker);
                gMapControl1.Overlays.Add(markers);
                marker.ToolTipText = "hello\nout there";


             

                GMap.NET.WindowsForms.GMapOverlay polyOverlay = new GMap.NET.WindowsForms.GMapOverlay("polygons");
                List<PointLatLng> points = new List<PointLatLng>();
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



        private void button1_Click_1(object sender, EventArgs e)
        {
            lat = gMapControl1.Position.Lat.ToString();
            longt = gMapControl1.Position.Lng.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=airportd; userid=root; password=1234;");
            con.Open();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}