using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geek_brains_learn
{
    public class Leasson9
    {
        private static int result;
        public static void SequenceNumber(int a)
        {
            Console.WriteLine(a);
            if(a > 1) SequenceNumber(a - 1);
            return;
        }

        public static int SumInRange(int m, int n)
        {
            if(n > m) 
            {
                result += n;
                n--;
                SumInRange(m, n);
            }
            return result;
        }
    }
}
