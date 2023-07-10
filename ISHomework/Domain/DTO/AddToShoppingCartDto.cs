namespace ISDomain.DTO
{
    using ISDomain.DomainModels;
    using System;
    public class AddToShoppingCartDto
    {
        public Ticket Ticket { get; set; }
        public Guid TicketId { get; set; }
        public int Quantity { get; set; }
    }
}
