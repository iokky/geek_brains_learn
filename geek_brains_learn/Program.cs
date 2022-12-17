using geek_brains_learn;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Leasson1.Max(12, 7));
        Console.WriteLine(Leasson1.Even(1));

        var data = Leasson1.Range(7);
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }
}
