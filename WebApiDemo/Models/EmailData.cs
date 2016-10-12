using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class EmailData
    {
        public string EmailAddress { get; set; }
        public string FromName { get; set; }
        public string Content { get; set; }
        public string Subject { get; set; }
    }
}