namespace ISRepository.Interface
{
    using ISDomain.DomainModels;
    using System;
    using System.Collections.Generic;

    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        Order GetOrderDetails(Guid orderId);
    }
}
