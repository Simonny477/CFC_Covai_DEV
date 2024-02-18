using CFCCoimbatore.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CFCCoimbatore.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksEnglish
        public ActionResult English()
        {
            BookUtil books = new BookUtil();
            return View(books.GetEnglishBooks());
        }

        public ActionResult Tamil()
        {
            BookUtil books = new BookUtil();
            return View(books.GetTamilBooks());
        }
    }
}