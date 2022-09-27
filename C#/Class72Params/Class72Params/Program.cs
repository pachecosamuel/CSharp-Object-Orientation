using Class72Params;

internal class Program {
    private static void Main(string[] args) {

        double result = Calculator.Sum(new double[] { 10, 10 });
        double x = 10.0;
        int a = 25;
        int resultado;
        string[] names = new string[] { "Julia" , "Stephanie" , "Giovana" };

        foreach (object obj in names) {
            Console.WriteLine(obj);
        }

        Calculator.Duple(a, out resultado);
        Console.WriteLine(resultado);
    }
}