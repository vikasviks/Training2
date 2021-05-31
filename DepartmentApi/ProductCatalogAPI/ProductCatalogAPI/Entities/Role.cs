using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Entities
{
	public class Role
	{
		public int RoleId { get; set; }
		public string role { get; set; }
		public string Description { get; set; }
		public ICollection<Staff> Staff { get; set; }
		
	}
}
