using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_230_Delegates_Lambda.Services
{
    internal class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return Math.Pow(x, 2);
        }

        public static void ShowSum(double y, double x)
        {
            double sum = y + x;
            Console.WriteLine("Sum: " + sum);
        }

        public static void ShowMax(double y, double x)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine("Max value: " + max);
        }
    }
}
