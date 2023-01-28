using System.Numerics;
using System.Drawing.Drawing2D;
namespace geek_brains_learn;

public class Lesson8
{
    public static int[][] MultiArraySort(int[,] array)
    {
        int[][] result = new int[array.GetLength(0)][];
 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result[i] = new int[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[i][j] = array[i, j];
            }
            result[i] = result[i].OrderByDescending(x => x).ToArray();
        }
        return result;
  
    }
    public static string MinSumOfRow(int[,] array)
    {
        int[] result = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[i] += array[i, j];
            }
        }
        return $"Max sum in row {Array.IndexOf(result, result.Min()) + 1}";
    }

    public static int[,] MatrixMultiplication()
    {
        int[,] array1 = new int[,] { { 2, 4 }, { 3, 2 } };
        int[,] array2 = new int[,] { { 3, 4 }, { 3, 3 } };
        int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];

        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(1); k++)
                {
                    result[i, j] += array1[i, k] * array2[k, j];
                }
            }    
        }
        return result;
    }

    public static void TrippleArrayGenerator()
    {
        Random random = new Random();
        int[,,] array = new int[2,2,2];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = random.Next(10, 100);
                    Console.Write($"{array[i, j, k]}({i},{j},{k})");
                }
                Console.WriteLine();
            }
        } 
    }

    public static void SpiralAddedToArray()
    {
        int MatrixSize = 4;
        int temp = 1;
        int i = 0;
        int j = 0;
        int[,] array = new int[MatrixSize, MatrixSize];


        while (temp <= array.GetLength(0) * array.GetLength(1))
        {
            array[i, j] = temp;
            temp++;
            if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
            else if (i < j && i + j >= array.GetLength(0) - 1) i++;
            else if (i >= j && i + j > array.GetLength(1) - 1)j--;
            else i--;
        }
        for (int a = 0; a < array.GetLength(0); a++)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {
                Console.Write(array[a, b]);
            }
            Console.WriteLine();
        }
    }
}
