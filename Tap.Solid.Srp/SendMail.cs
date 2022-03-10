using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Solid.Srp
{
    public class SendMail
    {
        public MailMessage mailMessageObject;
        public SmtpClient client;
        public SendMail()
        {
            this.client = new SmtpClient
            {
                Port = 25,
                Host = "smtp.demo.exercise"
            };
        }
        public SendMail(String Email)
        {
            this.mailMessageObject = new MailMessage("demo@solid.princiles.srp", Email);
        }
        public void makeMessage(String Name)
        {
            this.mailMessageObject.Subject = "Welcome to the lab!";
            this.mailMessageObject.Body = $"Hey {Name}! Glad to have you!";
        }
    }
}
