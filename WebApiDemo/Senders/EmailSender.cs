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
            string apiKey = "YOUR API KEY FROM SENDGRID WEBSITE";
            var sg = new SendGridAPIClient(apiKey);

            Email from = new Email(emailData.FromEmailAddress);
            string subject = emailData.Subject;
            Email to = new Email(emailData.ToEmailAddress);
            Content content = new Content("text/html", emailData.Content);
            Mail mail = new Mail(from, subject, to, content);

            var response = await sg.client.mail.send.post(requestBody: mail.Get());
        }
    }
}