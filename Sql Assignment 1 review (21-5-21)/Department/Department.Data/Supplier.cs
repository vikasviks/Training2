using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }        
        public Address Address { get; set; }
    }
}
