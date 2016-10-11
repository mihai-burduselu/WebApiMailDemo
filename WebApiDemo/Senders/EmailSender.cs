using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace WebApiDemo.Senders
{
    public class EmailSender
    {

        public static async Task SendMail(string emailAddress)
        {
            string apiKey = Environment.GetEnvironmentVariable("WebApiDemo", EnvironmentVariableTarget.User);
            dynamic sg = new SendGridAPIClient(apiKey);

            Email from = new Email("MIC@upb.ro");
            string subject = "Sal cf";
            Email to = new Email(emailAddress);
            Content content = new Content("text/plain", "Salut! Mail-ul asta nu are absolut nici un scop");
            Mail mail = new Mail(from, subject, to, content);

            dynamic response = await sg.client.mail.send.post(requestBody: mail.Get());
        }
    }
}