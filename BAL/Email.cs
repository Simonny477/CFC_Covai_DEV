using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Services.Description;

namespace CFCCoimbatore.BAL
{
    public class Email
    {
        [Required]
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string Message { get; set; }
        public string Subject { get; set; }
        public bool SendEmail()
        {

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp 
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("cfccovai@gmail.com", "umsv acbb rmre ttol");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                MailMessage message = new MailMessage(FromAddress, ToAddress, Subject, Message);
                message.IsBodyHtml = true;
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}