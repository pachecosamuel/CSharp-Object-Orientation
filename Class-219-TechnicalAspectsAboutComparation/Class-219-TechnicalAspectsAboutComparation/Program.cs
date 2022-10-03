using Class_219_TechnicalAspectsAboutComparation.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<Product> prod = new();
        HashSet<Point> point = new();

        prod.Add(new Product("TV", 900));
        prod.Add(new Product("Notebook", 1200));

        point.Add(new Point(9, 3));
        point.Add(new Point(8, 2));

        Product p = new("Notebook", 1200);



    }
}