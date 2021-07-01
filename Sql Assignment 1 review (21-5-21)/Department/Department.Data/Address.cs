﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class Address
    {
        public long AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
    }
}
