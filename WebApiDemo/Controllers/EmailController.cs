using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;
using WebApiDemo.Senders;

namespace WebApiDemo.Controllers
{
    public class EmailController : ApiController
    {
        new EmailData[] emailDatabase =
        {
            new EmailData { Id = 1, EmailAddress = "andrei_spatariu@yahoo.com", FromName = "Daniel" },
            new EmailData { Id = 2, EmailAddress = "andrei.spatariu@equilobe.com", FromName = "Nicoleta" },
            new EmailData { Id = 3, EmailAddress = "andrei.spatariu@gmail.com", FromName = "Andreea" }
        };

        [HttpPost]
        public IHttpActionResult SendEmail(int id)
        {
            var actualData = emailDatabase.First(x => x.Id == id);

            if (actualData != null)
                EmailSender.SendMail(actualData.EmailAddress).Wait();

            return NotFound();
        }
    }
}
