using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mailServisi = Microsoft.Office.Interop.Outlook;

namespace GorselProgramlamaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

//------------------------------------Mail Gönderme İşlemı try carh ile durum bilidirimi------------------------------


            try
            {
                mailServisi._Application _app = new mailServisi.Application();
                mailServisi.MailItem mail = (mailServisi.MailItem)_app.CreateItem(mailServisi.OlItemType.olMailItem);
                mail.To = txtTo.Text;
                mail.Subject = txtSubject.Text;
                mail.Body = txtMessage.Text;
                mail.Importance = mailServisi.OlImportance.olImportanceNormal;
                ((mailServisi.MailItem)mail).Send();
                MessageBox.Show("MESSAGJE BAŞARILI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gönderme Başarısız!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        //-------------------------------------------------------Gelen Mesajları İndirme-----------------------------------

        DataTable dt;
        private void btnReceive_Click(object sender, EventArgs e)
        {





            try
            {

                mailServisi._Application _app = new mailServisi.Application();
                mailServisi._NameSpace _ns = _app.GetNamespace("MAPI");
                mailServisi.MAPIFolder Inbox = _ns.GetDefaultFolder(mailServisi.OlDefaultFolders.olFolderInbox);
                _ns.SendAndReceive(true);
                dt = new DataTable("Inbox");
                dt.Columns.Add("Subject", typeof(String));
                dt.Columns.Add("Sender", typeof(String));
                dt.Columns.Add("Body", typeof(String));
                dt.Columns.Add("Date", typeof(String));
                dataGrid.DataSource = dt;
                foreach (mailServisi.MailItem item in Inbox.Items)
                    dt.Rows.Add(new object[] { item.Subject, item.SenderName, item.HTMLBody, item.SentOn.ToLongDateString() + " " + item.SentOn.ToLongTimeString() });
            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "İndirme Başarısız!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }


        //----------------------------------------Düzgün sıra ile gösterme ama 3 taneden fazla olunca indirmiyor




        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dt.Rows.Count && e.RowIndex >= 0)
                webBrowser.DocumentText = dt.Rows[e.RowIndex]["Body"].ToString();
        }
    }
}
