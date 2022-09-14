internal class Program {
    private static void Main(string[] args) {

        string p1 = "Monitor 27'";
        string p2 = "Iphone 13 Pro";

        byte age = 24;
        int codiguin = 2560;
        char gender = 'm';

        double price1 = 1250.5680;
        double price2 = 5860.85239;
        double measure = 53.12345678;

        double test = 10.50;
        /*test += 10;
        test -= 5;
        test *= 10;
        test /= 5;
        Console.WriteLine(test);
        */
        double newTest = --test;
        Console.WriteLine(test);
        Console.WriteLine(newTest);


        /*Console.WriteLine($"Produtos: \n{p1} preço: {price1:F2} \n{p2} preço: {price2:F2}");
        Console.WriteLine($"Registro: {age} de idade, código: {codiguin} e gênero: {gender}");
        Console.WriteLine($"Medida total da mesa: {measure}\nArredondado: {measure:F2}\nCom invariant culture: {measure}");
        */
    }
}