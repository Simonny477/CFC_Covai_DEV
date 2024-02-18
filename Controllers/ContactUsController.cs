using CFCCoimbatore.BAL;
using CFCCoimbatore.Models;
using CFCCoimbatore.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CFCCoimbatore.Controllers
{
    public class ContactUsController : Controller
    {
        ReadFilesAndProcessRecords readFile = new ReadFilesAndProcessRecords();
        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {

            Contact contact = new Contact();
           
            contact.ContactUs = readFile.ReadContact();

            return View(contact);
        }

        [HttpPost]
        public ActionResult sendMail(Mail mail)
        {
            Email email = new Email();
            email.Subject = ConstantsDef.MailSubTemplate;
            email.phone = mail.MobileNumber;
            email.Message = string.Format(ConstantsDef.MailBodyTemplate, mail.Body, mail.Name, mail.MobileNumber, mail.FromMail);
            email.FromAddress = mail.FromMail;
            email.ToAddress = ConstantsDef.CovaiCFCMail;
            email.SendEmail();

            Contact contact = new Contact();
            contact.ContactUs = readFile.ReadContact();

            return Redirect("/ContactUs/Contact?mail=T");
        }
    }
}