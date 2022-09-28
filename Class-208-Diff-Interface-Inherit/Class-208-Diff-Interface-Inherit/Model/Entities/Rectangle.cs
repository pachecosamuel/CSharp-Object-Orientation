using Class_208_Diff_Interface_Inherit.Model.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_208_Diff_Interface_Inherit.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public Rectangle()
        {
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string? ToString()
        {
            return "Circle color : "
                + Color
                + ", Width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", Height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
