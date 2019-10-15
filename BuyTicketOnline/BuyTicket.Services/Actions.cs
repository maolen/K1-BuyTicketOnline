using Microsoft.Extensions.Configuration;
using BuyTicket.DataAccess;
using BuyTicket.Domain;
using BuyTicket.Services;
using BuyTicket.Services.Abstract;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using static System.Console;
using System.Text;

namespace BuyTicket.Services
{
    public static class Actions
    {
        public static void Register()
        {
            var user = new User();
            WriteLine("Введите имя:");
            user.FirstName = ReadLine();

            WriteLine("Введите фамилию:");
            user.LastName = ReadLine();

            WriteLine("Введите ИИН:");
            user.Iin = ReadLine();

            WriteLine("Введите номер телефона:");
            user.PhoneNumber = ReadLine();

            WriteLine("Введите адрес электронной почты:");
            user.Email = ReadLine();

            using (var context = new Repository(providerName, connectionString))
            {
                context.Users.Add(user);
            }
        }
        public static void StartConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);

            IConfigurationRoot configurationRoot = builder.Build();

            string providerName = configurationRoot.GetSection("AppConfig")
                                 .GetChildren()
                                 .Single()
                                 .Value;

            string connectionString = configurationRoot.GetConnectionString("DebugConnectionString");

            DbProviderFactories.RegisterFactory(providerName, SqlClientFactory.Instance);
        }
    }
}
