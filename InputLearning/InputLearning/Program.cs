using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        /* Aula 2 */

        /*
        int n1 = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine($"Integer: {n1}\nLetter: {letter}\nDouble: {num:F2}");
        */

        //Nome idade salario gênero
        string[] vet = Console.ReadLine().Split(" ");
        
        string name = vet[0];
        int age = int.Parse(vet[1]);
        double salary = double.Parse(vet[2], CultureInfo.InvariantCulture);
        char gender = char.Parse(vet[3]);

        Console.WriteLine($"Nome: {name}\nAge: {age}\nSalary: {salary}\nGender: {gender}");

        
        /* Aula 1 
        Console.WriteLine("Type your name");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is: " + name);

        Console.WriteLine("Type three words separeted by space");
        string[] fat = Console.ReadLine().Split(" ");
        //string s = Console.ReadLine();
        //string[] vet = s.Split(" ");

        string p1 = fat[0];
        string p2 = fat[1];
        string p3 = fat[2];

        Console.WriteLine($"First word: {p1}\nSecond word: {p2}\nThird word: {p3}");
        */

    }
}