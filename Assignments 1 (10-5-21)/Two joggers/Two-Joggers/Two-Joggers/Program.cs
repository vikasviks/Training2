using System;

namespace Two_Joggers
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Enter Two Numbers");

            string val1 = Console.ReadLine();
            // convert to integer
            int num1 = Convert.ToInt32(val1);

            string val2 = Console.ReadLine();
            // convert to integer
            int num2 = Convert.ToInt32(val2);

            Gcd_Lcm obj = new Gcd_Lcm();
            int res = obj.lcm(num1,num2);
            Console.WriteLine("\n the number of laps that each jogger has to complete " +
                "before they meet each other again are:-");
            Console.WriteLine(res / num1);
            Console.WriteLine(res / num2);
        }
    } 
}
