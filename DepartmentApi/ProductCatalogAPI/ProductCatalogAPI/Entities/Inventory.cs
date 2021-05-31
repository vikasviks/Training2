using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Entities
{
	public class Inventory
	{
		public int InventoryId { get; set; }
		public int ProductId { get; set; }
		public long Quantity { get; set; }

		public Product Product { get; set; }
	}
}
