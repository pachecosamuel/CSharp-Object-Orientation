using FirstExercisesPOO;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        //Class person with name, age and salary
        // you have to filter and points to the older
        //person e the average of salary
        Pessoa p1, p2;

        p1 = new Pessoa();
        p2 = new Pessoa();

        Console.WriteLine("Type name, age and salary to the first person");
        p1.Nome = Console.ReadLine();
        p1.Age = int.Parse(Console.ReadLine());
        p1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("\nType name, age and salary to the second person");
        p2.Nome = Console.ReadLine();
        p2.Age = int.Parse(Console.ReadLine());
        p2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (p1.Age > p2.Age) {
            Console.WriteLine("\nPerson older: " + p1.Nome);
            Console.WriteLine("Salarial average: " + (p1.Salary + p2.Salary) / 2);
        }
        else {
            Console.WriteLine("\nPerson older: " + p2.Nome);
            Console.WriteLine("Salarial average: " + (p1.Salary + p2.Salary) / 2);
        }
    }
}