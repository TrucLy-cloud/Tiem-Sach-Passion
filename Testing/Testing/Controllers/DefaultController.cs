using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult MasterPage()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HistoryOrder()
        {
            return View();
        }
    }
}