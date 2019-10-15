using System;
using System.Collections.Generic;
using System.Text;

namespace BuyTicket.Domain
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Iin { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Balance { get; set; }
        public Guid ticketId { get; set; }
    }
}
