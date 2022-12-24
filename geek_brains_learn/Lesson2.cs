namespace geek_brains_learn
{
    public static class Lesson2
    {
        //Если принимаемое цисло меньше 100 возращает 0
        public static int SecondNumber(int a)
        {
            if (a < 100)
                return 0;
            string result = a.ToString();
            char data = result[1];

            return (int)Char.GetNumericValue(data);
        }

        public static string ThirdNumber(int a)
        {
            if (a < 100)
                return "третьей цифры нет";
            string result = a.ToString();
            char data = result[2];
            return data.ToString();
        }

        public static string HollyDay(int a)
        {
            return a < 8 ?(a > 5 ? "да" : "нет"):"такого дня недели не существует";
        }
    }
}
