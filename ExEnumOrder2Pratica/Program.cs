using System;
using ExEnumOrder2Pratica.Entities;
using ExEnumOrder2Pratica.Entities.Enums;

namespace ExEnumOrder2Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 102800,
                Moment = DateTime.Now,
                Status = OrderStatus.PeddingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PeddingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}
