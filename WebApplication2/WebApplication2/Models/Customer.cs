﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Customer
    {
        
            public int Custid { get; set; }
            public string Name { get; set; }
            public string Account { get; set; }
            public double Balance { get; set; }
            public string City { get; set; }
            public bool Status { get; set; }
            public string Photo { get; set; }
        
    }
}