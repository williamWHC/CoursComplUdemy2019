using System;
using CurseEntities.Entities;
using CurseEntities.Entities.Enums;

namespace CurseEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 10500,
                Moment = DateTime.Now,
                Status = OrderStatus.pendingPayment
            };

            Console.WriteLine(order);

            //Convertendo tipo Enumerado em String
            Console.WriteLine("===========================");
            string txt = OrderStatus.pendingPayment.ToString();
            Console.WriteLine("Convertendo tipo Enum para String --> " + txt);

            //Convertendo tipo String para Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine("Convertendo tipo Strin para  Enum --> " + os);
        }
    }
}
