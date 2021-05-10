using System;
using System.Collections.Generic;

namespace Sum_diff_products_LCMs
{
    class Program
    {
        public static int sum1 { get; set; }
        public static int sum2 { get; set; }
        public static int res { get; set; }

        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }
        public static void product(int a, int b)
        {
            sum1 += (a * b);
            //Console.WriteLine(sum1);
        }

        public static void lcm(int a, int b)
        {
            sum2 += (a / gcd(a, b)) * b;
            //Console.WriteLine(sum2);
        }

        public static void display()
        {
            res = sum1 - sum2;
            Console.WriteLine(res);
        }
        static void Main(string[] args)
        {
            int[,] a = new int[3, 2] { { 15, 18 },{ 4 , 5 },{ 12, 60}};

            for (int i = 0; i < 3; i++)
            {
                product(a[i, 0], a[i, 1]);
                lcm(a[i, 0], a[i, 1]);
            }

            display();
        }

    }
}
