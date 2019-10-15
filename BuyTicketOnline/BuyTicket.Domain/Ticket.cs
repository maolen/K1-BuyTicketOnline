using System;
using System.Collections.Generic;
using System.Text;

namespace BuyTicket.Domain
{
    public class Ticket : Entity
    {
        public Guid FlightId { get; set; }
        public int Price { get; set; }
    }
}
