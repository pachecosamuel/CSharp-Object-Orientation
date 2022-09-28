using Class_204_Interfaces.Entities;
using Class_204_Interfaces.Services;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Type rental data");

        Console.Write("Car model : ");
        string carModel = Console.ReadLine();

        Console.Write("Pickup (dd/MM/yyyy hh:mm) : ");
        DateTime pickUp = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

        Console.Write("Return (dd/MM/yyyy hh:mm) : ");
        DateTime retorno = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
        
        Console.Write("Type the price to the hours : ");
        double hours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.Write("Type the price to the days : ");
        double days = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        CarRental carRental = new(pickUp, retorno, new Vehicle(carModel));

        RentalService rentalService = new(hours, days, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine(carRental.Invoice);
    }
}