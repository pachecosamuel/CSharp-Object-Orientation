using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ThirdExercisePOO {
    internal class Student {

        public string Name;
        public double n1, n2, n3;

        public double FinalGrade() {
            return n1 + n2 + n3;
        }

        public void ToApprove() {
            if (FinalGrade() >= 60.0) {
                Console.WriteLine($"Final Grande = {FinalGrade()}\nApproved, Congrats!");
            }
            else {
                Console.WriteLine($"Final Grande = {FinalGrade()}\nReproved, Try again!\nMissing {(60-FinalGrade())} points!");
            }
        }
    }
}
