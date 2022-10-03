using Review02_01_10_222.Entities;
using Review02_01_10_222.Services;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        string x = "samu";
        string y = "Samu";
        Product p1 = new("Julia");
        Product p2 = new("Julia");

        Console.WriteLine(p1.Equals(p2));
        Console.WriteLine(p1.GetHashCode());
        Console.WriteLine(p2.GetHashCode());
        
        /*List<Product> list = new();

        while (x < 3)
        {
            string[] line = Console.ReadLine().Split(",");
            string prodName = line[0];
            double price = double.Parse(line[1], CultureInfo.InvariantCulture);

            list.Add(new Product(prodName, price));
            x++;
        }

        CalculationService calculationService = new();
        Console.WriteLine(calculationService.Max(list)); */
    }
}