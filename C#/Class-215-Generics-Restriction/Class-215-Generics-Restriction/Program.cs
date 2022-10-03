using Class_215_Generics_Restriction.Entites;
using Class_215_Generics_Restriction.Services;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("How many itens? ");
        int x = int.Parse(Console.ReadLine());

        List<Product> list = new();

        for (int i = 0; i < x; i++)
        {
            string[] line = Console.ReadLine().Split(",");
            string name = line[0];
            double price = double.Parse(line[1], CultureInfo.InvariantCulture);

            list.Add(new Product(name, price));
        }

        CalculationService calculationService = new();

        Console.WriteLine($"Max : {calculationService.Max(list)}");

    }
}