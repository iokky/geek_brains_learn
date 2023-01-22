using System.Numerics;
using geek_brains_learn;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[,]
        {
                {1, 4, 7, 2 },
                {5, 9, 2, 3 },
                {8, 4, 2, 4 }
        };
        var data = Lesson7.AverageArray(array);
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }
    static void MultiArrayPrint(int[,] data)
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Console.Write($"{data[i, j]} \t");
            }
            Console.WriteLine();
        }
    }

}
