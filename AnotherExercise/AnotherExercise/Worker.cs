﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AnotherExercise {
    internal class Worker {

        public string Name;
        public double Salary;
        public double Tax;

        public double Readjustment(double value) {
            Salary = Salary * (1 + value) - Tax;
            return Salary;
        }

        override public string ToString() {
            return "Employee: " + Name
                    + " Salary: " + (Salary - Tax).ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
