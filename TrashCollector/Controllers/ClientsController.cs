using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using TrashCollector.ViewModels;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Globalization;

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

       
        public ActionResult Index(Client client)
        {
            return View();
        }
        
        public ActionResult SeeAllClients()
        {
            if (User.IsInRole("CanSeeAllPickups"))
            {
                IEnumerable<Client> clients = _context.Clients.ToList();
                return View(clients);
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult ChangeInfo()
        {
            var viewModel = new ClientViewModel()
            {

                
                PickupDays = _context.PickupDays.ToList(),
                

            };
            return View("InfoForm", viewModel);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}


        [HttpPost]
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
        public ActionResult InfoForm()
        {
            return View();
        }
        public ActionResult Create(Client client)
        {
            _context.Clients.Add(client);

            
            return View();
        }

        public ActionResult SeePickups(int id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);
            var address = _context.Addresses.SingleOrDefault(a => a.Id == client.AddressId);

            var results = GetDaysForYearFromStartDate(client);
            var datelist = GetStringDates(results);



            var viewModel = new SeeDatesViewModel()
            {
                Client = client,
                Address = address,
                Result = results,
                Dates = datelist
            };
             if (client == null)
                return HttpNotFound();
            return View(viewModel);
        }

        public ActionResult DeleteDate(SeeDatesViewModel viewmodel, string element)
        {
            List<string> dates = viewmodel.Dates;
            dates.Remove(element);
            SeeDatesViewModel newViewModel = new SeeDatesViewModel()
            {
                Client = viewmodel.Client,
                Address = viewmodel.Address,
                Dates = dates
            };


            return View("SeePickups", newViewModel);
        }


        public IList<DateTime> GetDaysForYearFromStartDate(Client client)
        {
              var startdate = _context.PickupDays.SingleOrDefault(c => c.Id == client.PickUpDayId);


        DateTime currentDay = startdate.FirstPickup;
        List<DateTime> results = new List<DateTime>();


        int currentYear = (startdate.FirstPickup).Year;
                while (currentDay.Year == currentYear)
                {
                    currentDay = currentDay.AddDays(7);
                    results.Add(currentDay);

                }

                return results;
            }


    public List< string> GetStringDates(IList<DateTime> dates)
        {
            List< string> result = new List< string>();
       
            foreach (var el in dates)
            {
                
                result.Add( el.ToString("dddd dd MMMM", CultureInfo.CreateSpecificCulture("en-US")));
               
            }
            return result;
        }

        [HttpPost]
        public ActionResult Save(Client client, Address address)
        {



            if (address.Id < 1)
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
            _context.SaveChanges();
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