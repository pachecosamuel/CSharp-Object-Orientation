using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        Console.WriteLine("How many numbers do you want?!");
        int amount = int.Parse(Console.ReadLine());
        int local = 0;

        for (int i = 0; i < amount; i++) {

            Console.WriteLine("Type the " + (i+1) + "° number");
            int var = int.Parse(Console.ReadLine());

            local += var;

            if (i == (amount - 1))
                Console.WriteLine($"The sum is:{local}");
        }

        /*
        while (true) {
            Console.WriteLine("Type a number");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num < 0) {
                Console.WriteLine("N° negativo");
                break;
            }
            else {
                Console.WriteLine("Sqrt: " + Math.Sqrt(num));
                Console.WriteLine();
            }
        }
        */
    }
}