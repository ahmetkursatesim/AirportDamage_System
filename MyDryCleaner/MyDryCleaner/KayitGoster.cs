using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;

namespace MyDryCleaner
{
    public partial class KayitGoster : Form
    {
        public KayitGoster()
        {
            InitializeComponent();
        }

        private void KayitGoster_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource= dt;
            dataGridView1.Columns["garment_id"].HeaderText = "Ürün ID";
            dataGridView1.Columns["staff_details"].HeaderText = "Teslim Alan";
            dataGridView1.Columns["cost"].HeaderText = "Tutar";
            dataGridView1.Columns["brought_in_date"].HeaderText = "Giriş Tarihi";
            dataGridView1.Columns["actual_return_date"].HeaderText = "Tamamlanma Tarihi";
            dataGridView1.Columns["pickup_date"].HeaderText = "Alınış Tarihi";
            dataGridView1.Columns["customer_details"].HeaderText = "Müşteri Bilgileri";
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
