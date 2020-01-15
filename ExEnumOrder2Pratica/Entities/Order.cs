using System;
using System.Collections.Generic;
using System.Text;
using ExEnumOrder2Pratica.Entities.Enums;

namespace ExEnumOrder2Pratica.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                    + ", "
                    + Moment
                    + ", "
                    + Status;
        }

    }
}
