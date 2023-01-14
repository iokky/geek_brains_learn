using System.Numerics;
using geek_brains_learn;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(Lesson4.Degree(3, 5));
        //Console.WriteLine(Lesson4.Sum(82));

        var data = Console.ReadLine();
        var res = Lesson4.Array(data);
        foreach ( var item in res )
        {
            Console.WriteLine(item);    
        }
    }

}
