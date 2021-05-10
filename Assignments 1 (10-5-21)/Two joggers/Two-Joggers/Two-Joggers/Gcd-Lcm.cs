using System;
using System.Collections.Generic;
using System.Text;

namespace Two_Joggers
{
    public class Gcd_Lcm
    {
        public int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }
        public int lcm(int a, int b)
        {
            return (a / gcd(a, b)) * b;
        }
     
    }
}
