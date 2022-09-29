using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_208_Challenge_Interface.Services
{
    internal interface IOnlinePayment
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
