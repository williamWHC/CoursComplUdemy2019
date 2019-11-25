using System;
using System.Collections.Generic;
using System.Text;

namespace CurseEntities.Entities.Enums
{
    enum OrderStatus : int
    {
        pendingPayment = 0,
        Processing = 1,
        Seding = 2,
        Delivered = 3
    }
}
