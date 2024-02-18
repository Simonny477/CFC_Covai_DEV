using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFCCoimbatore.Models
{
    public class ContactUs
    {
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
    }

    public class Mail
    {
        public string FromMail { get; set; }
        public string ToMail { get; set; }
        public string MobileNumber { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Name { get; set; }
    }

    public class Contact
    {
        public List<ContactUs> ContactUs  { get; set; }

        public Mail Mail { get; set; }
    }
}