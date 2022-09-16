using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarConversor {
    internal class Conversor {
        public static double IOF = 0.06;

        public static double Calculator(double quotation, double amount) {
            return (amount * quotation) * (1 + IOF);
        }
    }
}
