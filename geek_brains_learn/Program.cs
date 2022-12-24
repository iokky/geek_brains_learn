using System.Numerics;
using geek_brains_learn;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine(Lesson2.SecondNumber(345));
        Console.WriteLine(Lesson2.ThirdNumber(34));
        Console.WriteLine(Lesson2.HollyDay(70));*/

        //Console.WriteLine(Lesson3.Polin(23435));
        //Console.WriteLine(Lesson3.Distance(new Vector3(3, 6, 8), new Vector3(2, 1, -7)));
        foreach (var item in Lesson3.Cube(5))
        {
            Console.WriteLine(item);
        }
        

    }

}
