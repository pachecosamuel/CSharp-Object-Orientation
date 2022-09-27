﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_140_Challenge_InheritPolyphormism.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double additionalCharge) 
            : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.10;
        }
    }
}
