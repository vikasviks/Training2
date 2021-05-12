using System;
using System.Collections.Generic;
using System.Text;
namespace ProductData.Menu
{
    public class MainMenu
    {
        public static void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Hello, Please Select Option");
                Console.WriteLine("1. Category");
                Console.WriteLine("2. Product");
                Console.WriteLine("3. Exit App!");

                char ch = Convert.ToChar(Console.ReadLine());

                switch (ch)
                {
                    case '1':
                        CategoryMenu.CategoryOperationMenu();
                        break;

                    case '2':
                        ProductMenu.ProductOperationMenu();
                        break;

                    case '3':
                        Console.WriteLine("Exit");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                Console.Clear();
            }
        }
    }
}
    
