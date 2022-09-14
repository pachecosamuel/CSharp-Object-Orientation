using System.Globalization;

internal class Program {
    private static void Main(string[] args) {

        string nome = "Samuel Pacheco";
        int idade = 24;
        char gen = 'm';
        double salario = 19562.25698;

        //1° Output way -> Placeholders
        Console.WriteLine("{0} tem {1} anos e salário de {2:F2}", nome, idade, salario);

        //2° Output way -> Interpolação
        Console.WriteLine($"{nome} tem {idade} anos e salário de {salario:F3}");

        //3° Output way -> Concatenação
        Console.WriteLine("Nome: " + nome + " idade: " + idade + " salário: " + salario.
            ToString("F2", CultureInfo.InvariantCulture));


    }
}