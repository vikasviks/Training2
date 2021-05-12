﻿using ProductData.Entities;
using ProductData.FileManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Operation
{
    public class ProductOperation
    {
        
        static List<Product> data = ProductFileManager.ReadDataFromFile();
        static int lastId = data[data.Count - 1].Product_ID;
        public static void GetAllProduct()
        {
           
            data.ForEach((i) =>
            {
                Console.WriteLine($"{i.Product_ID}, {i.product_Name}, {i.Manufacturer}," +
                    $" {i.ProductShortCode}, {i.ProductCategory}, {i.ProductDescription}, {i.Selling_Price}");
            });
            Console.ReadKey();
           
        }
        public static void AddProduct(string ProductName, string shortCode, string desc, int price, string manufactureName,string category)
        {

            var addproductdata = $"{++lastId},{ProductName},{manufactureName},{shortCode},{category},{desc},{price}";
            ProductFileManager.AddProductInFile(addproductdata);
            data = ProductFileManager.ReadDataFromFile();
            Console.ReadKey();

        }
        public static void SearchProduct(string name)
        {
            var searchData = data.Find((i) => i.product_Name == name);
            Console.WriteLine($"{searchData.Product_ID}, {searchData.product_Name}, {searchData.Manufacturer}," +
                   $" {searchData.ProductShortCode}, {searchData.ProductCategory}, {searchData.ProductDescription}, {searchData.Selling_Price}");
            Console.ReadKey();
        }
    }
}
