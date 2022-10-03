using Class_230_Delegates_Lambda.Services;

internal class Program
{

    delegate double BinaryNumericOperation(double n1, double n2);
    delegate double NumericSquare(double n1);
    delegate void Operation(double n1, double n2);

    private static void Main(string[] args)
    {
        double a = 10.0;
        double b = 5.0;
        double x = CalculationService.Max(a, b);
        double y = CalculationService.Square(b);

        BinaryNumericOperation op = CalculationService.Max;
        NumericSquare op2 = CalculationService.Square;

        Operation op3 = CalculationService.ShowSum;
        op3 += CalculationService.ShowMax;

        op3(a, b);
    }
}