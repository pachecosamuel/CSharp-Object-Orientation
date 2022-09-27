using AnotherExercise;
using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        Worker w1 = new Worker();

        Console.Write("Digite o nome: ");
        w1.Name = Console.ReadLine();

        Console.Write("Digite o Salário bruto: ");
        w1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o imposto a ser pago: ");
        w1.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(w1);

        Console.Write("Digite o percentual de aumento: ");
        double adjust = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        w1.Readjustment(adjust);
        Console.WriteLine(w1);
    }
}