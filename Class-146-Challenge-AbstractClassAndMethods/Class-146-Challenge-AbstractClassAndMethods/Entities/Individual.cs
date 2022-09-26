using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_146_Challenge_AbstractClassAndMethods.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public double VerifyIncome()
        {
            double TotalTax;

            if (AnualIncome <= 20000)
            {
                TotalTax = AnualIncome * 0.15;
            }
            else
            {
                TotalTax = AnualIncome * 0.25;
            }

            return TotalTax;
        }

        public override double Tax()
        {
            double TotalTax = VerifyIncome();
            if (HealthExpenditures > 0)
            {
                TotalTax -= (HealthExpenditures * 0.5);
            }
            return TotalTax;
        }
    }
}
