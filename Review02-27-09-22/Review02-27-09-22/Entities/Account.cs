using Review02_27_09_22.Entities.Exceptions;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review02_27_09_22.Entities
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int accountNumber, string holder, double balance, double withdrawLimit)
        {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void VerifyLimit(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Error : value higher than your withdraw limit.");
            }
        }

        public void VerifyBalance(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Error : you don't have enough balance.");
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            VerifyLimit(amount);
            VerifyBalance(amount);

            Balance -= amount;
            Console.WriteLine("New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
