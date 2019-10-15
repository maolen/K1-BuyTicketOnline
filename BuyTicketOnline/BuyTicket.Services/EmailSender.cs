using BuyTicket.Domain;
using BuyTicket.Services.Abstract;
using System.Net;
using System.Net.Mail;
using static BuyTicket.Services.SenderContact;

namespace BuyTicket.Services
{
    public class EmailSender : CodeSender
    {
        public override void SendCode(User user)
        {
            var from = new MailAddress(EMAIL_SEND_CODE);
            var to = new MailAddress(user.Email);
            var message = new MailMessage(from, to)
            {
                Subject = "Активация email адреса",
                Body = @$"Мы получили от вас запрос на регистрацию.
Введите код { GenerateCode() } на сайте, чтобы подтвердить адрес электронной почты и завешить регистрацию.",
                IsBodyHtml = false
            };

            var client = new SmtpClient(EMAIL_HOST, EMAIL_PORT);
            client.Credentials = new NetworkCredential(EMAIL_SEND_CODE, EMAIL_PASSWORD);
            client.EnableSsl = true;
            client.Send(message);
        }
    }
}
