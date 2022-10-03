using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Review_29_09_22.Entities
{
    internal class Calculator : Operations
    {
        public double ValueA { get; set; }
        public double ValueB { get; set; }

        public Calculator(double valueA, double valueB)
        {
            ValueA = valueA;
            ValueB = valueB;
        }

        public string Sum()
        {
            return $"Sum -> {(ValueA + ValueB).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Subtraction()
        {
            return $"Subtraction -> {(ValueA - ValueB).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Division()
        {
            return $"Division -> {(ValueA / ValueB).ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Multiplication()
        {
            return $"Multiplication -> {(ValueA * ValueB).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
