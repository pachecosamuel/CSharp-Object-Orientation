using Circuference;
using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        Console.WriteLine("Type the circumference's radius");
        Calculator.Radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Circumference: " + Calculator.Circumference(Calculator.Radius).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume : " + Calculator.Volume(Calculator.Radius).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PI : " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
    }

    

}