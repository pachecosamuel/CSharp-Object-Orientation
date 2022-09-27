internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Type three numbers");
        string[] vet = Console.ReadLine().Split(" ");

        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);
        int c = int.Parse(vet[2]);

        int result = Maior(a, b, c);
        Console.WriteLine($"Maior valor lido {result}");
    }

    static int Maior(int x, int y, int z) {
        int m;

        if (x > y && x > z) {
            m = x;
        }
        else if (y > z) {
            m = y;
        }
        else {
            m = z;
        }

        return m;
    }
}