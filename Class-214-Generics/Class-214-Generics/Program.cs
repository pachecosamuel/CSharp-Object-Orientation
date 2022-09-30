using Class_214_Generics.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        PrintService printService = new();

        Console.Write("How many values?");
        int x = int.Parse(Console.ReadLine());

        printService.AddValue(x);
        printService.Print();
        printService.First();
    }
}