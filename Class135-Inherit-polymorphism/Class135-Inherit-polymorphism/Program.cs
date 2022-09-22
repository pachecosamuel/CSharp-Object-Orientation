using Class135_Inherit_polymorphism.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Account acc1 = new(1010, "Brazza", 500.00);
        Account acc2 = new SavingAccount(1111, "Predella", 500.00, 1000.0);
        Account acc3 = new BusinessAccount(1212, "Samuca", 500.00, 1000.0);

        acc1.Withdraw(10);
        acc2.Withdraw(10);
        acc3.Withdraw(10);

        Console.WriteLine("Withdraw: 485 - " + acc1.Balance);
        Console.WriteLine("Withdraw: 490 - " + acc2.Balance);
        Console.WriteLine("Withdraw: 483 - " + acc3.Balance);
    }
}