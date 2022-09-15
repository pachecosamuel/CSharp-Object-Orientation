using SecondExercisePOO;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {

        /*Produto p1;
        p1 = new Produto();*/
        Produto p1 = new Produto();

        Console.WriteLine("Type informations about the products");

        Console.Write("Name: ");
        p1.Name = Console.ReadLine();

        Console.Write("Price: ");
        p1.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantidade: ");
        p1.Amount = int.Parse(Console.ReadLine());

        Console.WriteLine(p1);

        Console.Write("\nAdd more products to stock: ");
        int add = int.Parse(Console.ReadLine());
        p1.AddProdutos(add);
        Console.WriteLine(p1);

        Console.Write("\nRemove products from stock: ");
        int sub = int.Parse(Console.ReadLine());    
        p1.RemoveProdutos(sub); 
        Console.WriteLine(p1);

    }
}