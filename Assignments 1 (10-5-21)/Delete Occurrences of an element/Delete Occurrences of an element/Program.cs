using System;
using System.Collections.Generic;
using System.Linq;

namespace Delete_Occurrences_of_an_element
{
    class Program
    {
        static Dictionary<int, int> dictionary = new Dictionary<int, int>();

        static void countFreq(int[] arr, int n, int no)
        {
            for (int i = 0; i < n; i++)
            {
                if (dictionary.ContainsKey(arr[i]))
                    dictionary[arr[i]]++;
                else dictionary.Add(arr[i], 1);
            }

            foreach (KeyValuePair<int, int> dict in dictionary)
            {
                if (dict.Value >= no)
                {
                    for (int i = 0; i < no; i++)
                        Console.Write(dict.Key + " ");
                }
            }
        }

        static void print(int val)
        {
            if (dictionary.ContainsKey(val))
                Console.WriteLine(val);
            else
                return;
        }

        static void Main(string[] args)
        {
            int[] arr = {1,2,1,1,2,3,3,4,5,6};
            int n = arr.Length;
            int no;
            no = 1;

            countFreq(arr, n, no);

        }
    }
}
