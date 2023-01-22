using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geek_brains_learn
{
    public class Lesson6
    {
        public static int PositiveCount(string data) => data.Split(",").Select(p => Convert.ToInt32(p)).ToArray().Where(p => p > 0).Count();

        public static (double, double) CrossLine(double b1, double k1, double b2, double k2) => ((-b2 + b1) / (-k1 + k2), k2 * ((-b2 + b1) / (-k1 + k2)) + b2);

    }
}
