namespace GB_SC;

public static class ls5
{

    public static void Write(string data)
    {
        string path = "C:\\Users\\Anton\\Desktop\\rd.txt";

        using(StreamWriter sw = new StreamWriter(path,  true))
        {
            sw.Write($"{data}\n");
        }
    }

    public static void WriteTimeStart() 
    {
        string path = "C:\\Users\\Anton\\Desktop\\startup.txt"; 

        using(StreamWriter sw = new StreamWriter(path, true))
        {
            sw.WriteLine(DateTime.Now.ToString("HH/mm/ss"));
        }
    }

    public static string BinareDataWrite(int data) 
    {
        if (data == 0) return "1";
        else
            return BinareDataWrite(data / 2) + (data % 2);
    }
}


public class Employee
{
    private readonly string _fio;
    private readonly string _job;
    private readonly string _email;
    private readonly string _phoneNumber;
    private readonly int _salary;
    private readonly int _age;


    public Employee(string fio, string job, string email, string phoneNumber, int salary, int age)
    {
        _fio = fio;
        _job = job;
        _email = email;
        _phoneNumber = phoneNumber;
        _salary = salary;
        _age = age;
    }

    public int GetAge() => _age;
    public void GetInfo() => Console.WriteLine($"{_fio} {_job} {_email} {_phoneNumber} {_salary} {_age}" );
}