using System;
using System.Diagnostics;

namespace GB_SC;


public static class TaskManager
{
    public static void GetProcessAll()
    {
        Process[] procesess = Process.GetProcesses();
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (Process process in procesess)
        {
            Console.WriteLine($"{process.Id}_{process.ProcessName}____used: {process.PagedMemorySize64} MB");
        }
        Console.ResetColor();
    }

    public static void GetProcess(int id)
    {
        Process process = Process.GetProcessById(id);
        try
        {
            Console.WriteLine($"{process.Id}_{process.ProcessName}");
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }

    public static void Kill(int id) 
    {
        Process process = Process.GetProcessById(id);
        try
        {
            process.Kill();
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }

    public static void Kill(string name) 
    {
        Process[] process = Process.GetProcessesByName(name);
        try
        {
            foreach (var item in process)
            {
                item.Kill();
            }
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }
}
public class MyArraySizeException : Exception
{
    public MyArraySizeException(string message)
        : base(message) { }

}

public class MyArrayDataException : Exception
{
    public MyArrayDataException(string message)
        :base(message) { }
}

static class ArraySummator
{
    /// <summary>
    /// <remarks>Array must be a multi array [4,4] </remarks>
    /// </summary>
    /// <param name="array">Array must be a multi array [4,4]</param>
    /// <returns></returns>
    /// <exception cref="MyArraySizeException"></exception>
    /// <exception cref="MyArrayDataException"></exception>
    
    public static int SumOfArrayValue(string[,] array)
    {
        if (array.GetLength(0) != 4 | array.GetLength(1) != 4)
        {
            throw new MyArraySizeException("wrong array Length");
        }

        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {

                if (!int.TryParse(array[i, j], out sum))
                {
                    throw new MyArrayDataException($"wrong data on [{i},{j}]");
                }
                sum += int.Parse(array[i, j]);
            }
        }
        return sum;
    }
}

