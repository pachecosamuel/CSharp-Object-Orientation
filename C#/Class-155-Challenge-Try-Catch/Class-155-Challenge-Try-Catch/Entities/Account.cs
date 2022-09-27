using Class_155_Challenge_Try_Catch.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_155_Challenge_Try_Catch.Entities
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

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void AccountLimit(double amount)
        {
            if (amount > WithdrawLimit) {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit. ");
            }
        }

        public void VerifyWithdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: The amount exceeds the balance. ");
            }
        }

        public void Withdraw(double amount)
        {
            AccountLimit(amount);
            VerifyWithdraw(amount);

            Balance -= amount;
            Console.WriteLine($"New Balance {Balance}");
        }
    }
}
