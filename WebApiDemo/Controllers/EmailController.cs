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
        [HttpPost]
        public IHttpActionResult SendEmail(EmailData emailData)
        {
            EmailSender.SendMail(emailData).Wait();

            return Ok();
        }
    }
}
