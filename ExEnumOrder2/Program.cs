using System;
using ExEnumOrder2.Entities.Enums;

namespace ExEnumOrder2.Entities.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 10800,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);
            
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);



        }
    }
}
