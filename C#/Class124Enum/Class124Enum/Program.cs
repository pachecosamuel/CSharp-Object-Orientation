using Class124Enum.Entities;
using Class124Enum.Entities.Enum;

internal class Program
{
    private static void Main(string[] args)
    {

        Order order = new()
        {
            Id = 1,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment,
        };

        string txt = OrderStatus.Shipped.ToString();

        OrderStatus os1 = Enum.Parse<OrderStatus>("Delivered");
        OrderStatus os2 = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Shipped");

        Console.WriteLine(order);
        //Console.WriteLine(txt);
        //Console.WriteLine(os1);
        //Console.WriteLine(os2);

    }
}