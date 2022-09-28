using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Class_208_Challenge_Interface.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double InstallmentPrice { get; set; }
        
        public Installment()
        {
        }

        public Installment(DateTime dueDate, double installmentPrice)
        {
            DueDate = dueDate;
            InstallmentPrice = installmentPrice;
        }

        public override string? ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + InstallmentPrice.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
