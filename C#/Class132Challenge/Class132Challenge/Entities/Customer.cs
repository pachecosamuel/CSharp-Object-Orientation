using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class132Challenge.Entities
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }


        public Customer()
        {
        }

        public Customer(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string? ToString()
        {
            return $"Customer: -{Name}-  -{BirthDate}-  -{Email}- ";
        }
    }
}
