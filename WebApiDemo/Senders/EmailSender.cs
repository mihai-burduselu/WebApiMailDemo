using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Senders
{
    public class EmailSender
    {

        public static async Task SendMail(EmailData emailData)
        {
            string apiKey = "YOUR_API_KEY";
            var sg = new SendGridAPIClient(apiKey);

            Email from = new Email(emailData.FromName);
            string subject = emailData.Subject;
            Email to = new Email(emailData.EmailAddress);
            Content content = new Content("text/plain", emailData.Content);
            Mail mail = new Mail(from, subject, to, content);

            var response = await sg.client.mail.send.post(requestBody: mail.Get());
        }
    }
}