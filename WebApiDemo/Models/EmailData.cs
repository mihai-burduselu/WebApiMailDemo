﻿namespace WebApiDemo.Models
{
    public class EmailData
    {
        public string ToEmailAddress { get; set; }
        public string FromEmailAddress { get; set; }
        public string Content { get; set; }
        public string Subject { get; set; }
    }
}