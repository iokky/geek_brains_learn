namespace geek_brains_learn;

public class Lesson5
{
    static Random rnd = new Random();
    public static int ArrayGen()
    {
        int even = 0;
        int[] array = new int[4];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1000);
            if (array[i] % 2 == 0) even++;
        }
        return even;
    }

    public static int ArrayGen2()
    {
        int[] arr = new int[4];
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100);
            if ((double)i % 2 != 0) sum += arr[i];
        }
        return sum;
    }

    public static int ArrayGen3()
    {
        int[] arr = new int [4];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100);
        }
        return arr.Max() - arr.Min();

    }
}
