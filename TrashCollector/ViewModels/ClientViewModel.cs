using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;

namespace TrashCollector.ViewModels
{
    public class ClientViewModel
    {
        public IEnumerable<PickupDay> PickupDays { get; set; }
        public Client Client { get; set; }
       
        public Address Address { get; set; }
    }
}