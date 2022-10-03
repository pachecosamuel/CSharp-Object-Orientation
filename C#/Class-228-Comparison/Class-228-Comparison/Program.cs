using Class_228_Comparison.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new();
        list.Add(new Product(900, "TV"));
        list.Add(new Product(1200, "Notebook"));
        list.Add(new Product(450, "Tablet"));

        Comparison<Product> comp = CompareProducts;

        list.Sort((p1, p2) => p1.ProductName.ToUpper().CompareTo(p2.ProductName.ToUpper()));

        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
    }

    static int CompareProducts(Product p1, Product p2)
    {
        return p1.ProductPrice.CompareTo(p2.ProductPrice);
    }
}