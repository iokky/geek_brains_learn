using System;
using System.Linq;
using System.Numerics;

namespace geek_brains_learn
{
    public static class Lesson3
    {
        public static string Polin(int num)
        {
            string stringNum = num.ToString();
            if (stringNum.Length != 5)
                return "число не 5 значное";

            return stringNum[..2] == $"{stringNum[4]}{stringNum[3]}" ? "Да" : "Нет";
        }

        public static double Distance(Vector3 v1, Vector3 v2) => Vector3.Distance(v1, v2);

        public static dynamic Cube(int a) => Enumerable.Range(1, a).ToArray().Select(i => Math.Pow(i, 3)); 

    }
}
