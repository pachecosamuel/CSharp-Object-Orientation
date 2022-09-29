﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Class_204_Interfaces.Entities
{
    internal class Invoice
    {
        public Invoice()
        {
        }

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
            set { }
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string? ToString()
        {
            return "Basic payment : "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax : "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment : "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
