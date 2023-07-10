namespace ISDomain.DTO
{
    using ISDomain.DomainModels;
    using System.Collections.Generic;
    public class ShoppingCartDto
    {
        public List<TicketInShoppingCart> Tickets { get; set; }
        public double TotalPrice { get; set; }
    }
}
