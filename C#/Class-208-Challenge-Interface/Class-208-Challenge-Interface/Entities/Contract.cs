using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_208_Challenge_Interface.Entities
{
    internal class Contract
    {
        public Contract()
        {
        }

        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractTotalValue { get; set; }
        public List<Installment> InstallmentList { get; set; } = new();

        public Contract(int contractNumber, DateTime contractDate, double contractTotalValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractTotalValue = contractTotalValue;
        }

        public void AddInstallment(Installment installment)
        {
            InstallmentList.Add(installment);
        }

        public void RemoveInstallment(Installment installment)
        {
            InstallmentList.Remove(installment);
        }
    }
}
