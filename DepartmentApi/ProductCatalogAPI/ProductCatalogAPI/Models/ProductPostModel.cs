using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Models
{
	public class ProductPostModel
	{
		public string ProductName { get; set; }
		public string Manufacturer { get; set; }
		public double CostPrice { get; set; }
		public double SellingPrice { get; set; }
		public int CategoryId { get; set; }

		public DateTime ExpiryDate { get; set; }
	}
}
