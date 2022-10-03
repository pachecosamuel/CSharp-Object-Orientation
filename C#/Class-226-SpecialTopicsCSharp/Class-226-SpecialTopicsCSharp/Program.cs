internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dt = new(2022, 10, 03, 10, 00, 00);
        Console.WriteLine(dt.ElapsedTime());

    }
}