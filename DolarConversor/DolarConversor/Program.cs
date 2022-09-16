using DolarConversor;
using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        //double amount, quotation;

        Console.WriteLine("What is the dollar exchange rate?");
        double quotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("How many dollars do you wanna buy?");
        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Value to pay: " + Conversor.Calculator(quotation, amount)); 

    }
}