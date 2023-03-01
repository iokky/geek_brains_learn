using GB_SC;

class Programm
{
    static void Main(string[] args)
    {
        //ls5.Write(ls5.BinareDataWrite(890));
        Foo();
    }

    static void Foo()
    {
        Employee[] employers =
        {
            new Employee("Ivanov", "Engineer", "iv@i.com", "890", 40000, 23),
            new Employee("Petrov", "Engineer", "Petr@i.com", "112", 45000, 30),
            new Employee("Filatov", "Programmer", "Filme@i.com", "040", 80000, 35),
            new Employee("Smirnova", "Hr", "myHr@i.com", "011", 30000, 42),
            new Employee("Kozlov", "Director", "BossBox@i.com", "011", 200000, 51),
        };

        foreach (Employee emp in employers)
        {
            if(emp.GetAge() > 40)
                emp.GetInfo();
        }
    }
}