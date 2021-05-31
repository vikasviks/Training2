using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI
{
	public class DepartmentContext : DbContext
	{
		public DbSet<Role> Role { get; set; }
		public DbSet<Staff> Staff { get; set; }
		public DbSet<Address> Address { get; set; }
		public DbSet<Product> Product { get; set; }
		public DbSet<Category> Category { get; set; }
		public DbSet<Inventory> Inventory { get; set; }
		public DbSet<Supplier> Supplier { get; set; }
		public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
		

		public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options)
		{
		}
	}
}
