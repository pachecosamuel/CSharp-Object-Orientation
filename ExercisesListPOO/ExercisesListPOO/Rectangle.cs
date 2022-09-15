using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercisesListPOO {
    internal class Rectangle {

        public double height;
        public double width;

        public double Area() {
            return height * width;
        }

        public double Perimeter() {
            return 2 * (height + width);
        }

        public double Diagonal() {
            return Math.Sqrt(height  * height + width * width);
        }

    }
}
