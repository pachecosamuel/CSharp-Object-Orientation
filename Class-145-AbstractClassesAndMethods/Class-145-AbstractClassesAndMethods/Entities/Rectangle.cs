using Class_145_AbstractClassesAndMethods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_145_AbstractClassesAndMethods.Entities
{
    internal class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
