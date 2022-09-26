using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_146_Challenge_AbstractClassAndMethods.Entities
{
    internal class Company : TaxPayer
    {
        public int AmountEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int amountEmployees)
            : base(name, anualIncome)
        {
            AmountEmployees = amountEmployees;
        }

        public override double Tax()
        {
            double TotalTax;

            if (AmountEmployees >= 10)
            {
                TotalTax = AnualIncome * 0.14;
            }
            else
            {
                TotalTax = AnualIncome * 0.16;
            }
            return TotalTax;
        }
    }
}
