namespace ISDomain.DomainModels
{
    using ISDomain.Identity;
    using System.Collections.Generic;
    public class Order : BaseEntity
    {
        public string UserId { get; set; }
        public IEnumerable<TicketInOrder> TicketsInOrder { get; set; }

        public CinemaApplicationUser User { get; set; }
    }
}
