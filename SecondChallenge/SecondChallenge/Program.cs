using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        
        Console.WriteLine("Type your full name: ");
        string name = Console.ReadLine();

        Console.WriteLine("How many bedrooms are there in your house?");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Type a price of a product");
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Name and middle name: {name}\nBedrooms: {n1}\nProduct {n2}\n");


        Console.WriteLine("Type your last name, age and height");
        string[] vet = Console.ReadLine().Split(" ");
        string ln = vet[0];
        int age = int.Parse(vet[1]);
        double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine($"\nLast name: {ln} Age: {age} Height: {height}\n");

    }
}