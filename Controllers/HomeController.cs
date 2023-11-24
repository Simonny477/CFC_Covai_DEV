using CFCCoimbatore.BAL;
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
        ReadFilesAndProcessRecords readFile = new ReadFilesAndProcessRecords();
        public ActionResult Index()
        {

            
            var meetings = readFile.ReadMeetingDetails().Where(a => a.MeetingDate >=  DateTime.Now.AddHours(-3)).ToList();

            if(meetings.Any())
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

            
            return View(readFile.ReadContact());
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