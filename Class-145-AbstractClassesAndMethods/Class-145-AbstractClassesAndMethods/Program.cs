using Class_145_AbstractClassesAndMethods.Entities;
using Class_145_AbstractClassesAndMethods.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Shapes: ");
        int num = int.Parse(Console.ReadLine());
        List<Shape> shapes = new();

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"Shape {i+1} data: ");

            Console.WriteLine("Rectangle or Circle (rect/circ) ? ");
            string shape = Console.ReadLine();
            Console.WriteLine("Color (Black/ Blue/ Red)? ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (shape == "rect")
            {
                Console.WriteLine("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                shapes.Add(new Rectangle(width, height, color));
            }
            else
            {
                Console.WriteLine("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                shapes.Add(new Circle(radius, color));
            }
        }

        Console.WriteLine();
        Console.WriteLine("Shape areas");

        foreach (Shape obj in shapes)
        {
            Console.WriteLine(obj.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}