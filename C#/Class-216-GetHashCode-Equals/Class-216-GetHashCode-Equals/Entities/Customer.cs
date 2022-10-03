using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_216_GetHashCode_Equals.Entities
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Customer))
            {
                throw new ArgumentException("Obj is not a Customer");
            }

            Customer other = (Customer)obj;

            return Email.Equals(other.Email);   
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
