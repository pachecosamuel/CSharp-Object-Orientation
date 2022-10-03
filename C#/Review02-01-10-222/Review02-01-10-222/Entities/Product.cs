using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review02_01_10_222.Entities
{
    internal class Product : IComparable
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
        public Product()
        {
        }

        public Product(string productName)
        {
            ProductName = productName;
        }

        public int CompareTo(object? obj)
        {
            if (obj is not Product)
            {
                throw new ArgumentException("Comparando kiwi com laranja : " + nameof(obj));
            }

            Product other = (Product)obj;

            return Price.CompareTo(other.Price);
        }

        public override string? ToString()
        {
            return $"Product name: {ProductName} & Product Price: {Price} ";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Product)
            {
                throw new InvalidDataException("The types are different.");
            }

            Product other = obj as Product;

            return ProductName.Equals(other.ProductName);
        }

        public override int GetHashCode()
        {
            return ProductName.GetHashCode();
        }
    }
}
