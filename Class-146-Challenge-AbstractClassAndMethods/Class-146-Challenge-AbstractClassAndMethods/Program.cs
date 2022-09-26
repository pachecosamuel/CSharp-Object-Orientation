using Class_146_Challenge_AbstractClassAndMethods.Entities;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Amount of tax payers: ");
        int TaxPayers = int.Parse(Console.ReadLine());
        List<TaxPayer> TaxPayersList = new();

        Console.WriteLine();

        for (int i = 0; i < TaxPayers; i++)
        {
            Console.WriteLine($"Tax payer {i + 1} data: ");

            Console.WriteLine("Individual or company (i/c) ? ");
            char valid = char.Parse(Console.ReadLine());

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Anual Income: ");
            double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valid == 'i')
            {
                Console.WriteLine("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                TaxPayersList.Add(new Individual(name, anualIncome, healthExpenditures));
            }
            else
            {
                Console.WriteLine("Amount of employees: ");
                int amoutEmployees = int.Parse(Console.ReadLine());


                TaxPayersList.Add(new Company(name, anualIncome, amoutEmployees));
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("TAXES PAID");

        double TotalTax = 0.0;
        foreach (TaxPayer obj in TaxPayersList)
        {
            TotalTax += obj.Tax();
        }

        Console.WriteLine("Total Taxes : " + TotalTax.ToString("F2", CultureInfo.InvariantCulture));
    }
}