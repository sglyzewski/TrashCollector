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
    public class ClientsController : Controller
    {
        private ApplicationDbContext _context;
        
        // GET: Clients
        
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult ChangeInfo()
        {
            return View("InfoForm");
        }
    }
}