using System;
using System.Collections.Generic;
using System.Data.Common;
using BuyTicket.DataAccess.Abstract;
using BuyTicket.Domain;

namespace BuyTicket.DataAccess
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DbConnection connection;
        private readonly DbTransaction transaction;

        public TicketRepository(DbConnection connection, DbTransaction transaction)
        {
            this.connection = connection;
            this.transaction = transaction;
        }

        public void Add(Ticket Ticket)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid TicketId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Ticket Ticket)
        {
            throw new NotImplementedException();
        }
    }
}