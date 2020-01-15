using System;
using System.Collections.Generic;
using System.Text;

namespace ExEnumOrder2Pratica.Entities.Enums
{
    public enum OrderStatus : int
    {
        PeddingPayment = 0,
        billed = 1,
        Shipped = 2,
        Delivered = 3
    };
}
