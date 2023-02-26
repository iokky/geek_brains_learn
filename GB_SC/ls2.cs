using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_SC;


internal class ls2
{

    static Dictionary<int, string> mouth = new()
    {
        {1, "January" },
        {2, "February" },
        {3, "Marth" },
        {4, "April" },
        {5, "Mai"},
        {6,  "June"},
        {7, "Jul"},
        {8, "August"},
        {9, "September" },
        {10, "October" },
        {11, "November"},
        {12, "December"}
    };
    public static int AverageTemp(int min, int max) => (min + max) / 2;

    public static string GetMouthName(int number) => mouth[number];

    public static bool GetAverageOfNumber(int number) => number % 2 == 0;

    public static void Order()
    {
        string company = "СуперЧек.ru";
        int OrderNumber = 4201;
        string cashier = "Иванов";

        string template = $"\tOOO '{company}'\n\t   Чек: {OrderNumber}\n\t  Кассир:{cashier}" +
            $"\n1.Кирпич пустотельный одинарный М-150 x 10" +
            $"\n  Стоимость........................8176.00" +
            $"\n2.Цемент ПЦ-400 Д 20 (в мешках)" +
            $"\n  Стоимость........................5400.00" +
            $"\n3.Щебня фракция 20х40 т.5 х 480" +
            $"\n  Стоимость........................5400.00" +
            $"\n==========================================" +
            $"\nВсего.............................16628.00" +
            $"\nККМ  00000000000 ИНН 00000000000000  #{OrderNumber}";

        Console.WriteLine(template);
    }

    public static string HumidityOfWinter(int i, int tempMin, int tempMax) => i == 1 || i == 11 || i == 12 & AverageTemp(tempMin, tempMax) > 0 ? "Weat Winter" : "Dry Winter";
}
