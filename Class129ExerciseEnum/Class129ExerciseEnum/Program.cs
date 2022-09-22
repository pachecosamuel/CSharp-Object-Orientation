using Class129ExerciseEnum.Entities;
using Class129ExerciseEnum.Entities.Enums;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Type department's name: ");
        string deptName = Console.ReadLine();
        Department department = new(deptName);

        Console.WriteLine("Type worker's data");
        Console.Write("Name : ");
        string name = Console.ReadLine();

        Console.Write("Junior/MidLevel/Senior: ");
        WorkerLevel wl = Enum.Parse<WorkerLevel>(Console.ReadLine());

        Console.Write("Base salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Worker worker = new(name, wl, baseSalary, department);

        Console.Write("How many contracts to this worker? ");
        int amount = int.Parse(Console.ReadLine());

        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine($"Type #{i+1} contract data: ");
            
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Duration (hours): ");
            int duration = int.Parse(Console.ReadLine());

            HourContract hc = new(date, valuePerHour, duration);
            worker.AddContract(hc);
        }

        Console.WriteLine();
        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string[] monthAndYear = Console.ReadLine().Split("/");

        int month = int.Parse(monthAndYear[0]);
        int year = int.Parse(monthAndYear[1]);

        Console.WriteLine();
        Console.WriteLine("Name : " + worker.Name);
        Console.WriteLine("Department : " + worker.Department.Name);
        Console.WriteLine($"Income for -> {month}/{year} : " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));



    }
}