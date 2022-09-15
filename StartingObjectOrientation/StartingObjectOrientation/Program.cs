using StartingObjectOrientation;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {

        //Área de um triângulo = sqrt( p * (p-a)*(p-b)*(p-c) )
        // Sendo P = (a + b + c) / 2

        Triangle x, y;
        x = new Triangle();
        y = new Triangle();

        Console.WriteLine("Type measures to the first triangle");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Type measures to the second triangle");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX = x.Area();

        double areaY = y.Area();

        if (areaX > areaY)
            Console.WriteLine("The bigger triangle is X");
        else
            Console.WriteLine("The bigger triangle is Y");


    }
}