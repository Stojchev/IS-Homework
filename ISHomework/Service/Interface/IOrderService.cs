namespace ISServices.Interface
{
    using ISDomain.DomainModels;
    using System;
    using System.Collections.Generic;
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderDetails(Guid orderId);
    }
}
