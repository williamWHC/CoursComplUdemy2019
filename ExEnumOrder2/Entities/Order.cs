using System;
using System.Collections.Generic;
using System.Text;

namespace ExEnumOrder2.Entities.Enums
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        //sobreescrevendo o ToString

        public override string ToString()
        {
            return Id
                    + " ,"
                    + Moment
                    + ", "
                    + Status;
        }
    }
}
