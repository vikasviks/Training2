﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Entities
{
    public class Product
    {
        public static int ID = 1;
        public int Product_ID { get; set; }
        public static int GenerateProductId()
        {
            return ID++;
        }
        public string product_Name { get; set; }
        public string Manufacturer { get; set; }
        public string ProductShortCode { get; set; }
        public string ProductCategory { get; set; }
        
        public string ProductDescription { get; set; }
        public int Selling_Price { get; set; }
    }
}
