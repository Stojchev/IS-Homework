namespace ISServices.Interface
{
    using ISDomain.DomainModels;
    using ISDomain.DTO;
    using System;
    using System.Collections.Generic;
    public interface ITicketService
    {
        List<Ticket> GetAllTickets();
        Ticket GetDetailsForTicket(Guid? id);
        void CreateNewTicket(Ticket t);
        void UpdateExistingTicket(Ticket t);
        void DeleteTicket(Guid id);
        AddToShoppingCartDto GetShoppingCartInfo(Guid? id);
        bool AddToShoppingCart(AddToShoppingCartDto item, string userID);
    }
}
