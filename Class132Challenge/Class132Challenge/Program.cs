using Class132Challenge.Entities;
using Class132Challenge.Entities.Enums;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Fill customer's data: ");
        Console.Write("Name : ");
        string name = Console.ReadLine();

        Console.Write("Email : ");
        string email = Console.ReadLine();

        Console.Write("Birthdate (DD/MM/YYYY) : ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());

        Customer customer = new(name, email, birthdate);

        Console.WriteLine();
        Console.WriteLine("Fill orders data");
        
        DateTime moment = DateTime.Now;

        Console.Write("Status :");
        OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

        Console.Write("How many itens to this order:");
        int amountItems = int.Parse(Console.ReadLine());

        Order order = new(moment, os, customer);

        for (int i = 0; i < amountItems; i++)
        {
            Console.Write("Product name: ");
            string prodName = Console.ReadLine();

            Console.Write("Product price: ");
            double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Amount: ");
            int amount = int.Parse(Console.ReadLine());

            Product product = new(prodName, prodPrice);
            OrderItem orderItem = new(amount, prodPrice, product);

            order.AddItem(orderItem);
        }

        Console.WriteLine(order);

    }
}