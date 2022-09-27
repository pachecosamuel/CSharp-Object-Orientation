using Class_155_Challenge_Try_Catch.Entities;
using Class_155_Challenge_Try_Catch.Entities.Exceptions;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {

            Console.WriteLine("Type account data");

            Console.Write("Number : ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Initial balance : ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit  : ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Type the amount for withdraw : ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new(accountNumber, name, initialBalance, withdrawLimit);

            try
            {
                acc.Withdraw(amount);
                Console.WriteLine();
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}