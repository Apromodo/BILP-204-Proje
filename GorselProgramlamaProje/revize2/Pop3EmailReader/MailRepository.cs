using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pop3EmailReader
{
    public class MailRepository : IMailRepository
    {
        public void Connect(string hostname, string username, string password, int port, bool isUseSsl)
        {
            this._client = new Pop3Client();
            this._client.Connect(hostname, port, isUseSsl);
            this._client.Authenticate(username, password);
        }

        public List<Pop3Mail> GetMail()
        {
            int messageCount = this._client.GetMessageCount();

            var allMessages = new List<Pop3Mail>(messageCount);

            for (int i = messageCount; i > 0; i--)
            {
                allMessages.Add(new Pop3Mail() { MessageNumber = i, Message = this._client.GetMessage(i) });
            }

            return allMessages;
        }
        
        private Pop3Client _client { get; set; }
    }

    public class Pop3Mail
    {
        public int MessageNumber { get; set; }
        public Message Message { get; set; }
    }
}
