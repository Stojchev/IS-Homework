namespace ISServices.Implementation
{
    using ISDomain.DomainModels;
    using ISRepository.Interface;
    using ISServices.Interface;
    using System;
    using System.Collections.Generic;
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }
        public List<Order> GetAllOrders()
        {
            return this._orderRepository.GetAllOrders();
        }

        public Order GetOrderDetails(Guid orderId)
        {
            return this._orderRepository.GetOrderDetails(orderId);
        }
    }
}
