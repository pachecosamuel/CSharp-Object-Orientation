using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Class_232_Predicate
{
    internal class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product(string productName, double productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }

        public override string? ToString()
        {
            return $"{ProductName}, {ProductPrice.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
