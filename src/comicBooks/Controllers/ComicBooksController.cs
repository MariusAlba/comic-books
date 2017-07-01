using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comicBooks.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return Redirect("/");
            }
            return Content("Hello from MVC content result");
        }
    }
}