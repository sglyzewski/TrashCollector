using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;
using TrashCollector.Controllers;
using System.Globalization;

namespace TrashCollector.ViewModels
{
    public class SeeDatesViewModel
    {
        public Client Client { get; set; }
        private ApplicationDbContext _context = new ApplicationDbContext();

        public Address Address { get; set; }
        public int? PickupDayId { get; set; }

        public IList<DateTime> result { get; set; }

        public IList<string> dates { get; set; }

      

      

        public IList<string> GetStringDates(IList<DateTime> dates)
        {
            IList<string> result = new List<string>();
            foreach (var el in dates)
            {
                result.Add(el.ToString("dddd dd MMMM", CultureInfo.CreateSpecificCulture("en-US")));
            }
            return result;
        }
       

        
    }
}