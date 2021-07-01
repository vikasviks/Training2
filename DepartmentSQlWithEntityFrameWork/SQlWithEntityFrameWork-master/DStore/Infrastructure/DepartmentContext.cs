using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Data.Infrastructure
{
    public class DepartmentContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrderDetail> ProductOrderDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierProductOrderDetail> SupplierProductOrderDetails { get; set; }
        public DbSet<ProductCategory> ProductCategories { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;DataBase=DStore;username=postgres;password=pandey10");        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //staff
            modelBuilder.Entity<Staff>().HasKey(x => x.StaffId);
            modelBuilder.Entity<Staff>().Property(x => x.FirstName).HasMaxLength(32).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.LastName).HasMaxLength(32);
            modelBuilder.Entity<Staff>().Property(x => x.PhoneNumber).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.RoleId).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.AddressId).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.Gender).IsRequired();
            modelBuilder.Entity<Staff>().Property(x => x.Salary).IsRequired();

            //Role
            modelBuilder.Entity<Role>().HasKey(x => x.RoleId);
            modelBuilder.Entity<Role>().Property(x => x.RoleName).HasMaxLength(32).IsRequired();
            modelBuilder.Entity<Role>().Property(x => x.Description);

            //Address
            modelBuilder.Entity<Address>().HasKey(x => x.AddressId);
            modelBuilder.Entity<Address>().Property(x => x.AddressLine1).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.AddressLine2).HasMaxLength(128);
            modelBuilder.Entity<Address>().Property(x => x.City).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Address>().Property(x => x.Pincode).HasMaxLength(6).IsRequired();
            
            //product
            modelBuilder.Entity<Product>().HasKey(r => r.ProductId);
            modelBuilder.Entity<Product>().Property(x => x.ProductCode).HasMaxLength(6).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Manufacturer).HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(x => x.InStock).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.ProductName).HasMaxLength(30).IsRequired();

            //productcategory
            modelBuilder.Entity<ProductCategory>().HasKey(x =>x.CategoryId);
            modelBuilder.Entity<ProductCategory>().HasKey(x => x.ProductId);

            //category
            modelBuilder.Entity<Category>().HasKey(x => x.CategoryId);
            modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasMaxLength(32).IsRequired();


            //inventory
            modelBuilder.Entity<Inventory>().HasKey(x=>x.InventoryId);
            modelBuilder.Entity<Inventory>().Property(x => x.ProductId).IsRequired();
            modelBuilder.Entity<Inventory>().Property(x => x.ProductQuantity).IsRequired();


            //productorder detail
            modelBuilder.Entity<ProductOrderDetail>().HasKey(r => r.ProductOrderId);
            modelBuilder.Entity<ProductOrderDetail>().Property(x => x.Qunatity).IsRequired();

            //supplier
            modelBuilder.Entity<Supplier>().HasKey(r => r.SupplierId);
            modelBuilder.Entity<Supplier>().Property(r => r.SupplierName).HasMaxLength(64).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.PhoneNumber).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.AddressId).IsRequired();

            //supplierproductorder
            modelBuilder.Entity<SupplierProductOrderDetail>().HasKey(r => r.ProductId);
            modelBuilder.Entity<SupplierProductOrderDetail>().HasKey(r => r.ProductOrderId);
            modelBuilder.Entity<SupplierProductOrderDetail>().HasKey(r => r.SupplierId);

        }

    }
}
