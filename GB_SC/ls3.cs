using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_SC;

public static class ls3
{
    public static void DoubleArrayDiagonalPrint()
    {
        int[,] array = 
        { 
            {1, 2, 3, 4}, 
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        for (int i = 0; i <= array.GetLength(0); i++)
        {
           Console.WriteLine(array[i, i]);           
        }
    }

    public static void TelBook()
    {
        string[,] tel = 
        {
            {"Vasiya", "v@mail.com" },
            {"Irina", "ira@mail.me" },
            {"Petr", "PP@icloud.com" },
            {"Vera", "meme@yandex.ru" },
            {"Kostya", "hot@mail.com" }
        };

        for (int i = 0; i < tel.GetLength(0); i++)
        {
            for (int j = 0; j < tel.GetLength(1); j++)
            {
                Console.Write(tel[i, j]);
            }
            Console.WriteLine();
        }

    }

    public static void StringReverse(string str)
    {

        Console.WriteLine(new string(str.ToCharArray().Reverse().ToArray()));
    }

    public static void SeaBattle()
    {
        string[,] location =
        {
            {"X", "O", "O", "O", "O", "O", "X", "O", "O", "O"},
            {"O", "O", "X", "O", "O", "O", "O", "O", "O", "O"},
            {"O", "O", "O", "O", "O", "O", "O", "X", "O", "O"},
            {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
            {"O", "O", "O", "O", "O", "X", "X", "O", "O", "O"},
            {"O", "O", "X", "X", "O", "O", "O", "O", "O", "O"},
            {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
            {"X", "X", "O", "O", "O", "O", "O", "O", "O", "X"},
            {"O", "O", "O", "O", "O", "X", "X", "X", "O", "X"},
            {"X", "X", "X", "X", "O", "O", "O", "O", "O", "X"}

        };

        for (int i = 0; i < location.GetLength(0); i++)
        {
            for (int j = 0; j < location.GetLength(1); j++)
            {
                Console.Write(location[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void ArrayReBuild(int a)
    {
        int[] array = { 1, 2, 3, 4 };
        if (a > 0)
        {
            PositiveMove(array, a);
        }
        else
        {
            NegativeMove(array, a);
        }

    }

    public static void NegativeMove(int[] array,  int a)
    {
        int temp = 0;
        while (temp > a)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            temp--;

        }

        Array.Reverse(array);

        for (int i = 0; i < (a * -1); i++)
        {
            array[i] = 0;
        }

        Array.Reverse(array);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    public static void PositiveMove(int[] array, int a)
    {
        int temp = 0;
        while (temp < a)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            temp++;
        }

        for (int i = 0; i < a; i++)
        {
            array[i] = 0;
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
