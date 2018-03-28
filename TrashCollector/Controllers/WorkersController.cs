using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using System.Data.Entity;

namespace TrashCollector.Controllers
{
    [Authorize]
    public class WorkersController : Controller
    {
        private ApplicationDbContext _context;
        // GET: Workers

        public ActionResult Index()
        {
            return View("Index");
        }
    }
}