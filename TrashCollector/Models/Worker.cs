﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector.Models
{
    public class Worker
    {
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public byte AccountId { get; set; }


    }
}