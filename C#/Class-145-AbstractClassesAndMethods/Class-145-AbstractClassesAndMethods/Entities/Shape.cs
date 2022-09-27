using Class_145_AbstractClassesAndMethods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_145_AbstractClassesAndMethods.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        
        protected Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
