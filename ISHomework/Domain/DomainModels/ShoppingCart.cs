namespace ISDomain.DomainModels
{
    using ISDomain.Identity;
    using System.Collections.Generic;
    public class ShoppingCart : BaseEntity
    {
        public string UserId { get; set; }
        public CinemaApplicationUser User { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketsInShoppingCart { get; set; }
    }
}
