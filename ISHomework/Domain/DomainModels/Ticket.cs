namespace ISDomain.DomainModels
{
    using ISDomain.DomainModels.Enum;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Ticket : BaseEntity
    {
        [Required]
        public string MovieName { get; set; }

        [Required]
        public Genre MovieGenre { get; set; }

        [Required]
        public string MovieYear { get; set; }

        [Required]
        public string MovieDescription { get; set; }

        [Required]
        public string MovieImage { get; set; }

        [Required]
        public int TicketPrice { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketsInShoppingCart { get; set; }
        public virtual ICollection<TicketInOrder> TicketsInOrder { get; set; }
    }
}
