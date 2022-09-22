using Review21_09.Entities;
using Review21_09.Entities.Enums;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Type department's name : ");
        string deptName = Console.ReadLine();
        Department department = new(deptName);

        Console.WriteLine("Provide worker's data");
        Console.Write("Name : ");
        string name = Console.ReadLine();

        Console.Write("Level (Junior/MidLevel/Senior) : ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

        Console.Write("Base Salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Worker worker = new(name, level, baseSalary, department);

        Console.Write("How many contracts to this worker? ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++) 
        {
            Console.WriteLine($"Type {i+1}° contract's data: ");

            Console.Write("Date (DD/MM/YYYY) : ");
            DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Value per hours : ");
            double valuePerHour = double.Parse(Console.ReadLine());

            Console.Write("Duration : ");
            int duration = int.Parse(Console.ReadLine());

            Contract contract = new(date, valuePerHour, duration);
            worker.AddContract(contract);
        }

        Console.Write("Type month and year to calculate income (MM/YYYY) : ");
        string[] monthAndYear = Console.ReadLine().Split("/");
        int month = int.Parse(monthAndYear[0]); 
        int year = int.Parse(monthAndYear[1]);

        worker.Income(year, month);

        Console.WriteLine(worker);
        Console.WriteLine($"Income for {month}/{year} : {worker.Income(year, month)}");


    }
}