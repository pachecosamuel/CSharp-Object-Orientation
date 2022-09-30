using Class_210_InterfaceChallenge.Entities;
using Class_210_InterfaceChallenge.Services;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");
        Console.Write("Number : ");
        int accountNumber = int.Parse(Console.ReadLine());

        Console.Write("Date (dd/MM/yyyy) : ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.Write("Contract value : ");
        double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter number of installments : ");
        int months = int.Parse(Console.ReadLine());

        Contract contract = new(accountNumber, date, value);
        ContractService contractService = new(new PaypalService());

        contractService.ProcessContract(contract, months);

        Console.WriteLine();
        Console.WriteLine("Installments");

        foreach (Installment obj in contract.InstallmentsList)
        {
            Console.WriteLine(obj);
        }
    }
}