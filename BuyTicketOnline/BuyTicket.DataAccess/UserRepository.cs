using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using BuyTicket.DataAccess.Abstract;
using BuyTicket.Domain;
using System.Data.SqlClient;

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
            using (var command = connection.CreateCommand())
            {
                var query = "SELECT * FROM Users";
                command.CommandText = query;
                connection.Open();
                var sqlDataReader = command.ExecuteReader();

                var users = new List<User>();
                while (sqlDataReader.Read())
                {
                    users.Add(new User
                    {
                        Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                        CreationDate = DateTime.Parse(sqlDataReader["CreationDate"].ToString()),
                        FirstName = sqlDataReader["FirstName"].ToString(),
                        LastName = sqlDataReader["LastName"].ToString(),
                        Iin = sqlDataReader["Iin"].ToString(),
                        PhoneNumber = sqlDataReader["PhoneNumber"].ToString(),
                        Email = sqlDataReader["Email"].ToString(),
                        TicketId = Guid.Parse(sqlDataReader["TicketId"].ToString()),
                    }); 
                }
                return users;
            }
        }

        public void Update(User User)
        {
            
        }
        private void AddParameterTocommand(string parameterName, object parameterValue,
            DbType type, DbCommand command)
        {
            
            var parameter = command.CreateParameter();
            parameter.DbType = type;
            parameter.ParameterName = parameterName;
            parameter.Value = parameterValue;
            command.Parameters.Add(parameter);
        }
        private void ExecuteQuery(string query, User User)
        {
            using (connection)
            using (var command = connection.CreateCommand())
            {
                command.CommandText = query;
                // (?) SqlParameter parameter = command.CreateParameter();
                AddParameterTocommand("@Id", User.Id, DbType.Guid, command);
                AddParameterTocommand("@CreationDate", User.CreationDate, DbType.DateTime, command);
                AddParameterTocommand("@FirstName", User.FirstName, DbType.String, command);
                AddParameterTocommand("@LastName", User.LastName, DbType.String, command);
                AddParameterTocommand("@LastName", User.LastName, DbType.String, command);
                AddParameterTocommand("@Iin", User.Iin, DbType.String, command);
                AddParameterTocommand("@PhoneNumber", User.PhoneNumber, DbType.String, command);
                AddParameterTocommand("@Email", User.Email, DbType.String, command);
                AddParameterTocommand("@TicketId", User.TicketId, DbType.Guid, command);
                connection.ConnectionString = connectionString;
                connection.Open();
                command.ExecuteNonQuery();
                //ExecuteCommandsInTransaction(command);
            }
        }
    }
}