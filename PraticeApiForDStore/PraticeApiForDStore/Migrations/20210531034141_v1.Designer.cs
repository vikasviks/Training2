﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PraticeApiForDStore.Infrastructure;

namespace PraticeApiForDStore.Migrations
{
    [DbContext(typeof(DepartmentalStoreContext))]
    [Migration("20210531034141_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PraticeApiForDStore.Entities.Address", b =>
                {
                    b.Property<long>("Address_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("character varying(140)")
                        .HasMaxLength(140);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("character varying(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasColumnType("character(6)")
                        .IsFixedLength(true)
                        .HasMaxLength(6);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("character varying(120)")
                        .HasMaxLength(120);

                    b.HasKey("Address_Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Customer", b =>
                {
                    b.Property<long>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("Address_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(120)")
                        .HasMaxLength(120);

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("character varying(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("character(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1);

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.HasKey("Customer_Id");

                    b.HasIndex("Address_Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Inventory", b =>
                {
                    b.Property<string>("Product_Code")
                        .HasColumnType("text");

                    b.Property<string>("Brand_Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("InStock")
                        .HasColumnType("boolean");

                    b.Property<long>("Product_Quantity")
                        .HasColumnType("bigint");

                    b.HasKey("Product_Code");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("Address_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Customer_Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date_Of_Delivery")
                        .HasColumnType("date");

                    b.Property<DateTime>("Date_Of_Order")
                        .HasColumnType("date");

                    b.Property<int>("Ordered_Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("Product_Code")
                        .HasColumnType("text");

                    b.Property<long>("Supplier_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Order_Id");

                    b.HasIndex("Address_Id");

                    b.HasIndex("Customer_Id");

                    b.HasIndex("Product_Code");

                    b.HasIndex("Supplier_Id");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Product", b =>
                {
                    b.Property<string>("Product_Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("Expiry_Date")
                        .HasColumnType("date");

                    b.Property<DateTime>("Manufacturing_Date")
                        .HasColumnType("date");

                    b.Property<int>("ProductCategory_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("character varying(120)")
                        .HasMaxLength(120);

                    b.HasKey("Product_Code");

                    b.HasIndex("ProductCategory_Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategory_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasColumnType("character varying(150)")
                        .HasMaxLength(150);

                    b.HasKey("ProductCategory_Id");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.ProductPrice", b =>
                {
                    b.Property<string>("Product_Code")
                        .HasColumnType("text");

                    b.Property<decimal>("Cost_Price")
                        .HasColumnType("numeric")
                        .HasMaxLength(12);

                    b.Property<DateTime>("Date_Of_Register")
                        .HasColumnType("date");

                    b.Property<decimal>("Selling_Price")
                        .HasColumnType("numeric")
                        .HasMaxLength(12);

                    b.HasKey("Product_Code");

                    b.ToTable("ProductPrice");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Role", b =>
                {
                    b.Property<int>("Role_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Role_Name")
                        .IsRequired()
                        .HasColumnType("character varying(80)")
                        .HasMaxLength(80);

                    b.HasKey("Role_Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Staff", b =>
                {
                    b.Property<long>("Staff_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("Address_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("character varying(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("character varying(1)")
                        .HasMaxLength(1);

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.Property<int>("Role_Id")
                        .HasColumnType("integer");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.HasKey("Staff_Id");

                    b.HasIndex("Address_Id");

                    b.HasIndex("Role_Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Supplier", b =>
                {
                    b.Property<long>("Supplier_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("Address_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(120)")
                        .HasMaxLength(120);

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("character varying(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("character(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1);

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("character(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.HasKey("Supplier_Id");

                    b.HasIndex("Address_Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Customer", b =>
                {
                    b.HasOne("PraticeApiForDStore.Entities.Address", "Address")
                        .WithMany("Customer")
                        .HasForeignKey("Address_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.OrderDetail", b =>
                {
                    b.HasOne("PraticeApiForDStore.Entities.Address", "Address")
                        .WithMany("OrderDetail")
                        .HasForeignKey("Address_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PraticeApiForDStore.Entities.Customer", "Customer")
                        .WithMany("OrderDetail")
                        .HasForeignKey("Customer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PraticeApiForDStore.Entities.Product", "Product")
                        .WithMany("OrderDetail")
                        .HasForeignKey("Product_Code");

                    b.HasOne("PraticeApiForDStore.Entities.Supplier", "Supplier")
                        .WithMany("OrderDetail")
                        .HasForeignKey("Supplier_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Product", b =>
                {
                    b.HasOne("PraticeApiForDStore.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Product")
                        .HasForeignKey("ProductCategory_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PraticeApiForDStore.Entities.Inventory", "Inventory")
                        .WithOne("Product")
                        .HasForeignKey("PraticeApiForDStore.Entities.Product", "Product_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.ProductPrice", b =>
                {
                    b.HasOne("PraticeApiForDStore.Entities.Product", "Product")
                        .WithMany("ProductPrice")
                        .HasForeignKey("Product_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Staff", b =>
                {
                    b.HasOne("PraticeApiForDStore.Entities.Address", "Address")
                        .WithMany("Staff")
                        .HasForeignKey("Address_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PraticeApiForDStore.Entities.Role", "Role")
                        .WithMany("Staff")
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PraticeApiForDStore.Entities.Supplier", b =>
                {
                    b.HasOne("PraticeApiForDStore.Entities.Address", "Address")
                        .WithMany("Supplier")
                        .HasForeignKey("Address_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
