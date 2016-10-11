using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class EmailData
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string FromName { get; set; }
    }
}