using System;
using CurseEntities.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace CurseEntities.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return  "Numero do pedido: " + Id
                    + ", " +
                    "Data do Pedido: " + Moment
                    + ", " +
                    "Status do pedido atual: " + Status;
        }
    }
}
