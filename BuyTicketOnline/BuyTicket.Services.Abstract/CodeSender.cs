using BuyTicket.Domain;
using System;

namespace BuyTicket.Services.Abstract
{
    public abstract class CodeSender : ICodeSender
    {
        public abstract void SendCode(User user);
        public int GenerateCode()
        {
            var startInterval = 1000;
            var endInterval = 9999;
            var random = new Random();
            return random.Next(startInterval, endInterval);
        }
    }
}
