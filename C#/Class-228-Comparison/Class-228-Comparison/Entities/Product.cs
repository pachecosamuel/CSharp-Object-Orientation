using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Class_228_Comparison.Entities
{
    internal class Product
    {
        public double ProductPrice { get; set; }
        public string ProductName { get; set; }
        public Product()
        {
        }

        public Product(double productPrice, string productName)
        {
            ProductPrice = productPrice;
            ProductName = productName;
        }

        public override string? ToString()
        {
            return $"{ProductName}, {ProductPrice.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
