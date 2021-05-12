using System;
using System.Collections.Generic;

namespace Consective_Sum_Problem
{
    class Program
    {
        public static List<int> ConsecutiveSum(List<int> arr)
        {
            List<int> res = new List<int>();
            int data = arr[0];
            int sum = 0;
            foreach (int elmt in arr)
            {
                if (elmt == data)
                {
                    sum += data;
                }
                else
                {
                    res.Add(sum);
                    sum = data = elmt;
                }
            }
            res.Add(sum);
            return res;
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1};
            List<int> res = ConsecutiveSum(arr);
            foreach (int element in res)
            {
                Console.WriteLine(element);
            }
        }
    }
}
