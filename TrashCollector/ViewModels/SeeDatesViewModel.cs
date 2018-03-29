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

        public IList<DateTime> Result { get; set; }

        public List<string> Dates { get; set; }

      
        
    }
}