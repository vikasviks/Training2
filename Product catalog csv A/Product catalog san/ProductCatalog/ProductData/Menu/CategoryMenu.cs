using ProductData.Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Menu
{
    public class CategoryMenu
    {
        public static void CategoryOperationMenu()
        {
            Console.WriteLine("Please Select Category Operation");
            Console.WriteLine("1. Enter a Category");
            Console.WriteLine("2. List all Categories");
            Console.WriteLine("3. Search a Category");
            Console.WriteLine("4. Delete a Category");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '1':
                    Console.WriteLine("Enter Category Name");
                    var categoryName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(categoryName) || int.TryParse(categoryName, out _))
                    {
                        Console.WriteLine("Please Enter Only Char and It can not be Empty");
                        categoryName = Console.ReadLine();
                    }
                    Console.WriteLine("Enter Short Code");
                    var shortCode = Console.ReadLine();

                    Console.WriteLine("Enter Description");
                    var desc = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(desc) || int.TryParse(desc, out _))
                    {
                        Console.WriteLine("Please Enter Only Char and It can not be Empty");
                        desc = Console.ReadLine();
                    }
                    CategoryOperation.AddCategory(categoryName, shortCode, desc);
                    break;

                case '2':
                    CategoryOperation.GetAllCategory();
                    Console.ReadKey();
                    break;

                case '3':
                    Console.WriteLine("Enter Category Name");
                    var searchCategoryName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(searchCategoryName) || int.TryParse(searchCategoryName, out _))
                    {
                        Console.WriteLine("Please Enter Only Char and It can not be Empty");
                        searchCategoryName = Console.ReadLine();
                        
                    }
                    CategoryOperation.SearchCategory(searchCategoryName);
                    break;

                case '4':
                    Console.WriteLine("Enter Category Id or Short Code");
                    break;
                
                default:
                    Console.WriteLine("Invalid Selection");
                    CategoryOperationMenu();
                    break;

            }
        }
    }
}
