using Review_29_09_22.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calculator = new(6.0, 3.0);

        Console.WriteLine(calculator.Sum());
        Console.WriteLine(calculator.Subtraction());
        Console.WriteLine(calculator.Multiplication());
        Console.WriteLine(calculator.Division());
    }
}