using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Entities
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryCode { get; set; }
		public string CategoryName { get; set; }
		public ICollection<Product> Products { get; set; }
	}
}
