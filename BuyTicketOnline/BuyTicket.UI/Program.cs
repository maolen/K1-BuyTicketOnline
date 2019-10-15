using static BuyTicket.Services.Actions;
using System;
using static System.Console;

namespace BuyTicket.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            StartConnection();

            //var user = new User
            //{
            //    Email = "zhakupova.kamila@mail.ru"
            //};
            //ICodeSender messageSender = new EmailSender();
            //messageSender.SendCode(user);

            //using (var context = new Repository(providerName, connectionString))
            //{
            //    context.Users.Add(user);
            //}

            var isExit = false;
            WriteLine("Покупка билетов онлайн");
            WriteLine("1 - Зарегистрироваться");
            WriteLine("2 - Показать рейсы");
            WriteLine("3 - Купить билет");
            WriteLine("0 - Купить билет");
            while (!isExit)
            {
                WriteLine("Выбрать:");
                var userSelect = Convert.ToInt32(ReadLine());
                switch (userSelect)
                {
                    case (int) MenuItems.EXIT:
                        {
                            isExit = true;
                            break;
                        }
                    case (int)MenuItems.REGISTER:
                        {

                            break;
                        }
                    case (int)MenuItems.SHOW_FLIGHT:
                        {

                            break;
                        }
                    case (int)MenuItems.BUY_TICKET:
                        {

                            break;
                        }
                }

            }
        }
        
    }
}
