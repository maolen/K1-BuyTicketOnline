using System;
using System.Collections.Generic;
using System.Text;

namespace BuyTicket.Domain
{
    public class Flight : Entity
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime FlightDate { get; set; }
    }
}
