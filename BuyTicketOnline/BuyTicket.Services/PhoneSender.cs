using BuyTicket.Domain;
using BuyTicket.Services.Abstract;
using System;
using Twilio;
using static BuyTicket.Services.SenderContact;
using Twilio.Rest.Api.V2010.Account;

namespace BuyTicket.Services
{
    public class PhoneSender : CodeSender
    {
        public override void SendCode(User user)
        {
            var accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            var authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: $" Пароль: {GenerateCode()}. Никому не сообщайте ваш пароль!",
                from: new Twilio.Types.PhoneNumber(PHONE_SEND_CODE),
                to: new Twilio.Types.PhoneNumber(user.PhoneNumber)
            );
        }
    }
}
