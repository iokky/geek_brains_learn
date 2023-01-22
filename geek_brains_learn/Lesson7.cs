using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geek_brains_learn
{
    public class Lesson7
    {
        static Random random = new Random();


        public static int[,] MultiArray(int a, int b)
        {
            int[,] array = new int[a, b];
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = random.Next(1, 900);
                }
            }

            return array;
        }

        public static string IndexValue(int a, int b)
        {
            string result = String.Empty;
            var data = MultiArray(5, 5);
            try
            {
                result = data[a, b].ToString();
            }
            catch(Exception ex)
            {
                result = "empty data";
            }
            return result;
        }

        public static double[] AverageArray(int[,] array)
        {


            double[] result = new double[array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[j] += ((double)array[i, j] / array.GetLength(0));
                }

            }
            return result;
        }
    }
}
