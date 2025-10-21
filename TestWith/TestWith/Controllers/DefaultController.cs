using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWith.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult MasterPage()
        {
            return View();
        }
    }
}