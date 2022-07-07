using System;

namespace DepartmentStore.Entities.Enum
{
    enum OrderStatus : int
    {
        Pending_payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,

    }
}
