using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Models
{
	public class StaffPostModel
	{
		//public int staffId { get; set; }
		public string firstname { get; set; }
		public string lastname { get; set; }
		public string gender { get; set; }
		public long phone { get; set; }

		public int roleId { get; set; }
		public int addressId { get; set; }

	}
}
