using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirportDamage_S
{
    public partial class Home : Form
    {
        private string staffName = "";
        private int isAdmin;
        private int staffId;
        LogIn grs;
        public Home(int id, string staffName, int isAdmin, LogIn _grs)
        {
            this.staffId = id;
            this.staffName = staffName;
            this.isAdmin = isAdmin;
            grs = _grs;
           
           // grs.Hide();
           // grs.Close();
            
            InitializeComponent();
        }


        private void Delivery_Click(object sender, EventArgs e)
        {
            Form t = new Delivery();
            t.Show();

        }

        private void ListDamage_Click(object sender, EventArgs e)
        {
            ListDamageRecord t = new ListDamageRecord();
            t.Show();
        }

        private void Damagerecording_Click_1(object sender, EventArgs e)
        {
            newDamageAdd yk = new newDamageAdd(staffId,staffName);
            yk.Show();
        }

        private void newRecordTransactions_Click(object sender, EventArgs e)
        {
            AddRepair te = new AddRepair();
            te.Show();
        }

        private void NewDamageType_Click(object sender, EventArgs e)
        {
            NewDamageType yu = new NewDamageType();
            yu.Show();
        }

        private void NewRecordT_Click(object sender, EventArgs e)
        {
            NewRecordTransactions yt = new NewRecordTransactions();
            yt.Show();

        }

        private void NewComp_Click(object sender, EventArgs e)
        {
            NewComplaint ys = new NewComplaint();
            ys.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (this.isAdmin == 0)
            {
                NewaddWorker.Enabled = false;
                NewaddWorker.Visible = false;
                DeleteWorker.Enabled = false;
                DeleteWorker.Visible = false;

            }

          
        }



        private void eskiÇalışanıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new UpdateRecord();
            x.Show();
        }

        private void NewaddWorker_Click(object sender, EventArgs e)
        {
            Form x = new AddWorker();
            x.Show();

        }

        private void DeleteWorker_Click(object sender, EventArgs e)
        {
            Form t = new DeleteAttendant();
            t.Show();
        }

        ~Home()
        {
            MessageBox.Show("deneme başarılı");
            //grs.Dispose();
            //grs.Close();
            grs.RemoveOwnedForm(grs);
            grs.Invalidate();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Damageinformation_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void airportRunwayToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form xt = new AirportRunAway();
            xt.Show();
        }

        private void costToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form tz = new TotalCost();
            tz.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        //protected override void Finalize()
        //{
        //    try
        //    {
        //        // Cleanup statements...
        //    }
        //    finally
        //    {
        //        base.Finalize();
        //        base.
        //    }
        //}

    }
}
