internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\Samuel Pacheco\Desktop\JobT2M\LuxuryUpper.txt";

        Console.WriteLine();

        Console.WriteLine($"Path.PathSeparator -> {Path.PathSeparator}");
        Console.WriteLine($"Path.GetDirectoryName -> {Path.GetDirectoryName(path)}");
        Console.WriteLine($"Path.GetExtension -> {Path.GetExtension(path)}");

        
        
        Console.WriteLine();

    }
}