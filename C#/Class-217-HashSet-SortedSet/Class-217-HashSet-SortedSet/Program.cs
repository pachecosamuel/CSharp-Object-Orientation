using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {

        SortedSet<int> x = new() { 0, 2, 4, 6, 8, 10 };
        SortedSet<int> y = new() { 0, 1, 2, 3, 4, 5 };


        // Union -> Exists in both collections
        SortedSet<int> a = new(x);
        a.UnionWith(y);
        Console.Write($"Union -> ");
        PrintCollection(a);

        // Intersection -> Exclusives value from both collections
        SortedSet<int> b = new(x);
        b.IntersectWith(y);
        Console.Write($"Intersection -> ");
        PrintCollection(b);

        // Difference
        SortedSet<int> c = new(x);
        c.ExceptWith(y);
        Console.Write($"Exception -> ");
        PrintCollection(c);


        HashSet<string> set = new();

        set.Add("Monitor 27'");
        set.Add("Iphone 14");
        set.Add("Airpods 2");
        set.Add("Razer Kraken Chroma White");
        set.Add("Macbook Pro");

        int i = 1;
        foreach (string obj in set)
        {
            Console.WriteLine($"Wishlist {i}° : {obj}");
            i++;
        }
    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        Console.Write("[ ");
        foreach (T item in collection)
        {
            Console.Write($"{item}, ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}