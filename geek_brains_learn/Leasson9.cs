namespace geek_brains_learn;

public class Leasson9
{
    private static int result;
    public static void SequenceNumber(int a)
    {
        Console.WriteLine(a);
        if(a > 1) SequenceNumber(a - 1);
        return;
    }

    public static int SumInRange(int m, int n)
    {
        if(n > m) 
        {
            result += n;
            n--;
            SumInRange(m, n);
        }
        return result;
    }

    public static int AkkermanFunction(int a, int b)
    {
        if (a == 0)
        {
            return b + 1;
        }
        if (a > 0 && b == 0)
        {
            return AkkermanFunction(a - 1, 1);
        }
        return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
    }
}
