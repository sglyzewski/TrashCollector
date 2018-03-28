using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Day
    {
        public int Id { get; set; }

        public DateTime DateAdded { get; set; }
        public byte ClientId { get; set; }
    }
}