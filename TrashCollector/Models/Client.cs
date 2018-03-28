using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte AccountId { get; set; }
        public byte PickUpDayId { get; set; }
        public byte AddressId { get; set; }
        public int NumberOfPickUpsYTD { get; set; }

    }
}