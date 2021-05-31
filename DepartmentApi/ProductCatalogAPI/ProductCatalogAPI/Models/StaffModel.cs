using ProductCatalogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Models
{
	public class StaffModel
	{
		public int staffId { get; set; }
		public string firstname { get; set; }
		public string lastname { get; set; }
		public string gender { get; set; }
		public long phone { get; set; }

		public AddressModel Address { get; set; }
		public RoleModel Role { get; set; }

	}
}
