internal class Program {
    private static void Main(string[] args) {

        Console.WriteLine("Type a number that will represent a square matrix");
        int num = int.Parse(Console.ReadLine());
        int[,] mat = new int[num, num];

        for (int i = 0; i < num; i++) {
            string[] numbers = Console.ReadLine().Split(" ");

            for (int j = 0; j < num; j++) {
                mat[i, j] = int.Parse(numbers[j]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Main diagonal: ");

        for (int i = 0; i < num; i++) {
            Console.Write(mat[i, i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        int count = 0;
        for (int i = 0; i < num; i++) {

            for (int j = 0; j < num; j++) {
                if (mat[i, j] < 0)
                    count++;
            }
        }

        Console.Write($"Negative numbers: {count}");
        Console.WriteLine();

        var x = 10;
        var y = 20.0;
        var z = "Samuca";
        var w = 'S';


        /*double[,] mat = new double[2,3];
        Console.WriteLine(mat.Length);
        Console.WriteLine(mat.Rank);
        Console.WriteLine(mat.GetLength(0));
        Console.WriteLine(mat.GetLength(1));*/

    }
}