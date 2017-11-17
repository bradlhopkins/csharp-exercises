﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class MenuItem
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }
        public DateTime DateAdded { get; set; }

        
    }

    
}
