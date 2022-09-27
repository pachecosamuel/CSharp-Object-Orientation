using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_140_Challenge_InheritPolyphormism.Entities
{
    internal class Employee
    {
        public string Name { get; protected set; }
        public int Hours { get; protected set; }
        public double ValuePerHour { get; protected set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHours;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

    }
}
