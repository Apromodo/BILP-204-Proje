using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace Pop3EmailReader
{
    public interface IMailRepository
    {
        void Connect(string pop3Server, string pop3User, string pop3Pass, int pop3Port, bool pop3UseSsl);
        List<Pop3Mail> GetMail();
     
    }
}
