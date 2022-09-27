using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        //We gonna do six exercises to fix all the content that we've learned

        /* 1° Make sum between two numbers */
        int aa = int.Parse(Console.ReadLine());
        int bb = int.Parse(Console.ReadLine());

        Console.WriteLine($"Soma entre os números: {aa + bb}");


        /* 2° Giving the radius of a circle, calculate its area */
        // pi.r²  being pi = 3.14159
        Console.WriteLine("Type the radius of a circle");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double area = 3.14159 * (radius*radius);

        Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));


        /* 3° Type four numbers and calculate (A * B - C * D) */
        string[] nums = Console.ReadLine().Split(" ");
        double a = double.Parse(nums[0]);
        double b = double.Parse(nums[1]);
        double c = double.Parse(nums[2]);
        double d = double.Parse(nums[3]);

        Console.WriteLine($"Result = {a*b - c*d}");


        /* 4° Read a number of a worker, his worked hours and how much he receive per hour
         * after show his number and salary */
        Console.WriteLine("Type the number of the worker");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Type how many hours of work");
        int hour = int.Parse(Console.ReadLine());   

        Console.WriteLine("How much costs its hours");
        double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("\nNumber = " + num + "\nSalary: " + ((double) value * hour).ToString("F2", CultureInfo.InvariantCulture));


        /* 5° Read a code of a product, the amount and the unitary value */
        string[] p1 = Console.ReadLine().Split(" ");
        string[] p2 = Console.ReadLine().Split(" ");
        
        int amount1 = int.Parse(p1[1]);
        double v1 = double.Parse(p1[2], CultureInfo.InvariantCulture);
        
        int amount2 = int.Parse(p2[1]);
        double v2 = double.Parse(p2[2], CultureInfo.InvariantCulture);

        double total = amount1 * v1 + amount2 * v2;
        Console.WriteLine("Total value: " + total.ToString("F2", CultureInfo.InvariantCulture));
        

        /* Read three values that corresponds to the sides of a circle*/
        string[] sides = Console.ReadLine().Split(" ");
        double l1 = double.Parse(sides[0], CultureInfo.InvariantCulture);
        double l2 = double.Parse(sides[1], CultureInfo.InvariantCulture);
        double l3 = double.Parse(sides[2], CultureInfo.InvariantCulture);

        Console.WriteLine("Triangle");

    }
}