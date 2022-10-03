internal class Program
{
    private static void Main(string[] args)
    {
        SortedSet<int> a = new() { 0, 2, 4, 6, 8, 10 };
        SortedSet<int> b = new() { 0, 1, 2, 3, 4, 5 };
        SortedSet<int> c = new(a);

        int az = 0;
        int bz = 0;
        Console.WriteLine(a == c);
        Console.WriteLine(az == bz);

        //Union
        SortedSet<int> union = new SortedSet<int>(a);
        union.UnionWith(b);
        PrintCollection(union);

        Console.WriteLine();
        //Intersection
        SortedSet<int> intersection = new(a);
        intersection.IntersectWith(b);
        PrintCollection(intersection);

        Console.WriteLine();
        //Difference
        SortedSet<int> difference = new(a);
        difference.ExceptWith(b);
        PrintCollection(difference);
    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}