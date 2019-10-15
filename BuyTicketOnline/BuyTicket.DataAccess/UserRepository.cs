using System;
using System.Collections.Generic;
using System.Data.Common;
using BuyTicket.DataAccess.Abstract;
using BuyTicket.Domain;

namespace BuyTicket.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly DbConnection connection;
        private readonly DbTransaction transaction;


        public UserRepository(DbConnection connection, DbTransaction transaction)
        {
            this.connection = connection;
            this.transaction = transaction;
        }
        public void Add(User User)
        {
            
        }

        public void Delete(Guid UserId)
        {
            
        }

        public ICollection<User> GetAll()
        {
            var users = new List<User>();
            
            return users;
        }

        public void Update(User User)
        {
            
        }
    }
}