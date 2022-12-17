using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geek_brains_learn
{

    public static class Leasson1
    {  
        public static string Max(int a, int b)
        {
            string result = a < b ? $"{a} is max" : $"{b} is max";
            return result;
        }

        public static string Tripple(int a, int b, int c) 
        {
            int[] arr = {a, b, c};
            return $"{arr.Max()} is max";
        }

        public static string Even(int num)
        {
            string result = (num % 2 == 0) ? $"{num} is even": $"{num} is not even";
            return result;
        }

        public static int[] Range(int num)
        {
            int[] arr = Enumerable.Range(1, num).Where(x => x % 2 == 0 ).ToArray();
            return arr;
        } 
    }

}
