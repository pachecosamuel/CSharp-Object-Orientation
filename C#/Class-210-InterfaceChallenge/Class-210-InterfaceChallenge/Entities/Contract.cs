using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_210_InterfaceChallenge.Entities
{
    internal class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> InstallmentsList { get; set; }

        public Contract(int contractNumber, DateTime contractDate, double totalValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            TotalValue = totalValue;
        }

        public Contract()
        {
        }

        public void AddInstallment(Installment installment)
        {
            InstallmentsList.Add(installment);
        }

        public void RemoveInstallment(Installment installment)
        {
            InstallmentsList.Remove(installment);
        }
    }
}
