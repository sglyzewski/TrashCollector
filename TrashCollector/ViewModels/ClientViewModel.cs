using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;

namespace TrashCollector.ViewModels
{
    public class ClientViewModel
    {
        public List<PickupDay> PickupDays { get; set; }
        public Client Client { get; set; }
    
        public Address Address { get; set; }
        public int? PickupDayId { get; set; }
       
       
        
    }
}