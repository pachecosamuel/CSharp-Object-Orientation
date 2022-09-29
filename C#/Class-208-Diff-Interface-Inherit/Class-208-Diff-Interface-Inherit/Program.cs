using Class_208_Diff_Interface_Inherit.Model.Entities;
using Class_208_Diff_Interface_Inherit.Model.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        IShape s1 = new Circle(2.0, Color.White);
        IShape s2 = new Rectangle(3.5, 4.2, Color.Black);

        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}