using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Class_208_Diff_Interface_Inherit.Model.Enums;

namespace Class_208_Diff_Interface_Inherit.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public Circle(double radius, Color color)
        {
            Radius = radius;
            Color = color;
        }

        public override string? ToString()
        {
            return "Circle color : "
                + Color
                + ", Radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
