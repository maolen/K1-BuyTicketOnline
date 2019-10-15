using BuyTicket.Domain;
using System;
using System.Collections.Generic;

namespace BuyTicket.DataAccess.Abstract
{
    public interface ITicketRepository
    {
        void Add(Ticket Ticket);
        void Delete(Guid TicketId);
        void Update(Ticket Ticket);
        ICollection<Ticket> GetAll();
    }
}
