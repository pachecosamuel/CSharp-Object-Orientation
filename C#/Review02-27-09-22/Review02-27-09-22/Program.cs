using Review02_27_09_22.Entities;
using Review02_27_09_22.Entities.Exceptions;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Type account data");

                Console.Write("Number : ");
                int accountNumber = int.Parse(Console.ReadLine());

                Console.Write("Holder : ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance : ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit : ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                
                Console.Write("Type the value for withdraw : ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new(accountNumber, holder, initialBalance, withdrawLimit);

                acc.Withdraw(amount);
            }
            catch (DomainException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }


    }
}