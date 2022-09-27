using System.Globalization;
using Class69Array;
internal class Program {
    private static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        Product[] vet = new Product[n];

        Product p1 = new Product { Name = "Salsicha" , Price = 500.50 };

        for (int i = 0; i < n; i++) {
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sum += price;

            vet[i] = new Product { Name = name, Price = price };

            if (i == n - 1) {
                Console.WriteLine("Price average = " + (sum/3.0).ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        for (int j = 0; j < n; j++) {
            Console.WriteLine(vet[j]);
        }

        int cont = int.Parse(Console.ReadLine());
        double average = 0;
        double[] vet1 = new double[10];

        for (int i = 0; i < cont; i++) {
            double local = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            average += local;

            if (i == cont - 1) {
                Console.WriteLine("Average height: " + (average/3.0).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}