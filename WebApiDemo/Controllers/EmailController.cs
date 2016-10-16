using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiDemo.Models;
using WebApiDemo.Senders;

namespace WebApiDemo.Controllers
{
    public class EmailController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> SendEmail(EmailData emailData)
        {
            await EmailSender.SendMail(emailData);

            return Ok();
        }
    }
}
