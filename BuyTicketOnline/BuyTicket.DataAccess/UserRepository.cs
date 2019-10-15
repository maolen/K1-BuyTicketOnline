using System;
using System.Collections.Generic;
using System.Data;
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
        private void AddParameterToSqlCommand(string parameterName, object parameterValue,
            DbType type, DbCommand command)
        {
            var parameter = providerFactory.CreateParameter();
            parameter.DbType = type;
            parameter.ParameterName = parameterName;
            parameter.Value = parameterValue;
            command.Parameters.Add(parameter);
        }
        private void ExecuteQuery(string query, User User)
        {
            //using (connection)
            //using (var sqlCommand = connection.CreateCommand())
            //{
            //    sqlCommand.CommandText = query;
            //    // (?) SqlParameter parameter = sqlCommand.CreateParameter();
            //    AddParameterToSqlCommand("@Id", User.Id, DbType.Guid, sqlCommand);
            //    AddParameterToSqlCommand("@CreationDate", User.CreationDate, DbType.DateTime, sqlCommand);
            //    AddParameterToSqlCommand("@Name", User.Name, DbType.String, sqlCommand);
            //    AddParameterToSqlCommand("@ImagePath", User.ImagePath, DbType.String, sqlCommand);
            //    connection.ConnectionString = connectionString;
            //    connection.Open();
            //    sqlCommand.ExecuteNonQuery();
            //    //ExecuteCommandsInTransaction(sqlCommand);
            //}
        }
    }
}