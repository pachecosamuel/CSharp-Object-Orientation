using Class132Challenge.Entities.Enums;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class132Challenge.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Customer CustomerOrder { get; set; }
        public List<OrderItem> Items { get; set; } = new();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Customer customer)
        {
            Moment = moment;
            Status = status;
            CustomerOrder = customer;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double total()
        {
            double total = 0.0;

            foreach (OrderItem obj in Items)
            {
                total += obj.SubTotal();
            }

            return total;
        }

        public override string? ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine(CustomerOrder.ToString());

            foreach (OrderItem obj in Items)
            {
                sb.AppendLine(obj.Product.Name
                    + ", $"
                    + obj.Price
                    + ", Amount: "
                    + obj.Amount + ", Subtotal: "
                    + obj.SubTotal().ToString("F2", CultureInfo.InvariantCulture)
                    );
            }

            sb.AppendLine("Total Price: $" + total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
