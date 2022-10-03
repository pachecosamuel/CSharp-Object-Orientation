internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dt = new DateTime(2022, 10, 1, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());

    }
}