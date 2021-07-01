using Department.Data;
using Department.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Department.UI
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            EFQuery.ProductWithinCategory();


            using (DepartmentContext context = new DepartmentContext())
            {
                context.Categories.AddRange(
                new Data.Category { CategoryName = "Groceries" },
                new Data.Category { CategoryName = "Dairy" },
                new Data.Category { CategoryName = "Food" },
                new Data.Category { CategoryName = "Appliances" }
                );
                context.SaveChanges();
                Console.WriteLine("data Added Successfully");
            }


            using (DepartmentContext context = new DepartmentContext())
            {
                context.Staffs.AddRange(
                new Data.Staff { FirstName = "Vikas", LastName = "kumar", AddressId = 3, Gender = "M", PhoneNumber = "1234567890", Salary = 10000, RoleId = 1 },
                new Data.Staff { FirstName = "Nishu", LastName = "singh", AddressId = 4, Gender = "M", PhoneNumber = "0987654321", Salary = 15000, RoleId = 2 },
                new Data.Staff { FirstName = "Vik", LastName = "kumar", AddressId = 1, Gender = "M", PhoneNumber = "1234567890", Salary = 10000, RoleId = 3 },
                new Data.Staff { FirstName = "Nik", LastName = "singh", AddressId = 6, Gender = "M", PhoneNumber = "0987654321", Salary = 15000, RoleId = 4 }
                );
                context.SaveChanges();
                Console.WriteLine("data Added Successfully");
            }


            using (DepartmentContext context = new DepartmentContext())
            {
                context.Addresses.AddRange(
                new Data.Address { AddressLine1 = "E-125", AddressLine2 = "nand gram", City = "ghaziabad", Pincode = "201003" },
                new Data.Address { AddressLine1 = "E-124", AddressLine2 = "raj nagar", City = "delhi", Pincode = "201001" },
                new Data.Address { AddressLine1 = "E-125", AddressLine2 = "nand gram", City = "noida", Pincode = "201004" },
                new Data.Address { AddressLine1 = "E-124", AddressLine2 = "raj nagar", City = "delhi", Pincode = "201002" }
                );
                context.SaveChanges();
                Console.WriteLine("data Added Successfully");
            }


            using (DepartmentContext context = new DepartmentContext())
            {
                context.Roles.AddRange(
                    new Data.Role { RoleName = "Manager", Description = "Brach manager" },
                    new Data.Role { RoleName = "Billing", Description = "Counter Billing perpose" },
                    new Data.Role { RoleName = "Security", Description = "For Security perpose" },
                    new Data.Role { RoleName = "Helper", Description = "For helping Customer" }
                    );
                context.SaveChanges();
                Console.WriteLine("data Added Successfully");
            }


            using (DepartmentContext context = new DepartmentContext())
            {
                context.ProductOrderDetails.AddRange(
                    new Data.ProductOrderDetail { OrderTime = new DateTime(2021, 01, 13), Qunatity = 10 },
                    new Data.ProductOrderDetail { OrderTime = new DateTime(2020, 02, 13), Qunatity = 15 },
                    new Data.ProductOrderDetail { OrderTime = new DateTime(2019, 03, 13), Qunatity = 20 },
                    new Data.ProductOrderDetail { OrderTime = new DateTime(2018, 04, 33), Qunatity = 30 }
                    );
                context.SaveChanges();
                Console.WriteLine("data Added Successfully");
            }


            using (DepartmentContext context = new DepartmentContext())
            {
                context.Suppliers.AddRange(
                    new Data.Supplier { SupplierName = "Varun", AddressId = 3, PhoneNumber = "1122334455" },
                    new Data.Supplier { SupplierName = "Deepak", AddressId = 2, PhoneNumber = "6677889900" },
                    new Data.Supplier { SupplierName = "Rajnish", AddressId = 3, PhoneNumber = "1234512345" },
                    new Data.Supplier { SupplierName = "David", AddressId = 1, PhoneNumber = "1234567890" }
                    );
                context.SaveChanges();
                Console.WriteLine("data Added Successfully");
            }


            using (DepartmentContext context = new DepartmentContext())
            {
                context.SupplierProductOrderDetails.AddRange(
                new Data.SupplierProductOrderDetail { ProductId = 1, ProductOrderId = 2, SupplierId = 4 },
                new Data.SupplierProductOrderDetail { ProductId = 2, ProductOrderId = 3, SupplierId = 2 },
                new Data.SupplierProductOrderDetail { ProductId = 3, ProductOrderId = 1, SupplierId = 1 },
                new Data.SupplierProductOrderDetail { ProductId = 4, ProductOrderId = 4, SupplierId = 3 }
               );
                context.SaveChanges();
                Console.WriteLine("data Added Successfully");
            }

        }

    }
}
