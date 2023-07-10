namespace ISDomain.DTO
{
    using ISDomain.DomainModels;
    using System;
    using System.Collections.Generic;
    public class TicketDto
    {
        public List<Ticket> Tickets { get; set; }
        public DateTime Date { get; set; }
    }
}
