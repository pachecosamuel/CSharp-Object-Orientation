using Class78ChallengeList;
using System.Collections.Generic;
using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        Console.Write("How many employees will be registered? ");
        int amount = int.Parse(Console.ReadLine());
        List<Employee> listEmp = new();

        for (int i = 0; i < amount; i++) {
            Console.WriteLine($"Employee ${i+1}: ");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            listEmp.Add(new Employee ( id, name, salary ) );

            Console.WriteLine();
        }

        Console.Write("Enter employee's id that will have salary's increasing: ");
        double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Employee search = listEmp.Find(x => x.Id == num);

        if (search != null) {
            Console.Write("Enter the percentage: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            search.Readjustment(value);
        }
        else {
            Console.WriteLine("That id doesn't exist!");
        }

        Console.WriteLine("----------");
        foreach (Employee emp in listEmp) {
            Console.WriteLine(emp);
        }

    }
}