﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentalStoreAppAPI.Domain
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
