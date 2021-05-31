using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Entities
{
	public class PurchaseOrder
	{
		public int PurchaseOrderId { get; set; }
		public int ProductId { get; set; }
		public int SupplierId { get; set; }
		public DateTime Orderdate { get; set; }

		public Product Product { get; set; }
		public Supplier Supplier { get; set; }
	}
}
