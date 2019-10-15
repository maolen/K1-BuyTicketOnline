using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace BuyTicket.DataAccess
{
    public class Repository : IDisposable
    {
        private readonly DbConnection connection;
        private readonly DbProviderFactory providerFactory;
        private readonly DbTransaction transaction;

        public UserRepository Users { get; set; }
        public TicketRepository Tickets { get; set; }

        public Repository(string providerName, string connectionString)
        {
            providerFactory = DbProviderFactories.GetFactory(providerName);

            connection = providerFactory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            transaction = connection.BeginTransaction();

            Users = new UserRepository(connection, transaction);
            Tickets = new TicketRepository(connection, transaction);
        }
        public void Dispose()
        {
            transaction.Commit();
            transaction.Dispose();
            connection.Close();
        }
    }
}
