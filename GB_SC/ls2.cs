using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_SC;


internal class ls2
{

    static Dictionary<int, string> mouth = new()
    {
        {1, "January" },
        {2, "February" },
        {3, "Marth" },
        {4, "April" },
        {5, "Mai"},
        {6,  "June"},
        {7, "Jul"},
        {8, "August"},
        {9, "September" },
        {10, "October" },
        {11, "November"},
        {12, "December"}
    };
    public static int AverageTemp(int min, int max) => (min + max) / 2;

    public static string GetMouthName(int number) => mouth[number];

    public static bool GetAverageOfNumber(int number) => number % 2 == 0;
}
