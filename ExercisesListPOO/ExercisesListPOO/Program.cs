using ExercisesListPOO;
using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        //ler largura e altura de um retangulo
        //então retornar sua área, perímetro e diagonal
        Rectangle r1 = new Rectangle();

        Console.Write("Type the height: ");
        r1.height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.Write("Type the width: ");
        r1.width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Area: " + r1.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Perimeter: " + r1.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Diagonal: " + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));



    }
}