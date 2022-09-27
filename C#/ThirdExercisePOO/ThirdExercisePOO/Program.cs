using ThirdExercisePOO;
using System.Globalization;
internal class Program {
    private static void Main(string[] args) {
        Student s1 = new();
        int i = 0;

        Console.Write("Type the nome to the student: ");
        s1.Name = Console.ReadLine();

        Console.WriteLine("Enter the student's three grades");
        s1.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        s1.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        s1.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        s1.ToApprove();
    }
}