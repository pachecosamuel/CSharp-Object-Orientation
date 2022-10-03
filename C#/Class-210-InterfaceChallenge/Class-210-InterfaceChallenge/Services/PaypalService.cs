using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_210_InterfaceChallenge.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public const double PaymentFeeTax = 0.02;
        public const double MonthInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * PaymentFeeTax;
        }
    }
}
