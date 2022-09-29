using Class_208_Challenge_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_208_Challenge_Interface.Services
{
    internal class ContractService
    {
        private IOnlinePayment _onlinePaymentService;

        public ContractService(IOnlinePayment onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.ContractTotalValue / months;

            for (int i = 0; i < months; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new(date, fullQuota));
            }
        }
    }
}
