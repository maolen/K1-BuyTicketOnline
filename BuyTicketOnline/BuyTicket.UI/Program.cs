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
using System.Text;

namespace BuyTicket.UI
{
    class Program
    {
        static void Main(string[] args)
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

            var user = new User
            {
                Email = "zhakupova.kamila@mail.ru"
            };
            ICodeSender messageSender = new EmailSender();
            messageSender.SendCode(user);

            using var context = new Repository(providerName, connectionString);
            context.Users.Add(user);

        }
    }
}
