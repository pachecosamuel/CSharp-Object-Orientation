using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuference {
    internal class Calculator {
        public static double Pi = 3.14;
        public static double Radius = 0.0;

        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }

        public static double Circumference(double r) {
            return 2.0 * Pi * r;
        }
    }
}
