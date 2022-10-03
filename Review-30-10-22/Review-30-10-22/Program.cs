using Review_30_10_22.Services;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        UniversalPrint up = new();

        up.PrintUniversal(10.5);
        up.PrintUniversal(20);
        up.PrintUniversal("Samuel");
        up.PrintUniversal('c');

        /*
        PrintService<string> printServiceString = new();
        PrintService<double> printServiceDouble = new();

        Console.Write("How many values? ");
        int amount = int.Parse(Console.ReadLine());

        for (int i = 0; i < amount; i++)
        {
            Console.Write($"{i+1}° value: ");
            double auxiliar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            printServiceDouble.AddValue(auxiliar);
        }

        Console.WriteLine();

        for (int i = 0; i < amount; i++)
        {
            Console.Write($"{i+1}° words: ");
            string auxiliar = Console.ReadLine();
            printServiceString.AddValue(auxiliar);
        }

        Console.WriteLine();

        Console.Write("Int generics values: ");
        printServiceDouble.Print();

        Console.WriteLine();

        Console.Write("String generics values: ");
        printServiceString.Print();

        Console.WriteLine();
        Console.WriteLine("First int value : " + printServiceDouble.First());
        
        Console.WriteLine();
        Console.WriteLine("First string value : " + printServiceDouble.First());
        */

    }
}