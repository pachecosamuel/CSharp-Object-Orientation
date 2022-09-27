using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Challenge_ArchivesManipulation.Entities
{
    internal class Product
    {
        public Product()
        {
        }

        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProdutAmount { get; set; }

        public Product(string productName, double productPrice, int produtAmount)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProdutAmount = produtAmount;
        }

        public virtual double FinalPrice()
        {
            return ProductPrice * ProdutAmount;
        }
    }
}
