using BuyTicket.Domain;
using System;
using System.Collections.Generic;

namespace BuyTicket.DataAccess.Abstract
{
    public interface IUserRepository
    {
        void Add(User User);
        void Delete(Guid UserId);
        void Update(User User);
        ICollection<User> GetAll();
    }
}
