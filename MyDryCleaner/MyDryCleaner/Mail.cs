using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Sockets;

namespace AirportDamage_S
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
           
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mes = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("AirportDamageSystem@outlook.com", "krstahmet1235");
            smtp.Port = 587;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl=true;
            mes.To.Add(Subjecttxt.Text);
            mes.From = new MailAddress("AirportDamageSystem@outlook.com", "krstahmet1235");
            mes.Subject = Title.Text;
            mes.Body = Message.Text;
            smtp.Send(mes);
            MessageBox.Show("Mail was sent");
          
        }

        private void Subjecttxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
