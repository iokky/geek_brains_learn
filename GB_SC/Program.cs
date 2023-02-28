using GB_SC;

class Programm
{
    public static void Fio()
    {
        Console.WriteLine(ls4.GetFullName("Ivan", "Ivanov", "Konstantinovich"));
        Console.WriteLine(ls4.GetFullName("Petr", "Petrov", "Semenovich"));
        Console.WriteLine(ls4.GetFullName("Stepan", "Kotov", "Andreevich"));
    }
    static void Main(string[] args)
    {
        //Console.WriteLine(ls4.CountSymbolByString(Console.ReadLine()??""));
        //Console.WriteLine(ls4.GetSeasson(13));

        string s = "Предложение один Теперь предложение два Предложение три";

        Console.WriteLine(ls4.ReplaceString(s));
        ls4.Fibonachi(3);
    }


}