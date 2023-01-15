namespace geek_brains_learn;

public static class Lesson4
{
   public static int Degree(int a, int b)
    {
        var result = 1;
        for (int i = 1; i <= b; i++)
        {
            result = result * a;
        }
        return result;
    }

    public static int Sum(int a)
    {
        string data = a.ToString();
        int result = 0;
        for (int i = 0; i < data.Length; i++)
        {
            result += int.Parse(data[i].ToString());
        }
        return result;
    }

    public static int[] Array(string data)
    {
        var array = data.Split(',');
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = int.Parse(array[i]);
        }
        return result;
    }
}
