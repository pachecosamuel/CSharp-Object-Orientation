using Constructor;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {

        Product p1 = new("TV", 1000, 10);

        Console.WriteLine(p1.Nome);
        Console.WriteLine(p1.Preco);
        Console.WriteLine(p1.Quantidade);
    }
}