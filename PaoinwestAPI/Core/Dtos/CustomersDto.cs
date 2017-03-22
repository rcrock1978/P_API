﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaoinwestAPI.Core.Dtos
{
    public class CustomerDto
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}