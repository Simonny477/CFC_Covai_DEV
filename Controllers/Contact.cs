using CFCCoimbatore.BAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CFCCoimbatore.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult SubmitQuery()
        {       
            return View();
        }
        
    }
}