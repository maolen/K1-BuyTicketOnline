using BuyTicket.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyTicket.Services.Abstract
{
    public interface ICodeSender
    {
        void SendCode(User user);
        int GenerateCode();
    }
}
