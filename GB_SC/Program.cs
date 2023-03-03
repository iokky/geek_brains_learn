using GB_SC;

class Programm
{

    static void Main(string[] args)
    {
        Console.WriteLine(ls4.SumSymbolByString("1 2 3"));
    }

    static void ArrayRun()
    {
        string[,] array =
        {
            {"1", "2", "3", "4" },
            {"5", "6", "7", "8" },
            {"9", "10", "11", "12"},
            {"9", "10", "11", "12"},
        };

        int x = 0;
        try
        {
            try
            {
                x = ArraySummator.SumOfArrayValue(array);
            }
            catch (MyArrayDataException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        catch (MyArraySizeException e)
        {

            Console.WriteLine(e.Message);
        }

        Console.WriteLine(x);
    }

    static void EmployeeSort()
    {
        Employee[] employers =
        {
            new Employee("Ivanov", "Engineer", "iv@i.com", "890", 40000, 23),
            new Employee("Petrov", "Engineer", "Petr@i.com", "112", 45000, 30),
            new Employee("Filatov", "Programmer", "Filme@i.com", "040", 80000, 35),
            new Employee("Smirnova", "Hr", "myHr@i.com", "011", 30000, 42),
            new Employee("Kozlov", "Director", "BossBox@i.com", "011", 200000, 51),
        };

        foreach (Employee emp in employers.Where(i => i.GetAge() > 40).ToArray())
        {
            emp.GetInfo();
        }
    }

 
}