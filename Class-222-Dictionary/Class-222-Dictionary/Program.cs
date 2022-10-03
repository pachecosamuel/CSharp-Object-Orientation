internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> cks = new();

        cks[1] = "Samuel";
        cks[2] = "samu@gmail.com";
        cks[3] = "40028922";
        cks[3] = "123456789";

        Console.WriteLine(cks[1]);
        Console.WriteLine(cks[2]);
        Console.WriteLine(cks[3]);

        try
        {
            cks.Remove(4);
            Console.WriteLine("FOI");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}