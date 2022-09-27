using ChallengeSeason3;
using System.Globalization;
internal class Program {
    private static void Main(string[] args) {

        Account ac1 = new Account();
        double valor;

        Console.Write("Digite o número da conta: ");
        ac1.AccountNumber = Console.ReadLine();
        string auxNum = ac1.AccountNumber;

        Console.Write("Digite o nome do titular da conta: ");
        ac1.Name = Console.ReadLine();
        string auxName = ac1.Name;

        Console.Write("Haverá depósito inicial?! : ");
        char valid = char.Parse(Console.ReadLine());

        if (valid == 's') {
            Console.Write("Entre com o valor de depósito inicial: ");
            double cash = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ac1.Deposito(cash);

            Account ac2 = new Account(auxName, auxNum, ac1.Deposito(cash));
        }
        else {
            Account ac2 = new Account(auxName, auxNum);

        }

        Console.WriteLine($"\n{ac1}");

        Console.Write("\nValor de depósito: ");
        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ac1.Deposito(valor);
        Console.WriteLine(ac1);

        Console.Write("\nValor de Saque: ");
        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ac1.Saque(valor);
        Console.WriteLine(ac1);

    }
}