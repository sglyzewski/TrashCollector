using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using TrashCollector.ViewModels;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace TrashCollector.Controllers
{
    [Authorize]
    public class ClientsController : Controller
    {
        private ApplicationDbContext _context;
        
        // GET: Clients

        public ClientsController()
        {
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Index()
        {
            var movies = _context.Clients.ToList();
            return View("Index");
        }

        public ActionResult ChangeInfo()
        {
            var viewModel = new ClientViewModel()
            {

                
                PickupDays = _context.PickupDays.ToList(),
                

            };
            return View("InfoForm", viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ActionResult Edit(int id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (client == null) {

                return HttpNotFound();
            }

            
                var viewModel = new ClientViewModel()
                {

                    Client = client,
                    PickupDays = _context.PickupDays.ToList(),
                    Address = _context.Addresses.SingleOrDefault(a => a.Id == (Convert.ToInt32(client.AddressId)))

            };

            return View("InfoForm", viewModel);
        
        }

        [HttpPost]
        public ActionResult Save(Client client, Address address)
        {
            

            //if (!ModelState.IsValid)
            ////{
            //    var viewModel = new ClientViewModel
            //    {
            //        Client = client,
            //        PickupDays = _context.PickupDays.ToList(),
            //        Address = address
            //    };
            //    return View("InfoForm", viewModel);

            //}

            if(address.Id == 0)
            {
                _context.Addresses.Add(address);
               
            }
            else
            {
                var addressInDb = _context.Addresses.Single(a => a.Id == address.Id);
                addressInDb.AddressLine1 = address.AddressLine1;
                addressInDb.AddressLine2 = address.AddressLine2;
                addressInDb.City = address.City;
                addressInDb.State = address.State;
                addressInDb.ZipCode = address.ZipCode;
                
            }
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }

            if (client.Id == 0)
            {
                _context.Clients.Add(client);
            }
            else
            {
                var clientInDb = _context.Clients.Single(c => c.Id == client.Id);
                var addressInDb = _context.Addresses.Single(a => a.Id == address.Id);
                clientInDb.Name = client.Name;
                clientInDb.AddressId = client.AddressId;
                clientInDb.PickUpDayId = client.PickUpDayId;
                clientInDb.AddressId = Convert.ToByte(addressInDb.Id);
            }
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index", "Clients");
        }

        public ActionResult Details(int id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);

            _context.SaveChanges();

            if (client == null)
                return HttpNotFound();

            return View(client);
        }

    }
}