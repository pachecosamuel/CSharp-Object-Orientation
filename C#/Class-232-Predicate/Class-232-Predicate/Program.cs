using Class_232_Predicate;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        Action<Product> act = p => { p.ProductPrice += p.ProductPrice * 0.1 ; };

        //list.RemoveAll(ProductValidation);
        list.ForEach(p => { p.ProductPrice += p.ProductPrice * 0.1; });

        Func<Product, string> func = NameUpper;

        List<string> listUpper = list.Select(func).ToList();

        foreach (string p in listUpper)
        {
            Console.WriteLine(p);
        }
    }

    public static string NameUpper(Product p)
    {
        return p.ProductName.ToUpper();
    }

    public static void ProductIncrease(Product p)
    {
        p.ProductPrice += p.ProductPrice * 0.1;
    }

    public static bool ProductValidation(Product p)
    {
        return p.ProductPrice >= 400.0;
    }
}