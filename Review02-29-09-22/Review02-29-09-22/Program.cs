using Review02_29_09_22.Entities;
using Review02_29_09_22.Services;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Type rental data");

        Console.Write("Car Model : ");
        string model = Console.ReadLine();

        Console.Write("Pickup (dd/MM/yyyy hh:mm) : ");
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Return (dd/MM/yyyy hh:mm) : ");
        DateTime finishDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        CarRental carRental = new(startDate, finishDate, new Vehicle(model));

        Console.Write("Type price per hour : ");
        double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Type price per day : ");
        double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        RentalService rentalService = new(pricePerHour, pricePerDay, new BrazilTaxService());

        Console.WriteLine();

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine("Invoice :");
        Console.WriteLine(carRental.Invoice);

    }
}