using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public Product Product { get; set; }

    }
}
