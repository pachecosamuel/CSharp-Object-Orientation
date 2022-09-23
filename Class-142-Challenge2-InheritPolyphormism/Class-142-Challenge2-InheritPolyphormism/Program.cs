using Class_142_Challenge2_InheritPolyphormism.Entities;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Type the amount of products: ");
        int amountProducts = int.Parse(Console.ReadLine());
        List<Product> list = new();

        for (int i = 0; i < amountProducts; i++)
        {
            Console.WriteLine($"Product {i+1} data: ");

            Console.Write("Common, used or imported (c/u/i)? ");
            char status = char.Parse(Console.ReadLine());

            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Price : ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (status == 'c')
            {
                Product product = new(name, price);
                list.Add(product);
            }
            else if (status == 'i')
            {
                Console.Write("Customs fee : ");
                double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ImportedProduct importedProduct = new(name, price, customsFee);
                list.Add(importedProduct);
            }
            else
            {
                Console.Write("Manufacture date (DD/MM/YYYY) : ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                UsedProduct usedProduct = new(name, price, date);
                list.Add(usedProduct);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Price Tags: ");

        foreach (Product obj in list)
        {
            Console.WriteLine(obj.PriceTag());
        }

    }
}