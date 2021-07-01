using System;
using System.Collections.Generic;
using System.Text;

namespace DStore.Data
{
    public class ProductOrderDetail
    {
        public int ProductOrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public int Qunatity { get; set; }
    }
}
