using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Manufacturer { get; set; }
        public int CostPrice { get; set; }
        public int SellingPrice { get; set; }
        public bool InStock { get; set; }

    }
}
