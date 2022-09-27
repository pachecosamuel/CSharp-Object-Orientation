using Class135_Inherit_polymorphism.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Account acc1 = new(1010, "Brazza", 500.00);
        Account acc2 = new SavingAccount(1111, "Predella", 500.00, 1000.0);
        Account bacc = new BusinessAccount(1212, "Samuca", 500.00, 1000.0);

        BusinessAccount bac = new(1313, "Samuel", 1000.00, 10000.00);

        acc1.Withdraw(10);
        acc2.Withdraw(10);

        Console.WriteLine(bacc);
        Console.WriteLine(bac);

        
    }
}