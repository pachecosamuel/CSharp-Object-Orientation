using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class132Challenge.Entities
{
    internal class OrderItem
    {
        public int Amount { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int amount, double price, Product product)
        {
            Amount = amount;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Amount * Price;
        }
    }
}
