using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Class_215_Generics_Restriction.Entites
{
    internal class Product : IComparable
    {
        public string Name{ get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string? ToString()
        {
            return $"Name : {Name}, Price : {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(Object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Object is not a product");
            }
            
            Product other = (Product)obj;
            
            return Price.CompareTo(other.Price);
        }
    }
}
