using Class_216_GetHashCode_Equals.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer c1 = new("Samuel", "samu@g.com");
        Customer c2 = new("Julia", "julia@g.com");

        Console.WriteLine(c1.Equals(c2));
        Console.WriteLine(c1.GetHashCode());
        Console.WriteLine(c2.GetHashCode());
    }
}