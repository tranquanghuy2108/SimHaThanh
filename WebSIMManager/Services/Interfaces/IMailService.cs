using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IMailService
    {
        Task<bool> SendMailGoogleSmtp(string _from, string _to, string _subject, string _body, string _gmailsend, string _gmailpassword);
        Task<bool> SendMail(string _from, string _to, string _subject, string _body, SmtpClient client);
    }
}
