using OpenPop.Pop3;
using Pop3EmailReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailApp
{
    public partial class mailSenderForm : Form
    {
        public mailSenderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            try
            {
                var senderEmail = new MailAddress(txtGonderenMail.Text, "");
                var receivereEmail = new MailAddress(txtKime.Text, "Receiver");
                var password = txtGonderenSifre.Text;

                var sub = txtKonu.Text;
                var body = txtMesaj.Text;
                var smtp = new SmtpClient

                {
                    Timeout = 100000,
                    Host = "smtp.live.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using (var mess = new MailMessage(senderEmail, receivereEmail)
                {
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8,
                    Subject = sub.ToString(),
                    Body = body.ToString(),
                    DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure,

                })
                {
                    smtp.Send(mess);
                }
                MessageBox.Show("Mesaj Gönderilmiştir", "Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Mesaj Gönderme Sırasında Bir Hata Meydana Geldi", "Hata");
            }
        }

        private void btnMesajOku_Click(object sender, EventArgs e)
        {
            MailRepository rep = new MailRepository();
            rep.Connect("outlook.office365.com", txtEmail.Text, txtSifre.Text, 995, true);




            foreach (var item in rep.GetMail())
            {

                string[] body = item.Message.MessagePart.GetBodyAsText().Split('>');
                rtxtMesajlar.AppendText("\nFrom: " + item.Message.Headers.From.Address + "\n" + "Subject: "
                    + item.Message.Headers.Subject + "\n" + "TEXT: " + body[1]);
            }
        }
    }
}
