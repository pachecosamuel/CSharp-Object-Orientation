using Class_140_Challenge_InheritPolyphormism.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Type the amount of employees: ");
        int nEmployees = int.Parse(Console.ReadLine());
        List<Employee> list = new();


        for (int i = 0; i < nEmployees; i++)
        {
            Console.WriteLine($"Employee {i + 1} data: ");
            Console.Write("Outsouced (yes/no)? ");
            string condition = Console.ReadLine();

            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hours: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (condition == "yes")
            {
                Console.Write("Adittional Charge : ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                OutsourcedEmployee outsourcedEmployee = new(name, hours, valuePerHour, additionalCharge);
                list.Add(outsourcedEmployee);
            }
            else
            {
                Employee employee = new(name, hours, valuePerHour);
                list.Add((employee));
            }
        }

        Console.WriteLine();

        foreach (Employee obj in list)
        {
            if (obj is Employee)
            {
                Console.WriteLine($"{obj.Name} - $ {obj.Payment():F2}");
            }
            else
            {
                Console.WriteLine($"{obj.Name} - $ {obj.Payment():F2}");
            }
        }
    }
}