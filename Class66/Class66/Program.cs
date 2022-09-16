using Class66;
internal class Program {
    private static void Main(string[] args) {

        Estrutura est;
        est.X = 10;
        est.Y = 30;

        Nullable<double> A = null;
        double? B = 10.1;

        double x = A ?? 100;
        double y = B ?? 200;

        Console.WriteLine(x + "   " + y);

        Console.WriteLine(A.GetValueOrDefault());
        Console.WriteLine(B.GetValueOrDefault());

        Console.WriteLine(A.HasValue);
        Console.WriteLine(B.HasValue);

        if (A.HasValue)
            Console.WriteLine(A.Value);
        else
            Console.WriteLine("A is null");

        if (B.HasValue) {
            Console.WriteLine(B.Value);
            double aleatorio = B.Value;
            Console.WriteLine("Aleatorizada: " + aleatorio);
        }
        else
            Console.WriteLine("B is null");

    }
}