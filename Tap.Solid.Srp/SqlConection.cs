using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Solid.Srp
{
    public class SqlConection
    {
        public SmtpClient client;
        public SqlConection()
        {
            this.client = new SmtpClient
            {
                Port = 25,
                Host = "smtp.demo.exercise"
            };
        }
        public void executeSqlConector()
        {
            var sqlCommand = "INSERT INTO students (Name, Email, SocialSecurityNumber) values (@Name, @Email, @SocialSecurityNumber)";
            using (var connection = new SqliteConnection("Data Source=:memory:"))
            {
                var affectedRows = connection.Execute(sqlCommand);
            }

        }
    }
}
