using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        //Casting
        int a = 5, b = 2;
        double result = (double) a / b;
        /*Console.WriteLine(result.
            ToString("F4", CultureInfo.InvariantCulture));*/

        //Operadores lógicos
        //Precedência 1° ! 2° && 3° ||
        bool case1 = 2 > 3 && 5 != 6; // false
        bool case2 = 2 > 3 || 5 != 6; // true
        bool case3 = !(2 > 3) && 5 != 6; // true
        bool case4 = case1 || case2 && case3;
        //Console.WriteLine($"Caso 1:{case1} , Caso 2:{case2} , Caso 3:{case3}");

        //Operadores aritméticos
        //Precedência 1° % * /  2° + -
        double goal = (2 + 3) * 5;
        double goal2 = 2 + 3 * 5;
        Console.WriteLine(goal);
        Console.WriteLine(goal2);
    }
}