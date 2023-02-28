using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_SC;

public class ls4
{
    [Flags]
    enum Seasson
    {
        Winter = 1, // декабрь январь февраль
        Spring = 4, // март апрель май
        Summer = 7, // июнь июль август
        Autumn = 10, // сентябрь октябрь ноябрь
    }
    public static string GetFullName(string firstName, string lastName, string patrinymic) => $"{lastName} {firstName} {patrinymic}"; 
    public static int CountSymbolByString(string word) => word.Count();

    public static string GetSeasson(int number)
    {
        string result = String.Empty;

        if (number > 0 && number < 4)
        {
            result = Seasson.Winter.ToString();
        }
        else if (number >= 4 && number < 7)
        {
            result = Seasson.Spring.ToString();
        }
        else if (number >= 7 && number < 10)
        {
            result = Seasson.Summer.ToString();
        }
        else if (number >= 10 && number < 13)
        {
            result = Seasson.Autumn.ToString();
        }
        else
        {
            result = "Ошибка ввода месяца";
        }

        return result;
    }

    public static int Fibonachi(int number)
    {
        Console.WriteLine(number);
        if (number == 0 || number == 1) return number;
        return Fibonachi(number - 1) + Fibonachi(number - 2);
    }

    public static string ReplaceString(string str) => str.Replace("один", "один.").Replace("два", "два.");
}
