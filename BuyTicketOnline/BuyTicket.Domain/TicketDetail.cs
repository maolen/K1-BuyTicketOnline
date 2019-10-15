using System;
using System.Collections.Generic;

namespace BuyTicket.Domain
{
    public class TicketDetail : Entity
    {
        public Ticket Ticket { get; set; }
        public int freePlaceNumber { get; set; }
    }
}
