using CFCCoimbatore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CFCCoimbatore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string path = Environment.CurrentDirectory;
            ////string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Names.txt");
            //foreach (string file in Directory.EnumerateFiles("../../Docs", "*.txt"))
            //{
            //    //string contents = File.ReadAllText(file);
            //}
            //StreamReader sr = new StreamReader("../Docs/liveinfos.txt");

            List<MeetingDetails> meetings = new List<MeetingDetails>();
            meetings.Add(new MeetingDetails() {MeetingName= "Sunday Service", MeetingDate = new DateTime(2023,11,26), MeetingDateString = "Nov 26, 2023 10:00:00", MeetingLink= "6o5c8zApOOA" });
            meetings.Add(new MeetingDetails() { MeetingName = "Wednesday Gathering", MeetingDate = new DateTime(2023,11,29), MeetingDateString = "Nov 29, 2023 19:30:00", MeetingLink = "m4MIj9Di1B4" });
            meetings.Add(new MeetingDetails() { MeetingName = "Sunday Service", MeetingDate = new DateTime(2023,12,03), MeetingDateString = "Dec 03, 2023 10:00:00", MeetingLink = "m4MIj9Di1B4" });

            ViewBag.Template = 1;
            ViewBag.NextMeetingDate = meetings.OrderBy(a => a.MeetingDate).FirstOrDefault().MeetingDateString;
            ViewBag.MeetingId = meetings.OrderBy(a => a.MeetingDate).FirstOrDefault().MeetingLink;
            ViewBag.MeetingName = meetings.OrderBy(a => a.MeetingDate).FirstOrDefault().MeetingName;

            return View(meetings);
        }

        public ActionResult About()
        {
            ViewBag.Template = 1;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Template = 1;

            List<ContactUs> contactUs = new List<ContactUs>();

            contactUs.Add(new ContactUs() { ContactName = "Br. Samuel", ContactNumber = "9894781648" });
            contactUs.Add(new ContactUs() { ContactName = "Br. Vedaiyan", ContactNumber = "9894135510" });
            contactUs.Add(new ContactUs() { ContactName = "Br. Obadiah", ContactNumber = "9944286556" });
            contactUs.Add(new ContactUs() { ContactName = "Br. Rajavelu", ContactNumber = "9842241310" });
            return View(contactUs);
        }

        public ActionResult MaintenancePage()
        {
            ViewBag.Template = 0;
            return View();
        }

        public ActionResult AboutZacPoonen()
        {
            ViewBag.Template = 1;
            return View();
        }
    }
}