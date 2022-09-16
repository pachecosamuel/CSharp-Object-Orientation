using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ChallengeSeason3 {
    internal class Account {

        public string _accountNumber;
        public string Name { get; set; }
        public double Saldo { get; private set; }

        public Account() {
        }

        public Account(string accountNumber, string name) { 
            _accountNumber = accountNumber;
            Name = name;
        }

        public Account(string accountNumber, string name, double saldo) : this(accountNumber, name) {
            Deposito(Saldo);
        }

        public string AccountNumber {
            get { return _accountNumber; }
            set {
                if (value.Length == 4) {
                    _accountNumber = value;
                }
                else {
                    Console.WriteLine("Valor inválido");
                }
            }
        }

        public void Deposito(double valor) {
            Saldo += valor;
            return Saldo;
        }

        public double Saque(double valor) {
            Saldo = Saldo - valor - 5;
            return Saldo;
        }

        public override string ToString() {
            return
            "Conta: " + _accountNumber +
            ", Titular: " + Name +
            ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
