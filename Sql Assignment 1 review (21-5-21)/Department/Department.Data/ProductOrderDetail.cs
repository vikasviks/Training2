using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data
{
    public class ProductOrderDetail
    {
        public int ProductOrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public int Qunatity { get; set; }
    }
}
