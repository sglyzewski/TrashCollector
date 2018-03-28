using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollector.Controllers
{
    [Authorize]
    public class WorkersController : Controller
    {
        // GET: Workers
       
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}